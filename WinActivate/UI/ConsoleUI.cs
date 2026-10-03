namespace WinActivate.UI
{
    public class ConsoleUI
    {
        static string space = FormatForLine();
        static string[] menuPointArray = { "Выберите пункт из меню:", " ", "1.Активировать Windows", "0.Выйти из программы" };
        string startLine = "____________________Activation Window's____________________\n" + space;
        string endLine = space + "|_________________________________________________________|";

        public void ShowMainMenu()
        {
            ClearUI();
            ShowMessage(menuPointArray);

        }

        // Показ сообщений
        public void ShowMessage(string message)
        {
            ClearUI();

            Console.WriteLine(startLine + FormatForLine(message) + endLine);
            Thread.Sleep(800);
        }

        public void ShowMessage(string[] messages)
        {
            ClearUI();

            Console.WriteLine(startLine + FormatForList(messages) + endLine);
        }

        //Форматирование для строк и списков
        private static string FormatForLine(string read = "")
        {
            string spaces = " ";
            read = "|        " + read;
            for (int i = 0; i < 57 - read.Length; i++) spaces += " ";
            return read + spaces + "|\n";
        }
        private static string FormatForList(string[] messages)
        {
            string read = "";
            //Крч задумка на будущее, что бы список отображался по центру
            //int longestLength = 0;
            //foreach (string line in messages)
            //{
            //    if (longestLength > line.Length) longestLength = line.Length;
            //}
            foreach (var item in messages)
            {
                string spaces = " ";
                string helper = "|        " + item;
                read = read + helper;
                for (int i = 0; i < 57 - helper.Length; i++) spaces += " ";
                read = read + spaces + "|\n";
            }
            return read;
        }

        //Возвращение ответа (для Programm)
        public int GetUserAnswer()
        {
            string usAnswer = Console.ReadLine();
            if (!int.TryParse(usAnswer.Trim(), out int input))
            {
                return -1;
            }
            return input;
        }

        private void ClearUI() => Console.Clear();
    }
}

//ActivationService.cs
//CommandExecutor.cs
//WindowsDetector.cs
//AdminChecker.cs +
//ActivationChecker.cs +
//WindowsUI.cs +