using System.Collections.Generic;
using System;

class Database{
    //List ที่เก็บข้อมูลผู้ใช้ต่างๆ
    public static List<User> users = new List<User>(); 
    public static List<UserRented> userRented = new List<UserRented>(); 
    public static List<Bicycle> bicycles = new List<Bicycle>(); 
    

    protected void CheckRented(string input, string Location, User user)
     {
         
        if (userRented.Exists(x => x.GetUserName == user.GetUserName && x.GetRented == "used"))
        {
                  Console.Clear();
                  Console.WriteLine(" ");
                  Console.WriteLine(" ");                  
                  Console.WriteLine("    ************************************************      ");
                  Console.WriteLine("        You have a bicycle that you are renting!                      ");
                  Console.WriteLine("                    --------------                       ");                
                  Console.WriteLine(" ");                   
                  Thread.Sleep(1000); 
                   
        }
         else
         {
          Rented(input, Location, user);      
      }        
     }
    protected void Rented(string input, string Location, User user)
     {
        foreach (Bicycle bicycle in bicycles)
        {
            if (bicycle.GetBicycleID == input && bicycle.GetLocation == Location) 
            {
               if (bicycle.GetStatus == "Ready")
               {
                        DateTime start  = Times.GetTime();
                        UserRented UserRented = new UserRented (user.GetUserName, bicycle.GetBicycleID, bicycle.GetLocation, start, "used"); 
                        userRented.Add(UserRented);
                        bicycle.GetStatus = "used ";
                        Console.Clear();
                        Console.WriteLine(" ");  
                        Console.WriteLine(" ");                
                        Console.WriteLine("    ************************************************      ");
                        Console.WriteLine("                Successfully Reservate                       ");
                        Console.WriteLine("                    --------------                       ");                
                        Console.WriteLine(" ");                
               }
               else
               {
                     Console.Clear();
                     Console.WriteLine(" ");  
                     Console.WriteLine(" ");  
                     Console.WriteLine("    ************************************************      ");
                     Console.WriteLine($"         Bicycle ID:{input} has been rented!");
                     Console.WriteLine("                    --------------                       ");                
                     Console.WriteLine(" ");                   
                     Thread.Sleep(1000); 
                     break;            
            }


            }
            
        }
     }
     protected void RentedList(User user)
     {

                    foreach (UserRented check in userRented)
                    {
                        if (check.GetUserName == user.GetUserName) 
                        {
                           if (check.GetRented == "used")
                           {
                            DateTime end = Times.GetTime();
                            double TimeH = Times.CountHours(end, check.GetTimeRented);
                            double TimeM = Times.CountMinutes(end, check.GetTimeRented);
                            double Charge = Times.CalCharge(end, check.GetTimeRented);
    
                            Console.WriteLine("");  
                            Console.WriteLine($"           {check.GetBicycleID}              {check.GetLocation}             {TimeM} Minutes          {check.GetRented}          {Charge} Baht  ");  
                           }

                           }
                    }

    
     }



     public static void AddNewUser(User user) 
     {
      users.Add(user);
     }
     public static void AddNewBicycleA() 
     {
        for (int i = 1; i < 10; i++)
        {
        Bicycle x = new Bicycle($"{i}","A","Ready");  
        bicycles.Add(x);
        }
     }
     public static void AddNewBicycleB() 
     {
        for (int i = 10; i < 20; i++)
        {
        Bicycle x = new Bicycle($"{i}","B","Ready");  
        bicycles.Add(x);
        }
     }
     public static void AddNewBicycleC() 
     {
        for (int i = 20; i < 30; i++)
        {
        Bicycle x = new Bicycle($"{i}","C","Ready");  
        bicycles.Add(x);
        }
     }


     protected static void BicycleAtLocation(string input) 
     {
        foreach (Bicycle bicycle in bicycles)
        {
            string x = bicycle.GetLocation;
            if (x == input) 
            {
            Console.WriteLine("");                 
            Console.WriteLine($"            {bicycle.GetBicycleID}                  {bicycle.GetLocation}                 {bicycle.GetStatus}   ");                 
                
            }
            
        }
     }
}
    //

