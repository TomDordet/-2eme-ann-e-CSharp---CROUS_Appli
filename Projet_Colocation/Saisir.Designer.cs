
namespace Projet_Colocation {
    partial class Saisir {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saisir));
            this.txtBoxDescriptif = new System.Windows.Forms.TextBox();
            this.txtBoxFichier = new System.Windows.Forms.TextBox();
            this.lbDescriptif = new System.Windows.Forms.Label();
            this.od_ouvrir = new System.Windows.Forms.OpenFileDialog();
            this.btnexplFich = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lbMontant = new System.Windows.Forms.Label();
            this.txtBoxMontant = new System.Windows.Forms.TextBox();
            this.lbNomColoc = new System.Windows.Forms.Label();
            this.txtBoxNomColoc = new System.Windows.Forms.TextBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.Calendrier = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxDescriptif
            // 
            this.txtBoxDescriptif.Location = new System.Drawing.Point(308, 63);
            this.txtBoxDescriptif.Name = "txtBoxDescriptif";
            this.txtBoxDescriptif.Size = new System.Drawing.Size(145, 20);
            this.txtBoxDescriptif.TabIndex = 0;
            this.txtBoxDescriptif.TextChanged += new System.EventHandler(this.txtBoxDescriptif_TextChanged);
            // 
            // txtBoxFichier
            // 
            this.txtBoxFichier.Location = new System.Drawing.Point(308, 145);
            this.txtBoxFichier.Name = "txtBoxFichier";
            this.txtBoxFichier.Size = new System.Drawing.Size(145, 20);
            this.txtBoxFichier.TabIndex = 1;
            this.txtBoxFichier.TextChanged += new System.EventHandler(this.txtBoxFichier_TextChanged);
            // 
            // lbDescriptif
            // 
            this.lbDescriptif.AutoSize = true;
            this.lbDescriptif.Location = new System.Drawing.Point(245, 63);
            this.lbDescriptif.Name = "lbDescriptif";
            this.lbDescriptif.Size = new System.Drawing.Size(57, 13);
            this.lbDescriptif.TabIndex = 2;
            this.lbDescriptif.Text = "Descriptif :";
            this.lbDescriptif.Click += new System.EventHandler(this.lbDescriptif_Click);
            // 
            // od_ouvrir
            // 
            this.od_ouvrir.FileName = "openFileDialog1";
            this.od_ouvrir.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnexplFich
            // 
            this.btnexplFich.Location = new System.Drawing.Point(157, 142);
            this.btnexplFich.Name = "btnexplFich";
            this.btnexplFich.Size = new System.Drawing.Size(145, 25);
            this.btnexplFich.TabIndex = 3;
            this.btnexplFich.Text = "Selectionner un fichier";
            this.btnexplFich.UseVisualStyleBackColor = true;
            this.btnexplFich.Click += new System.EventHandler(this.btnexplFich_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(141, 37);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(106, 13);
            this.lbDate.TabIndex = 5;
            this.lbDate.Text = "Date de la dépense :";
            this.lbDate.Click += new System.EventHandler(this.lbDate_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(383, 228);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 25);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(283, 228);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(100, 25);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 228);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(100, 25);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lbMontant
            // 
            this.lbMontant.AutoSize = true;
            this.lbMontant.Location = new System.Drawing.Point(250, 89);
            this.lbMontant.Name = "lbMontant";
            this.lbMontant.Size = new System.Drawing.Size(52, 13);
            this.lbMontant.TabIndex = 10;
            this.lbMontant.Text = "Montant :";
            this.lbMontant.Click += new System.EventHandler(this.lbMontant_Click);
            // 
            // txtBoxMontant
            // 
            this.txtBoxMontant.Location = new System.Drawing.Point(308, 89);
            this.txtBoxMontant.Name = "txtBoxMontant";
            this.txtBoxMontant.Size = new System.Drawing.Size(145, 20);
            this.txtBoxMontant.TabIndex = 9;
            this.txtBoxMontant.TextChanged += new System.EventHandler(this.txtBoxMontant_TextChanged);
            // 
            // lbNomColoc
            // 
            this.lbNomColoc.AutoSize = true;
            this.lbNomColoc.Location = new System.Drawing.Point(197, 115);
            this.lbNomColoc.Name = "lbNomColoc";
            this.lbNomColoc.Size = new System.Drawing.Size(105, 13);
            this.lbNomColoc.TabIndex = 12;
            this.lbNomColoc.Text = "Nom du colocataire :";
            this.lbNomColoc.Click += new System.EventHandler(this.lbNomColoc_Click);
            // 
            // txtBoxNomColoc
            // 
            this.txtBoxNomColoc.Location = new System.Drawing.Point(308, 115);
            this.txtBoxNomColoc.Name = "txtBoxNomColoc";
            this.txtBoxNomColoc.Size = new System.Drawing.Size(145, 20);
            this.txtBoxNomColoc.TabIndex = 11;
            this.txtBoxNomColoc.TextChanged += new System.EventHandler(this.txtBoxNomColoc_TextChanged);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.picBoxLogo.TabIndex = 13;
            this.picBoxLogo.TabStop = false;
            this.picBoxLogo.Click += new System.EventHandler(this.picBoxLogo_Click);
            // 
            // Calendrier
            // 
            this.Calendrier.Location = new System.Drawing.Point(253, 37);
            this.Calendrier.Name = "Calendrier";
            this.Calendrier.Size = new System.Drawing.Size(200, 20);
            this.Calendrier.TabIndex = 14;
            this.Calendrier.ValueChanged += new System.EventHandler(this.Calendrier_ValueChanged);
            // 
            // Saisir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.Calendrier);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.lbNomColoc);
            this.Controls.Add(this.txtBoxNomColoc);
            this.Controls.Add(this.lbMontant);
            this.Controls.Add(this.txtBoxMontant);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.btnexplFich);
            this.Controls.Add(this.lbDescriptif);
            this.Controls.Add(this.txtBoxFichier);
            this.Controls.Add(this.txtBoxDescriptif);
            this.Name = "Saisir";
            this.Text = "Saisir une dépense";
            this.Load += new System.EventHandler(this.Saisir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxDescriptif;
        private System.Windows.Forms.TextBox txtBoxFichier;
        private System.Windows.Forms.Label lbDescriptif;
        private System.Windows.Forms.OpenFileDialog od_ouvrir;
        private System.Windows.Forms.Button btnexplFich;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lbMontant;
        private System.Windows.Forms.TextBox txtBoxMontant;
        private System.Windows.Forms.Label lbNomColoc;
        private System.Windows.Forms.TextBox txtBoxNomColoc;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.DateTimePicker Calendrier;
    }
}