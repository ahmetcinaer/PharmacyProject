using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyProject
{
    public partial class Frm3 : Form
    {
        public Frm3()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frm4 frm4 = new frm4();
            frm4.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm5 frm5 = new frm5();
            frm5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm6 frm6 = new frm6();
            frm6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm7 frm7 = new frm7();
            frm7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm8 frm8 = new frm8();
            frm8.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm9 frm9 = new frm9();
            frm9.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm10 frm10 = new frm10();
            frm10.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm11 frm11 = new frm11();
            frm11.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frm12 frm12 = new frm12();
            frm12.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //frm13 frm13 = new frm13();
            //frm13.Show();
            System.Diagnostics.Process.Start("https://medeczane.sgk.gov.tr/eczane/login.jsp"); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frm13 frm13 = new frm13();
            frm13.Show();
        }
    }
}
