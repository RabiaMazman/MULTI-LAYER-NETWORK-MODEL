using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokKatmanlıAgModeli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Gerekli değişkenler tanımladık
        float ogrenmeKatsayisi;
        float momentum; 
        int iterasyonSayisi = 100;

        float agirlik1Arakatman1, agirlik1Arakatman2;
        float agirlik2Arakatman1, agirlik2Arakatman2;
        float Arakatman1Cikis1, Arakatman2Cikis1;
        float agirlikE1Arakatman1, agirlikE1Arakatman2, agirlikE2Cikis1;

        float degisim1Arakatman1, degisim1Arakatman2;
        float degisim2Arakatman1, degisim2Arakatman2;
        float degisim1Cikis1, degisim2Cikis2;
        float degisimE1Arakatman1, degisimE1Arakatman2, degisimE2Cikis1;

        float Girdi1, Girdi2, AraKatman1, AraKatman2, Cikis1;
        float esik1 = 1.0f, esik2 = 1.0f;


        ListBox listboxHata = new ListBox();
        ListBox listboxagirlik1Arakatman1 = new ListBox();
        ListBox listboxagirlik1Arakatman2 = new ListBox();
        ListBox listboxagirlik2Arakatman1 = new ListBox();
        ListBox listboxagirlik2Arakatman2 = new ListBox();
        ListBox listboxAgirlik1_C1 = new ListBox();
        ListBox listboxAgirlik2_C1 = new ListBox();

     

        ListBox listboxAgirlikE1_A1 = new ListBox();
        ListBox listboxAgirlikE1_A2 = new ListBox();
        ListBox listboxAgirlikE2_C1 = new ListBox();

        Random rasgelesayıuret = new Random(); //her defasında farklı değerler üretmesi için public olması gerekiyor.
        private float rastgeleAgirlikUret()
        {
            return (float)rasgelesayıuret.Next(1, 999) / 1000.0f;
        }

        private void agiKur()
        {
            //Başlangıçta raşgelesayı üretmesi ve labelde gösterilmesi için
            agirlik1Arakatman1 = rastgeleAgirlikUret();
            lblW1A1.Text = agirlik1Arakatman1.ToString();

            agirlik1Arakatman2 = rastgeleAgirlikUret();
            lblW1A2.Text = agirlik1Arakatman2.ToString();

            agirlik2Arakatman1 = rastgeleAgirlikUret();
            lblW2A1.Text = agirlik2Arakatman1.ToString();

            agirlik2Arakatman2 = rastgeleAgirlikUret();
            lblW2A2.Text = agirlik2Arakatman2.ToString();

            Arakatman1Cikis1 = rastgeleAgirlikUret();
            lblW1_C1.Text = Arakatman1Cikis1.ToString();

            Arakatman2Cikis1 = rastgeleAgirlikUret();
            lblW2_C1.Text = Arakatman2Cikis1.ToString();

            agirlikE1Arakatman1 = rastgeleAgirlikUret();
            lblWe1A2.Text = agirlikE1Arakatman1.ToString();

            agirlikE1Arakatman2 = rastgeleAgirlikUret();
            lblWe1A1.Text = agirlikE1Arakatman2.ToString();

            agirlikE2Cikis1 = rastgeleAgirlikUret();
            lblWe2_C1.Text = agirlikE2Cikis1.ToString();

            degisim1Arakatman1 = 0;   degisim1Arakatman2 = 0;
            degisim2Arakatman1 = 0;   degisim2Arakatman2 = 0;
            degisim1Cikis1 = 0;   
            degisimE1Arakatman1 = 0;  degisimE1Arakatman2 = 0;
            degisimE2Cikis1 = 0;

            Girdi1 = 0.0f; Girdi2 = 0.0f; AraKatman1 = 0.0f; AraKatman2 = 0.0f; Cikis1 = 0.0f;

            lbl1Cikis.Text = "0.000000";
            lbl2Cikis.Text = "0.000000";
            lbl3Cikis.Text = "0.000000";

            listboxTemizle();
        }


        private float aktivasyon(float x) //sigmoid fonksiyonu 
        {
            return (float)(1.0f / (1.0f + Math.Exp(-x)));
        }

        private float ileriHesaplama(float giris1, float giris2)
        {

            Girdi1 = (float)giris1;
            Girdi2 = (float)giris2;

            AraKatman1 = (Girdi1 * agirlik1Arakatman1) + (Girdi2 * agirlik2Arakatman1) + (esik1 * agirlikE1Arakatman1);
            AraKatman1 = aktivasyon(AraKatman1);

            AraKatman2 = (Girdi1 * agirlik1Arakatman2) + (Girdi2 * agirlik2Arakatman2) + (esik1 * agirlikE1Arakatman2);
            AraKatman2 = aktivasyon(AraKatman2);

            Cikis1 = (AraKatman1 * Arakatman1Cikis1) + (AraKatman2 * Arakatman2Cikis1) + (esik2 * agirlikE2Cikis1);
            Cikis1 = aktivasyon(Cikis1);

            lbl1Cikis.Text = AraKatman1.ToString();
            lbl2Cikis.Text = AraKatman2.ToString();
            lbl3Cikis.Text = Cikis1.ToString();
            lblGiris1.Text = Girdi1.ToString();
            lblGiris2.Text = Girdi2.ToString();

            return Cikis1;
        }

        private void geriHesaplama(float giris1, float giris2, float istenenCikis) //
        {
            ileriHesaplama(giris1, giris2);
            Application.DoEvents();

            //float ogrenmeKatsayisi, momentum dısardan deger alması için;
            ogrenmeKatsayisi = float.Parse(tbOgrenmeKatsayisi.Text);
            momentum = float.Parse(tbmomentum.Text);

            //hata hesapları:
            float hata3 = (Cikis1) * (1 - Cikis1) * (istenenCikis - Cikis1); //çıkıştaki hata hesabı
            float hata2 = AraKatman2 * (1 - AraKatman2) * (hata3 * Arakatman2Cikis1); // ara katmandaki hata hesabı
            float hata1 = AraKatman1 * (1 - AraKatman1) * (hata3 * Arakatman1Cikis1);//ara katmandaki hata hesabı

            //ağırlık değişimlerinin hesaplanması:
            degisim1Arakatman1 = ogrenmeKatsayisi * hata1 * Girdi1 + (momentum * degisim1Arakatman1);
            agirlik1Arakatman1 = agirlik1Arakatman1 + degisim1Arakatman1;
            lblW1A1.Text = agirlik1Arakatman1.ToString();

            degisim1Arakatman2 = ogrenmeKatsayisi * hata2 * Girdi1 + (momentum * degisim1Arakatman2);
            agirlik1Arakatman2 = agirlik1Arakatman2 + degisim1Arakatman2;
            lblW1A2.Text = agirlik1Arakatman2.ToString();

            degisim2Arakatman1 = ogrenmeKatsayisi * hata1 * Girdi2 + (momentum * degisim2Arakatman1);
            agirlik2Arakatman1 = agirlik2Arakatman1 + degisim2Arakatman1;
            lblW2A1.Text = agirlik2Arakatman1.ToString();

            degisim2Arakatman2 = ogrenmeKatsayisi * hata2 * Girdi2 + (momentum * degisim2Arakatman2);
            agirlik2Arakatman2 = agirlik2Arakatman2 + degisim2Arakatman2;
            lblW2A2.Text = agirlik2Arakatman2.ToString();

            degisimE1Arakatman1 = ogrenmeKatsayisi * hata1 * esik1 + (momentum * degisimE1Arakatman1);
            agirlikE1Arakatman1 = agirlikE1Arakatman1 + degisimE1Arakatman1;
            lblWe1A2.Text = agirlikE1Arakatman1.ToString();

            degisimE1Arakatman2 = ogrenmeKatsayisi * hata2 * esik1 + (momentum * degisimE1Arakatman2);
            agirlikE1Arakatman2 = agirlikE1Arakatman2 + degisimE1Arakatman2;
            lblWe1A1.Text = agirlikE1Arakatman2.ToString();

            degisim1Cikis1 = ogrenmeKatsayisi * hata3 * AraKatman1 + (momentum * degisim1Cikis1);
            Arakatman1Cikis1 = Arakatman1Cikis1 + degisim1Cikis1;
            lblW1_C1.Text = Arakatman1Cikis1.ToString();

            degisim2Cikis2 = ogrenmeKatsayisi * hata3 * AraKatman2 + (momentum * degisim2Cikis2);
            Arakatman2Cikis1 = Arakatman2Cikis1 + degisim2Cikis2;
            lblW2_C1.Text = Arakatman2Cikis1.ToString();

            degisimE2Cikis1 = ogrenmeKatsayisi * hata3 * esik2 + (momentum * degisimE2Cikis1);
            agirlikE2Cikis1 = agirlikE2Cikis1 + degisimE2Cikis1;
            lblWe2_C1.Text = agirlikE2Cikis1.ToString();

        }
        private void btnTestEt_Click(object sender, EventArgs e)
        {
            try
            {
                Girdi1 = float.Parse(tbGiris1.Text);
                Girdi2 = float.Parse(tbGiris2.Text);
            }

            catch
            {
                MessageBox.Show("Boş kutucuk bırakmayın", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            lbl3Cikis.Text = ileriHesaplama(Girdi1, Girdi2).ToString();
        }

        private void btnXorEgit_Click(object sender, EventArgs e)
        {

            for (int i = 0; i <= iterasyonSayisi; i++)
            {
                geriHesaplama(0, 0, 0);
                geriHesaplama(0, 1, 1);
                geriHesaplama(1, 0, 1);
                geriHesaplama(1, 1, 0);
            }

            if (Cikis1 > 0.45) //işlem sonundaki çıkış noronu sıfıra yaklaşmamışsa, ile eğitmeye devam et.
            {
                for (int i = 0; i <= 100; i++)
                {
                    geriHesaplama(0, 0, 0);
                    geriHesaplama(0, 1, 1);
                    geriHesaplama(1, 0, 1);
                    geriHesaplama(1, 1, 0);
                }          
            }

            lblAciklama.Text = "XOR için ağ eğitildi.Eğitilen ağın\nsonuçlarını kontrol edebilirsiniz.";
            btnTestEt.Enabled = true;
        }

        private void btnOrEgit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= iterasyonSayisi; i++)
            {
                geriHesaplama(0, 0, 0);
                geriHesaplama(0, 1, 1);
                geriHesaplama(1, 0, 1);
                geriHesaplama(1, 1, 1);
                // Application.DoEvents();
            }

            lblAciklama.Text = "OR için ağ eğitildi.Eğitilen ağın\nsonuçlarını kontrol edebilirsiniz.";
            btnTestEt.Enabled = true;
        }

        private void btnAndEgit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= iterasyonSayisi; i++)
            {
                geriHesaplama(0, 0, 0);
                geriHesaplama(0, 1, 0);
                geriHesaplama(1, 0, 0);
                geriHesaplama(1, 1, 1);
                // Application.DoEvents();
            }
            lblAciklama.Text = "AND için ağ eğitildi.Eğitilen ağın\nsonuçlarını kontrol edebilirsiniz.";
            btnTestEt.Enabled = true;
        }

        //buradada cizim işlemleri için gereken kısım
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //şekli çizmek için gerekli renklerin belirlenmesi
            Graphics grafik = this.CreateGraphics();
            Pen kalem1 = new Pen(Color.Blue, 2); 
            Pen kalem2 = new Pen(Color.Yellow, 2);
            Pen kalem3 = new Pen(Color.Black, 1);

            //Elipse çizimleri için gerekli ölçü ayarları
            grafik.DrawEllipse(kalem1, 270, 60, 75, 75);//G1
            grafik.DrawEllipse(kalem1, 270, 180, 75, 75);//G2          
            grafik.DrawEllipse(kalem2, 400, 300, 75, 75);//E1
            grafik.DrawEllipse(kalem1, 550, 60, 75, 75);//A1
            grafik.DrawEllipse(kalem1, 550, 180, 75, 75);//A2
            grafik.DrawEllipse(kalem2, 600, 300, 75, 75);//E2
            grafik.DrawEllipse(kalem1, 750, 120, 75, 75);//C1

            //Cizgiler için gerekli ölçü ayarları
            grafik.DrawLine(kalem3, 343, 90, 550, 100);    //G1-A1
            grafik.DrawLine(kalem3, 343, 90, 550, 200);   //G1-A2
            grafik.DrawLine(kalem3, 343, 200, 550, 100);   //G2-n4
            grafik.DrawLine(kalem3, 343, 200, 550, 200);  //G2-n5
            grafik.DrawLine(kalem3, 450, 300, 550, 100);  //e1-A1
            grafik.DrawLine(kalem3, 450, 300, 550, 210); //e1-A2
            grafik.DrawLine(kalem3, 620, 100, 750, 160);  //A1-C1
            grafik.DrawLine(kalem3, 620, 210, 750, 160);  //A1-C1
            grafik.DrawLine(kalem3, 660, 310, 750, 160);  //e2-C1
        }
        private void listboxTemizle()
        {
            //Listbox içersindeki değerleri silmek için Clear() metodu kullanıldı

            listboxHata.Items.Clear();
            listboxagirlik1Arakatman1.Items.Clear();
            listboxagirlik1Arakatman2.Items.Clear();
            listboxagirlik2Arakatman1.Items.Clear();
            listboxagirlik2Arakatman2.Items.Clear();
            listboxAgirlik1_C1.Items.Clear();
            listboxAgirlik2_C1.Items.Clear();
            listboxAgirlikE1_A1.Items.Clear();
            listboxAgirlikE1_A2.Items.Clear();
            listboxAgirlikE2_C1.Items.Clear();
        }
    }
}
