﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entreprise.WinForm_02
{
    public partial class FrmList : Form
    {
        Societe _societe = Societe.CreerSociete();

        public FrmList()
        {
            InitializeComponent();

            ListView.View = View.List; // Permet de mettre les éléments les uns en dessous des autres.

            foreach (Travailleur item in Societe.CreerSociete())
            {
                ListView.Items.Add(string.Format("{00}", item.Id.ToString()) + ' ' + item.Nom + ' ' + item.Prenom + ' ' + item.Age.ToString() + ' ' + item.Salaire().ToString() + " " + item.Email);
            }

        }
    }
}
