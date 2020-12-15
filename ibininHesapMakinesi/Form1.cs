using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ibininHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            secim = 4;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            sayi2 = double.Parse(textBox1.Text);
            if (secim == 1)
            {
                sonuc = sayi1 + sayi2;
                label1.Text = sonuc.ToString();
            }
            if (secim == 2)
            {
                sonuc = sayi1 - sayi2;
                label1.Text = sonuc.ToString();
            }
            if (secim == 3)
            {
                sonuc = sayi1 * sayi2;
                label1.Text = sonuc.ToString();
            }
            if (secim == 4)
            {
                sonuc = sayi1 / sayi2;
                label1.Text = sonuc.ToString("0.00");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Seçilibutonlar(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + ((Button)sender).Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",") < 1)
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            {
                int toplam = 0;
                int ortalama = 0;
                label1.Text = ortalama.ToString();
                textBox1.Text = ortalama.ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }
        double sayi1, sayi2, sonuc;

        private void button16_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            secim = 1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            secim = 2;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            secim = 3;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            label1.Text = Convert.ToString(Math.Sqrt(sayi1));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            label1.Text = Convert.ToString(sayi1 * sayi1);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int faktoriyel = 1;
            sayi1 = Convert.ToInt32(textBox1.Text);

            for (int i = 1; i <= sayi1; i++)
            {
                faktoriyel = faktoriyel * i;
            }
            label1.Text = faktoriyel.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            sayi2 = double.Parse(textBox1.Text);
            {
                sonuc = sayi2 *= sayi2;
                label1.Text = sonuc.ToString();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int sayi, i, tektop = 0, cifttop = 0;
            sayi = int.Parse(textBox1.Text);
            for (i = 1; i < sayi; i++)
            {
                if (i % 2 == 0)
                    cifttop = cifttop + i;
                else
                    tektop = tektop + i;
            }
            label1.Text = cifttop.ToString();
            label1.Text = tektop.ToString();
        }

        int secim = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}