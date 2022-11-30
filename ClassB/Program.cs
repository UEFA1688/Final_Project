
enum AuthenMenu {
    Logout = 0,
    Reservation,
    List,
    ShowAll

}

class Program
{
    static MainMenu mainMenu;
    public static void Main(string[] args)
    {
        PreMainMenu();
        ShowMainMenuScreen();
    }

        static void PreMainMenu() {
            Program.mainMenu = new MainMenu();
        }

        static void ShowMainMenuScreen() {
            Program.mainMenu.ShowMainMenuScreen();
        }
}

