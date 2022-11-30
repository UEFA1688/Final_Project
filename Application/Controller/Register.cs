using System.Threading.Tasks.Dataflow;
using System.Reflection.Metadata;
using System.Threading;
using System;

class Register{

    public void ShowRegisterScreen() {
        Console.Clear();
        PrintHeaderRegisterScreen();
    }
    public User InputNewUserFromKeyboard(List<User> listUsers) {

        string NamePrefix = RouteToPrefix(SelectedPrefix());
        string FirstName = InputFirstNameFromKeyboard();
        string LastName = InputLastNameFromKeyboard(); 

        string PhoneNumber = InputPhoneNumberFromKeyboard();
            foreach (User user in listUsers)
            {
                while (PhoneNumber == user.GetPhoneNumber) {
                Console.WriteLine("");
                Console.WriteLine("|==========================================================|");
                Console.WriteLine("|  This phone number is already in use, please try again.  |");
                Console.WriteLine("|==========================================================|");                 
                Console.WriteLine("");
                Console.WriteLine("");
                PhoneNumber = InputPhoneNumberFromKeyboard();      
                }
                if (PhoneNumber != user.GetPhoneNumber)            
                {
                    break;
                }
            }

        string ID_CardNumber = InputID_CardNumberFromKeyboard();
            foreach (User user in listUsers)
            {
                while (ID_CardNumber == user.GetID_CardNumber) {
                Console.WriteLine("");
                Console.WriteLine("|=======================================================|");
                Console.WriteLine("|  This ID number is already in use, please try again.  |");
                Console.WriteLine("|=======================================================|");                
                Console.WriteLine("");
                Console.WriteLine("");
                ID_CardNumber = InputID_CardNumberFromKeyboard();      
                }
                if (ID_CardNumber != user.GetID_CardNumber)            
                {
                    break;
                }
            }        

        string Email = InputEmailFromKeyboard();
            foreach (User user in listUsers)
            {
                while (Email == user.GetEmail) {
                Console.WriteLine("");
                Console.WriteLine("|===========================================================|");
                Console.WriteLine("|  This email address is already in use, please try again.  |");
                Console.WriteLine("|===========================================================|");                
                Console.WriteLine("");
                Console.WriteLine("");
                Email = InputEmailFromKeyboard();     
                }
                if (Email != user.GetEmail)            
                {
                    break;
                }
            }     

        string UserName = InputUserNameFromKeyboard();
            foreach (User user in listUsers)
            {
                while (UserName == user.GetUserName) {
                Console.WriteLine("");
                Console.WriteLine("|======================================================|");
                Console.WriteLine("|  This username is already in use, please try again.  |");
                Console.WriteLine("|======================================================|");
                Console.WriteLine("");
                Console.WriteLine("");
                UserName = InputUserNameFromKeyboard();      
                }
                if (UserName != user.GetUserName)            
                {
                    break;
                }
            }     

        string Password = InputPasswordFromKeyboard();


 
      return new Visitor(NamePrefix, FirstName, LastName, PhoneNumber ,ID_CardNumber, Email, UserName, Password, "Visitor");
}

    private string InputFirstNameFromKeyboard() {
        Console.WriteLine("");
        Console.Write("               Input FirstName: ");

        return Console.ReadLine();
    }

    private string InputLastNameFromKeyboard() {
        Console.Write("               Input LastName: ");

        return Console.ReadLine();
    }

    private string InputPhoneNumberFromKeyboard() {
        Console.Write("               PhoneNumber: ");
        return Console.ReadLine();
    }
    private string InputID_CardNumberFromKeyboard() {
        Console.Write("               ID_CardNumber: ");

        return Console.ReadLine();
    }

    private string InputEmailFromKeyboard() {
        Console.Write("               Email : ");

        return Console.ReadLine();
    }
    private string InputUserNameFromKeyboard() {
        Console.Write("               UserName : ");

        return Console.ReadLine();
    }
    private string InputPasswordFromKeyboard() {
        Console.Write("               Password : ");

        return Console.ReadLine();
    }


    private void PrintHeaderRegisterScreen() {

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("    ************************************************      ");
        Console.WriteLine("    |            KMUTT Bicycle Rental              |      ");
        Console.WriteLine("    ************************************************      ");
        Console.WriteLine("                    Register Screen                       ");
        Console.WriteLine("                    --------------                       ");         
    }
    public string SelectedPrefix() {

        Console.WriteLine("");
        Console.WriteLine("               Select Prefix: ");
        Console.WriteLine("               1: Mr.");
        Console.WriteLine("               2: Ms.");
        Console.WriteLine("               3: Miss.");
        Console.Write("               Input Number:");


        return Console.ReadLine();     
    }

    private string RouteToPrefix(string menu) {


        if (menu ==  "1") {
             return "Mr.";
        } else if (menu == "2") {
             return "Ms.";
           
        }else if (menu == "3") {
             return "Miss.";
           
        }
        else
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("  You can enter 1, 2, or 3 only.");
            Thread.Sleep(1000);
            Console.Clear();
            PrintHeaderRegisterScreen();           
            RouteToPrefix(SelectedPrefix());
        }
        return null;
    }


}