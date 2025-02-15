using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDusaGirmek[] dusaGirmeks = new IDusaGirmek[3]
            {
                new Anne(),
                new Baba(),
                new Cocuk()
            };
            foreach (var DusaGirmek in dusaGirmeks)
            {
                DusaGirmek.DusaGirmek();
            }
            Console.WriteLine("____________________");
            IYemekYemek[] yemekYemeks = new IYemekYemek[3]
            {
                new Anne(),
                new Baba(),
                new Cocuk()
            };
            foreach (var YemekYemek in yemekYemeks)
            {
                YemekYemek.YemekYemek();
            }
            Console.WriteLine("____________________");
            IOkulaGitmek[] okulaGitmeks = new IOkulaGitmek[1]
            {
                new Cocuk()
            };
            foreach (var OkulaGitmek in okulaGitmeks)
            {
                OkulaGitmek.OkulaGitmek();
            }
            Console.WriteLine("____________________");
            IYemekYapmak[] yemekYapmaks = new IYemekYapmak[2]
            {
                new Anne(),
                new Baba()
            };
            foreach (var YemekYapmak in yemekYapmaks)
            {
                YemekYapmak.YemekYapmak();
            }
            Console.WriteLine("____________________");
            IİseGitmek[] iseGitmeks = new IİseGitmek[1]
            {
                new Baba()
            };
            foreach (var İseGitmek in iseGitmeks)
            {
                İseGitmek.İseGitmek();
            }
            Console.WriteLine("____________________");
            IOyunOynamak[] oyunOynamaks = new IOyunOynamak[1]
            {
                new Cocuk()
            };
            foreach (var OyunOynamak in oyunOynamaks)
            {
                OyunOynamak.OyunOynamak();
            }
            Console.WriteLine("____________________");
            IArabaKullanmak[] arabaKullanmaks = new IArabaKullanmak[2]
            {
                new Anne(),
                new Baba(),
            };
            foreach (var ArabaKullanmak in arabaKullanmaks)
            {
                ArabaKullanmak.ArabaKullanmak();
            }
            Console.ReadLine();


        }
    }
}
