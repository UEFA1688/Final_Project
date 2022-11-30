using System.Reflection.Emit;

class User {
    protected string NamePrefix;
    protected string FirstName;
    protected string LastName;
    protected string PhoneNumber;
    protected string ID_CardNumber;
    protected string Email;
    protected string UserName;
    protected string Password;
    protected string UserType;
    protected string StudentID;

    public User( 
      string NamePrefix, 
      string FirstName, 
      string LastName, 
      string PhoneNumber ,
      string ID_CardNumber, 
      string Email, 
      string UserName, 
      string Password,
      string UserType, 
      string StudentID) 
      {
        this.NamePrefix = GetNamePrefix = NamePrefix;
        this.FirstName = GetFirstName = FirstName;
        this.LastName = GetLastName = LastName;
        this.PhoneNumber = GetPhoneNumber = PhoneNumber;
        this.ID_CardNumber = GetID_CardNumber = ID_CardNumber;
        this.Email = GetEmail = Email;
        this.UserName = GetUserName = UserName;
        this.Password = GetPassword = Password;
        this.UserType = GetUserType = UserType;
        this.StudentID = GetStudentID = StudentID;


    }

   public string GetNamePrefix {get;}
   public string GetFirstName {get;}
   public string GetLastName {get;}
   public string GetPhoneNumber {get;}
   public string GetID_CardNumber {get;}
   public string GetEmail {get;}
   public string GetUserName {get;}
   public string GetPassword {get;}
   public string GetUserType {get;}
   public string GetStudentID {get;}


  }