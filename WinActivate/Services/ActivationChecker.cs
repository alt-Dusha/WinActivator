using System;
using System.Collections.Generic;
using System.Text;

namespace WinActivate.Services
{
    class ActivationChecker
    {

        public string CheckActivationStatus()
        {
            CommandExecutor commandExecutor = new CommandExecutor();
            return commandExecutor.TakeConsoleCommandResult(commandExecutor.ConsoleCommandSwitcher("CheckActivationStatus"));
        }
    }
}
