using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek2
{
    internal class Cocuk : IDusaGirmek, IYemekYemek,IOkulaGitmek,IOyunOynamak
    {
        public void DusaGirmek()
        {
            Console.WriteLine("Cocuk Dusa Girer");
        }

        public void YemekYemek()
        {
            Console.WriteLine("Cocuk Yemek Yer");
        }

        public void OkulaGitmek()
        {
            Console.WriteLine("Cocuk Okula Gider");
        }

        public void OyunOynamak()
        {
            Console.WriteLine("Cocuk Oyun Oynar");
        }
    }
}
