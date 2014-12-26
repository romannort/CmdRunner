using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rnort.CmdRunner.Core
{
    public class ExecutionResult : IExecutionResult
    {
        public string Value { get; set; }

        public ICollection<string> Errors { get; set; }

        public bool HasErrors
        {
            get { return Errors.Any(); }
        }

        public ExecutionResult()
        {
            Value = string.Empty;

            Errors = new List<string>();
        }
    }
}
