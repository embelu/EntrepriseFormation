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
    public partial class FormMdi : Form
    {
        public FormMdi()
        {
            InitializeComponent();
            this.IsMdiContainer = true;  // Pour la rendre MDI
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void modalNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNoModal formEntreprise = new FormNoModal();
            formEntreprise.MdiParent = this;
            formEntreprise.WindowState = FormWindowState.Maximized;
            formEntreprise.Show();
        }

        private void modalYesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYesModal formModal = new FormYesModal();
            formModal.ShowDialog();
        }
    }
}
