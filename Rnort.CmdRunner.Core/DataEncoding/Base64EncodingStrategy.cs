using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rnort.CmdRunner.Core.DataEncoding
{
    public class Base64EncodingStrategy : IEncodingStrategy
    {
        private readonly Encoding encoding;

        public Base64EncodingStrategy(Encoding encoding)
        {
            this.encoding = encoding;
        }

        public string Encode(string data)
        {
            return Convert.ToBase64String(GetBytes(data));
        }

        public string Decode(string data)
        {
            return GetString(Convert.FromBase64String(data));
        }
        
        protected byte[] GetBytes(string s)
        {
            return encoding.GetBytes(s);
        }

        protected string GetString(byte[] data)
        {
            return encoding.GetString(data);
        }
    }
}
