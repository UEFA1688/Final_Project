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

            mainMenu.ShowMainMenuScreen();        

    }
}
