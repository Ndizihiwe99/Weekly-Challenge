// ### **Unit testing**

// **Framework: xUnit**

// Write tests covering these five scenarios:

// | Test case          | Input `(month, year)` | Expected result |
// | ---                | ---                   | ---             |
// | January            | `(1, 2025)`           | `31`            |
// | April              | `(4, 2025)`           | `30`            |
// | Normal February    | `(2, 2025)`           | `28`            |
// | Leap-year February | `(2, 2024)`           | `29`            |
// | Century exception  | `(2, 1900)`           | `28`            |

// Also verify:

// - February 2000 returns 29.
// - Month `0` or `13` throws `ArgumentOutOfRangeException`.
// - Year `0` throws `ArgumentOutOfRangeException`.

using Xunit;
public class CalendarHelperTests
{
    [Theory]
    [InlineData(1, 2025)]
    public void Test_Month_Year_inputs(int month, int year)
    {
        var calendarHelper = CalendarHelper.GetDaysInMonth(month, year);

        Assert.Equal(31, calendarHelper);
        
        
    }

    [Theory]
    [InlineData(1, 0)]
    public void Test_Month_Year_Invalidinputs(int month, int year)

    {
        Assert.Throws<ArgumentOutOfRangeException>(() => CalendarHelper.GetDaysInMonth(month, year));
        

        
        
        
    }
}