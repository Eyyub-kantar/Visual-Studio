using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraylistUygulama_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList Sehirler = new ArrayList();
        private void Listele()
        {
            listeSehirler.Items.Clear();
            foreach (var sehir in Sehirler)
            {
                listeSehirler.Items.Add(sehir);
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sehirler.Add(txtSehirler.Text);
            Listele();
        }

        private void btnArayaEkle_Click(object sender, EventArgs e)
        {
            int indexNo = listeSehirler.SelectedIndex;
            Sehirler.Insert(indexNo, txtSehirler.Text);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int indexNo = listeSehirler.SelectedIndex;
            Sehirler[indexNo] = txtSehirler.Text;
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int indexNo = listeSehirler.SelectedIndex;
            Sehirler.RemoveAt(indexNo);
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (Sehirler.Contains(txtSehirler.Text))
            {
                label2.Text = "Aranan değer bulundu!";
                listeSehirler.SelectedIndex = Sehirler.IndexOf(txtSehirler.Text);
            }
            else
            {
                label2.Text = "Aranan değer bulunamadı!";

            }
        }
    }
}
