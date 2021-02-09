using System;


public struct Age
{
    public Age(int newDay, int newMonth, int newYear)
    {
        this.Day = newDay;
        this.Month = newMonth;
        this.Year = newYear;
    }

    public int Day;
    public int Month;
    public int Year;

    public void ResetAge()
    {
        this.Day = 0;
        this.Month = 0;
        this.Year = 0;
    }
    
    public void ChangeAge(int newDay, int newMonth, int newYear)
    {
        this.Day += newDay;
        this.Month += newMonth;
        this.Year += newYear;
        Console.WriteLine($"--Day changed by {newDay}");
        Console.WriteLine($"--Month changed by {newMonth}");
        Console.WriteLine($"--Year changed by {newYear}");

    }

    public void SetDay(int newDay)
    {
        this.Day = newDay;
        Console.WriteLine($"--Day changed to {newDay}");
    }

    public void SetMonth(int newMonth)
    {
        this.Month = newMonth;
        Console.WriteLine($"--Month changed to {newMonth}");
    }

    public void SetYear(int newYear)
    {
        this.Year = newYear;
        Console.WriteLine($"--Year changed to {newYear}");
    }

    public void Info()
    {
        Console.WriteLine($"Day: {this.Day}");
        Console.WriteLine($"Month: {this.Month}");
        Console.WriteLine($"Year: {this.Year}");
        //Console.WriteLine($"{this.Day}/{this.Month}/{this.Year}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Age magoo = new Age(14,10,2000);
        Age billy = new Age(21,5,1980);

        magoo.Info();
        magoo.SetDay(4);
        magoo.SetMonth(12);
        magoo.SetYear(1999);
        magoo.Info();

        billy.Info();
        //billy.ResetAge();
        billy.Info();
        billy.ChangeAge(5,-3,7);
        billy.Info();
    }
}