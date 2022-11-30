class Reservation : Database
{
    private User user;
    private static UserMenu userMenu;
    
    public void ShowReservation(User user) {
        SetupUser(user);
        Console.Clear();
        PrintHeaderScreen();
        PrintListMenuScreen();
        RouteToMenu();
    }

    private void SetupUser(User user) {
        this.user = (User)user;
    }

    private void PrintHeaderScreen() {
        Console.Clear();
        Console.WriteLine("    _________________________________________________");
        Console.WriteLine("    |                                               |");
        Console.WriteLine("    |                VEHICLES LIST                  |");
        Console.WriteLine("    |_______________________________________________|");

    }
    private void PrintLocation(String input) {
        Console.Clear();
        Console.WriteLine("    __________________________________________________________");
        Console.WriteLine("    |                                                        |");
        Console.WriteLine($"    |                VEHICLES LIST LOCATION {input}                    |");
        Console.WriteLine("    |________________________________________________________|");
        Console.WriteLine("     ________________________________________________________");
        Console.WriteLine("     |      ID      |      Location     |       Status      |");
       

    }


    private void PrintListMenuScreen() {
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("          |   1 - Show Bicycle at Location A.   |");
        Console.WriteLine("          |   2 - Show Bicycle at Location B.   | ");
        Console.WriteLine("          |   3 - Show Bicycle at Location C.   | ");
        Console.WriteLine("          |   0 - Back to previous menu.        |");
        Console.WriteLine(" ");
        Console.Write("               Input Number: ");
    }
    private void ReservationMenu() {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine(" ");
        Console.WriteLine("               |  Select BicycleID to Reservation.  |");
        Console.WriteLine("               |     0 - Back to previous menu.     |");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.Write("               Input Number: ");
    }

        public static bool IsEmpty<T>(List<T> list)
    {
        if (list == null) {
            return true;
        }
 
        return !list.Any();
    }
    private void ReservationMenu(string Location) {    
            PrintLocation(Location) ;
            Database.BicycleAtLocation(Location); 
            ReservationMenu();

            string input = Console.ReadLine();
            char UserInput = input[0]; 
            if (char.IsDigit(UserInput))
            {
                if (Int32.Parse(input) > 0 && Int32.Parse(input) < 31)
                {
                    bool isEmpty = IsEmpty(userRented);
            
                    if (isEmpty) {
                        Rented(input, Location, this.user);
                    }
                    else {
                        CheckRented(input, Location, this.user);
                    }
                }
            }
            else
            {
             Console.Clear();
             Console.WriteLine("You can enter 1-30, or 0 only.");
             Thread.Sleep(1000);
             ShowReservation(this.user);               
            }               
             
    }
    private void RouteToMenu() {
        string menu = Console.ReadLine();
        if (menu == "0") {
            userMenu.ShowUserMenu(this.user);
        }
        else if (menu == "1") 
        {
            ReservationMenu("A");
        }  
        else if (menu == "2") 
        {
            ReservationMenu("B");

        }  
        else if (menu == "3") 
        {
            ReservationMenu("C");;

        }

        else{
                Console.Clear();
                Console.WriteLine("You can enter 1, 2, 3, or 0 only.");
                Thread.Sleep(1000); 
                ShowReservation(this.user);           
        }  

    }


}


