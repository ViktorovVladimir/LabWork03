using System;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;


//ВАРИАНТ #1


namespace ShootOnTargetNameSpace
{
    /*
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
    */

    /*
    public class WhatDay3
    {
        public static int[] DaysInLeapMonths = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public static int[] DaysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    }
    */

    class ShootOnTarget
    {
        public static double rX, rY, rCenterX, rCenterY, r1, r2;
        public static uint uBonus;

        //--.
        public static void setOptions()
        {
            rCenterX = 0; rCenterY = 0;
            r1 = 1; r2 = 2;
            uBonus = 0;
        }

        //--.
        public static void setShootPoint()
        {
            //--.
            Console.Write("Please enter real value X-coorditate shoot: ");
            rX = double.Parse(Console.ReadLine());
            //--.
            Console.Write("Please enter real value Y-coorditate shoot: ");
            rY = double.Parse(Console.ReadLine());
        }


        public static uint getScoring(double x, double y, double centerX, double centerY, uint bon, double radius)
        {
            decimal c1 = (decimal)((x - centerX) * (x - centerX) + (y - centerY) * (y - centerY));
            decimal c2 = (decimal)(r1 * r1);

            return c1 <= c2 ? (uint)bon : 0;
        }

        //--.
        public static uint getBonusFromShoot()
        {
            uint bonus2 = 0;
            uint bonus1 = getScoring(rX, rY, rCenterX, rCenterY, 10, r1);
            if (bonus1 == 0)
            {
                bonus2 = getScoring(rX, rY, rCenterX, rCenterY, 5, r2);
            }
            return bonus1 + bonus2;
        }


        public static void Main()
        {

            //--. Устанавливаем начальные настройки
            setOptions();
            
            //--.
            Console.Write("Please enter count shoot's on target (1 - 9): ");
            int iCountShoots = int.Parse( Console.ReadLine() );

            do
            {
                //--. Запрашиваем координаты выстрела
                setShootPoint();

                //--. Проверяем куда попали и возвращаем кол-во очков
                //--. Делаем подсчёт очков
                uBonus += getBonusFromShoot();
                
                //--. Декремент патронов
                iCountShoots--;
            } while( iCountShoots > 0 );

            //--. Вывод на экран сумма очков (баллов)
            //--.
            Console.WriteLine("Сумма набранных очков {0}", uBonus);

            /*

            //--.
            try
            {
                //--.
                Console.Write("Please enter the year: ");
                int yearNum = int.Parse(Console.ReadLine());
                bool isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0) || (yearNum % 400 == 0);
                int maxDayNum = isLeapYear ? 366 : 365;

                string sOtvet = isLeapYear ? "IS a leap year" : " is NOT a leap year";
                Console.WriteLine(sOtvet);

                //--.                
                Console.WriteLine("Please enter a day number between 1 and {0}: ", maxDayNum);
                //--.
                int daynum = int.Parse(Console.ReadLine());

                //--.
                if (daynum < 1 || daynum > maxDayNum)
                {
                    throw new ArgumentOutOfRangeException("Day out of range");
                }

                //--.
                int monthNum = 0;


                if (isLeapYear)
                {
                    //--.
                    foreach (int daysInMonth in WhatDay3.DaysInLeapMonths)
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
                }
                else
                {
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
            */
        }
    }
}