/**
 * Autogenerated by Thrift Compiler (0.10.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace PoviMartLib
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class ResultCode : TBase
  {
    private int _CODE;
    private string _MESSAGE;
    private string _DESCRIPTION;

    public int CODE
    {
      get
      {
        return _CODE;
      }
      set
      {
        __isset.CODE = true;
        this._CODE = value;
      }
    }

    public string MESSAGE
    {
      get
      {
        return _MESSAGE;
      }
      set
      {
        __isset.MESSAGE = true;
        this._MESSAGE = value;
      }
    }

    public string DESCRIPTION
    {
      get
      {
        return _DESCRIPTION;
      }
      set
      {
        __isset.DESCRIPTION = true;
        this._DESCRIPTION = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool CODE;
      public bool MESSAGE;
      public bool DESCRIPTION;
    }

    public ResultCode() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I32) {
                CODE = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                MESSAGE = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                DESCRIPTION = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("ResultCode");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.CODE) {
          field.Name = "CODE";
          field.Type = TType.I32;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(CODE);
          oprot.WriteFieldEnd();
        }
        if (MESSAGE != null && __isset.MESSAGE) {
          field.Name = "MESSAGE";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(MESSAGE);
          oprot.WriteFieldEnd();
        }
        if (DESCRIPTION != null && __isset.DESCRIPTION) {
          field.Name = "DESCRIPTION";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(DESCRIPTION);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("ResultCode(");
      bool __first = true;
      if (__isset.CODE) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("CODE: ");
        __sb.Append(CODE);
      }
      if (MESSAGE != null && __isset.MESSAGE) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("MESSAGE: ");
        __sb.Append(MESSAGE);
      }
      if (DESCRIPTION != null && __isset.DESCRIPTION) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DESCRIPTION: ");
        __sb.Append(DESCRIPTION);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}