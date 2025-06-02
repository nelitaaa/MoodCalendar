using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodCalendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            PrintCalendar(year, month);
            Console.WriteLine("Изберете настроение:\n1-щастлив\n2-неутрален \n3-тъжен \n4-ядосан \n5-продуктивен");
            
        }



        static void PrintCalendar( int year, int month)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            DateTime firstDay = new DateTime(year, month, 1);
            Console.WriteLine("Пoн Вт Ср Четв Пет Сб Нд");

            int indent = ((int)firstDay.DayOfWeek + 6) % 7; // За да започне от Понеделник
            for (int i = 0; i < indent; i++)
                Console.Write("   " );
            

            int daysInMonth = DateTime.DaysInMonth(year, month);
            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write($"{day,2} ");
                if ((day + indent) % 7 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
           
        }
    }
}
