using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a=Convert.ToInt32(textBox1.Text);
            b=Convert.ToInt32(textBox2.Text);
            c=Convert.ToInt32(textBox3.Text);
            if (a > b && a > c)
            {
                MessageBox.Show(a.ToString());
            }
            if (b > c && b > a)
            {
                MessageBox.Show(b.ToString());
            }
            if (c>a && c > b)
            {
                MessageBox.Show(c.ToString());
            }
        }
    }
}
