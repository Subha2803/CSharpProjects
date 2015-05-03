using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace RegularExpression
{
    public class FileName
    {
       public static void Main(string[] args)
        {
            var filePath = Environment.CurrentDirectory + @"\s";
            var dirInfo = new DirectoryInfo(filePath);
            string oldFileName= "";
            string newFileName = "";
            FileInfo[] fileInfo = dirInfo.GetFiles();
           foreach(FileInfo f in fileInfo)
           {
               oldFileName = f.Name;
               if(oldFileName.Contains(".jpg"))
               {
                   newFileName = Regex.Replace(oldFileName, @"\d", string.Empty);
                   Console.WriteLine("oldFileName:{0} \t newFileName:{1}", oldFileName, oldFileName);
                   File.Move(filePath + @"\" + oldFileName, filePath + @"\" + newFileName);
               }
           }
        }
    }
}
