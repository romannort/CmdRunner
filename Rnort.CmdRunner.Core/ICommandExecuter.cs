using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rnort.CmdRunner.Core
{
    public interface ICommandExecuter
    {
        IExecutionResult Execute(ICommandParams commandArguments);
    }
}
