using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ornek_MWR
{
    internal class Worker : IEat, IWork, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker Yemek Yer");
        }

        public void Salary()
        {
            Console.WriteLine("Worker Maaş Alır");
        }

        public void Work()
        {
            Console.WriteLine("Worker Çalışır");
        }
    }
}
