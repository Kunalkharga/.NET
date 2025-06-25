using System;

class Program
{
   
    enum Month
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    static void Main()
    {
        Console.WriteLine("Enter month number (1-12):");
        int input = int.Parse(Console.ReadLine());

        if (input < 1 || input > 12)
        {
            Console.WriteLine("Invalid month number.");
            return;
        }

        Month selectedMonth = (Month)input;

        int days = GetDaysInMonth(selectedMonth);

        Console.WriteLine($"{selectedMonth} has {days} days.");
    }

    static int GetDaysInMonth(Month month)
    {
        switch (month)
        {
            case Month.January:
            case Month.March:
            case Month.May:
            case Month.July:
            case Month.August:
            case Month.October:
            case Month.December:
                return 31;

            case Month.April:
            case Month.June:
            case Month.September:
            case Month.November:
                return 30;

            case Month.February:
                return 28; 

            default:
                return 0;
        }
    }
}