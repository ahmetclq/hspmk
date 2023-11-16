using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hspmkns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayı1,sayı2, sonuc;
        string ıslem;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";

            label1.Text += 1;
           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";

            label1.Text += 2;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";

            label1.Text += 3;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";

            label1.Text += 4;
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";

            label1.Text += 5;
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";

            label1.Text += 6;
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";

            label1.Text += 7;
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";

            label1.Text += 8;
        }

        private void bunifuThinButton213_Click(object sender, EventArgs e)
        {
            ıslem = "+";
            label2.Text = label1.Text;
            label1.Text = "0";
           
            
        }

        private void bunifuThinButton214_Click(object sender, EventArgs e)
        {
            ıslem = "-";
            label2.Text = label1.Text;
            label1.Text = "0";
            

        }

        private void bunifuThinButton215_Click(object sender, EventArgs e)
        {
            ıslem = "*";
            label2.Text = label1.Text;
            label1.Text = "0";
           

        }


        private void bunifuThinButton212_Click(object sender, EventArgs e)
        {
            label3.Text = label1.Text;
            sayı1 = Convert.ToInt32(label2.Text);
            sayı2 = Convert.ToInt32(label3.Text);

            {
                if (ıslem == "+")label1.Text=(sayı1+sayı2).ToString();
                if (ıslem == "-") label1.Text = (sayı1 - sayı2).ToString();
                if (ıslem == "*") label1.Text = (sayı1 * sayı2).ToString();
                if (ıslem == "/") label1.Text = (sayı1 / sayı2).ToString();
            



            }
        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void bunifuThinButton216_Click(object sender, EventArgs e)
        {
            ıslem = "/";
            label2.Text = label1.Text;
            label1.Text = "0";
           
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") label1.Text = "";

            label1.Text += 9;
        }
    }
}
