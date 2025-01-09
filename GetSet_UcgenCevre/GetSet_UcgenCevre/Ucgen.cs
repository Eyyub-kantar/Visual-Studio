using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet_UcgenCevre
{
    internal class Ucgen
    {
        int a, b, c;
        public int A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Hatalı Giriş");
                }
                else
                {
                    a = value;
                }
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Hatalı Giriş");
                }
                else
                {
                    b = value;
                }
            }
        }
        public int C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Hatalı Giriş");
                }
                else
                {
                    c = value;
                }
            }
        }
        public int CevreHesapla()
        {
            return a + b + c;
        }
    }
}
