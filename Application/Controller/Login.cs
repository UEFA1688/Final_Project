using System.Collections.Generic;
using System;

class Login{

    public void ShowLoginScreen() {
        Console.Clear();
        PrintHeaderLoginScreen();
    }

    public bool InputLoginFromKeyboard(List<User> listUsers) {
        string UserName = InputUserNameFromKeyboard();
        string Password = InputPasswordFromKeyboard();

        foreach (User user in listUsers) {
            if (user.GetUserName == UserName && user.GetPassword == Password) {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                  Logging >        ");
                Thread.Sleep(800);
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                  Logging >>        ");
                Thread.Sleep(800);
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");        
                Console.WriteLine("                  Logging >>>        ");
                Thread.Sleep(800);
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                  Logging >>>>        ");
                Thread.Sleep(800);
                Console.Clear();               
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("               ***  Logged in  ***        ");
                Thread.Sleep(1000);
                Console.Clear();               
                ShowUserMenu(user);
            }
        }
        return false;
    }

    private void ShowUserMenu(User user) {
        UserMenu controller = new UserMenu();
        controller.ShowUserMenu(user);
    }


    public string InputUserNameFromKeyboard() {
        Console.Write("               Input UserName: ");

        return Console.ReadLine();
    }

    public string InputPasswordFromKeyboard() {
        Console.Write("               Input Password: ");

        return Console.ReadLine();
    }

    private void PrintHeaderLoginScreen() {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("    ************************************************      ");
        Console.WriteLine("    |            KMUTT Bicycle Rental              |      ");
        Console.WriteLine("    ************************************************      ");
        Console.WriteLine("                     Login Screen                       ");
        Console.WriteLine("                    --------------                       "); 
    }

}