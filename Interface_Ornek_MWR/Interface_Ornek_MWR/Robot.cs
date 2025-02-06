using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ornek_MWR
{
    internal class Robot : IWork
    {
        public void Work()
        {
            Console.WriteLine("Robot Çalışır");
        }
    }
}
