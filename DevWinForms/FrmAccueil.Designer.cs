namespace DevWinForms
{
    partial class FrmAccueil
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btEntrer = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(186, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 203);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btEntrer
            // 
            this.btEntrer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEntrer.Location = new System.Drawing.Point(91, 334);
            this.btEntrer.Name = "btEntrer";
            this.btEntrer.Size = new System.Drawing.Size(142, 37);
            this.btEntrer.TabIndex = 1;
            this.btEntrer.Text = "&Accès au Forum";
            this.btEntrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEntrer.UseVisualStyleBackColor = true;
            this.btEntrer.Click += new System.EventHandler(this.btEntrer_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(474, 334);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(151, 37);
            this.btQuitter.TabIndex = 2;
            this.btQuitter.Text = "&Quitter";
            this.btQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(719, 415);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btEntrer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmAccueil";
            this.Text = "2ISA\'sDevCommunity";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btEntrer;
        private System.Windows.Forms.Button btQuitter;
    }
}

