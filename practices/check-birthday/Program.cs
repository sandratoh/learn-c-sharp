using System;

namespace CheckBirthday
{
  class Program
  {
    static void Main(string[] args)
    {
      //   DateTime today = DateTime.Today;
      DateTime today = new DateTime(2021, 5, 16);
      DateTime birthday = new DateTime(2002, 4, 16);

      // If input = 4, 14 -- should equal 333 days
      // If input = 6, 14 -- should equal 28 days
      // If input = 4, 17 -- should equal 336 days
      // If input = 6, 17 -- should equal 31 days

      Console.WriteLine(today);
      Console.WriteLine(birthday);

      int currentMonth = today.Month;
      int currentDate = today.Day;

      int birthMonth = birthday.Month;
      int birthDate = birthday.Day;

      bool correctMonth = currentMonth == birthMonth;

      bool correctDate = currentDate == birthDate;

      if (correctMonth && correctDate)
      {
        Console.WriteLine("***Happy Birthday!***");
      }
      else
      {
        int daysUntil = currentDate - birthDate;

        Console.WriteLine("daysUntil {0}", daysUntil);

        int monthsUntil = currentMonth - birthMonth;


        Console.WriteLine("monthsUntil {0}", monthsUntil);

        int totalDaysDiff = (monthsUntil * 30) + daysUntil;

        Console.WriteLine($"totalDaysDiff {totalDaysDiff}");

        // if negative diff, means upcoming birthday within the year
        // if positive diff, means it already passed

        int totalDaysUntil = totalDaysDiff > 0 ? 365 - totalDaysDiff : Math.Abs(totalDaysDiff);

        Console.WriteLine($"There are {totalDaysUntil} days until your birthday!");
      }
    }
  }
}
