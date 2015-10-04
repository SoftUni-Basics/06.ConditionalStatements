/*  A beer time is after 1:00 PM and before 3:00 AM. 
    Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. 
 * Note that you may need to learn how to parse dates and times.*/

using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        CultureInfo enUS = new CultureInfo("en-US");
        Console.Write("Please enter format with a space(h mm AM/PM):\t");
        string format = "h mm tt";
        string userInput = Console.ReadLine();

        string start = "13:00";
        string end = "03:00";
        DateTime beerTimeStart = DateTime.Parse(start);
        DateTime beerTimeEnd = DateTime.Parse(end);

        DateTime dateValue;
        bool dateTime = DateTime.TryParseExact(userInput, format, enUS, DateTimeStyles.None, out dateValue);

        if (dateTime)
        {
            if (dateValue >= beerTimeStart || dateValue < beerTimeEnd)
            {
                Console.WriteLine("Beer Time!");
            }
            else if (dateValue < beerTimeStart || dateValue >= beerTimeEnd)
            {
                Console.WriteLine("Non-Beer time.");
            }
        }
        else
        {
            Console.WriteLine("Invalid Time!");
        }
        Console.WriteLine();
    }
}
/*
    time        result
    
    1:00 PM     beer time
    4:30 PM     beer time
    10:57 PM    beer time
    8:30 AM     non-beer time
    02:59 AM    beer time
    03:00 AM    non-beer time
    03:26 AM    non-beer time
*/