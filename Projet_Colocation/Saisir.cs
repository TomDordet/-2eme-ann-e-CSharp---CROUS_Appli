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
using Model;

namespace Projet_Colocation {
    public partial class Saisir:Form {
        public Saisir() {
            InitializeComponent();
        }

        private void lbDescriptif_Click(object sender,EventArgs e) {

        }

        private void openFileDialog1_FileOk(object sender,CancelEventArgs e) {

        }

        private void lbDate_Click(object sender,EventArgs e) {

        }

        private void Saisir_Load(object sender,EventArgs e) {

        }

        private void btnMenu_Click(object sender,EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender,EventArgs e) {
            foreach(Control c in this.Controls) {
                if(c is TextBox) {
                    c.Text=String.Empty;
                }
            }
        }

        private void picBoxLogo_Click(object sender,EventArgs e) {

        }

        private void lbMontant_Click(object sender,EventArgs e) {

        }

        private void lbNomColoc_Click(object sender,EventArgs e) {

        }

        private void btnexplFich_Click(object sender,EventArgs e) {

        }

        private void Calendrier_ValueChanged(object sender,EventArgs e) {

        }

        private void txtBoxDescriptif_TextChanged(object sender,EventArgs e) {

        }

        private void txtBoxMontant_TextChanged(object sender,EventArgs e) {

        }

        private void txtBoxNomColoc_TextChanged(object sender,EventArgs e) {

        }

        private void txtBoxFichier_TextChanged(object sender,EventArgs e) {

        }

        private void btnValider_Click(object sender,EventArgs e) {
            
        }
    }
}
