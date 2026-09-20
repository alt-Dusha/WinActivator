using WinActivate.Services;
using WinActivate.UI;

ConsoleUI _c = new ConsoleUI();
Main();
void Main()
{
    AdminChecker check = new AdminChecker();
    // Показываем меню
    _c.ShowMainMenu();
    // Проверяем ввод пользователя
    CommandExecutor _ex = new CommandExecutor();
    Menu();
}

void Menu()
{
    switch (_c.GetUserAnswer())
    {
        case (-1):
            _c.ShowMessage("Ошибка ввода");
            Main();
            break;
        case (0):
            _c.ShowMessage("Выбран пункт заркытия программы");
            break;
        case (1):
            _c.ShowMessage("Активация");
            break;
    }
}