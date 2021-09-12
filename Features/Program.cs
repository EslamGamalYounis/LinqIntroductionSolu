using System;
using System.Collections.Generic;
using Features;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee {Id=1, Name="Scoot"},
                new Employee {Id=2,Name="Alex"}
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { Id= 3, Name ="Alex"}
            };

            //foreach (var person in sales)
            //{
            //    Console.WriteLine(person.Name);
            //}

            Console.WriteLine(developers.Count());

            IEnumerator<Employee> enumerator = developers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Name);
            }   

        }
    }
}
