namespace ImperialCalendar
{
    using System;

    public static class CalendarUtility
    {
        public static int SecondsInYear(DateTime date)
        {
            return DateTime.IsLeapYear(date.Year) ? 31622400 : 31536000;
        }

        public static string ToPaddedValue(this double value)
        {
            if (value < 10)
            {
                return $"00{value}";
            }

            if (value < 100)
            {
                return $"0{value}";
            }

            if (value == 1000)
            {
                return $"000";
            }

            return value.ToString();
        }

        public static string ToPaddedValue(this int value)
        {
            return value < 10 ? $"00{value}" : $"0{value}";
        }

    }
}