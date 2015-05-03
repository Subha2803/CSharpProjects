using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            /// bac and cba --> 1) same length 2) after sorting both should represent same string
            //Ram   mar    amr == amr ==>true 
       
            Console.WriteLine("enter the string");
            var str = Console.ReadLine();
            Console.WriteLine("enter the string");
            var str1 = Console.ReadLine();
            if (str.Length != str1.Length)
            {
                Console.WriteLine("{0} string  doest not have same char of string {1}", str, str1);
                return;
            }
            var charArray = str.ToCharArray();// abc -->['a', 'b' ,'c' ]
            var charArray1 = str1.ToCharArray();
            //
            //  Array.Sort(charArray);
            // Array.Sort(charArray1);
            string sortedStr1 = string.Concat(charArray.OrderBy(I => I));
            string sortedStr2 = string.Concat(charArray1.OrderBy(I => I));
            Console.WriteLine(sortedStr1 + " " + sortedStr2);
            if (sortedStr1 == sortedStr2)
            {
                Console.WriteLine("both strings have same characters");
            }
            else
            {
                Console.WriteLine("{0} string  doest not have same char of string {1}", str, str1);
            }
            Console.Read();
            //// string pattern = @"/[a-z]";
            //var result = Regex.Match(str, str1);
            //if (result.Success)
            //{
            //    Console.WriteLine("the string is matched :{0}", true);
            //}
            //else
            //{
            //    Console.WriteLine("the string is not matched:{0}", false);
            //}
        }
   