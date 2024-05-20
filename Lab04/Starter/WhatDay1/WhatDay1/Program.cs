using System;


namespace WhtDay1NameSpace
{
    public struct Distance
    {
        public uint foot;               //отрицательным быть не может
        public uint inch;               //отрицательным быть не может
    }


    class WhatDay
    {
        uint DaysInMonts;
        
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
            //Distance d1, d2, d3;
            Console.WriteLine("Please enter a day number between 1 and 365: ");
            int daynum = int.Parse( Console.ReadLine() );
            
            //--.
            int monthNum = 0;
            
            //--.
            if( daynum <= 31)       //January
            {        
                goto End;
            } 
            else 
            {
                daynum -= 31;
                monthNum++;
            }
            //--.
            if( daynum <= 28)       //February
            {        
                goto End;
            }
            else
            {
                daynum -= 28;
                monthNum++;
            }
            //--.
            if (daynum <= 31)       //March
            {
                goto End;
            }
            else
            {
                daynum -= 31;
                monthNum++;
            }
            //--.
            if (daynum <= 30)       //April
            {
                goto End;
            }
            else
            {
                daynum -= 30;
                monthNum++;
            }
            //--.
            if (daynum <= 31)       //May
            {
                goto End;
            }
            else
            {
                daynum -= 31;
                monthNum++;
            }
            //--.
            if (daynum <= 30)       //June
            {
                goto End;
            }
            else
            {
                daynum -= 30;
                monthNum++;
            }
            //--.
            if (daynum <= 31)       //July
            {
                goto End;
            }
            else
            {
                daynum -= 31;
                monthNum++;
            }
            //--.
            if (daynum <= 31)       //August
            {
                goto End;
            }
            else
            {
                daynum -= 31;
                monthNum++;
            }
            //--.
            if (daynum <= 30)       //September
            {
                goto End;
            }
            else
            {
                daynum -= 30;
                monthNum++;
            }
            //--.
            if (daynum <= 31)       //October
            {
                goto End;
            }
            else
            {
                daynum -= 31;
                monthNum++;
            }
            //--.
            if (daynum <= 30)       //November
            {
                goto End;
            }
            else
            {
                daynum -= 30;
                monthNum++;
            }
            //--.
            if (daynum <= 31)       //December
            {
                goto End;
            }
            else
            {
                daynum -= 31;
                monthNum++;
            }


        End:

            string monthName;

            switch( monthNum )
            {
                case 0:
                    monthName = "January";
                    break;
                case 1:
                    monthName = "February";
                    break;
                case 2:
                    monthName = "March";
                    break;
                case 3:
                    monthName = "April";
                    break;
                case 4:
                    monthName = "May";
                    break;
                case 5:
                    monthName = "June";
                    break;
                case 6:
                    monthName = "July";
                    break;
                case 7:
                    monthName = "August";
                    break;
                case 8:
                    monthName = "September";
                    break;
                case 9:
                    monthName = "October";
                    break;
                case 10:
                    monthName = "November";
                    break;
                case 11:
                    monthName = "December";
                    break;
                default:
                    monthName = "not done yet";
                    break;

            }

            //--.
            Console.WriteLine("{0} {1}", daynum, monthName);


            /*
            Console.WriteLine("Enter <inch> value for FIRST number: ");
            d1.inch = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter <foot> value for SECOND number: ");
            d2.foot = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter <inch> value for SECOND number: ");
            d2.inch = uint.Parse(Console.ReadLine());


            //--.
            d3 = MOperations.SumDist(d1, d2);

            //--.            
            Console.WriteLine($"Итого получилось: {d3.foot}'- {d3.inch}\" ");
            */
        }
    }
}