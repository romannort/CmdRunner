using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rnort.CmdRunner.Core.DataEncoding
{
    /// <summary>
    ///  Does nothing to the data.
    /// </summary>
    internal class DefaultEncodingStrategy : IEncodingStrategy
    {
        public string Encode(string data)
        {
            return data;
        }

        public string Decode(string data)
        {
            return data;
        }
    }
}
