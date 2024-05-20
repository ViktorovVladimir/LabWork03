using System;


namespace WhtDay3NameSpace
{
    enum MonthName
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
        December
    }

    public class WhatDay3
    {
        public static int[] DaysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    }

    class Program
    {

        public static void Main()
        {
            //--.
            try
            {
                //--.
                Console.Write("Please enter the year: ");
                int yearNum = int.Parse(Console.ReadLine());
                //--.                
                Console.WriteLine("Please enter a day number between 1 and 365: ");
                //-.
                int daynum = int.Parse(Console.ReadLine());
                //--.
                if( daynum < 1 || daynum > 365 )
                {
                    throw new ArgumentOutOfRangeException("Day out of range");
                }

                //--.
                int monthNum = 0;

                //--.
                foreach (int daysInMonth in WhatDay3.DaysInMonths)
                {
                    if (daynum <= daysInMonth)
                    {
                        break;
                    }
                    else
                    {
                        daynum -= daysInMonth;
                        monthNum++;
                    }
                }



                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();

                //--.
                Console.WriteLine("{0} {1}", daynum, monthName);


            }
            catch (Exception caugh)
            {
                Console.WriteLine("Day out of range: {0}", caugh);
            }

        }
    }
}