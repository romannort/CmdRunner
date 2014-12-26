using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rnort.CmdRunner.Core
{
    public interface IExecutionResult
    {
        string Value { get; set; }

        ICollection<string> Errors { get; set; }

        bool HasErrors { get; }
    }
}
