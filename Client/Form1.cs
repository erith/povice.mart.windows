using PoviMartLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thrift.Protocol;
using Thrift.Transport;

namespace Client
{
    public partial class Form1 : Form
    {

        TTransport transport;
        MarketService.Client client;

        /// <summary>
        /// 사용이 유효한지 확인
        /// </summary>
        bool IsAvaliable
        {
            get
            {
                return transport != null && transport.IsOpen;
            }
        }

        public Form1()
        {
            InitializeComponent();

            transport = new TSocket("192.168.0.70", 9090);
            TProtocol protocol = new TBinaryProtocol(transport);
            client = new MarketService.Client(protocol);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            transport.Open();
            var rows = client.GetProductList(2000);
            dataGridView1.DataSource = rows;
            transport.Close();
        }
    }
}
