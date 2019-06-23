using GymProyect.Web.Infraestructure.Utils;
using System;
using System.Globalization;

namespace GymProyect.Web.Helpers
{
    public static class StringExtensions
    {
        public static DateTime ToDate(this string date)
        {
            DateTime result;

            DateTime.TryParseExact(date, WebConstants.DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None,
                out result);

            return result;
        }

        public static DateTime FromAnsiDateToDate(this string date)
        {
            DateTime result;

            DateTime.TryParseExact(date, WebConstants.AnsiDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None,
                out result);

            return result;
        }

    }
}
