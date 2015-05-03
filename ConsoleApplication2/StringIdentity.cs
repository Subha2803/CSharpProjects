using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // aabbcccccdddddd --> a2b2c5d6
            Console.WriteLine("enter a string");
            var str = Console.ReadLine();
            // string pattern = "@/B+";
            //var result1 = Regex.Match(str,pattern);
            //if(result1.Success)
            //{
            //     var result = Regex.Replace($_,"@[a-z]/d");
            //    Console.WriteLine("the stringlenth :{0}",result);
            //}

            char previousChar = str[0];
            char currentChar = 'a';
            int count = 1;
            string output = string.Empty;
            for (int i = 1; i < str.Length; i++)
            {
                currentChar = str[i];
                if (previousChar == currentChar)
                {
                    count++;
                }
                else
                {
                    output += Convert.ToString(previousChar) + Convert.ToString(count);
                    previousChar = currentChar;
                    //resetting the count to 1 when previous and current char are not equal
                    count = 1;
                }
            }
            output += Convert.ToString(previousChar) + Convert.ToString(count);
            Console.WriteLine(output);
        }
    }
}
