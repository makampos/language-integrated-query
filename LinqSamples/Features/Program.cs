
using System;
using System.Collections.Generic;
using System.Linq;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x,y) => x + y;

            Console.WriteLine(square(3));
            Console.WriteLine(square(add(3,5)));

            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee { Id = 1, Name = "Scott" },
                new Employee { Id = 2, Name = "Chris" }
            };

            IEnumerable<Employee> sales = new List<Employee>() 
            {
                new Employee { Id = 3, Name = "Alex" }
            };
            
            
            // System.Console.WriteLine(developers.Count());
            // IEnumerator<Employee> enumerator = developers.GetEnumerator();
            // while(enumerator.MoveNext()) 
            // {
            //     Console.WriteLine(enumerator.Current.Name);
            // }


            var query = developers.Where(e => e.Name.Length == 5)
                                .OrderByDescending(e => e.Name)
                                .Select(e => e);

            foreach (var employee in query) {
                System.Console.WriteLine(employee.Name);
            }


            var  query2 = from developer in developers
                         where developer.Name.Length == 5
                         orderby developer.Name descending
                         select developer;

            foreach (var employee in query2) 
            {
                System.Console.WriteLine(employee.Name);
                
            }              


            // foreach (var employee in developers.Where(e => e.Name.StartsWith("B"))) 
            // {
            //     System.Console.WriteLine(employee.Name);
                
            // }
        }

        private static bool NameStartsWithS(Employee employee)
        {
            return employee.Name.StartsWith("S");
        }
    }
}
