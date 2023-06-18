using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            san = Convert.ToInt32(saniye.Text);
            san++;
            saniye.Text = san.ToString();
            
            if(san == 59)
            {
                san = 0;
                saniye.Text = san.ToString();
                dak++;
                dakika.Text = dakika.ToString();
            }
            if (dak == 59)
            {
                dak = 0;
                dakika.Text = dakika.ToString();
                saa++;
                saat.Text = saat.ToString();
            }
        }

        int say, san, dak, saa;

        private void sıfırla_Click(object sender, EventArgs e)
        {
            saniye.Text = "0";
            dakika.Text = "0";
            saat.Text = "0";
        }

        private void başlat_Click(object sender, EventArgs e)
        {
            say = say + 1;

            if (say == 0)
            {
                timer1.Enabled = true;
                başlat.Text = "Kronometreyi Durdur";
            }
            else
            {
                timer1.Enabled = false;
                başlat.Text = "Kronometreyi Çalıştır";
                say = 0;

            }
                
        }
    }
}
