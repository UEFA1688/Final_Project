using System.Net;
using System.Net.Mail;


class Program {

    public static MainMenu mainMenu = new MainMenu();
    
    static void Main(string[] args)
    {   
            Console.ForegroundColor = ConsoleColor.Cyan; 

            Database.AddNewBicycleA(); 
            Database.AddNewBicycleB(); 
            Database.AddNewBicycleC(); 
            Database.AddNewUser(new KMUTT("Mr.", 
            "Palapol", 
            "Sankla", 
            "0888888888",
            "01234567891234", 
            "uefa.palapol@gmail.com", 
            "UEFA8888", "12345678", 
            "KMUTT", 
            "641205010004"));

            mainMenu.ShowMainMenuScreen();        

    }
}
