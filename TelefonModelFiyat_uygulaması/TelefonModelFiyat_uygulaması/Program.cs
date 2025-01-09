using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonModelFiyat_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Telefon telefon1 = new Telefon();
            telefon1.marka = "İPhone";
            telefon1.model = "15 pro";
            telefon1.fiyat = 45000;
            telefon1.bilgiYazdir();
            telefon1.aramaYap("0555 555 55 55");
            Console.ReadLine();
        }
    }
}
