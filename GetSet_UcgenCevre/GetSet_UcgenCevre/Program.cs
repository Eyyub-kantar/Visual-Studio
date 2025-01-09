using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet_UcgenCevre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Ucgen ucgen = new Ucgen();
            ucgen.A = 6;
            ucgen.B = 8;
            ucgen.C = 10;
            int cevre = ucgen.CevreHesapla();
            Console.WriteLine("Ucgenin cevresi = " + cevre);
            Console.ReadLine();
        }
    }
}
