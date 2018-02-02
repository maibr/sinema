using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema
{
    public partial class Bilet : Form
    {
        public Bilet()
        {
            InitializeComponent();
           
        }

     

        private void btngetir_Click(object sender, EventArgs e)
        {
           
             sayi.Text = Form1.koltuksayisi;
            labelfilm. Text = Form1.film;
           
         
            

        }

        private void kayit_Click(object sender, EventArgs e)
        { 
            string adsoyad = ads.Text;
            int hesap = Convert.ToInt32(sayi.Text);
            int tutar;

            if (tamsecim != null)
            {
             
                tutar = 25 * hesap;
                ttr.Text = Convert.ToString(tutar);

            }

            else if (ogrencisecim != null)
            {
                 tutar = 15 * hesap;
                ttr.Text = Convert.ToString(tutar);
            }
            else
            {
                Hesapla.Enabled = false;

                MessageBox.Show("Sinema Bileti için seçim yapınız. Tam & Öğrenci", "Bilgilendirme Penceresi", MessageBoxButtons.RetryCancel);
               
            }



        }

        private void tamsecim_CheckedChanged(object sender, EventArgs e)
        {

            
                fyt.Text = "25";
                ogrencisecim.Enabled = false;
             

            
        }

        private void ogrencisecim_CheckedChanged(object sender, EventArgs e)
        {
            fyt.Text = "15";
            tamsecim.Enabled = false;
        }
    }

}
