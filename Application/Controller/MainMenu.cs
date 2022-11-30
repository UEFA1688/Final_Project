using System;
using System.Collections.Generic;



class MainMenu:Database {

    private Register register;
    private Login login;
    private static List<User> users = Database.users;
    private static List<Bicycle> bicycle = Database.bicycles;

    public void ShowMainMenuScreen() {
        Console.Clear();
        ShowMenuScreenInformation();
    }

    private void ShowMenuScreenInformation() {
        PrintHeaderMenuScreen();
        PrintListMenuScreen();
        RouteToMenu(InputSelectedMenuFromKeyboard());
    }

    public string InputSelectedMenuFromKeyboard() {
        Console.Write("               Select Menu: ");
        return Console.ReadLine();        
    }

    private void RouteToMenu(string menu) {

        if (menu ==  "2") {
            ShowRegisterScreen();
            Database.AddNewUser(this.register.InputNewUserFromKeyboard(users));
            
            Console.Clear();
            ShowMenuScreenInformation();
        }


        else if (menu ==  "1") {
            ShowLoginScreen();
            bool status = this.login.InputLoginFromKeyboard(users);
            ShowMenuScreenWhenAuthenInCorrect(status);
        }  
        else
        {
            Console.Clear();
            Console.WriteLine("You can enter 1 or 2 only.");
            Thread.Sleep(1000);
            Console.Clear();
            ShowMenuScreenInformation(); 
        }        
      ShowMainMenuScreen();
    }
    
    private void ShowUserScreenWhenAuthenInCorrect(bool authenStatus) {
        if (authenStatus) {
            ShowMenuScreenInformation();
     }
    }
    private void ShowMenuScreenWhenAuthenInCorrect(bool authenStatus) {
        if (!authenStatus) {
            Console.WriteLine(" ");
            Console.WriteLine("Incorrect email or password. Please try again.");
            Console.WriteLine(" ");
            Thread.Sleep(1000);
            Console.Clear();
            ShowMenuScreenInformation();
        }
    }

    private void ShowRegisterScreen() {
        this.register = new Register();
        this.register.ShowRegisterScreen();
    }

    private void ShowLoginScreen() {
        this.login = new Login();
        this.login.ShowLoginScreen();
    }

    private void PrintHeaderMenuScreen() {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("    ************************************************       ");
        Console.WriteLine("    |            KMUTT Bicycle Rental              |      ");
        Console.WriteLine("    ************************************************      ");
        Console.WriteLine("                                                            ");
        Console.WriteLine("");
    }

    private void PrintListMenuScreen() {

        Console.WriteLine("          |   1 - Login                       |");
        Console.WriteLine("          |   2 - Register for Visitor        | ");
        Console.WriteLine("");

    }

}