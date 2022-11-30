using System.Collections.Generic;
using System;

class UserRented{

    private string UserName ;
    private string BicycleID ;
    private string Location ;
    private DateTime TimeRented ;
    private string Rented;
     public UserRented( 


      string UserName, 
      string BicycleID, 
      string Location, 
      DateTime TimeRented,
      string Rented)
     {

        this.UserName = GetUserName = UserName;
        this.BicycleID = GetBicycleID = BicycleID;
        this.Location = GetLocation = Location;
        this.TimeRented = GetTimeRented = TimeRented;
        this.Rented = GetRented = Rented;

     }


     public string GetUserName {get;}
     public string GetBicycleID {get;}
     public string GetLocation {get; set;}
     public DateTime GetTimeRented {get; set;}
     public string GetRented {get; set;}

}
