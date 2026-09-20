namespace WinActivate.UI
{
    public class ConsoleUI
    {
        public void ShowMainMenu()
        {
            string[] 
            ClearUI();
            ShowMessage(FormatInBox("Выберите пункт из меню:") + FormatInBox() +
                FormatInBox("1.Активировать Windows") +
                FormatInBox("0.Выйти из программы"));
        }
        public void ShowMessage(string message)
        {
            string startLine = "___________________Activation Window's___________________\n" + FormatInBox();
            string endLine = FormatInBox() + "|_______________________________________________________|";

            Console.WriteLine(startLine + FormatInBox(message) + endLine);
            Console.ReadKey();
            ClearUI();
        }

        public int GetUserAnswer()
        {
            if (int.TryParse(Console.ReadLine().Trim(), out int input) && input <= 1) return input;
            return -1;
        }

        private void ClearUI() => Console.Clear();
        private string FormatInBox(string read = "")
        {
            string spaces = " ";
            read = "|   " + read;
            int widghtWindow = Console.WindowWidth;
            for (int i = 0; i < 57 - read.Length - 2; i++) spaces += " ";
            return read + spaces + "|\n";
        }
    }
}

//ActivationService.cs
//CommandExecutor.cs
//WindowsDetector.cs
//AdminChecker.cs +
//ActivationChecker.cs +
//WindowsUI.cs +-