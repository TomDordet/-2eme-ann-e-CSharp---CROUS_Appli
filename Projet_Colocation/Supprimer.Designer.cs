
namespace Projet_Colocation {
    partial class Supprimer {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supprimer));
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lBoxSupprimer = new System.Windows.Forms.ListBox();
            this.lbSupprimer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 228);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(100, 25);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(383, 228);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(94, 25);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // lBoxSupprimer
            // 
            this.lBoxSupprimer.FormattingEnabled = true;
            this.lBoxSupprimer.Location = new System.Drawing.Point(203, 50);
            this.lBoxSupprimer.Name = "lBoxSupprimer";
            this.lBoxSupprimer.Size = new System.Drawing.Size(175, 147);
            this.lBoxSupprimer.TabIndex = 15;
            this.lBoxSupprimer.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbSupprimer
            // 
            this.lbSupprimer.AutoSize = true;
            this.lbSupprimer.Location = new System.Drawing.Point(200, 25);
            this.lbSupprimer.Name = "lbSupprimer";
            this.lbSupprimer.Size = new System.Drawing.Size(162, 13);
            this.lbSupprimer.TabIndex = 16;
            this.lbSupprimer.Text = "Veuillez supprimer une dépense :";
            this.lbSupprimer.Click += new System.EventHandler(this.lbSupprimer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Supprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbSupprimer);
            this.Controls.Add(this.lBoxSupprimer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnMenu);
            this.Name = "Supprimer";
            this.Text = "Supprimer une dépense";
            this.Load += new System.EventHandler(this.Supprimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ListBox lBoxSupprimer;
        private System.Windows.Forms.Label lbSupprimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}