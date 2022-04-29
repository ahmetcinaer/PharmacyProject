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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FrmDoktorKaydol FrmDoktorKaydol = new FrmDoktorKaydol();
            FrmDoktorKaydol.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmDoktorMain frmDoktorMain = new FrmDoktorMain();
            frmDoktorMain.Show();
        }
    }
}
