using PoviMartLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thrift.Server;
using Thrift.Transport;

namespace Server
{
    public class ServerHandler : MarketService.Iface
    {
        public ResultCode DeleteProduct(int Number)
        {
            if (Number == 1)
            {
                return new ResultCode() { CODE = -1, MESSAGE = "처리실패", DESCRIPTION = "권한이 없는 상품입니다." };
            }
            else
            {
                return new ResultCode() { CODE = 0, MESSAGE = "처리완료", DESCRIPTION = "처리가 완료되었습니다." };
            }
        }

        public List<Product> GetProductList(int limit)
        {
            Random r = new Random();
            var rows = new List<Product>();

            for(var i=0;i<limit;i++)
            {                
                rows.Add(new Product()
                {
                    NUMBER = i+1,
                    NAME = $"상품_{i}",
                    COST = r.Next(0, 200000),
                    REGDATE = DateTime.Now.Ticks
                });
            }
            return rows;
        }

        public ResultCode InsertProduct(string Name, string Email, long RegDate)
        {
            //new DateTime(RegDate);

            return new ResultCode() { CODE = 0, MESSAGE = "처리완료", DESCRIPTION = $"{Name}, {Email}입력이 완료되었습니다." };
        }

        public void SendMail(Customer customer, SendType sendtype)
        {
            //TODO MAIL SENDING
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServerHandler handler = new ServerHandler();
                MarketService.Processor processor = new MarketService.Processor(handler);
                TServerTransport serverTransport = new TServerSocket(9090);
                TServer server = new TSimpleServer(processor, serverTransport);

                // Use this for a multithreaded server
                // server = new TThreadPoolServer(processor, serverTransport);

                Console.WriteLine("Starting the server...");
                server.Serve();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.StackTrace);
            }
            Console.WriteLine("done.");
        }
    }
}
