using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dao;

namespace Projet_Colocation
{
    public partial class GererColoc : Form
    {
        public GererColoc()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void GererColoc_Load(object sender, EventArgs e)
        {
            // Crée une instance de la classe dbConnexion
            dbConnexion db = new dbConnexion();

            // Affiche les colocataires dans la liste déroulante lbColoc
           //  db.afficherColocataires(lbColoc);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {

        }

        private void lbColoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
