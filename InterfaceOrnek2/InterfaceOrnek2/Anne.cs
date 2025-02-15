using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek2
{
    internal class Anne : IArabaKullanmak, IDusaGirmek, IYemekYapmak, IYemekYemek
    {
        public void ArabaKullanmak()
        {
            Console.WriteLine("Anne Araba Kullanır");
        }

        public void DusaGirmek()
        {
            Console.WriteLine("Anne Dusa Girer");

        }

        public void YemekYapmak()
        {
            Console.WriteLine("Anne Yemek Yapar");

        }

        public void YemekYemek()
        {
            Console.WriteLine("Anne Yemek Yer");

        }
    }
}
