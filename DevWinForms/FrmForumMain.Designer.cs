namespace DevWinForms
{
    partial class FrmForumMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpFrmForumMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpgrid = new System.Windows.Forms.TableLayoutPanel();
            this.dGVReponse = new System.Windows.Forms.DataGridView();
            this.plConnexion = new System.Windows.Forms.Panel();
            this.btQuitter = new System.Windows.Forms.Button();
            this.btEditPassword = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.tlpSelection = new System.Windows.Forms.TableLayoutPanel();
            this.lblPasDeReponse = new System.Windows.Forms.Label();
            this.grbCatégorie = new System.Windows.Forms.GroupBox();
            this.cbBoxCategorie = new System.Windows.Forms.ComboBox();
            this.grBoxSujet = new System.Windows.Forms.GroupBox();
            this.plDescription = new System.Windows.Forms.Panel();
            this.lblPasDeSujet = new System.Windows.Forms.Label();
            this.grBoxDescription = new System.Windows.Forms.GroupBox();
            this.cbBoxSujet = new System.Windows.Forms.ComboBox();
            this.txtBoxDescSujet = new System.Windows.Forms.TextBox();
            this.tlpInteraction = new System.Windows.Forms.TableLayoutPanel();
            this.grBoxAjoutSujetReponse = new System.Windows.Forms.GroupBox();
            this.btAjouterSujet = new System.Windows.Forms.Button();
            this.btAjouterReponse = new System.Windows.Forms.Button();
            this.grBoxAdministration = new System.Windows.Forms.GroupBox();
            this.btEditSujet = new System.Windows.Forms.Button();
            this.btDeleteSujet = new System.Windows.Forms.Button();
            this.btDeleteReponse = new System.Windows.Forms.Button();
            this.tlpFrmForumMain.SuspendLayout();
            this.tlpgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVReponse)).BeginInit();
            this.plConnexion.SuspendLayout();
            this.tlpSelection.SuspendLayout();
            this.grbCatégorie.SuspendLayout();
            this.grBoxSujet.SuspendLayout();
            this.plDescription.SuspendLayout();
            this.grBoxDescription.SuspendLayout();
            this.tlpInteraction.SuspendLayout();
            this.grBoxAjoutSujetReponse.SuspendLayout();
            this.grBoxAdministration.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFrmForumMain
            // 
            this.tlpFrmForumMain.BackColor = System.Drawing.Color.CadetBlue;
            this.tlpFrmForumMain.ColumnCount = 1;
            this.tlpFrmForumMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.29742F));
            this.tlpFrmForumMain.Controls.Add(this.tlpgrid, 0, 2);
            this.tlpFrmForumMain.Controls.Add(this.tlpSelection, 0, 0);
            this.tlpFrmForumMain.Controls.Add(this.lblPasDeReponse, 0, 3);
            this.tlpFrmForumMain.Controls.Add(this.tlpInteraction, 0, 1);
            this.tlpFrmForumMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFrmForumMain.Location = new System.Drawing.Point(0, 0);
            this.tlpFrmForumMain.Name = "tlpFrmForumMain";
            this.tlpFrmForumMain.RowCount = 4;
            this.tlpFrmForumMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFrmForumMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFrmForumMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 387F));
            this.tlpFrmForumMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFrmForumMain.Size = new System.Drawing.Size(1115, 667);
            this.tlpFrmForumMain.TabIndex = 0;
            // 
            // tlpgrid
            // 
            this.tlpgrid.ColumnCount = 2;
            this.tlpgrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.6787F));
            this.tlpgrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.3213F));
            this.tlpgrid.Controls.Add(this.dGVReponse, 0, 0);
            this.tlpgrid.Controls.Add(this.plConnexion, 1, 0);
            this.tlpgrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpgrid.Location = new System.Drawing.Point(3, 263);
            this.tlpgrid.Name = "tlpgrid";
            this.tlpgrid.RowCount = 1;
            this.tlpgrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpgrid.Size = new System.Drawing.Size(1109, 381);
            this.tlpgrid.TabIndex = 0;
            // 
            // dGVReponse
            // 
            this.dGVReponse.AllowUserToAddRows = false;
            this.dGVReponse.AllowUserToDeleteRows = false;
            this.dGVReponse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVReponse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVReponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVReponse.Location = new System.Drawing.Point(3, 3);
            this.dGVReponse.Name = "dGVReponse";
            this.dGVReponse.ReadOnly = true;
            this.dGVReponse.Size = new System.Drawing.Size(899, 375);
            this.dGVReponse.TabIndex = 0;
            // 
            // plConnexion
            // 
            this.plConnexion.Controls.Add(this.btQuitter);
            this.plConnexion.Controls.Add(this.btEditPassword);
            this.plConnexion.Controls.Add(this.btLogout);
            this.plConnexion.Controls.Add(this.btLogin);
            this.plConnexion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plConnexion.Location = new System.Drawing.Point(908, 3);
            this.plConnexion.Name = "plConnexion";
            this.plConnexion.Size = new System.Drawing.Size(198, 375);
            this.plConnexion.TabIndex = 1;
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(41, 305);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(120, 44);
            this.btQuitter.TabIndex = 3;
            this.btQuitter.Text = "&Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btEditPassword
            // 
            this.btEditPassword.Location = new System.Drawing.Point(41, 219);
            this.btEditPassword.Name = "btEditPassword";
            this.btEditPassword.Size = new System.Drawing.Size(120, 48);
            this.btEditPassword.TabIndex = 2;
            this.btEditPassword.Text = "Modifier&MDP";
            this.btEditPassword.UseVisualStyleBackColor = true;
            this.btEditPassword.Click += new System.EventHandler(this.btEditPassword_Click);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(41, 125);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(120, 49);
            this.btLogout.TabIndex = 1;
            this.btLogout.Text = "D&éconnecter";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(41, 25);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(120, 55);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "&Se Connecter";
            this.btLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tlpSelection
            // 
            this.tlpSelection.ColumnCount = 3;
            this.tlpSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.91144F));
            this.tlpSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.08856F));
            this.tlpSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tlpSelection.Controls.Add(this.grbCatégorie, 0, 0);
            this.tlpSelection.Controls.Add(this.grBoxSujet, 1, 0);
            this.tlpSelection.Controls.Add(this.plDescription, 2, 0);
            this.tlpSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSelection.Location = new System.Drawing.Point(3, 3);
            this.tlpSelection.Name = "tlpSelection";
            this.tlpSelection.RowCount = 1;
            this.tlpSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSelection.Size = new System.Drawing.Size(1109, 124);
            this.tlpSelection.TabIndex = 1;
            // 
            // lblPasDeReponse
            // 
            this.lblPasDeReponse.AutoSize = true;
            this.lblPasDeReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasDeReponse.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPasDeReponse.Location = new System.Drawing.Point(3, 647);
            this.lblPasDeReponse.Name = "lblPasDeReponse";
            this.lblPasDeReponse.Size = new System.Drawing.Size(438, 18);
            this.lblPasDeReponse.TabIndex = 2;
            this.lblPasDeReponse.Text = "Désolé ! le sujet séléctionné, ne contient aucune réponse";
            // 
            // grbCatégorie
            // 
            this.grbCatégorie.Controls.Add(this.cbBoxCategorie);
            this.grbCatégorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbCatégorie.Location = new System.Drawing.Point(3, 3);
            this.grbCatégorie.Name = "grbCatégorie";
            this.grbCatégorie.Size = new System.Drawing.Size(235, 118);
            this.grbCatégorie.TabIndex = 0;
            this.grbCatégorie.TabStop = false;
            this.grbCatégorie.Text = "Choix Catégorie";
            // 
            // cbBoxCategorie
            // 
            this.cbBoxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxCategorie.FormattingEnabled = true;
            this.cbBoxCategorie.Location = new System.Drawing.Point(6, 30);
            this.cbBoxCategorie.Name = "cbBoxCategorie";
            this.cbBoxCategorie.Size = new System.Drawing.Size(220, 21);
            this.cbBoxCategorie.TabIndex = 0;
            this.cbBoxCategorie.SelectedIndexChanged += new System.EventHandler(this.cbBoxCategorie_SelectedIndexChanged);
            // 
            // grBoxSujet
            // 
            this.grBoxSujet.Controls.Add(this.cbBoxSujet);
            this.grBoxSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBoxSujet.Location = new System.Drawing.Point(244, 3);
            this.grBoxSujet.Name = "grBoxSujet";
            this.grBoxSujet.Size = new System.Drawing.Size(301, 118);
            this.grBoxSujet.TabIndex = 1;
            this.grBoxSujet.TabStop = false;
            this.grBoxSujet.Text = "Choix Sujet";
            // 
            // plDescription
            // 
            this.plDescription.Controls.Add(this.grBoxDescription);
            this.plDescription.Controls.Add(this.lblPasDeSujet);
            this.plDescription.Location = new System.Drawing.Point(551, 3);
            this.plDescription.Name = "plDescription";
            this.plDescription.Size = new System.Drawing.Size(555, 118);
            this.plDescription.TabIndex = 2;
            // 
            // lblPasDeSujet
            // 
            this.lblPasDeSujet.AutoSize = true;
            this.lblPasDeSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasDeSujet.ForeColor = System.Drawing.Color.Red;
            this.lblPasDeSujet.Location = new System.Drawing.Point(8, 100);
            this.lblPasDeSujet.Name = "lblPasDeSujet";
            this.lblPasDeSujet.Size = new System.Drawing.Size(355, 18);
            this.lblPasDeSujet.TabIndex = 0;
            this.lblPasDeSujet.Text = "Désolé ! La Categorie, ne contient aucun sujet";
            // 
            // grBoxDescription
            // 
            this.grBoxDescription.Controls.Add(this.txtBoxDescSujet);
            this.grBoxDescription.Location = new System.Drawing.Point(8, 7);
            this.grBoxDescription.Name = "grBoxDescription";
            this.grBoxDescription.Size = new System.Drawing.Size(541, 90);
            this.grBoxDescription.TabIndex = 1;
            this.grBoxDescription.TabStop = false;
            this.grBoxDescription.Text = "Description sujet";
            // 
            // cbBoxSujet
            // 
            this.cbBoxSujet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxSujet.FormattingEnabled = true;
            this.cbBoxSujet.Location = new System.Drawing.Point(6, 30);
            this.cbBoxSujet.Name = "cbBoxSujet";
            this.cbBoxSujet.Size = new System.Drawing.Size(276, 21);
            this.cbBoxSujet.TabIndex = 1;
            this.cbBoxSujet.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtBoxDescSujet
            // 
            this.txtBoxDescSujet.Location = new System.Drawing.Point(3, 19);
            this.txtBoxDescSujet.Multiline = true;
            this.txtBoxDescSujet.Name = "txtBoxDescSujet";
            this.txtBoxDescSujet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDescSujet.Size = new System.Drawing.Size(538, 65);
            this.txtBoxDescSujet.TabIndex = 0;
            // 
            // tlpInteraction
            // 
            this.tlpInteraction.ColumnCount = 2;
            this.tlpInteraction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.81425F));
            this.tlpInteraction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.18575F));
            this.tlpInteraction.Controls.Add(this.grBoxAjoutSujetReponse, 0, 0);
            this.tlpInteraction.Controls.Add(this.grBoxAdministration, 1, 0);
            this.tlpInteraction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInteraction.Location = new System.Drawing.Point(3, 133);
            this.tlpInteraction.Name = "tlpInteraction";
            this.tlpInteraction.RowCount = 1;
            this.tlpInteraction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInteraction.Size = new System.Drawing.Size(1109, 124);
            this.tlpInteraction.TabIndex = 3;
            // 
            // grBoxAjoutSujetReponse
            // 
            this.grBoxAjoutSujetReponse.Controls.Add(this.btAjouterReponse);
            this.grBoxAjoutSujetReponse.Controls.Add(this.btAjouterSujet);
            this.grBoxAjoutSujetReponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBoxAjoutSujetReponse.Location = new System.Drawing.Point(3, 3);
            this.grBoxAjoutSujetReponse.Name = "grBoxAjoutSujetReponse";
            this.grBoxAjoutSujetReponse.Size = new System.Drawing.Size(369, 118);
            this.grBoxAjoutSujetReponse.TabIndex = 0;
            this.grBoxAjoutSujetReponse.TabStop = false;
            this.grBoxAjoutSujetReponse.Text = "Ajout Sujet ou Réponse";
            // 
            // btAjouterSujet
            // 
            this.btAjouterSujet.Location = new System.Drawing.Point(21, 41);
            this.btAjouterSujet.Name = "btAjouterSujet";
            this.btAjouterSujet.Size = new System.Drawing.Size(122, 45);
            this.btAjouterSujet.TabIndex = 0;
            this.btAjouterSujet.Text = "&Ajout Sujet";
            this.btAjouterSujet.UseVisualStyleBackColor = true;
            this.btAjouterSujet.Click += new System.EventHandler(this.btAjouterSujet_Click);
            // 
            // btAjouterReponse
            // 
            this.btAjouterReponse.Location = new System.Drawing.Point(204, 41);
            this.btAjouterReponse.Name = "btAjouterReponse";
            this.btAjouterReponse.Size = new System.Drawing.Size(125, 45);
            this.btAjouterReponse.TabIndex = 1;
            this.btAjouterReponse.Text = "&Poster Réponse";
            this.btAjouterReponse.UseVisualStyleBackColor = true;
            this.btAjouterReponse.Click += new System.EventHandler(this.btAjouterReponse_Click);
            // 
            // grBoxAdministration
            // 
            this.grBoxAdministration.Controls.Add(this.btDeleteReponse);
            this.grBoxAdministration.Controls.Add(this.btDeleteSujet);
            this.grBoxAdministration.Controls.Add(this.btEditSujet);
            this.grBoxAdministration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBoxAdministration.Location = new System.Drawing.Point(378, 3);
            this.grBoxAdministration.Name = "grBoxAdministration";
            this.grBoxAdministration.Size = new System.Drawing.Size(728, 118);
            this.grBoxAdministration.TabIndex = 1;
            this.grBoxAdministration.TabStop = false;
            this.grBoxAdministration.Text = "Administration";
            // 
            // btEditSujet
            // 
            this.btEditSujet.Location = new System.Drawing.Point(52, 41);
            this.btEditSujet.Name = "btEditSujet";
            this.btEditSujet.Size = new System.Drawing.Size(131, 45);
            this.btEditSujet.TabIndex = 0;
            this.btEditSujet.Text = "&Modifier Sujet";
            this.btEditSujet.UseVisualStyleBackColor = true;
            this.btEditSujet.Click += new System.EventHandler(this.btEditSujet_Click);
            // 
            // btDeleteSujet
            // 
            this.btDeleteSujet.Location = new System.Drawing.Point(296, 41);
            this.btDeleteSujet.Name = "btDeleteSujet";
            this.btDeleteSujet.Size = new System.Drawing.Size(131, 45);
            this.btDeleteSujet.TabIndex = 1;
            this.btDeleteSujet.Text = "&Supprimer Sujet";
            this.btDeleteSujet.UseVisualStyleBackColor = true;
            this.btDeleteSujet.Click += new System.EventHandler(this.btDeleteSujet_Click);
            // 
            // btDeleteReponse
            // 
            this.btDeleteReponse.Location = new System.Drawing.Point(560, 41);
            this.btDeleteReponse.Name = "btDeleteReponse";
            this.btDeleteReponse.Size = new System.Drawing.Size(131, 45);
            this.btDeleteReponse.TabIndex = 2;
            this.btDeleteReponse.Text = "Supprimer &Réponse";
            this.btDeleteReponse.UseVisualStyleBackColor = true;
            this.btDeleteReponse.Click += new System.EventHandler(this.btDeleteReponse_Click);
            // 
            // FrmForumMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 667);
            this.Controls.Add(this.tlpFrmForumMain);
            this.Name = "FrmForumMain";
            this.Text = "2ISA\'sDevCommunity";
            this.Load += new System.EventHandler(this.FrmForumMain_Load);
            this.tlpFrmForumMain.ResumeLayout(false);
            this.tlpFrmForumMain.PerformLayout();
            this.tlpgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVReponse)).EndInit();
            this.plConnexion.ResumeLayout(false);
            this.tlpSelection.ResumeLayout(false);
            this.grbCatégorie.ResumeLayout(false);
            this.grBoxSujet.ResumeLayout(false);
            this.plDescription.ResumeLayout(false);
            this.plDescription.PerformLayout();
            this.grBoxDescription.ResumeLayout(false);
            this.grBoxDescription.PerformLayout();
            this.tlpInteraction.ResumeLayout(false);
            this.grBoxAjoutSujetReponse.ResumeLayout(false);
            this.grBoxAdministration.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpFrmForumMain;
        private System.Windows.Forms.TableLayoutPanel tlpgrid;
        private System.Windows.Forms.DataGridView dGVReponse;
        private System.Windows.Forms.Panel plConnexion;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btEditPassword;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TableLayoutPanel tlpSelection;
        private System.Windows.Forms.Label lblPasDeReponse;
        private System.Windows.Forms.GroupBox grbCatégorie;
        private System.Windows.Forms.ComboBox cbBoxCategorie;
        private System.Windows.Forms.GroupBox grBoxSujet;
        private System.Windows.Forms.ComboBox cbBoxSujet;
        private System.Windows.Forms.Panel plDescription;
        private System.Windows.Forms.GroupBox grBoxDescription;
        private System.Windows.Forms.TextBox txtBoxDescSujet;
        private System.Windows.Forms.Label lblPasDeSujet;
        private System.Windows.Forms.TableLayoutPanel tlpInteraction;
        private System.Windows.Forms.GroupBox grBoxAjoutSujetReponse;
        private System.Windows.Forms.Button btAjouterReponse;
        private System.Windows.Forms.Button btAjouterSujet;
        private System.Windows.Forms.GroupBox grBoxAdministration;
        private System.Windows.Forms.Button btDeleteReponse;
        private System.Windows.Forms.Button btDeleteSujet;
        private System.Windows.Forms.Button btEditSujet;
    }
}