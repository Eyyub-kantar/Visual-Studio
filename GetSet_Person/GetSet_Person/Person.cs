using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet_Person
{
    internal class Person
    {
        // Name özelliği
        private string name;
        // Name için get ve set metodları
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
