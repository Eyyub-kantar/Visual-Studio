using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ornek_MWR
{
    internal class Manager : IWork,ISalary,IEat,IManagement
    {
        public void Eat()
        {
            Console.WriteLine("Manager Yemek Yer");
        }

        public void Management()
        {
            Console.WriteLine("Manager Yöneticidir");
        }

        public void Salary()
        {
            Console.WriteLine("Manager Maaş Alır");
        }

        public void Work()
        {
            Console.WriteLine("Manager Çalışır");
        }
    }
}
