﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilet_programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(textBox3.Text);
        }

        private void Kaydet_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + " " +
                textBox2.Text + maskedTextBox1.Text + " " +
                dateTimePicker1.Text + " " + maskedTextBox2.Text
                + comboBox1.Text + "dan " + comboBox2.Text + "'ya");
        }
    }
}
