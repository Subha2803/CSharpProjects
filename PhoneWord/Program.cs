using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneWord
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter phoneword");

            var phoneWord = Console.ReadLine().ToUpper();
            var phonePad = new string[] { "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };
            var phoneNumber = "";
            var ignoreChars = "0123456789-";
            foreach(var c in phoneWord)
            {
                if(ignoreChars.IndexOf(c)>=0)
                {
                    phoneNumber = phoneNumber + c;
                }
                else
                {
                    var translatedCharacter = 0;
                  
                   for(int i=0;i<phonePad.Length;i++)
                    {
                        if(phonePad[i].IndexOf(c)>=0)
                        {
                            translatedCharacter = i + 2;
                            phoneNumber = phoneNumber + translatedCharacter;
                        }
                    }
                   
                }
            } 
            Console.WriteLine(phoneNumber);
        }
    }
}
