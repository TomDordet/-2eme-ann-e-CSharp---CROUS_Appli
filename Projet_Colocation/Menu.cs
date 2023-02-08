using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Colocation
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void lbMenu_Click(object sender,EventArgs e) {

        }

        private void btnConsulter_Click(object sender,EventArgs e) {
            Consulter consulter = new Consulter();
            consulter.Show();
        }

        private void Menu_Load(object sender,EventArgs e) {

        }

        private void btnSaisir_Click(object sender,EventArgs e) {
            //this.Hide();
            Saisir frm2 = new Saisir();
            frm2.Show();
        }

        private void btnModifier_Click(object sender,EventArgs e) {
            Modifier modifier = new Modifier();
            modifier.Show();
        }

        private void btnSupprimer_Click(object sender,EventArgs e) {
            Supprimer supprimer = new Supprimer();
            supprimer.Show();
        }

        private void lbDepense_Click(object sender, EventArgs e)
        {

        }

        private void lbColoc_Click(object sender, EventArgs e)
        {

        }

        private void btnGererColoc_Click(object sender, EventArgs e)
        {
            GererColoc gererColoc = new GererColoc();
            gererColoc.Show();
        }
    }
}
