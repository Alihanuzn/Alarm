using System;
using System.Windows.Forms;
using System.Media;

namespace Alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer ses = new SoundPlayer("ses.wav");
        int ertelemesuresi = 0;




        private void Form1_Load(object sender, EventArgs e)
        {
            lblGuncelZaman.Text = DateTime.Now.ToLongTimeString();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblGuncelZaman.Text = DateTime.Now.ToLongTimeString();
            if (lblGuncelZaman.Text==txtAlarmZamani.Text)
            {
                ses.Play();
            }
        }

        private void btnAlarmKur_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime zaman = Convert.ToDateTime(txtAlarmZamani.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli Zaman Giriniz");
                txtAlarmZamani.Focus();
                txtAlarmZamani.SelectAll();
                return;
            }
        }

        private void btnAlarmErteleme_Click(object sender, EventArgs e)
        {
            ertelemesuresi = 5;
            timer2.Enabled = true;
            label2.Text = ertelemesuresi.ToString() + " Saniye Sonra Alarm Çalacak";
            ses.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            while (ertelemesuresi==0)
            {
                ses.Play();
                timer1.Enabled = true;
                timer2.Enabled = false;
                label2.Text = "Kalkma Vakti!!!";
                return;
            }
            ertelemesuresi--;
            label2.Text = ertelemesuresi.ToString() + " Saniye Sonra Alarm Çalacak";
        }

        private void btnAlarmDurdur_Click(object sender, EventArgs e)
        {
            ses.Stop();
            timer2.Stop();
            label2.Text = "";
        }
    }
}
