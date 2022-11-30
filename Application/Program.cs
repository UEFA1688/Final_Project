using System.Net;
using System.Net.Mail;


class Program : Database{

    public static Program program = new Program();
    public static MainMenu mainMenu = new MainMenu();
    
    static void Main(string[] args)
    {   
            Console.ForegroundColor = ConsoleColor.Cyan;
            DateTime.Now.ToString("HHmmss");
            DateTime.Now.ToString("yyyyMMddHHmm"); 
            Database.AddNewBicycleA(); 
            Database.AddNewBicycleB(); 
            Database.AddNewBicycleC(); 


            mainMenu.ShowMainMenuScreen();        

    }
    public void MailOTP(string Email, int Input){
            string fromMail = "palapol.uefa@mail.kmutt.ac.th";
            string fromPassword = "@oSzkC7M1Zd!8E7";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "KMUTT Bicycle Rental";
            message.To.Add(new MailAddress($"{Email}"));
            message.Body = $"<html><body> <h1>Your OTP to payment confirmation</h1><h2>{Input}</h2> </body></html>";
            message.IsBodyHtml = true;
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587, 
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };
            smtpClient.Send(message);
    }

    public void MailReceipt(string Email, string UserName, string Time){
            string fromMail = "palapol.uefa@mail.kmutt.ac.th";
            string fromPassword = "@oSzkC7M1Zd!8E7";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Your KMUTT Bicycle Rental E-Receipt";
            message.Body = $"<html><body> <h1>Thank you for using the service.</h1></body></html>";            
            message.To.Add(new MailAddress($"{Email}"));
            message.Attachments.Add(new Attachment($"output_{UserName}_{Time}.bmp"));
            message.IsBodyHtml = true;
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587, 
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };
            smtpClient.Send(message);
    }
}
