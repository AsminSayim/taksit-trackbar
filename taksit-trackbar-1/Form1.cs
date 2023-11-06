using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taksit_trackbar_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int adet = 1;
            double fiyat = 0;
            int taksit = 1;
            double taksitTutar = 0;
            adet=Convert.ToInt32(textBox1.Text);
            fiyat = Convert.ToInt32(textBox2.Text);
            taksit = trackBar1.Value;
            taksitTutar = (adet * fiyat) / taksit;
            label3.Text=taksitTutar.ToString();
        }
    }
}
