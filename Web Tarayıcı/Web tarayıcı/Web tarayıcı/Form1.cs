using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_tarayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void BtnAnasayfa_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.bing.com");
        }

        private void geriButonu_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack(); // tarayıcının geri gitmesini sağlar
        }

        private void İleriButonu_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void yenile_buton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Buton_ara_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar=='\r')
            {
                webBrowser1.Navigate(toolStripTextBox1.Text);
            }
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Maximum = (int)e.MaximumProgress;
            
            

            try
            {
                toolStripProgressBar1.Value = (int)e.CurrentProgress;
                durum_label.Text = webBrowser1.Url.ToString();
                this.Text = webBrowser1.DocumentTitle;
                toolStripTextBox1.Text = webBrowser1.Url.ToString();

            }
            catch (Exception)
            {

                
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(webBrowser1.DocumentText);
        }
    }
}
