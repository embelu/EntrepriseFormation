using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Entreprise.ASP
{
    public partial class WebFormEntreprise : System.Web.UI.Page
    {
        private Societe societe = new Societe();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TBoxMatricule.Text = "Matricule";
            }
        }

        protected void BtnEnvoyer_Click(object sender, EventArgs e)
        {
            LblMatricule.Text = TBoxMatricule.Text;
        }

        protected void TBoxMatricule_TextChanged(object sender, EventArgs e)
        {
            societe.Matricule = Int32.Parse(TBoxMatricule.Text);
        }
    }
}