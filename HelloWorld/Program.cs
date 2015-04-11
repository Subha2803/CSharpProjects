using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Helloworld");
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine(Environment.MachineName);
            Console.WriteLine(Environment.UserName);
        }
    }
}
