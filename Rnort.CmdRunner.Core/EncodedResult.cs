using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rnort.CmdRunner.Core.DataEncoding;

namespace Rnort.CmdRunner.Core
{
    internal class EncodedResult : IExecutionResult
    {
        private readonly IExecutionResult innerResult;

        public IEncodingStrategy EncodingStrategy { get; set; }

        public EncodedResult(IExecutionResult innerResult)
        {
            this.innerResult = innerResult;
        }

        public string Value
        {
            get { return EncodingStrategy.Decode(innerResult.Value); }
            set { innerResult.Value = value; }
        }

        public ICollection<string> Errors
        {
            get { return innerResult.Errors; }
            set { innerResult.Errors = value; }
        }

        public bool HasErrors
        {
            get { return innerResult.HasErrors; }
        }
    }
}
