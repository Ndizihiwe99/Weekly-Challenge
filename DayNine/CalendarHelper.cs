//                             Calendar Days Calculator



// Today's challenge focuses on **conditional logic, 
// switch expressions, integer arithmetic, and unit testing**.

//                                   Scenario

// implementing a small calendar utility. 
// Given a month and a year, it should return the number of days in that month.


//                                 Requirements

// 1. The month must be between `1` and `12`, inclusive. Otherwise, throw `ArgumentOutOfRangeException`.
// 2. The year must be greater than or equal to `1`. Otherwise, throw `ArgumentOutOfRangeException`.
// 3. February has 28 days in a normal year and 29 days in a leap year.
// 4. April, June, September, and November have 30 days. All other months have 31 days.
// 5. Use the Gregorian leap-year rules:
//     - A year divisible by 400 is a leap year.
//     - A year divisible by 100 but not 400 is not a leap year.
//     - Otherwise, a year divisible by 4 is a leap year.

// Restriction: Do not use `DateTime.DaysInMonth()` or `DateTime.IsLeapYear()`. Implement the logic yourself.

using System.Collections;
using System.Security.Cryptography;

public static class CalendarHelper
{
    public static int GetDaysInMonth(int month, int year)
    {
        if(month <= 0 || month >=12 || year <= 1)
        throw new ArgumentOutOfRangeException("invalid month and year");

        int days = 0;

        switch (month)
        {
            case 4:
            days = 30;
            break;

            case 6:
            days = 30;
            break;

            case 9:
            days = 30;
            break;

            case 10:
            days = 30;
            break;
            
            case 2:
            if(year %400 == 0 || year  %4 == 0)
                {
                    days = 29;
            
                }else if(year %100 == 0 && year %400 != 0)
                {
                    days = 28;
                }
            break;

           default:
            days = 31;
            break;


        }

        return days;

        throw new NotImplementedException();
    }
}