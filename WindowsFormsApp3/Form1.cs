using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayacBir = -1;
        int sayacIki = -1;
        int sayacUc = -1;
        int saniye;
        int dakika;
        int saat;

        Button btn = new Button();

        private void grpSaat_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblSaat.Text = Convert.ToString(timer1);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    sayacBir++;
                    btn = new Button();
                    btn.BackColor = Color.White;
                    btn.Size = new Size(50, 25);
                    btn.Left = ((20 + 30) * j) + 30;
                    btn.Top = ((10 + 20) * i) + 10;
                    btn.Text = sayacBir.ToString();
                    btn.Name = btn.Text;
                    grpSaat.Controls.Add(btn);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    sayacIki++;
                    btn = new Button();
                    btn.BackColor = Color.White;
                    btn.Size = new Size(50, 25);
                    btn.Left = ((20 + 30) * j) + 30;
                    btn.Top = ((10 + 20) * i) + 10;
                    btn.Text = sayacIki.ToString();
                    btn.Name = btn.Text;
                    grpDakika.Controls.Add(btn);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    sayacUc++;
                    btn = new Button();
                    btn.BackColor = Color.White;
                    btn.Size = new Size(50, 25);
                    btn.Left = ((20 + 30) * j) + 30;
                    btn.Top = ((10 + 20) * i) + 10;
                    btn.Text = sayacUc.ToString();
                    btn.Name = btn.Text;
                    grpSaniye.Controls.Add(btn);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            lblSaniye.Text = saniye.ToString();
            lblDakika.Text = dakika.ToString();
            lblSaat.Text = saat.ToString();

            foreach (Button item in grpSaniye.Controls)     
                item.BackColor = (item.Name == saniye.ToString() ? Color.Yellow : Color.White);              
     


            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
                lblDakika.Text = dakika.ToString();

                foreach (Button item in grpDakika.Controls)
                    item.BackColor = (item.Name == dakika.ToString() ? Color.Yellow : Color.White);

                if (dakika == 60)
                {
                    dakika = 0;
                    saat++;
                    lblSaat.Text = saat.ToString();

                    if (saat == 24)
                    {
                        saniye = 0;
                        dakika = 0;
                        saat = 0;
                    }
                }
            }
        }
    }
}
