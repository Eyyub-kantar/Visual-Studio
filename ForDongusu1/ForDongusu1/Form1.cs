using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDongusu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        string isim;
        
        private void button1_Click(object sender, EventArgs e)
        {
            sayi=Convert.ToInt32(textBox1.Text);
            isim = textBox2.Text;
            
            for (int i = 0; i < sayi; i++)
            {
                listBox1.Items.Add(isim);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
