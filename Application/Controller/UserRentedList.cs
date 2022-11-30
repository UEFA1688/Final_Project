using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System;

class UserRentedList : Database
{
    private static UserMenu userMenu = new UserMenu();
    private static Program main = new Program();
    private User user;

    
    private void SetupUser(User user) {
        this.user = (User)user;
    }
    public void ShowUserRentedList(User user) {
        SetupUser(user);
        Console.Clear();
        PrintRentedList();

    }

    private void PrintRentedList() {
        Console.Clear();
        while (true)
        {
       
        PrintList(this.user); 
        RentedList(this.user);   
        PrintListMenuScreen();
        Console.Write("               Select Menu: ");  
        while (Console.KeyAvailable == true)
        {
              Stopwatch stopWatch = new Stopwatch();
              ConsoleKeyInfo UserInput = Console.ReadKey(); 

              if (char.IsDigit(UserInput.KeyChar) && UserInput.KeyChar == '1' || UserInput.KeyChar == '0')
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
                Console.WriteLine("");
                Console.WriteLine("You can enter 1 or 0 only.");
                Thread.Sleep(1000);
                break;
              }
        
        }   
        Thread.Sleep(1000);
        Console.Clear();
        }
    }

    private void PrintList(User user) {
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
        Console.WriteLine("      ______________________________________________________________________________");
        Console.WriteLine("      |   ID    |     Location    |       Time       |    Status    |     Charge   |");
                      
    }

    private void PrintListMenuScreen() {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("          |    1 - Return the Bicycle and pay the service charge.   |");
        Console.WriteLine("          |    0 - Back to previous menu.                           |");
        Console.WriteLine(" ");
        Console.WriteLine("");
    }

    private void Paying(User user) {

            foreach (UserRented check in userRented)
            {
            if (check.GetUserName == this.user.GetUserName && check.GetRented == "used") 
                {
               
                    DateTime end = Times.GetTime();
                    double TimeM = Times.CountMinutes(end, check.GetTimeRented);
                    double Charge = Times.CalCharge(end, check.GetTimeRented);
                    Console.Clear(); 
                    Console.WriteLine("    _________________________________________________________________________________");
                    Console.WriteLine("    |                                                                               |");
                    Console.WriteLine($"    |                          Service Charge : {Charge} Baht                             |");
                    Console.WriteLine("    |_______________________________________________________________________________|");
                    Console.WriteLine(" ");
                    Console.WriteLine("          |    1 - Pay service charge.        |");
                    Console.WriteLine("          |    0 - Back to previous menu.     |");
                    Console.WriteLine(" ");
                    Console.WriteLine("");
                    Console.Write("                  Select Menu: ");  




                    string pay = Console.ReadLine(); 
                    char UserInput = pay[0]; 
                    if (char.IsDigit(UserInput))
                    {
                        if (Int32.Parse(pay) == 1)
                        {
                            int OTP = GenerateRandomNo();
                            main.MailOTP(user.GetEmail, OTP);
                            Console.Clear();
                            Console.WriteLine(" ");                  
                            Console.WriteLine("    ************************************************      ");
                            Console.WriteLine("                   OTP Number Send!                      ");
                            Console.WriteLine("                    --------------                       ");                
                            Console.WriteLine(" ");  
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("    _________________________________________________________________________________");
                            Console.WriteLine("    |                                                                                |");
                            Console.WriteLine("    |     Please enter the otp number received from your email to confirm payment.   |");
                            Console.WriteLine("    |________________________________________________________________________________|");
                            Console.WriteLine("");
                            Console.WriteLine($"    Service Charge : {Charge} Baht");
                            Console.WriteLine($"    UserName : {user.GetUserName}");
                            Console.WriteLine("");
                            Console.Write("                  Enter the OTP number: ");  
  
                            string input = Console.ReadLine();
                            char xInput = input[0]; 
                                        
                        if (char.IsDigit(xInput))
                        {   
                            if (Int32.Parse(input) == OTP)
                                {
                                    Console.Clear(); 
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ");                  
                                    Console.WriteLine("    ************************************************      ");
                                    Console.WriteLine("                     OTP Correct!                      ");
                                    Console.WriteLine("                    --------------                       ");                
                                    Console.WriteLine(" ");                                           
                                    Thread.Sleep(1000);
                                    Console.Clear();                                   
                                    Console.WriteLine("    ___________________________________________________________________________________________");
                                    Console.WriteLine("    |                                                                                          |");
                                    Console.WriteLine("    |                         At which station do you return the bike?                         |");
                                    Console.WriteLine("    |__________________________________________________________________________________________|");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("          Select Location   ");
                                    Console.WriteLine("          |  1 - A.                       |");
                                    Console.WriteLine("          |  2 - B.                       |     ");
                                    Console.WriteLine("          |  3 - C.                       |");
                                    Console.WriteLine("          |  0 - Back to previous menu.   |                         ");
                                    Console.WriteLine(" ");      

                                    string a = Console.ReadLine();
                                    char b = a[0]; 
                                    if (char.IsDigit(b))
                                    {                                     
                                    if (int.Parse(a) == 1 || int.Parse(a) == 2 || int.Parse(a) == 3 || int.Parse(a) == 0)
                                        {

                                            foreach (Bicycle bicycle in bicycles)
                                            {
                                                if (bicycle.GetBicycleID == check.GetBicycleID) 
                                                {
                                                    check.GetRented = "returned";
                                                    bicycle.GetStatus = "Ready";
                                                    DateTime now = Times.GetTime();                                                   
                                                    if (int.Parse(a) == 1)
                                                    {
                                                        bicycle.GetLocation = "A";
                                                    }
                                                    if (int.Parse(a) == 2)
                                                    {
                                                        bicycle.GetLocation = "B";
                                                    }
                                                    if (int.Parse(a) == 3)
                                                    {
                                                        bicycle.GetLocation = "C";
                                                    }
                                                    if (int.Parse(a) == 0){
                                                        ShowUserRentedList(this.user); 
                                                    }

                                                    if (user.GetUserType == "Visitor")
                                                    {
                                                        Receipt.Print_Picture(user.GetUserType, 
                                                        null, 
                                                        user.GetUserName,
                                                        user.GetNamePrefix, 
                                                        user.GetFirstName, 
                                                        user.GetLastName, 
                                                        check.GetBicycleID,
                                                        bicycle.GetLocation,
                                                        check.GetTimeRented,
                                                        now,
                                                        Charge);                                                         
                                                    }
                                                    if (user.GetUserType == "KMUTT")
                                                    {
                                                        Receipt.Print_Picture(user.GetUserType, 
                                                        user.GetStudentID, 
                                                        user.GetUserName,
                                                        user.GetNamePrefix, 
                                                        user.GetFirstName, 
                                                        user.GetLastName, 
                                                        check.GetBicycleID,
                                                        bicycle.GetLocation,
                                                        check.GetTimeRented,
                                                        now, 
                                                        Charge);                                                        
                                                    }


                                                    main.MailReceipt(user.GetEmail, user.GetUserName, (now.ToString("yyyyMMddHHmm")));

 
                                                    Console.Clear();
                                                    Console.WriteLine(" ");                  
                                                    Console.WriteLine("    ************************************************      ");
                                                    Console.WriteLine("            Successfully return of the Bicycle.                      ");
                                                    Console.WriteLine("                    --------------                       ");                
                                                    Console.WriteLine(" "); 
                                                    Thread.Sleep(1000);

                                                    userMenu.ShowUserMenu(user);                                                                                                                                                         
                                                }

                                        }
                                    }                                    
                                    if (Int32.Parse(input) == 0)
                                    {
                                        ShowUserRentedList(this.user); 
                                    }                                    

                                    else
                                    {
                                        Console.Clear(); 
                                        Console.WriteLine("");              
                                        Console.WriteLine("You can enter 1, 2, 3 or 0 only.");
                                        Thread.Sleep(1000);

                                    }                                     


                                }
                                if (Int32.Parse(input) == 0)
                                {
                                    ShowUserRentedList(this.user);                                                          
                                }
                            }  
                            else
                            {
                                Console.Clear();   
                                Console.WriteLine("");
                                Console.WriteLine("You enter wrong OTP number.");
                                Thread.Sleep(1000); 
                                ShowUserRentedList(this.user);
                            }
                        }     

                        if (Int32.Parse(pay) == 0)
                        {
                            ShowUserRentedList(this.user);
                        } 
                        else
                        {
                            Console.Clear();   
                            Console.WriteLine("");
                            Console.WriteLine("You can enter number only.");
                            Thread.Sleep(1000);
                            ShowUserRentedList(this.user);             

                        } 
                        }      
                    }
                    else
                    {
                    Console.Clear();  
                    Console.WriteLine(""); 
                    Console.WriteLine("You can enter 1 or 0 only.");
                    Thread.Sleep(1000);
                    }                       

                    }

                }
    

          
    }

    private  void RouteToMenu(UserMenuSelect menu) {
        
        if (menu == UserMenuSelect.Logout) {
            
        userMenu.ShowUserMenu(user);         
        }
        if (menu == UserMenuSelect.Reservation) {
        Paying(this.user); 
      
        }
        else
        {
            ShowUserRentedList(this.user);
        }
    }
    public int GenerateRandomNo()
    {
        int _min = 1000;
        int _max = 9999;
        Random _rdm = new Random();
        return _rdm.Next(_min, _max);
    }

}


