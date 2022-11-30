using System.Globalization;
public class Times
{

    public static DateTime GetTime() //เอาเวลาปัจจุบัน
    {
     DateTime Now = new DateTime((int.Parse(DateTime.Now.ToString("yyyy"))), 
     (int.Parse(DateTime.Now.ToString("MM"))), 
     (int.Parse(DateTime.Now.ToString("dd"))), 
     (int.Parse(DateTime.Now.ToString("HH"))), 
     (int.Parse(DateTime.Now.ToString("mm"))), 
     (int.Parse(DateTime.Now.ToString("ss"))));
     return Now;
    }
    public static string CovertYearToThai(DateTime CurrentTime)// แปลงเป็น พ.ศ.
    {
    ThaiBuddhistCalendar cal = new ThaiBuddhistCalendar();
    return ((cal.GetYear(CurrentTime)-543))+(CurrentTime.ToString("/MM/dd HH:mm"));
    }
    public static double CalCharge(DateTime ReturnTime, DateTime RentedTime)// คำนวณค่าบริการ
    {
        double SumTime = ((ReturnTime - RentedTime).TotalHours);
        return Math.Ceiling(SumTime) * 15;
    }
    public static double CountHours(DateTime ReturnTime, DateTime RentedTime) //ชั่วโมง
    {
        double SumTime = ((ReturnTime - RentedTime).TotalHours);
        return Math.Ceiling(SumTime);
    }
    public static double CountMinutes(DateTime ReturnTime, DateTime RentedTime)//นาที
    {
        double SumTime = ((ReturnTime - RentedTime).TotalMinutes);
        return Math.Round(SumTime);
    }


}