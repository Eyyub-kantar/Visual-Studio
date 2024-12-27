using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForOrnegi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int baslangic, bitis;

        private void button1_Click(object sender, EventArgs e)
        {
            baslangic=Convert.ToInt32(textBox1.Text);
            bitis=Convert.ToInt32(textBox2.Text);
            for (int i = baslangic; i <= bitis; i=i+2)
            {
                Sayilar.Items.Add(i);
            }
        }
    }
}
