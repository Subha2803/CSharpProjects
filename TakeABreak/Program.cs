using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace TakeABreak
{
    public class TakeABreak
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the total number of breaks");
           //// var strName=Console.ReadLine();
            int breakCountsTaken = 0;
            var totalbreaks = int.Parse(Console.ReadLine());
            var songurl="https://www.youtube.com/watch?v=uVcRWDoj30I";
            //var breakTime = 
            while(breakCountsTaken<totalbreaks)
            {
                Thread.Sleep(15000);
                Console.WriteLine("Dude,Take a Break,Watch the song and enjoy");
                Process.Start(songurl);
                breakCountsTaken++;
            }
        }
    }
}
