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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Frm2 frm2 = new Frm2();
            frm2.Show();
            this.Hide();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Frm3 frm3 = new Frm3();
            frm3.Show();
            this.Hide();
        }
    }
}
