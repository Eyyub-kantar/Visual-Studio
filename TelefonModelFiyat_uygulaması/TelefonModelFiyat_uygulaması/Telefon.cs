using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonModelFiyat_uygulaması
{
    internal class Telefon
    {
        public string marka;
        public string model;
        public int fiyat;
        public void bilgiYazdir()
        {
            Console.WriteLine($"Telefon Bilgileri ; \n Marka =" + marka + "\n Model =" + model + "\n Fiyat =" + fiyat);
        }
        public void aramaYap(string telNo)
        {
            Console.WriteLine(marka + " " + model + " ile " + telNo + " ile arıyorsunuz.");
        }
    }
}
