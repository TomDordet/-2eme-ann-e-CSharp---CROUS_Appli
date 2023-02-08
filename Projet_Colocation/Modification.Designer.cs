
namespace Projet_Colocation {
    partial class Modification {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modification));
            this.lbDate = new System.Windows.Forms.Label();
            this.Calendrier = new System.Windows.Forms.DateTimePicker();
            this.lbDescriptif = new System.Windows.Forms.Label();
            this.txtBoxDescriptif = new System.Windows.Forms.TextBox();
            this.lbMontant = new System.Windows.Forms.Label();
            this.txtBoxMontant = new System.Windows.Forms.TextBox();
            this.lbNomColoc = new System.Windows.Forms.Label();
            this.txtBoxNomColoc = new System.Windows.Forms.TextBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.txtBoxFichier = new System.Windows.Forms.TextBox();
            this.btn_explFich = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(141, 37);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(106, 13);
            this.lbDate.TabIndex = 6;
            this.lbDate.Text = "Date de la dépense :";
            this.lbDate.Click += new System.EventHandler(this.lbDate_Click);
            // 
            // Calendrier
            // 
            this.Calendrier.Location = new System.Drawing.Point(253, 37);
            this.Calendrier.Name = "Calendrier";
            this.Calendrier.Size = new System.Drawing.Size(200, 20);
            this.Calendrier.TabIndex = 15;
            this.Calendrier.ValueChanged += new System.EventHandler(this.Calendrier_ValueChanged);
            // 
            // lbDescriptif
            // 
            this.lbDescriptif.AutoSize = true;
            this.lbDescriptif.Location = new System.Drawing.Point(245, 63);
            this.lbDescriptif.Name = "lbDescriptif";
            this.lbDescriptif.Size = new System.Drawing.Size(57, 13);
            this.lbDescriptif.TabIndex = 16;
            this.lbDescriptif.Text = "Descriptif :";
            this.lbDescriptif.Click += new System.EventHandler(this.lbDescriptif_Click);
            // 
            // txtBoxDescriptif
            // 
            this.txtBoxDescriptif.Location = new System.Drawing.Point(308, 63);
            this.txtBoxDescriptif.Name = "txtBoxDescriptif";
            this.txtBoxDescriptif.Size = new System.Drawing.Size(145, 20);
            this.txtBoxDescriptif.TabIndex = 17;
            this.txtBoxDescriptif.TextChanged += new System.EventHandler(this.txtBoxDescriptif_TextChanged);
            // 
            // lbMontant
            // 
            this.lbMontant.AutoSize = true;
            this.lbMontant.Location = new System.Drawing.Point(250, 89);
            this.lbMontant.Name = "lbMontant";
            this.lbMontant.Size = new System.Drawing.Size(52, 13);
            this.lbMontant.TabIndex = 18;
            this.lbMontant.Text = "Montant :";
            this.lbMontant.Click += new System.EventHandler(this.lbMontant_Click);
            // 
            // txtBoxMontant
            // 
            this.txtBoxMontant.Location = new System.Drawing.Point(308, 89);
            this.txtBoxMontant.Name = "txtBoxMontant";
            this.txtBoxMontant.Size = new System.Drawing.Size(145, 20);
            this.txtBoxMontant.TabIndex = 19;
            this.txtBoxMontant.TextChanged += new System.EventHandler(this.txtBoxMontant_TextChanged);
            // 
            // lbNomColoc
            // 
            this.lbNomColoc.AutoSize = true;
            this.lbNomColoc.Location = new System.Drawing.Point(197, 115);
            this.lbNomColoc.Name = "lbNomColoc";
            this.lbNomColoc.Size = new System.Drawing.Size(105, 13);
            this.lbNomColoc.TabIndex = 20;
            this.lbNomColoc.Text = "Nom du colocataire :";
            this.lbNomColoc.Click += new System.EventHandler(this.lbNomColoc_Click);
            // 
            // txtBoxNomColoc
            // 
            this.txtBoxNomColoc.Location = new System.Drawing.Point(308, 115);
            this.txtBoxNomColoc.Name = "txtBoxNomColoc";
            this.txtBoxNomColoc.Size = new System.Drawing.Size(145, 20);
            this.txtBoxNomColoc.TabIndex = 21;
            this.txtBoxNomColoc.TextChanged += new System.EventHandler(this.txtBoxNomColoc_TextChanged);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.picBoxLogo.TabIndex = 22;
            this.picBoxLogo.TabStop = false;
            this.picBoxLogo.Click += new System.EventHandler(this.picBoxLogo_Click);
            // 
            // txtBoxFichier
            // 
            this.txtBoxFichier.Location = new System.Drawing.Point(308, 145);
            this.txtBoxFichier.Name = "txtBoxFichier";
            this.txtBoxFichier.Size = new System.Drawing.Size(145, 20);
            this.txtBoxFichier.TabIndex = 23;
            this.txtBoxFichier.TextChanged += new System.EventHandler(this.txtBoxFichier_TextChanged);
            // 
            // btn_explFich
            // 
            this.btn_explFich.Location = new System.Drawing.Point(157, 142);
            this.btn_explFich.Name = "btn_explFich";
            this.btn_explFich.Size = new System.Drawing.Size(145, 25);
            this.btn_explFich.TabIndex = 24;
            this.btn_explFich.Text = "Selectionner un fichier";
            this.btn_explFich.UseVisualStyleBackColor = true;
            this.btn_explFich.Click += new System.EventHandler(this.btn_explFich_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 228);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(100, 25);
            this.btnMenu.TabIndex = 25;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(283, 228);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(94, 25);
            this.btnValider.TabIndex = 26;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(383, 228);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(94, 25);
            this.btnAnnuler.TabIndex = 27;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // Modification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btn_explFich);
            this.Controls.Add(this.txtBoxFichier);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.txtBoxNomColoc);
            this.Controls.Add(this.lbNomColoc);
            this.Controls.Add(this.txtBoxMontant);
            this.Controls.Add(this.lbMontant);
            this.Controls.Add(this.txtBoxDescriptif);
            this.Controls.Add(this.lbDescriptif);
            this.Controls.Add(this.Calendrier);
            this.Controls.Add(this.lbDate);
            this.Name = "Modification";
            this.Text = "Modification de la dépense";
            this.Load += new System.EventHandler(this.Modification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DateTimePicker Calendrier;
        private System.Windows.Forms.Label lbDescriptif;
        private System.Windows.Forms.TextBox txtBoxDescriptif;
        private System.Windows.Forms.Label lbMontant;
        private System.Windows.Forms.TextBox txtBoxMontant;
        private System.Windows.Forms.Label lbNomColoc;
        private System.Windows.Forms.TextBox txtBoxNomColoc;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.TextBox txtBoxFichier;
        private System.Windows.Forms.Button btn_explFich;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}