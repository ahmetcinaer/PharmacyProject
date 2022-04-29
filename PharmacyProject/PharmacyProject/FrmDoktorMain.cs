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
    public partial class FrmDoktorMain : Form
    {
        public FrmDoktorMain()
        {
            InitializeComponent();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            frm10 frm10 = new frm10();
            frm10.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm9 frm9 = new frm9();
            frm9.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm5 frm5 = new frm5();
            frm5.Show();
        }
    }
    }
    

