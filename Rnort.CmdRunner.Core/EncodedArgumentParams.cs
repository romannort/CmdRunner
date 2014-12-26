using Rnort.CmdRunner.Core.DataEncoding;

namespace Rnort.CmdRunner.Core
{
    internal class EncodedArgumentParams : ICommandParams
    {
        private readonly ICommandParams innerParams;

        public IEncodingStrategy EncodingStrategy { get; set; }

        public EncodedArgumentParams(ICommandParams innerParams)
        {
            this.innerParams = innerParams;
        }

        public string Executable
        {
            get { return innerParams.Executable; }
            set { innerParams.Executable = value; }
        }

        public string Command
        {
            get { return innerParams.Command; }
            set { innerParams.Command = value; }
        }

        public string Arguments
        {
            get { return EncodingStrategy.Encode(innerParams.Arguments); }
            set { innerParams.Arguments = value; }
        }
    }  
}
