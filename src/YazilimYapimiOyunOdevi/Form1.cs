using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimYapimiOyunOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int HamleSayisi = 0;
        int AlanBoyutu = 5;
        PictureBox[,] zemin = new PictureBox[9, 9];
        private void Form1_Load(object sender, EventArgs e)
        {
            AlanOlustur(AlanBoyutu, 1);
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            HamleSayisi = 0;
            lblHamleSayisi.Text = "Hamle Sayısı : " + HamleSayisi.ToString();
            lblDurum.Text = "";
            AlanOlustur(AlanBoyutu, 0);
            AlanOlustur(AlanBoyutu, 1);
        }
        public void AlanOlustur(int N, int kontrol)
        {
            int xpos = 32, ypos = 50;

            if (kontrol == 1)
            {
                for (int x = 0; x < N; x++)
                {
                    for (int y = 0; y < N; y++)
                    {
                        zemin[x, y] = new PictureBox();
                        zemin[x, y].Name = x.ToString() + y.ToString();
                        zemin[x, y].Width = 30;
                        zemin[x, y].Height = 30;
                        zemin[x, y].Location = new Point(xpos, ypos);
                        zemin[x, y].SizeMode = PictureBoxSizeMode.Zoom;
                        zemin[x, y].BackColor = ColorTranslator.FromHtml("#0004ff");
                        xpos += 32;
                        this.Controls.Add(zemin[x, y]);
                        zemin[x, y].Click += new EventHandler(zemin_Click);
                    }
                    xpos = 32;
                    ypos += 32;
                }
            }
            if (kontrol == 0)
            {
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        this.Controls.Remove(zemin[x, y]);
                    }
                }
            }
        }
        public void zemin_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            PictureBox sec = sender as PictureBox;
            x = (Convert.ToInt32(sec.Name) - (Convert.ToInt32(sec.Name) % 10)) / 10;
            y = Convert.ToInt32(sec.Name) % 10;
            if (HamleSayisi == 0)
            {
                sec.BackColor = ColorTranslator.FromHtml("#ffffff");//beyaz yap
                HamleSayisi++;
                HamleAlani(x, y);
            }
            else
            {
                if (sec.BackColor == ColorTranslator.FromHtml("#11fc3c"))//yeşilse
                {
                    sec.BackColor = ColorTranslator.FromHtml("#ffffff");//beyaz yap
                    HamleAlani(x, y);
                    HamleSayisi++;
                }
            }
            lblHamleSayisi.Text = "Hamle Sayısı : " + HamleSayisi.ToString();
            if (HamleSayisi == (AlanBoyutu*AlanBoyutu))
                lblDurum.Text = "Tebrikler Kazandınız..";
        }
        public void HamleAlani(int x, int y)
        {
            int k = 1;
            Hamle_Devami();
            if (!(x - 2 < 0) && !(y - 1 < 0))
            {
                if (zemin[x - 2, y - 1].BackColor != ColorTranslator.FromHtml("#ffffff"))
                {
                    zemin[x - 2, y - 1].BackColor = ColorTranslator.FromHtml("#11fc3c");
                    k = 0;
                }
            }
            if (!(x - 2 < 0) && !(y + 1 > AlanBoyutu - 1))
            {
                if (zemin[x - 2, y + 1].BackColor != ColorTranslator.FromHtml("#ffffff"))
                {
                    zemin[x - 2, y + 1].BackColor = ColorTranslator.FromHtml("#11fc3c");
                    k = 0;
                }
            }
            if (!(x - 1 < 0) && !(y - 2 < 0))
            {
                if (zemin[x - 1, y - 2].BackColor != ColorTranslator.FromHtml("#ffffff"))
                {
                    zemin[x - 1, y - 2].BackColor = ColorTranslator.FromHtml("#11fc3c");
                    k = 0;
                }
            }
            if (!(x - 1 < 0) && !(y + 2 > AlanBoyutu - 1))
            {
                if (zemin[x - 1, y + 2].BackColor != ColorTranslator.FromHtml("#ffffff"))
                {
                    zemin[x - 1, y + 2].BackColor = ColorTranslator.FromHtml("#11fc3c");
                    k = 0;
                }
            }
            if (!(x + 1 > AlanBoyutu - 1) && !(y - 2 < 0))
            {
                if (zemin[x + 1, y - 2].BackColor != ColorTranslator.FromHtml("#ffffff"))
                {
                    zemin[x + 1, y - 2].BackColor = ColorTranslator.FromHtml("#11fc3c");
                    k = 0;
                }
            }
            if (!(x + 1 > AlanBoyutu - 1) && !(y + 2 > AlanBoyutu - 1))
            {
                if (zemin[x + 1, y + 2].BackColor != ColorTranslator.FromHtml("#ffffff"))
                {
                    zemin[x + 1, y + 2].BackColor = ColorTranslator.FromHtml("#11fc3c");
                    k = 0;
                }
            }
            if (!(x + 2 > AlanBoyutu - 1) && !(y - 1 < 0))
            {
                if (zemin[x + 2, y - 1].BackColor != ColorTranslator.FromHtml("#ffffff"))
                {
                    zemin[x + 2, y - 1].BackColor = ColorTranslator.FromHtml("#11fc3c");
                    k = 0;
                }
            }
            if (!(x + 2 > AlanBoyutu - 1) && !(y + 1 > AlanBoyutu - 1))
            {
                if (zemin[x + 2, y + 1].BackColor != ColorTranslator.FromHtml("#ffffff"))
                {
                    zemin[x + 2, y + 1].BackColor = ColorTranslator.FromHtml("#11fc3c");
                    k = 0;
                }
            }
            if (k == 1)
            {
                lblDurum.Text = "Kaybettiniz..";
            }
        }
        public void Hamle_Devami()
        {
            for (int x = 0; x < AlanBoyutu; x++)
            {
                for (int y = 0; y < AlanBoyutu; y++)
                {
                    if (zemin[x, y].BackColor == ColorTranslator.FromHtml("#11fc3c"))
                    {
                        zemin[x, y].BackColor = ColorTranslator.FromHtml("#0004ff");
                    }
                }
            }
        }

        private void rd5x5_CheckedChanged_1(object sender, EventArgs e)
        {
            AlanBoyutu = 5;
            HamleSayisi = 0;
            lblHamleSayisi.Text = "Hamle Sayısı : " + HamleSayisi.ToString();
            lblDurum.Text = "";
            AlanOlustur(AlanBoyutu, 0);
            AlanOlustur(AlanBoyutu, 1);
        }

        private void rd6x6_CheckedChanged(object sender, EventArgs e)
        {
            AlanBoyutu = 6;
            HamleSayisi = 0;
            lblHamleSayisi.Text = "Hamle Sayısı : " + HamleSayisi.ToString();
            lblDurum.Text = "";
            AlanOlustur(AlanBoyutu, 0);
            AlanOlustur(AlanBoyutu, 1);
        }

        private void rd7x7_CheckedChanged(object sender, EventArgs e)
        {
            AlanBoyutu = 7;
            HamleSayisi = 0;
            lblHamleSayisi.Text = "Hamle Sayısı : " + HamleSayisi.ToString();
            lblDurum.Text = "";
            AlanOlustur(AlanBoyutu, 0);
            AlanOlustur(AlanBoyutu, 1);
        }

        private void rd8x8_CheckedChanged(object sender, EventArgs e)
        {
            AlanBoyutu = 8;
            HamleSayisi = 0;
            lblHamleSayisi.Text = "Hamle Sayısı : " + HamleSayisi.ToString();
            lblDurum.Text = "";
            AlanOlustur(AlanBoyutu, 0);
            AlanOlustur(AlanBoyutu, 1);
        }

        private void rd9x9_CheckedChanged(object sender, EventArgs e)
        {
            AlanBoyutu = 9;
            HamleSayisi = 0;
            lblHamleSayisi.Text = "Hamle Sayısı : " + HamleSayisi.ToString();
            lblDurum.Text = "";
            AlanOlustur(AlanBoyutu, 0);
            AlanOlustur(AlanBoyutu, 1);
        }
    }
}
