using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rnort.CmdRunner.Core.DataEncoding
{
    public interface IEncodingStrategy
    {
        string Encode(string data);

        string Decode(string data);
    }
}
