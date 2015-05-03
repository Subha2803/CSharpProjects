using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepCal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter your name");
            var strName = Console.ReadLine();
            Console.WriteLine("how much sleep did you have last night");
            int hoursOfSleep = int.Parse(Console.ReadLine());
            if(hoursOfSleep<8)
            {
                Console.WriteLine("Hello,{0},{1}", strName, "you will be tired");
            }
            else if(hoursOfSleep ==8)
            {
                Console.WriteLine("Hello,{0},{1}", strName, "you had enough sleep");
            }
            else
            {
                Console.WriteLine("Hello,{0},{1}", strName, "you seem well rested");
            }
        }
    }
}
