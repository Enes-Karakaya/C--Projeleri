using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace müzikçalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Media.SoundPlayer media = new System.Media.SoundPlayer();

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Aç...";
            openFileDialog1.Filter = "müzik dosyası(*.wav)|*.wav|Tüm Dosyalar(*.*)|*.*";
            if(openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        string dosyakonumu;
        private void button1_Click(object sender, EventArgs e)
        {
            dosyakonumu = @textBox1.Text;
            media.SoundLocation = dosyakonumu;
            media.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            media.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            media.PlayLooping();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            media.Stream = Properties.müzikler.LYNC_onhold;
            media.Play();
        }
    }
}
