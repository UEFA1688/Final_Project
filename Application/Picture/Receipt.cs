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
        string Charge = String.Format($"{Price} Baht");
        string Type = String.Format($"UserType : {UserType}");

        Font fontH = new Font("Kanit", 7);
        Font fontI = new Font("Kanit", 16);
        Font fontE = new Font("Kanit", 12);
        Font fontCharge = new Font("Kanit", 11, FontStyle.Bold);
        SolidBrush ellipseBrush = new SolidBrush(Color.White);
        SolidBrush textBrush = new SolidBrush(Color.Orange);
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
                142,
                100
            );
            graphics.DrawString(
                UserNameInput,
                new Font("Kanit", 5, FontStyle.Bold),
                textBrush,
                52,
                160
            );
            graphics.DrawString(
                Name,
                new Font("Kanit", 4, FontStyle.Bold),
                textBrush,
                52,
                200
            );
            graphics.DrawString(
                Type,
                new Font("Kanit", 5, FontStyle.Bold),
                textBrush,
                260,
                275
            );
            graphics.DrawString(
                Bicycle_ID,
                new Font("Kanit", 6, FontStyle.Bold),
                textBrush,
                260,
                237
            );
            graphics.DrawString(
                Location,
                new Font("Kanit", 4, FontStyle.Bold),
                textBrush,
                52,
                240
            );
            graphics.DrawString(
                Rented,
                new Font("Kanit", 3, FontStyle.Bold),
                textBrush,
                52,
                270
            );
            graphics.DrawString(
                Return,
                new Font("Kanit", 3, FontStyle.Bold),
                textBrush,
                52,
                290
            );
            graphics.DrawString(
                Time,
                new Font("Kanit", 6, FontStyle.Bold),
                textBrush,
                52,
                310
            );
            graphics.DrawString(
                Charge,
                fontCharge,
                textBrush,
                52,
                386
            );
        }
        if (UserType == "KMUTT")
        {
            graphics.DrawString(
                Head,
                fontH,
                textBrush,
                142,
                100
            );
            graphics.DrawString(
                Student_ID,
                new Font("Kanit", 3, FontStyle.Bold),
                textBrush,
                240,
                360
            );
            graphics.DrawString(
                UserNameInput,
                new Font("Kanit", 5, FontStyle.Bold),
                textBrush,
                52,
                160
            );
            graphics.DrawString(
                Name,
                new Font("Kanit", 4, FontStyle.Bold),
                textBrush,
                52,
                200
            );
            graphics.DrawString(
                Type,
                new Font("Kanit", 5, FontStyle.Bold),
                textBrush,
                260,
                275
            );
            graphics.DrawString(
                Bicycle_ID,
                new Font("Kanit", 6, FontStyle.Bold),
                textBrush,
                260,
                237
            );
            graphics.DrawString(
                Location,
                new Font("Kanit", 4, FontStyle.Bold),
                textBrush,
                52,
                240
            );
            graphics.DrawString(
                Rented,
                new Font("Kanit", 3, FontStyle.Bold),
                textBrush,
                52,
                270
            );
            graphics.DrawString(
                Return,
                new Font("Kanit", 3, FontStyle.Bold),
                textBrush,
                52,
                290
            );
            graphics.DrawString(
                Time,
                new Font("Kanit", 6, FontStyle.Bold),
                textBrush,
                52,
                310
            );
            graphics.DrawString(
                Charge,
                fontCharge,
                textBrush,
                52,
                386
            );
        }


        outputImage.Save(OutputImageFilePath);
        graphics.Dispose();
    }
}
