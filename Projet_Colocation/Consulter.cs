using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Model;
using Dao;

namespace Projet_Colocation {
    public partial class Consulter:Form {
        public Consulter() {
            InitializeComponent();
            dbConnexion cnx = new dbConnexion();
        }

        private void lBoxConsulter_SelectedIndexChanged(object sender,EventArgs e) {

        }

        private void picBoxLogo_Click(object sender,EventArgs e) {

        }

        private void btnMenu_Click(object sender,EventArgs e) {
            this.Close();
        }

        private void lbModifier_Click(object sender,EventArgs e) {

        }

        private void btnValider_Click(object sender,EventArgs e) {

        }

        private void btnAnnuler_Click(object sender,EventArgs e) {

        }

        private void Consulter_Load(object sender,EventArgs e) {

        }

        private void label1_Click(object sender,EventArgs e) {

        }

        private void listBox1_SelectedIndexChanged(object sender,EventArgs e) {
            
        }

        private void label2_Click(object sender,EventArgs e) {

        }

        private void lb_Depense_SelectedIndexChanged(object sender,EventArgs e) {
            foreach(Depense D in new DaoDepense().GetAll()) {
                lb_Depense.Items.Add(D);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender,EventArgs e) {
            label4.Text = comboBox1.Text;
        }

        private void button1_Click(object sender,EventArgs e) {
            lb_Depense.Items.Clear();
            foreach(Depense D in new DaoDepense().GetAll(comboBox1.SelectedIndex)) {
                lb_Depense.Items.Add(D);
            }
        }

        private void label4_Click(object sender,EventArgs e) {

        }

        private void label3_Click(object sender,EventArgs e) {

        }
    }
}
