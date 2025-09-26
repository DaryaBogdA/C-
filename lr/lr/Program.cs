using Microsoft.VisualBasic;
using System;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

class Program
    {
        public static void Main()
        {
            Date d = new Date(16, 12, 2006);
            Console.WriteLine("Your date:");
            d.show();

            Console.WriteLine("Change year");
            d.set_year(2009);
            d.show();

            Console.WriteLine("Change month");
            d.set_month(2);
            d.show();

            Console.WriteLine("Change day");
            d.set_day(27);
            d.show();

            Console.WriteLine("+ 10 day");
            d.change_day(10);
            d.show();

            Console.WriteLine("+ 3 month");
            d.change_month(3);
            d.show();

            Console.WriteLine("+ 2 year");
            d.change_year(2);
            d.show();

        Day_week d2 = new Day_week(24, 9, 2025);
        d2.show();
        d2.GetDayOfWeek();
    }

}
class Day_week : Date
{
    public Day_week(int day, int month, int year) : base(day, month, year) { }

    public void GetDayOfWeek()
    {
        Console.WriteLine(date.ToString("dddd", CultureInfo.InvariantCulture)); 
    }
}
class Date
{
    protected DateTime date;

    public Date() 
    { 
        date = new DateTime(1900, 1, 1);
    }

    public Date(int day, int month, int year)
    {
        try
        {
            date = new DateTime(year, month, day);
        }
        catch
        {
            Console.WriteLine("Not true date");
            date = new DateTime(1900, 1, 1);
        }


    }

    private void update_date(int day, int month, int year)
    {
        try
        {
            date = new DateTime(year, month, day);
        }
        catch
        {
            Console.WriteLine("Not true date");
            date = new DateTime(1900, 1, 1);
        }
    }
    public void set_year(int year)
    {
        update_date(date.Day, date.Month, year);
    }

    public void set_day(int day)
    {
        update_date(day, date.Month, date.Year);
    }

    public void set_month(int month)
    {
        update_date(date.Day, month, date.Year);
    }

    public void show()
    {
        Console.WriteLine(date.ToString("dd.MM.yyyy"));
    }

    public void change_day(int day)
    {
        date = date.AddDays(day);
    }

    public void change_month(int month)
    {
        date = date.AddMonths(month);
    }

    public void change_year(int year)
    {
        date = date.AddMonths(year); 
    }
}

