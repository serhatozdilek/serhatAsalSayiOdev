using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serhatAsalOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dfg.Text = "";
            double sayac = 0;
            listBox1.Items.Clear();// Her seferinde listBox temizlensin
            double x = Convert.ToDouble(textBox1.Text);
            if (x < 2)
            {
                MessageBox.Show("Asal Sayı Bulunamadı.");
            }
            else
            {
                for (double i = 2; i <= x; i++)
                {
                    double kontrol = 0;
                    for (double j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            kontrol++;
                            break;
                        }
                    }
                    if (kontrol == 0)
                    {
                        listBox1.Items.Add(i);
                        sayac++;
                    }
                }
            }

            dfg.Text = "girdiginiz sayi :" + x + " // " + sayac + " adet Asal Sayı Bulundu.";
        }
    }
}
