using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rnort.CmdRunner.Core
{
    public interface ICommandParams
    {
        string Executable { get; set; }

        string Command { get; set; }

        string Arguments { get; set; }
    }
}
