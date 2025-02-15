using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek2
{
    internal class Baba : IArabaKullanmak,IDusaGirmek,IYemekYapmak,IYemekYemek,IİseGitmek
    {
        public void ArabaKullanmak()
        {
            Console.WriteLine("Baba Araba Kullanır");
        }

        public void DusaGirmek()
        {
            Console.WriteLine("Baba Dusa Girer");

        }

        public void YemekYapmak()
        {
            Console.WriteLine("Baba Yemek Yapar");

        }

        public void YemekYemek()
        {
            Console.WriteLine("Baba Yemek Yer");

        }

        public void İseGitmek()
        {
            Console.WriteLine("Baba İse Gider");

        }
    }
}
