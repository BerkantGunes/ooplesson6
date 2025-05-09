using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi, us, sonuc;
            sonuc = 1;

            sayi = int.Parse(txtSayi.Text);
            us = int.Parse(txtUs.Text);

            for (int i = 0; i < us; i++)
            {
                sonuc = sonuc * sayi;
            }
            MessageBox.Show(sonuc.ToString());
        }
    }
}
