using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musteri_Ekleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Musteri_Yonetimi y = new Musteri_Yonetimi();
            Musteri_Bilgileri musteri1 = new Musteri_Bilgileri();
            musteri1.Id = 1;
            musteri1.Ad_Soyad = "Eyyub Kantar";
            musteri1.Sifre = 1234;
            Console.WriteLine("Kullanıcının Id' si = {0}", musteri1.Id);
            Console.WriteLine("Kullanıcının Adı ve Soyadı = {0}", musteri1.Ad_Soyad);
            Console.WriteLine("Kullanıcının Sifresi = {0}", musteri1.Sifre);
            y.Ekle();
            y.Guncelle();
            Console.ReadLine();
            

        }
    }
}
