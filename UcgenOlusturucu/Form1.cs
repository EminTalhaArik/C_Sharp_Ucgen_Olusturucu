using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcgenOlusturucu
{
    public partial class frm_yildizOlusturucu : Form
    {
        public frm_yildizOlusturucu()
        {
            InitializeComponent();
        }

        private void btn_yildizOlustur_Click(object sender, EventArgs e)
        {
            lbx_yildiz.Items.Clear();
            yildizBasamak = "";
            if (tbx_satirSayisi.Text != "")
            {
                int satirSayisi = Convert.ToInt32(tbx_satirSayisi.Text);

                if (cbx_turler.Text == "Dik Üçgen")
                {
                    DikUcgenOlustur(satirSayisi);

                }
                else if (cbx_turler.Text == "Eşkenar Üçgen")
                {
                    EskenarUcgenOlustur(satirSayisi);
                }
                else if (cbx_turler.Text == "Ters Üçgen")
                {
                    TersUcgenOlustur(satirSayisi);
                }
                else if (cbx_turler.Text == "Baklava Dilimi")
                {
                    BaklavaDilimi(satirSayisi);
                }
                else if (cbx_turler.Text == "Ev")
                {
                    EvOlustur(satirSayisi);
                }
                else if (cbx_turler.Text == "Kare")
                {
                    KareOlustur(satirSayisi, 2 * satirSayisi);
                }
            }
        }

        string yildizBasamak = "";
        private void DikUcgenOlustur(int satir)
        {
            for (int i = 0; i < satir; i++)
            {
                yildizBasamak += "*";
                lbx_yildiz.Items.Add(yildizBasamak);
            }
        }

        private void EskenarUcgenOlustur(int satir)
        {
            for (int i = 0; i < satir; i++)
            {
                for (int j = i; j < satir; j++)
                {
                    yildizBasamak += " ";
                }
                for (int a = 0; a <= i; a++)
                {
                    yildizBasamak += "*";
                }
                for (int h = i; h > 0; h--)
                {
                    yildizBasamak += "*";
                }
                lbx_yildiz.Items.Add(yildizBasamak);
                yildizBasamak = "";
            }
        }

        private void TersUcgenOlustur(int satir)
        {
            for (int i = satir - 1; i >= 0; i--)
            {
                for (int j = i; j < satir; j++)
                {
                    yildizBasamak += " ";
                }
                for (int a = i; a >= 0; a--)
                {
                    yildizBasamak += "*";
                }
                for (int h = 0; h < i; h++)
                {
                    yildizBasamak += "*";
                }
                lbx_yildiz.Items.Add(yildizBasamak);
                yildizBasamak = "";
            }
        }

        private void BaklavaDilimi(int satir)
        {
            EskenarUcgenOlustur(satir / 2);
            TersUcgenOlustur(satir / 2);
        }

        private void EvOlustur(int satir)
        {
            EskenarUcgenOlustur(satir / 2);
            KareOlustur(satir / 2, satir);
        }

        private void KareOlustur(int yukseklik, int genislik)
        {
            for (int i = 0; i < yukseklik; i++)
            {
                for (int j = 0; j < genislik; j++)
                {
                    yildizBasamak += "*";
                }
                lbx_yildiz.Items.Add(yildizBasamak);
                yildizBasamak = "";
            }

        }

        private void cbx_turler_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_yildizOlustur.Enabled = true;
        }

        private void tbx_satirSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
