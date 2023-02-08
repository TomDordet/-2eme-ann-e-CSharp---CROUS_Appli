
namespace Projet_Colocation
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnConsulter = new System.Windows.Forms.Button();
            this.btnSaisir = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.Label();
            this.btnGererColoc = new System.Windows.Forms.Button();
            this.lbDepense = new System.Windows.Forms.Label();
            this.lbColoc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 8;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(156, 188);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(150, 25);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier une dépense";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(156, 224);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(150, 25);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer une dépense";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnConsulter
            // 
            this.btnConsulter.Location = new System.Drawing.Point(156, 116);
            this.btnConsulter.Name = "btnConsulter";
            this.btnConsulter.Size = new System.Drawing.Size(150, 25);
            this.btnConsulter.TabIndex = 5;
            this.btnConsulter.Text = "Consulter une dépense";
            this.btnConsulter.UseVisualStyleBackColor = true;
            this.btnConsulter.Click += new System.EventHandler(this.btnConsulter_Click);
            // 
            // btnSaisir
            // 
            this.btnSaisir.Location = new System.Drawing.Point(156, 152);
            this.btnSaisir.Name = "btnSaisir";
            this.btnSaisir.Size = new System.Drawing.Size(150, 25);
            this.btnSaisir.TabIndex = 6;
            this.btnSaisir.Text = "Saisir une dépense";
            this.btnSaisir.UseVisualStyleBackColor = true;
            this.btnSaisir.Click += new System.EventHandler(this.btnSaisir_Click);
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Location = new System.Drawing.Point(231, 12);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(107, 13);
            this.lbMenu.TabIndex = 7;
            this.lbMenu.Text = "Menu de l\'application";
            this.lbMenu.Click += new System.EventHandler(this.lbMenu_Click);
            // 
            // btnGererColoc
            // 
            this.btnGererColoc.Location = new System.Drawing.Point(322, 169);
            this.btnGererColoc.Name = "btnGererColoc";
            this.btnGererColoc.Size = new System.Drawing.Size(150, 25);
            this.btnGererColoc.TabIndex = 16;
            this.btnGererColoc.Text = "Gérer les colocataires";
            this.btnGererColoc.UseVisualStyleBackColor = true;
            this.btnGererColoc.Click += new System.EventHandler(this.btnGererColoc_Click);
            // 
            // lbDepense
            // 
            this.lbDepense.AutoSize = true;
            this.lbDepense.Location = new System.Drawing.Point(153, 87);
            this.lbDepense.Name = "lbDepense";
            this.lbDepense.Size = new System.Drawing.Size(98, 13);
            this.lbDepense.TabIndex = 17;
            this.lbDepense.Text = "Espace dépenses :";
            this.lbDepense.Click += new System.EventHandler(this.lbDepense_Click);
            // 
            // lbColoc
            // 
            this.lbColoc.AutoSize = true;
            this.lbColoc.Location = new System.Drawing.Point(319, 87);
            this.lbColoc.Name = "lbColoc";
            this.lbColoc.Size = new System.Drawing.Size(109, 13);
            this.lbColoc.TabIndex = 18;
            this.lbColoc.Text = "Espace colocataires :";
            this.lbColoc.Click += new System.EventHandler(this.lbColoc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbColoc);
            this.Controls.Add(this.lbDepense);
            this.Controls.Add(this.btnGererColoc);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.btnSaisir);
            this.Controls.Add(this.btnConsulter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnConsulter;
        private System.Windows.Forms.Button btnSaisir;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Button btnGererColoc;
        private System.Windows.Forms.Label lbDepense;
        private System.Windows.Forms.Label lbColoc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

