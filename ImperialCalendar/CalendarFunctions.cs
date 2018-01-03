using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialCalendar
{
    public class CalendarFunctions
    {
        public DateTime GregorianDate { get; set; }
        public DateTime ImperialDate { get; set; }


        public string CalculateImperialDate(DateTime dateToConvert)
        {
            var checkNumber = 0;

            var theStandardDate = dateToConvert;

            var currentDate = DateTime.Now;
            var currentHour = currentDate.Hour;
            var currentMinute = currentDate.Minute;
            var currentSecond = currentDate.Second;

            var theStart = LastDayOfYear(theStandardDate);
            var theDiff = theStandardDate - theStart;
            var theDay = Math.Floor(theDiff.TotalMilliseconds / (1000.00 * 60.00 * 60.00 * 24.00));

            var days = (theDay * 86400) - 86400;
            var hours = currentHour * 3600;
            var minutes = currentMinute * 60;

            var secondsInYear = CalendarUtility.SecondsInYear(theStandardDate);

            var theYearFraction = Math.Floor(((days + hours + minutes + currentSecond) / secondsInYear) * 1000);

            var theYear = theStandardDate.Year % 1000;

            var milleniumCalc = theStandardDate.Year / 1000.00;

            var theMillennium = Math.Ceiling(milleniumCalc);

            var theImperialDate = checkNumber + " " + theYearFraction.ToPaddedValue() + " " + theYear.ToPaddedValue() + ".M" + theMillennium;

            return theImperialDate;
        }

        private static DateTime LastDayOfYear(DateTime date)
        {
            var temporaryDate = new DateTime(date.Year, 1, 1);

            return temporaryDate.AddDays(-1);
        }

        
    }
}

/*
 1) get a date
 2) 
     */
