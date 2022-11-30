class Visitor: User {
     public Visitor( 
      string NamePrefix, 
      string FirstName, 
      string LastName, 
      string PhoneNumber ,
      string ID_CardNumber, 
      string Email, 
      string UserName, 
      string Password,
      string UserType)
     :base(NamePrefix, FirstName, LastName, PhoneNumber, ID_CardNumber, Email, UserName, Password, UserType){
          this.UserType = "Visitor";

     }
}
