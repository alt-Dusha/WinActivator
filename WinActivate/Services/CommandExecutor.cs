using System.Diagnostics;
using System.Runtime;

namespace WinActivate.Services
{
    public class CommandExecutor
    {
        public string ConsoleCommandSwitcher(string command)
        {
            switch (command)
            {
                case "CheckActivationStatus":
                    return "slmgr /xpr";
                case "CheckWindowsVersion":
                    return "systeminfo | findstr /B /C:\"Имя ОС\"";
                default:
                    return "";
            }
        }

        public string ConsoleCommandExecutor(string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/C {command}",
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
            };
            Process process = Process.Start(startInfo);
            process.WaitForExit();
            string output = process.StandardOutput.ReadToEnd();
            return output;
        }
    }
}
