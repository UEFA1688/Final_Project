using System.Globalization;
using System;
using System.Drawing;
//dotnet add package System.Drawing.Common ด้วย

class Receipt
{
    private const int OutputImageSize = 500;
    //private static string OutputImageFilePath = "output.bmp";

    public static void Print_Picture(string UserType,
    string StudentID, 
    string UserName,
    string Prefix,
    string FirstName, 
    string LastName, 
    string BicycleID, 
    string LastLocation, 
    DateTime TimeRented, 
    DateTime TimeReturn, 
    double Price)
    {
        
        string OutputImageFilePath = String.Format($"output_{UserName}_{(TimeReturn.ToString("yyyyMMddHHmm"))}.bmp");

        string Head = ("KMUTT Bicycle Rental");
        string UserNameInput = String.Format($"UserName : {UserName}");
        string Name = String.Format($"Name : {Prefix}{FirstName} {LastName}");
        string Student_ID = String.Format($"Student ID : {StudentID}");
        string Bicycle_ID = String.Format($"BicycleID : {BicycleID}");
        string Location = String.Format($"Return Location : {LastLocation}");
        string Rented = String.Format($"Rental time : {Times.CovertYearToThai(TimeRented)}");
        string Return = String.Format($"Return time : {Times.CovertYearToThai(TimeReturn)}");
        string Time = String.Format($"Time spent : {Times.CountHours(TimeReturn, TimeRented)} Hours");
        string Charge = String.Format($"Price : {Price} Bath");
        string Type = String.Format($"UserType : {UserType}");
        string End = ("Thank you for using");

        Font fontH = new Font("Kanit", 20);
        Font fontI = new Font("Kanit", 16);
        Font fontE = new Font("Kanit", 12);
        SolidBrush ellipseBrush = new SolidBrush(Color.White);
        SolidBrush textBrush = new SolidBrush(Color.Black);
        Bitmap outputImage = new Bitmap("Picture/MDT.bmp");
        Pen Orangepen = new Pen(Color.OrangeRed, 4);
        Graphics graphics = Graphics.FromImage(outputImage);
        int x = 0;
        int y = 0;
        graphics.DrawRectangle(Orangepen, x, y, OutputImageSize, OutputImageSize);
        if (UserType == "Visitor")
        {
            graphics.DrawString(
                Head,
                fontH,
                textBrush,
                100,
                25
            );
            graphics.DrawString(
                End,
                fontE,
                textBrush,
                340,
                470
            );
            graphics.DrawString(
                UserNameInput,
                fontI,
                textBrush,
                130,
                70
            );
            graphics.DrawString(
                Name,
                fontI,
                textBrush,
                130,
                110
            );
            graphics.DrawString(
                Type,
                fontI,
                textBrush,
                130,
                150
            );
            graphics.DrawString(
                Bicycle_ID,
                fontI,
                textBrush,
                130,
                190
            );
            graphics.DrawString(
                Location,
                fontI,
                textBrush,
                130,
                230
            );
            graphics.DrawString(
                Rented,
                fontI,
                textBrush,
                130,
                270
            );
            graphics.DrawString(
                Return,
                fontI,
                textBrush,
                130,
                310
            );
            graphics.DrawString(
                Time,
                fontI,
                textBrush,
                130,
                350
            );
            graphics.DrawString(
                Charge,
                fontI,
                textBrush,
                130,
                390
            );
        }
        if (UserType == "KMUTT")
        {
            graphics.DrawString(
                Head,
                fontH,
                textBrush,
                100,
                25
            );
            graphics.DrawString(
                End,
                fontE,
                textBrush,
                340,
                470
            );
            graphics.DrawString(
                UserNameInput,
                fontI,
                textBrush,
                130,
                30
            );
            graphics.DrawString(
                Name,
                fontI,
                textBrush,
                130,
                70
            );
            graphics.DrawString(
                Type,
                fontI,
                textBrush,
                130,
                110
            );
            graphics.DrawString(
                Student_ID,
                fontI,
                textBrush,
                130,
                150
            );
            graphics.DrawString(
                Bicycle_ID,
                fontI,
                textBrush,
                130,
                190
            );
            graphics.DrawString(
                Location,
                fontI,
                textBrush,
                130,
                230
            );
            graphics.DrawString(
                Rented,
                fontI,
                textBrush,
                130,
                270
            );
            graphics.DrawString(
                Return,
                fontI,
                textBrush,
                130,
                310
            );
            graphics.DrawString(
                Time,
                fontI,
                textBrush,
                130,
                350
            );
            graphics.DrawString(
                Charge,
                fontI,
                textBrush,
                130,
                390
            );            
        }

        outputImage.Save(OutputImageFilePath);
        graphics.Dispose();
    }
}
