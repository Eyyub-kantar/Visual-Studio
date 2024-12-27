using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinifKademesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int sinif = Convert.ToByte(comboBox1.SelectedItem);
            if ( sinif > 0 && sinif < 5 )
            {
                label2.Text=("ilkokul kademesindesiniz");

            }
            else if (sinif>4 && sinif < 9)

            {
                label2.Text = ("ortaokul kademesindesiniz");

            }
            else if (sinif>8 && sinif<13)
            {
                label2.Text = ("lise kademesindesiniz");
            }
        }
    }
}
