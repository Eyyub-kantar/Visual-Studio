using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ornek_MWR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; 
            IWork[] works = new IWork[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var work in works)
            {
                work.Work();
            }
            Console.WriteLine("___________________");
            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
            Console.WriteLine("___________________");
            ISalary[] salaries = new ISalary[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var salary in salaries)
            {
                salary.Salary();
            }
            Console.WriteLine("___________________");
            IManagement[] managements = new IManagement[1]
            {
                new Manager()
            };
            foreach (var management in managements)
            {
                management.Management();
            }
            Console.ReadLine();
        }
    }
}
