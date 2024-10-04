using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Odev2._7OkulZilUygulamasi
{
    public partial class Form1 : Form
    {
        
        private List<string> dersSaatleri;
        private List<string> ogrenciSaatleri;
        private List<string> ogretmenSaatleri;
        private bool zilDurumuAcik; 
        private Timer kapanmaTimer;
        private SoundPlayer ses;
        private string aktifSes;
        private List<string> çalanSaatler;

        public Form1()
        {
            InitializeComponent();
            KullaniciGiris frm = new KullaniciGiris();
            frm.ShowDialog();
            string dosyaYolu = Application.StartupPath + "\\saatler.txt";
            if (File.Exists(dosyaYolu))
            {
                File.Delete(dosyaYolu);
            }
            dersSaatleri = new List<string>();
            ogrenciSaatleri = new List<string>();
            ogretmenSaatleri = new List<string>();
            kapanmaTimer = new Timer();
            kapanmaTimer.Tick += KapanmaTimer_Tick;
            timer1.Start();
            ses = new SoundPlayer();
            zilDurumuAcik = true;
            this.FormClosing += Form1_FormClosing;
            this.FormClosed += Form1_FormClosed;
            çalanSaatler = new List<string>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime simdi = DateTime.Now;
            lbl_saat.Text = simdi.ToString("HH:mm:ss");

            if (!zilDurumuAcik) return;

            string currentTime = simdi.ToString("HH:mm");

            List<string> tumSaatler = new List<string>();
            tumSaatler.AddRange(dersSaatleri);
            tumSaatler.AddRange(ogrenciSaatleri);
            tumSaatler.AddRange(ogretmenSaatleri);

            string dosyaYolu = Application.StartupPath + "\\saatler.txt";
            if (File.Exists(dosyaYolu))
            {
                string[] saatler = File.ReadAllLines(dosyaYolu);
                tumSaatler.AddRange(saatler);
            }

            if (tumSaatler.Contains(currentTime) && !çalanSaatler.Contains(currentTime))
            {
                PlaySound("meb_okul_zili.wav");
                çalanSaatler.Add(currentTime);
            }
            else if (!tumSaatler.Contains(currentTime))
            {
                çalanSaatler.Remove(currentTime);
            }
        }

        private void PlaySound(string soundFileName)
        {
            aktifSes = soundFileName;
            string dizin = Application.StartupPath + "\\" + soundFileName;
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void btn_istiklalmarsi_Click(object sender, EventArgs e)
        {
            PlaySound("istiklalmarsi.wav");
        }

        private void btn_saygidurusu_Click(object sender, EventArgs e)
        {
            PlaySound("saygidurusu.wav");
        }

        private void btn_marsvedurus_Click(object sender, EventArgs e)
        {
            PlaySound("sirenveistiklalmarsi.wav");
        }

        private void btn_siren_Click(object sender, EventArgs e)
        {
            PlaySound("siren.wav");
        }

        private void btn_ogrencizil_Click(object sender, EventArgs e)
        {
            PlaySound("meb_okul_zili.wav");
        }

        private void btn_ogretmenzil_Click(object sender, EventArgs e)
        {
            PlaySound("meb_okul_zili.wav");
        }

        private void btn_derscikis_Click(object sender, EventArgs e)
        {
            PlaySound("meb_okul_zili.wav");
        }

        private void btn_durdur_Click(object sender, EventArgs e)
        {
            ses.Stop();
        }

        private void btn_devamet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(aktifSes))
            {
                PlaySound(aktifSes);
            }
        }
        private void KaydetSaatler()
        {
            string dosyaYolu = Application.StartupPath + "\\saatler.txt";

            using (StreamWriter writer = new StreamWriter(dosyaYolu))
            {
                writer.WriteLine("Öğrenci Saatleri:");
                foreach (string saat in ogrenciSaatleri)
                {
                    writer.WriteLine(saat);
                }

                writer.WriteLine("Öğretmen Saatleri:");
                foreach (string saat in ogretmenSaatleri) 
                {
                    writer.WriteLine(saat);
                }

                writer.WriteLine("Ders Çıkış Saatleri:");
                foreach (string saat in dersSaatleri) 
                {
                    writer.WriteLine(saat);
                }
            }
        }
        

        private void btn_derskaydet_Click(object sender, EventArgs e)
        {
            ogrenciSaatleri.Clear();
            ogrenciSaatleri.Add(mtb_ogrenci1.Text);
            ogrenciSaatleri.Add(mtb_ogrenci2.Text);
            ogrenciSaatleri.Add(mtb_ogrenci3.Text);
            ogrenciSaatleri.Add(mtb_ogrenci4.Text);
            ogrenciSaatleri.Add(mtb_ogrenci5.Text);
            ogrenciSaatleri.Add(mtb_ogrenci6.Text);
            ogrenciSaatleri.Add(mtb_ogrenci7.Text);
            ogrenciSaatleri.Add(mtb_ogrenci8.Text);

            ogretmenSaatleri.Clear();
            ogretmenSaatleri.Add(mtb_ogretmen1.Text);
            ogretmenSaatleri.Add(mtb_ogretmen2.Text);
            ogretmenSaatleri.Add(mtb_ogretmen3.Text);
            ogretmenSaatleri.Add(mtb_ogretmen4.Text);
            ogretmenSaatleri.Add(mtb_ogretmen5.Text);
            ogretmenSaatleri.Add(mtb_ogretmen6.Text);
            ogretmenSaatleri.Add(mtb_ogretmen7.Text);
            ogretmenSaatleri.Add(mtb_ogretmen8.Text);

            dersSaatleri.Clear();
            dersSaatleri.Add(mtb_ders1.Text);
            dersSaatleri.Add(mtb_ders2.Text);
            dersSaatleri.Add(mtb_ders3.Text);
            dersSaatleri.Add(mtb_ders4.Text);
            dersSaatleri.Add(mtb_ders5.Text);
            dersSaatleri.Add(mtb_ders6.Text);
            dersSaatleri.Add(mtb_ders7.Text);
            dersSaatleri.Add(mtb_ders8.Text);

            KaydetSaatler();

            MessageBox.Show("Öğrenci Giriş, Öğretmen Giriş, Ders Çıkış saatleri kaydedildi: \n" +
                            "Öğrenci Giriş Saatleri: " + string.Join(", ", ogrenciSaatleri) + "\n" +
                            "Öğretmen Giriş Saatleri: " + string.Join(", ", ogretmenSaatleri) + "\n" +
                            "Ders Çıkış Saatleri: " + string.Join(", ", dersSaatleri));
        }
        private void btn_acik_Click(object sender, EventArgs e)
        {
            zilDurumuAcik = true;
            MessageBox.Show("Zil durumu: AÇIK\n\nZilin çalması için belirlenen saatleri kontrol ediniz.", "Zil Durumu Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_kapali_Click(object sender, EventArgs e)
        {
            zilDurumuAcik = false;
            MessageBox.Show("Zil durumu: KAPALI\n\nZil çalmayacaktır.", "Zil Durumu Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (TimeSpan.TryParse(mtb_kapat.Text, out TimeSpan zaman))
            {
                DateTime kapanmaZamani = DateTime.Today.Add(zaman);

                if (kapanmaZamani < DateTime.Now)
                {
                    kapanmaZamani = kapanmaZamani.AddDays(1);
                }

                TimeSpan beklemeSüresi = kapanmaZamani - DateTime.Now;

                kapanmaTimer.Interval = (int)beklemeSüresi.TotalMilliseconds;
                kapanmaTimer.Start();

                MessageBox.Show("Uygulama " + kapanmaZamani.ToString("HH:mm") + " tarihinde kapanacaktır.",
                                "Kapanma Zamanı Belirlendi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir saat girin (HH:mm) formatında.");
            }
        }
        private void KapanmaTimer_Tick(object sender, EventArgs e)
        {
            kapanmaTimer.Stop();
            Application.Exit();
        }

        private void TSMI_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış Yapmak İstiyor musun?", "Çıkış Onay", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ses.Stop();
            ses.Dispose();
            Application.Exit();
        }
    }
}



