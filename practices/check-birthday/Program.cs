using System;

namespace CheckBirthday
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("========= BIRTHDAY CHECK! ========");

      DateTime today = DateTime.Today;

      int currentMonth = today.Month;
      int currentDate = today.Day;

      Console.Write("Please enter the two digit value of your birth month: ");
      int birthMonth = Convert.ToInt32(Console.ReadLine());

      Console.Write("Please enter the two digit value of your birth day: ");
      int birthDate = Convert.ToInt32(Console.ReadLine());

      bool correctMonth = currentMonth == birthMonth;
      bool correctDate = currentDate == birthDate;

      if (correctMonth && correctDate)
      {
        Console.WriteLine("*** It's your birthday today!! Happy Birthday! 🥳 ***");
      }
      else
      {
        int daysUntil = currentDate - birthDate;

        int monthsUntil = currentMonth - birthMonth;

        int totalDaysDiff = (monthsUntil * 30) + daysUntil;
        // if negative diff, means upcoming birthday within the year
        // if positive diff, means it already passed
        int totalDaysUntil = totalDaysDiff > 0 ? 365 - totalDaysDiff : Math.Abs(totalDaysDiff);

        Console.WriteLine($"*** There are {totalDaysUntil} days until your birthday! 🎂 ***");
      }
    }
  }
}
