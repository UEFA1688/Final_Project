using System.Collections.Generic;
using System;

class KMUTT: User {
    private string StudentID;
     public KMUTT( 
      string NamePrefix, 
      string FirstName, 
      string LastName, 
      string PhoneNumber,
      string StudentID,
      string ID_CardNumber, 
      string Email, 
      string UserName, 
      string Password,
      string UserType)
     :base(NamePrefix, FirstName, LastName, PhoneNumber, ID_CardNumber, Email, UserName, Password, UserType){

        this.StudentID = GetStudentID= StudentID;

     }


     public string GetStudentID {get;}

}
