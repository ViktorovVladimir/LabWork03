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