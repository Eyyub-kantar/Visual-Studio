using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Person person1 = new Person();
            // set metoduyla name özelliğine değer atanıyor;
            person1.Name = "eyyub";
            // get metoduyla name özelliğinin değeri okunuyor ve ekrana yazdırılıyor;
            Console.WriteLine("Kişinin Adı = " + person1.Name);
            Console.ReadLine();
        }
    }
}
