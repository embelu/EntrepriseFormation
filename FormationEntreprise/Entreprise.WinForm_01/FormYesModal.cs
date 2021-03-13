using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entreprise.WinForm_01
{
    public partial class FormYesModal : Form
    {
        public FormYesModal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
        }
    }
}
