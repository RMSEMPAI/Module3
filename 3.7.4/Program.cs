using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked ((byte) int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age {1}",name,age);
            Console.Write("What's your favourite day of week?");
            DayOfWeek number = (DayOfWeek) int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day of week {0}",number);
            Console.ReadKey();
        }
    }
}
