
public class MainMenu {

    public void ShowMainMenuScreen() {
        Console.Clear();
        ShowMenuScreenInformation();
    }

    private void ShowMenuScreenInformation() {
        PrintHeaderMenuScreen();
        PrintListMenuScreen();
        RouteToMenu(InputSelectedMenuFromKeyboard());
    }


    public AuthenMenu InputSelectedMenuFromKeyboard() {
        Console.Write("Select Menu: ");

        return (AuthenMenu)(int.Parse)(Console.ReadLine());        
    }

    private void RouteToMenu(AuthenMenu menu) {

        if (menu == AuthenMenu.Reservation) {
            Console.Clear();
            Reservation();
        }

        else if (menu == AuthenMenu.List) {
            Console.Clear();
            UserList();
        }  

        else if (menu == AuthenMenu.ShowAll) {
            Console.Clear();
            ShowAll();
        }  
        else if (menu == AuthenMenu.Logout) {
            Console.Clear();
            Logout();

        } 
      ShowMainMenuScreen();
    }
    

    private void Reservation() {
        Console.WriteLine("________________________________________________");
        Console.WriteLine("|                                               |");
        Console.WriteLine("|                VEHICLES LIST                  |");
        Console.WriteLine("|_______________________________________________|");
        Console.WriteLine(" ____________________________");
        Console.WriteLine(" | ID | Location | Status   |");
        Console.WriteLine(" |--------------------------|");
        Console.WriteLine(" | 4  | A2       | Active   |");
        Console.WriteLine(" | 6  | A3       | Active   |");
        Console.WriteLine(" | 7  | A4       | Active   |");
        Console.WriteLine(" | 8  | A5       | Active   |");
        Console.WriteLine(" |__________________________|");
        Console.WriteLine("");
        Console.WriteLine("Input ID to Reservation or Input [0] Back to Main Menu ");
        Console.WriteLine("Select Menu: ");
        string input = Console.ReadLine();
            
            if(input == "4"){
            Console.WriteLine("Reservated!!!");
            Console.WriteLine("");
            Console.WriteLine("Input [1] Back to Main Menu or Input [0] to Logout");
                string input2 = Console.ReadLine();
                
                if(input2 == "0"){
                    Logout();
                }
                else if(input2 == "1"){
                    ShowMainMenuScreen();
                }

            }

            else if(input == "0"){
                ShowMainMenuScreen();
            }

        Console.WriteLine("");
    }
    private void UserList() {
        Console.WriteLine("");
        Console.WriteLine("________________________________________________");
        Console.WriteLine("|                                               |");
        Console.WriteLine("|               My Bicycle List                 |");
        Console.WriteLine("|_______________________________________________|");
        Console.WriteLine("________________________________________________");
        Console.WriteLine(" | ID |    Date    | Location | Status | Charge |");
        Console.WriteLine(" |-----------------------------------------------");
        Console.WriteLine(" | 1  | 12.08.2022 | A1       | Active | 221THB |");
        Console.WriteLine(" |______________________________________________|");
        Console.WriteLine("");
        Console.WriteLine("Input ID to Pay Service Charge or Input [0] Back to Main Menu ");
        Console.WriteLine("Select Menu: ");
        string input = Console.ReadLine();
            
            if(input == "1"){
            Console.WriteLine("Paid!!!");
            Console.WriteLine("");
            Console.WriteLine("Input [1] Back to Main Menu or Input [0] to Logout");
                string input2 = Console.ReadLine();
                
                if(input2 == "0"){
                    Logout();
                }
                else if(input2 == "1"){
                    ShowMainMenuScreen();
                }

            }

            else if(input == "0"){
                ShowMainMenuScreen();
            }

    }   
    private void ShowAll() {
        Console.WriteLine("________________________________________________");
        Console.WriteLine("|                                               |");
        Console.WriteLine("|                VEHICLES LIST                  |");
        Console.WriteLine("|_______________________________________________|");
        Console.WriteLine(" ____________________________");
        Console.WriteLine(" | ID | Location | Status   |");
        Console.WriteLine(" |--------------------------|");
        Console.WriteLine(" | 1  | A1       | Reserved |");
        Console.WriteLine(" | 4  | A2       | Active   |");
        Console.WriteLine(" | 6  | A3       | Active   |");
        Console.WriteLine(" | 7  | A4       | Active   |");
        Console.WriteLine(" | 8  | A5       | Active   |");
        Console.WriteLine(" |__________________________|");
        Console.WriteLine("");
        Console.WriteLine("Input [0] Back to Main Menu ");
        Console.WriteLine("Select Menu: ");
        string input = Console.ReadLine();  
            if(input == "0"){
                ShowMainMenuScreen();
            }

    }
    private void Logout() {
        Console.WriteLine("");
        Console.WriteLine("=======================================");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("||         Logout Success>>>>        ||");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("=======================================");
        Console.WriteLine("--------------------------");
        Environment.Exit(0);
    }

    private void PrintHeaderMenuScreen() {
        Console.WriteLine("=======================================");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("||     BICYCLE RENTAL SYSTEM 2022    ||");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("=======================================");
        Console.WriteLine("--------------------------");
    }

    private void PrintListMenuScreen() {
        Console.WriteLine("UseName : UEFA168 | CitizenID : 1223432453645 | UserType : Student");
        Console.WriteLine("Available Bicycle :  [ 4 ]");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("||   1 - Bicycle Reservation        ||");
        Console.WriteLine("||   2 - List your Bicycle          || ");
        Console.WriteLine("||   3 - Show All Bicycle           ||");
        Console.WriteLine("||   0 - Logout                     ||");
        Console.WriteLine(" -----------------------------------");
        Console.WriteLine("");


    }

}