using System;

namespace Applied_tasks_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            Console.WriteLine(Asnwer(time));
        }



        public static string Asnwer(int time)
        {
            if (time == 0)
            {
                return "Уже началось !";
            }
            else
            {
                return days((time / 1440)) + " "+hour((time%1440) / 60)+" " + Minut(time % 60);
            }
            
        }

        public static string Minut(int minut)
        {
            if (minut == 0)
            {
                return "";
            }
            else if(minut!= 11&& (minut == 1 || minut % 10 == 1))
            {
                return minut + " минута";
            }
            else if((minut >=5 && minut<=20)||minut % 10 >= 5)
            {
                return minut + " минут";
            }
            else
            {
                return minut + " минуты";
            }
        }

        public static string days(int day)
        {
            if (day == 0)
            {
                return "";
            }
            else if (day != 11 && (day == 1 || day % 10 == 1))
            {
                return day + " день";
            }
            else if ((day >= 5 && day <= 20) || day % 10 >= 5)
            {
                return day + " деней";
            }
            else
            {
                return day + " дня";
            }
        }
        public static string hour(int hour)
        {
            if (hour == 0)
            {
                return "";
            }
            else if (hour != 11 && (hour == 1 || hour % 10 == 1))
            {
                return hour + " час";
            }
            else if ((hour >= 5 && hour <= 20) || hour % 10 >= 5)
            {
                return hour + " часов";
            }
            else
            {
                return hour + " часа";
            }
        }
    }



    }
