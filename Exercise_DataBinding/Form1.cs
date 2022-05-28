using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_DataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Naufal" && textBox2.Text == "123" && checkBox1.Checked)
            {
                new Form3().Show();
                this.Hide();
            }
            else if (textBox1.Text == "Naufal" && textBox2.Text == "123")
            {
                MessageBox.Show("Centang Terlebih Dahulu!");
            }
            else
            {
                MessageBox.Show("Pastikan Username dan Password yang Anda Masukkan Benar!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
