using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGet_Araba
{
    internal class Araba
    {
        private string Renk;
        public string GetRenk()
        {
            // Renk özelliğine erişmek için.
            return Renk;
        }
        public void SetRenk(string YeniRenk)
        {
            // Renk özelliğini değiştirmek için.
            Renk = YeniRenk;
        }
    }
}
