using System.Runtime.InteropServices;
using WinActivate.Services;
using WinActivate.UI;

ConsoleUI _c = new ConsoleUI();
Main();
void Main()
{
    Menu();
}

void Menu()
{
    int usIntAnswer;
    do
    {
        _c.ShowMainMenu();
        usIntAnswer = _c.GetUserAnswer();
        switch (usIntAnswer)
        {
            case 0:
                _c.ShowMessage("Закрытие программы");
                break;
            case 1:
                ActivationChecker activationChecker = new ActivationChecker();
                _c.ShowMessage(activationChecker.CheckActivationStatus());
                break;
            default:
                _c.ShowMessage("Ошибка ввода");
                break;
        }
    }
    while (usIntAnswer != 0);
}

