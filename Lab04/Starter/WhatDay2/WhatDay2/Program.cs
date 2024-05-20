using System;


namespace WhtDay1NameSpace
{
    public struct Distance
    {
        public uint foot;               //отрицательным быть не может
        public uint inch;               //отрицательным быть не может
    }


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





    public class WhatDay2
    {
        public static int[] DaysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        /*
        public static Distance SumDist(Distance d1, Distance d2)
        {
            Distance k;

            k.foot = d1.foot + d2.foot;
            k.inch = d1.inch + d2.inch;

            k.foot += (k.inch / 12);
            k.inch = k.inch % 12;

            return k;
        }
        */
    }


    class Program
    {



        public static void Main()
        {
            //--.
            try
            {
                Console.WriteLine("Please enter a day number between 1 and 365: ");
                //-.
                int daynum = int.Parse(Console.ReadLine());
                //--.
                if (daynum < 1 || daynum > 365)
                {
                    throw new ArgumentOutOfRangeException("Day out of range");
                }

                //--.
                int monthNum = 0;

                //--.
                foreach (int daysInMonth in WhatDay2.DaysInMonths)
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