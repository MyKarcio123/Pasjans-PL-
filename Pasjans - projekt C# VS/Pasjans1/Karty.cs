using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Pasjans1
{
    class Karty : Button
    {
        public int kolor; //fasle - czerwona, true- czarna
        public int wartosc; //król 12, as 0
        public bool wierzch; // 0-zakryta, 1-odkryta
        public bool talia; //1- w tali na gorze, 0 - na dole;
        public bool gora; //0 - nic, 1- na gorze, tam;
        public bool nad; // 1- jest cos pod nia 
        static Karty[] wcisnieta;
        int g = 2;

        public Karty()
        {
            wcisnieta = new Karty[3];
            rewers();
            this.Click += new System.EventHandler(this.clicked);
        }

        private void clicked(object sender, EventArgs e)
        {
            if (wcisnieta[0] != null)
            {
                if (Program.wdus.wdus == true && this.wierzch == true && wcisnieta[0].nad != true)
                {
                    wcisnieta[1] = this;
                    if ((wcisnieta[1].wartosc == wcisnieta[0].wartosc + 1 && wcisnieta[1].kolor != wcisnieta[0].kolor) && wcisnieta[0] != wcisnieta[1])
                    {
                        if (wcisnieta[1].kolor == 1 && wcisnieta[0].kolor != 1 && wcisnieta[0].kolor != 2 || wcisnieta[1].kolor == 2 && wcisnieta[0].kolor != 1 && wcisnieta[0].kolor != 2 || wcisnieta[1].kolor == 3 && wcisnieta[0].kolor != 3 && wcisnieta[0].kolor != 4 || wcisnieta[1].kolor == 4 && wcisnieta[0].kolor != 3 && wcisnieta[0].kolor != 4)
                        {
                            wcisnieta[1].nad = true;
                            Point loc = wcisnieta[0].Location;
                            loc.Y -= 26;
                            foreach (Control control in wcisnieta[0].Parent.Controls)
                            {
                                if (control.Location == loc)
                                {
                                    (control as Karty).awers();
                                    (control as Karty).wierzch = true;
                                }
                            }
                            wcisnieta[0].Location = new Point(wcisnieta[1].Location.X, wcisnieta[1].Location.Y + 26);
                            wcisnieta[1].wierzch = true;
                            wcisnieta[0].wierzch = true;
                            wcisnieta[0].gora = false;
                            wcisnieta[1].gora = false;
                            wcisnieta[0].talia = true;
                            wcisnieta[1].talia = true;
                            wcisnieta[0].Parent.Controls.SetChildIndex(wcisnieta[0], +g);
                            g++;
                        }
                        else {
                            Program.wdus.wdus = false;
                            return;
                        }
                    }
                    if (((wcisnieta[1].wartosc == -1 || wcisnieta[1].kolor == wcisnieta[0].kolor) && wcisnieta[1].wartosc == wcisnieta[0].wartosc - 1 && wcisnieta[0] != wcisnieta[1]))
                    {
                        Point loc = wcisnieta[0].Location;
                        loc.Y -= 26;
                        foreach (Control control in wcisnieta[0].Parent.Controls)
                        {
                            if (control.Location == loc)
                            {
                                Console.WriteLine("FOUND");
                                (control as Karty).awers();
                                (control as Karty).wierzch = true;
                            }
                        }
                        wcisnieta[1].Visible = false;
                        wcisnieta[0].Location = new Point(wcisnieta[1].Location.X, wcisnieta[1].Location.Y);
                        wcisnieta[0].gora = true;
                        wcisnieta[0].talia = true;
                    }
                    if (wcisnieta[1].wartosc == 77 && wcisnieta[0].wartosc == 12)
                    {
                        Point loc = wcisnieta[0].Location;
                        loc.Y -= 26;
                        foreach (Control control in wcisnieta[0].Parent.Controls)
                        {
                            if (control.Location == loc)
                            {
                                (control as Karty).awers();
                                (control as Karty).wierzch = true;
                            }
                        }
                        wcisnieta[1].Visible = false;
                        wcisnieta[0].Location = new Point(wcisnieta[1].Location.X, wcisnieta[1].Location.Y);
                        wcisnieta[0].talia = true;
                    }
                    Program.wdus.wdus = false;
                    return;
                }
                if (wcisnieta[0].nad == true)
                {
                    Console.WriteLine("JESTEM TU");
                    wcisnieta[1] = this;
                    if ((wcisnieta[1].wartosc == wcisnieta[0].wartosc + 1 && wcisnieta[1].kolor != wcisnieta[0].kolor && wcisnieta[1].gora != true) && wcisnieta[0] != wcisnieta[1])
                    {
                        Point loc = wcisnieta[0].Location;
                        loc.Y -= 26;
                        foreach (Control control in wcisnieta[0].Parent.Controls)
                        {
                            if (control.Location == loc)
                            {
                                (control as Karty).awers();
                                (control as Karty).wierzch = true;
                            }
                        }
                        Point wcisnieta_loc = wcisnieta[0].Location;
                        int index = wcisnieta[1].Parent.Controls.GetChildIndex(wcisnieta[1]);
                        wcisnieta[0].Location = new Point(wcisnieta[1].Location.X, wcisnieta[1].Location.Y + 26);
                        wcisnieta[0].Parent.Controls.SetChildIndex(wcisnieta[0], (index == 0 ? 0 : --index));
                        int i = 0;
                        while (true)
                        {
                            Point loc2 = wcisnieta_loc;
                            loc2.Y += (i + 1) * 26;

                            bool found = false;
                            foreach (Control control in wcisnieta[0].Parent.Controls)
                            {
                                if (control.Location == loc2)
                                {
                                    Console.WriteLine("XD");
                                    control.Location = new Point(wcisnieta[1].Location.X, wcisnieta[1].Location.Y + 26 * (i + 2));
                                    control.Parent.Controls.SetChildIndex(control, (index == 0 ? 0 : --index));
                                    found = true;
                                    break;
                                }
                            }
                            if (found == false) //nie ma niżej
                                break;
                            i++;
                        }
                        Program.wdus.wdus = false;
                        return;
                    }

                }
            }
            if (Program.wdus.wdus == false && this.wierzch == true)
            {
                wcisnieta[0] = this;
                Program.wdus.wdus = true;
                return;
            }

        }
        public void rewers()
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Pasjans1.Properties.Resources.REWERS;
        }
        public void awers()
        {
            this.BackgroundImage = Pasjans1.Properties.Resources.card;

            Bitmap bitmap = new Bitmap(this.BackgroundImage.Width, this.BackgroundImage.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {

                if (wartosc > 9 || wartosc == 0)
                {
                    if (wartosc == 10)
                    {
                        g.DrawImage(Pasjans1.Properties.Resources.WALET, 0, 0);
                        this.BackColor = checkcolor(kolor);
                    }
                    if (wartosc == 11)
                    {
                        g.DrawImage(Pasjans1.Properties.Resources.queen, 0, 0);
                        this.BackColor = checkcolor(kolor);
                    }
                    if (wartosc == 12)
                    {
                        g.DrawImage(Pasjans1.Properties.Resources.king, 0, 0);
                        this.BackColor = checkcolor(kolor);
                    }
                    if (wartosc == 0)
                    {
                        g.Clear(Color.White);
                        text("As", bitmap, g);
                    }
                }
                else
                {
                    g.Clear(Color.White);
                    int c = wartosc + 1;
                    text(c.ToString(), bitmap, g);
                }
                if (kolor == 1)
                {
                    g.DrawImage(Pasjans1.Properties.Resources.kier, 0, 0);
                }
                if (kolor == 2)
                {
                    g.DrawImage(Pasjans1.Properties.Resources.karo, 0, 0);
                }
                if (kolor == 3)
                {
                    g.DrawImage(Pasjans1.Properties.Resources.pik, 0, 0);
                }
                if (kolor == 4)
                {
                    g.DrawImage(Pasjans1.Properties.Resources.trefl, 0, 0);
                }
            }
            this.BackgroundImage = bitmap;

        }
        void text(String text, Bitmap bm, Graphics g)
        {
            RectangleF rectf = new RectangleF(0, 0, bm.Width, bm.Height);
            Brush cl = Brushes.Black;

            if (kolor == 1 || kolor == 2)
            {
                cl = Brushes.Red;
            }
            else if (kolor == 3 || kolor == 4)
            {
                cl = Brushes.Black;
            }
            g.DrawString(text, new Font("Tahoma", 15), cl, rectf);
        }
        Color checkcolor(int kl)
        {
            if (kl == 1 || kl == 2)
            {
                return Color.Red;
            }
            return Color.Black;
        }

    }

}
