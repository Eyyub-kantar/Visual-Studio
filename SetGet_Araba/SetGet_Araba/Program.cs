using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGet_Araba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Araba araba1 = new Araba();
            araba1.SetRenk("Mavi");
            // Arabanın rengini ayarladık.
            Console.WriteLine("Arabanın rengi = " + araba1.GetRenk());
            Console.ReadLine();
        }
    }
}
