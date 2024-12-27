using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switchCaseOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string isim;
        private void button1_Click(object sender, EventArgs e)
        {
            isim = textBox1.Text;
            switch (isim)
            {
                case "eyyüb":
                    MessageBox.Show("giriş yapılıyor");
                    break;
                case "ahmet":
                    MessageBox.Show("Giriş yapılıyor");
                    break;
                case "mehmet":
                    MessageBox.Show("Giriş yapılıyor");
                    break;
                default:
                    MessageBox.Show("Giriş yapılamadı");
                    break;

            }
        }
    }
}
