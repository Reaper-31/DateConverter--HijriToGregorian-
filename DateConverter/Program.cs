using System;
using System.Globalization;

namespace HijriToGregorianConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hijriDates = {
             "1444-03-13",
"1445-06-26",
"1444-12-20",
"1445-03-14",
"1445-06-05",
"1445-03-13",
"1445-03-16",
"1445-07-11",
"1445-02-04",
"1444-07-07",
"1444-11-02",
"1445-06-26",
"1433-08-28",
"1442-11-29",
"1443-04-07",
"1445-12-09",
"1445-09-05",
"1441-05-16"





















            };

            foreach (string hijriDate in hijriDates)
            {
                string[] dateParts = hijriDate.Split('-');
                int year = int.Parse(dateParts[0]);
                int month = int.Parse(dateParts[1]);
                int day = int.Parse(dateParts[2]);

                UmAlQuraCalendar hijriCalendar = new UmAlQuraCalendar();
                DateTime gregorianDate = hijriCalendar.ToDateTime(year, month, day, 0, 0, 0, 0);

                Console.WriteLine($"{gregorianDate:dd/M/yyyy}");
            }
        }
    }
}
