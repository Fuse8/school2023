using System;
using System.Reflection;

namespace Fuse8_ByteMinds.SummerSchool.Domain
{
    public class CalendarResource
    {
        public static readonly CalendarResource Instance = new();

        public static readonly string January;
        public static readonly string February;

        public static string[] MonthNames;

        static CalendarResource()
        {
            MonthNames = new[]
            {
                "Январь",
                "Февраль",
                "Март",
                "Апрель",
                "Май",
                "Июнь",
                "Июль",
                "Август",
                "Сентябрь",
                "Октябрь",
                "Ноябрь",
                "Декабрь",
            };

            January = GetMonthByNumber(0);
            February = GetMonthByNumber(1);
        }

        private static string GetMonthByNumber(int number)
            => MonthNames[number];

     
        public string this[Month month]
        {
            get
            {
                int monthNumber = (int)month;
                if (monthNumber >= 0 && monthNumber < MonthNames.Length)
                    return MonthNames[monthNumber];
                else
                    throw new ArgumentOutOfRangeException("Invalid Month value.");
            }
        }
    }

    public enum Month
    {
        January,
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
        December,
    }
}
