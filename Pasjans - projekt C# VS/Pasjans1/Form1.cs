using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasjans1
{
    public partial class Form1 : Form
    {
        public bool wdus = false;
        public int talia = -1;
        public Form1()
        {
            InitializeComponent();
            Karty[] Talia = { karty1, karty2, karty3, karty4, karty5, karty6, karty7, karty8, karty9, karty10, karty11, karty12, karty13, karty14, karty15, karty16, karty17, karty18, karty19, karty20, karty21, karty22, karty23, karty24 };
            Karty[] talia = { k1, k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13, k14, k15, k16, k17, k18, k19, k20, k21, k22, k23, k24, k25, k26, k27, k28, karty1, karty2, karty3, karty4, karty5, karty6, karty7, karty8, karty9, karty10, karty11, karty12, karty13, karty14, karty15, karty16, karty17, karty18, karty19, karty20, karty21, karty22, karty23, karty24 };
            Random rng = new Random();
            int n = talia.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                Karty temp = talia[n];
                talia[n] = talia[k];
                talia[k] = temp;
            }
            k1.wierzch = true;
            k3.wierzch = true;
            k6.wierzch = true;
            k10.wierzch = true;
            k15.wierzch = true;
            k21.wierzch = true;
            k28.wierzch = true;
            karty25.wierzch = true;
            karty26.wierzch = true;
            karty27.wierzch = true;
            karty28.wierzch = true;
            karty29.wierzch = true;
            karty30.wierzch = true;
            karty31.wierzch = true;
            karty32.wierzch = true;
            karty33.wierzch = true;
            karty34.wierzch = true;
            karty35.wierzch = true;
            karty25.wartosc = -1;
            karty26.wartosc = -1;
            karty27.wartosc = -1;
            karty28.wartosc = -1;
            karty29.wartosc = 77;
            karty30.wartosc = 77;
            karty31.wartosc = 77;
            karty32.wartosc = 77;
            karty33.wartosc = 77;
            karty34.wartosc = 77;
            karty35.wartosc = 77;
            for (int i = 0; i != 24; i++)
            {
                Talia[i].wierzch = true;
                Talia[i].awers();
            }
            for (int i = 0; i < 52; i++)
            {
                if (i % 4 == 0)
                {
                    talia[i].kolor = 1;
                }else if(i%4 == 1)
                {
                    talia[i].kolor = 2;
                }
                else if (i % 4 == 2)
                {
                    talia[i].kolor = 3;
                }
                else if (i % 4 == 3)
                {
                    talia[i].kolor = 4;
                }
                if (i == 0 || i == 1 || i == 2 || i == 3)
                {
                    talia[i].wartosc = 0;
                    if (talia[i].wierzch == true)
                    {
                        talia[i].Text = "";
                        talia[i].awers();
                    }
                    else
                    {
                     talia[i].Text = "";
                    }
                }
                else if (i == 4 || i == 5 || i == 6 || i == 7)
                {
                    talia[i].wartosc = 1;
                    if (talia[i].wierzch == true)
                    {
                        talia[i].Text = "";
                        talia[i].awers();
                    }
                    else
                    {
                     talia[i].Text = "";
                    }
                }
                else if (i == 8 || i == 9 || i == 10 || i == 11)
                {
                    talia[i].wartosc = 2;
                    if (talia[i].wierzch == true)
                    {
                        talia[i].Text = "";
                        talia[i].awers();
                    }
                    else
                    {
                     talia[i].Text = "";
                    }
                }
                else if (i == 12 || i == 13 || i == 14 || i == 15)
                {
                    talia[i].wartosc = 3;
                    if (talia[i].wierzch == true)
                    {
                        talia[i].Text = "";
                        talia[i].awers();
                    }
                    else
                    {
                     talia[i].Text = "";
                    }
                }
                else if (i == 16 || i == 17 || i == 18 || i == 19)
                {
                    talia[i].wartosc = 4;
                    if (talia[i].wierzch == true)
                    {
                        talia[i].Text = "";
                        talia[i].awers();
                    }
                    else
                    {
                     talia[i].Text = "";
                    }
                }
                else if (i == 20 || i == 21 || i == 22 || i == 23)
                {
                    talia[i].wartosc = 5;
                    if (talia[i].wierzch == true)
                    {
                        talia[i].Text = "";
                        talia[i].awers();
                    }
                    else
                    {
                     talia[i].Text = "";
                    }
                }
                else if (i == 24 || i == 25 || i == 26 || i == 27)
                {
                    talia[i].wartosc = 6;
                    if (talia[i].wierzch == true)
                    {
                        talia[i].Text = "";
                        talia[i].awers();
                    }
                    else
                    {
                     talia[i].Text = "";
                    }
                }
                else if (i == 28 || i == 29 || i == 30 || i == 31)
                {
                    talia[i].wartosc = 7;
                    if (talia[i].wierzch == true)
                    {
                        talia[i].Text = "";
                        talia[i].awers();
                    }
                    else
                    {
                     talia[i].Text = "";
                    }
                }
                else if (i == 32 || i == 33 || i == 34 || i == 35)
                {
                    talia[i].wartosc = 8;
                    if (talia[i].wierzch == true)
                    {
                        talia[i].Text = "";
                        talia[i].awers();
                    }
                    else
                    {
                     talia[i].Text = "";
                    }
                }
                else if (i == 36 || i == 37 || i == 38 || i == 39)
                {
                    talia[i].wartosc = 9;
                    if (talia[i].wierzch == true)
                    {
                        talia[i].Text = "";
                        talia[i].awers();
                    }
                    else
                    {
                     talia[i].Text = "";
                    }
                }
                else if (i == 40 || i == 41 || i == 42 || i == 43)
                {
                    talia[i].wartosc = 10;
                    if (talia[i].wierzch == true)
                    {
                        talia[i].Text = "";
                        talia[i].awers();
                    }
                    else
                    {
                     talia[i].Text = "";
                    }
                }
                else if (i == 44 || i == 45 || i == 46 || i == 47)
                {
                    talia[i].wartosc = 11;
                    if (talia[i].wierzch == true)
                    {
                        talia[i].Text = "";
                        talia[i].awers();
                    }
                    else
                    {
                     talia[i].Text = "";
                    }
                }
                else if (i == 48 || i == 49 || i == 50 || i == 51)
                {
                    talia[i].wartosc = 12;
                    if (talia[i].wierzch == true)
                    {
                        talia[i].Text = "";
                        talia[i].awers();
                    }
                    else
                    {
                     talia[i].Text = "";
                    }
                }
            }
            for (int i = 0; i != 24; i++)
            {
                Talia[i].wierzch = true;
                Talia[i].gora = true;
            }

            //Karty[] DolnyPanel = { k1, k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13, k14, k15, k16, k17, k18, k19, k20, k21, k22, k23, k24, k25, k26, k27, k28 };
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void karty12_Click(object sender, EventArgs e)
        {

        }

        private void karty19_Click(object sender, EventArgs e)
        {

        }

        private void karty1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Karty[] Talia = { karty1, karty2, karty3, karty4, karty5, karty6, karty7, karty8, karty9, karty10, karty11, karty12, karty13, karty14, karty15, karty16, karty17, karty18, karty19, karty20, karty21, karty22, karty23, karty24 };
            if (talia == 23)
            {
                talia = -1;
            }
            if (talia > -1 && Talia[talia].talia == false)
            {
                Talia[talia].Visible = false;
            }
            talia++;
            Talia[talia].Visible = true;
        }

        private void k1_Click(object sender, EventArgs e)
        {

        }

        private void karty24_Click(object sender, EventArgs e)
        {

        }
    }
}
