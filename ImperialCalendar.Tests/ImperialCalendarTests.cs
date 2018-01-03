namespace ImperialCalendar.Tests
{
    using System;
    using Xunit;
    public class ImperialCalendarTests
    {
        [Theory]
        [InlineData("12-31-2001", "0 998 001.M3")]
        [InlineData("01-01-2001", "0 001 001.M3")]
        [InlineData("12-31-2000", "0 998 000.M2")]
        [InlineData("01-01-2000", "0 001 000.M2")]
        public void CalculateImperialDate_ReturnsProperDate(string originalDate, string expected)
        {
           var calendarUtility = new CalendarFunctions();

            var result = calendarUtility.CalculateImperialDate(DateTime.Parse(originalDate));

            Assert.Equal(expected, result);

        }
        
        [Theory]
        [InlineData("1-1-2004", 31622400)]
        [InlineData("1-1-2017", 31536000)]
        public void SecondsInYear_ReturnsProperSecondsCountForNormalandLeapYears(string date, int expected)
        {
            var result = CalendarUtility.SecondsInYear(DateTime.Parse(date));

            Assert.Equal(expected, result);

        }
    }
}
