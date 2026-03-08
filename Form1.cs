using System;
using System.Windows.Forms;

namespace TP_MODUL3_103022400070
{
    public partial class Form1 : Form
    {
        double total = 0;
        bool tambahAktif = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // ===== Tombol Angka =====

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "0";
        }

        // ===== Tombol + =====

        private void button12_Click(object sender, EventArgs e)
        {
            total += Convert.ToDouble(label1.Text);
            label1.Text = "0";
            tambahAktif = true;
        }

        // ===== Tombol = =====

        private void button11_Click(object sender, EventArgs e)
        {
            if (tambahAktif)
            {
                total += Convert.ToDouble(label1.Text);
                label1.Text = total.ToString();
                total = 0;
                tambahAktif = false;
            }
        }


    }
}