using System;
using System.Diagnostics;

class UserMenu {

    private User user;    
    private static MainMenu mainMenu = new MainMenu();

    public void ShowUserMenu(User user) {
        SetupUser(user);
        PrintUserMenu();
    }
    public void PrintUserMenu() {
        Console.Clear();
        while (true)
        {   
        PrintHeaderScreen();
        PrintListMenuScreen();
        Console.Write("                  Select Menu: ");  
        while (Console.KeyAvailable == true)
        {
              Stopwatch stopWatch = new Stopwatch();
              ConsoleKeyInfo UserInput = Console.ReadKey(); 

              if (char.IsDigit(UserInput.KeyChar) && UserInput.KeyChar == '1' || UserInput.KeyChar == '2' || UserInput.KeyChar == '0')
              {
                stopWatch.Start();
                if(stopWatch.ElapsedMilliseconds > 1000)
                {
                    stopWatch.Stop();
                    Console.Clear();
                    break;
                }
                if ((Console.ReadKey().Key == ConsoleKey.Enter))
                {
                UserMenuSelect input = (UserMenuSelect)int.Parse(UserInput.KeyChar.ToString());
                RouteToMenu(input);
                }                           
              }       
              else
              {
                Console.Clear();
                Console.WriteLine("You can enter 1, 2, or 0 only.");
                Thread.Sleep(1000);
                break;
              }
        
        }   
        Thread.Sleep(1000);
        Console.Clear();
        }
    }

    private void SetupUser(User user) {
        this.user = (User)user;
    }

    private void PrintHeaderScreen() {
        Console.WriteLine("");
        Console.WriteLine("    _________________________________________________");
        Console.WriteLine("    |                                               |");
        Console.WriteLine("    |              KMUTT Bicycle Rental             |");
        Console.WriteLine("    |                                               |");
        Console.WriteLine($"    |           {DateTime.Now.ToString("MM/dd/yyyy")}  Time :{DateTime.Now.ToString("HH:mm:ss")}          |");
        Console.WriteLine("    |_______________________________________________|");
        Console.WriteLine("");
        Console.WriteLine("                    [ USER INFORMATION]              ");
        Console.WriteLine($"        Username : {this.user.GetUserName} ");
        Console.WriteLine($"        FullName : {this.user.GetNamePrefix}{this.user.GetFirstName}  {this.user.GetLastName} ");
        Console.WriteLine($"        UserType : {this.user.GetUserType} ");
        Console.WriteLine("");

    }

    private void PrintListMenuScreen() {
        Console.WriteLine("         ");
        Console.WriteLine("        |   1 - Bicycle Reservation        |");
        Console.WriteLine("        |   2 - List your Bicycle          | ");
        Console.WriteLine("        |   0 - Logout                     |");
        Console.WriteLine("          ");
        Console.WriteLine("");
    }
     private void Logout() {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("         Logout >        ");
        Thread.Sleep(800);
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("         Logout >>        ");
        Thread.Sleep(800);
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("");        
        Console.WriteLine("         Logout >>>        ");
        Thread.Sleep(800);
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("         Logout >>>>        ");
        Thread.Sleep(800);
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("       ***  Logout  ***        ");
        Thread.Sleep(1000);
        Console.Clear();        


    }

    private void RouteToMenu(UserMenuSelect menu) {

        if (menu == UserMenuSelect.Logout) {
            Logout();
            mainMenu.ShowMainMenuScreen();
        }


        else if (menu == UserMenuSelect.Reservation) {
            Reservation reservation = new Reservation();
            reservation.ShowReservation(this.user);
        }  

        else if (menu == UserMenuSelect.List) 
        {
            UserRentedList userRentedList = new UserRentedList();
            userRentedList.ShowUserRentedList(this.user);
        }  

    }



}