using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Rota : "  + comboBox1.Text + "-" + comboBox2.Text);
            listBox1.Items.Add("Tarih : " + maskedTextBox3.Text);
            listBox1.Items.Add("Saat : " + maskedTextBox4.Text);
            listBox1.Items.Add("Yolcu /Ad Soyad : " + maskedTextBox5.Text);
            listBox1.Items.Add("Tc : " + maskedTextBox6.Text);
            listBox1.Items.Add("Telefon : " + maskedTextBox2.Text);
            MessageBox.Show("Biletiniz Alindi");


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                groupBox1.Focus();
            }
        }

        private void comboBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                maskedTextBox3.Focus();
            }
        }

        private void maskedTextBox3_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBox4.Focus();
            }
        }

        private void maskedTextBox5_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBox6.Focus();
            }
        }

        private void maskedTextBox6_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBox2.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            maskedTextBox5.Clear();
            maskedTextBox6.Clear();
            maskedTextBox2.Clear();
        }
    }
}
