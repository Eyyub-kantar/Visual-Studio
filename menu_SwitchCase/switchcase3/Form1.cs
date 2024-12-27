using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switchcase3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilenicerik;
            int yemekucret;
            string secilenYemek = textBox1.Text;
            switch (secilenYemek)
            {
                case "hamburger":
                    secilenicerik = "Patates,Cola ile servis edilir";
                    yemekucret = 300;
                    break;
                case "pizza":
                    secilenicerik = "patates ve tatlı ile servis edilir";
                    yemekucret = 400;
                    break;
                default:
                    secilenicerik = "menümüzde boyle bir yiyecek bulunmamaktadır!";
                    yemekucret = 0;

                    break;
            }
            MessageBox.Show( "seçilen yemek :" + secilenYemek + "secilen içerik :" + secilenicerik + "ücret :" + yemekucret.ToString());
        }
    }
}
