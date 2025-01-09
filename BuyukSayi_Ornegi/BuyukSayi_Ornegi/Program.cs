using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukSayi_Ornegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            BuyukSayi Buyuk = new BuyukSayi();
            int a = 10;
            int b = 15;
            int sonuc = Buyuk.BuyukSayiyiBul(a,b);
            Console.WriteLine("Buyuk sayi = " + sonuc);
            Console.ReadLine();


        }
    }
}
