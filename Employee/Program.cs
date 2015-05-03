using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] e = new Employee[3];
            e[0] = new Employee() { Dept = "physco", EmpID = 1, Name = "you", IsManager = true, HireDate = DateTime.Now };
            e[0].Courses[0] = new Course() { Id = 1, Name = "CSharp" };
            e[0].Courses[1] = new Course() { Id = 2, Name = "SQL" };

            e[1] = new Employee() { Dept = "physics", EmpID = 2, Name = "me", IsManager = false, HireDate = DateTime.Now };
            e[1].Courses[0] = new Course() { Id = 1, Name = "Java" };
            e[1].Courses[1] = new Course() { Id = 2, Name = "Hadoop" };

            e[2] = new Employee() { Dept = "photons", EmpID = 3, Name = "hum", IsManager = false, HireDate = DateTime.Now };
            e[2].Courses[0] = new Course() { Id = 1, Name = "Hi" };
            e[2].Courses[1] = new Course() { Id = 2, Name = "Bye" };

            string serializedData = JsonConvert.SerializeObject(e);

            Console.WriteLine(serializedData);

            Console.WriteLine("Enter Json string for Employee");

            var jsonData = Console.ReadLine();
            Employee s = JsonConvert.DeserializeObject<Employee>(jsonData);
            Console.WriteLine("{0}, {1}", s.Name, s.EmpID);
            Console.ReadLine();

            
        }
        [Serializable]
        public class Employee
        {
            public Employee()
            {
                Courses = new Course[2];

            }
            public int EmpID { get; set; }
            public string Name { get; set; }
            public string Dept { get; set; }
            public bool IsManager { get; set; }
            public DateTime HireDate { get; set; }
           public Course[] Courses { get; set; }
        }

        public class Course
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }










    }
}
