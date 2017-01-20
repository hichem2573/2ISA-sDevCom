using DevCBL;
using DevCMetier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevWinForms
{

    public partial class FrmForumMain : Form
    {
        public FrmForumMain()
        {
            InitializeComponent();
            dGVReponse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FrmForumMain_Load(object sender, EventArgs e)
        {
            remplirComboBoxCategorie(Outils.GetAllCategories());

            remplirComboBoxSujet(Outils.GetSujetsByCategorieID((int)cbBoxCategorie.SelectedValue));
            ModoVisibilite();
        }



        private void cbBoxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btAjouterSujet_Click(object sender, EventArgs e)
        {

        }

        private void btAjouterReponse_Click(object sender, EventArgs e)
        {

        }

        private void btEditSujet_Click(object sender, EventArgs e)
        {

        }

        private void btDeleteSujet_Click(object sender, EventArgs e)
        {

        }

        private void btDeleteReponse_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //using(FrmIdentification frmident = new FrmIdentification())
            //{
            //    frmident.ShowDialog();
            //}
            //ModoVisibilite();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {

        }

        private void btEditPassword_Click(object sender, EventArgs e)
        {

        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void remplirComboBoxSujet(List<Sujet> sujets)
        {
            cbBoxSujet.ValueMember = "Id";
            cbBoxSujet.DisplayMember = "Titre";
            cbBoxSujet.DataSource = sujets;
            Sujet sujet = (Sujet)cbBoxSujet.SelectedItem;
        }

        private void remplirComboBoxCategorie(List<Categorie> categories)
        {
            cbBoxCategorie.ValueMember = "Id";
            cbBoxCategorie.DisplayMember = "Libelle";
            cbBoxCategorie.DataSource = categories;
        }

        private void ModoVisibilite()
        {
            grBoxAjoutSujetReponse.Visible = FrmAccueil.Isconnected;
            btEditPassword.Visible = FrmAccueil.Isconnected;
            btLogout.Visible = FrmAccueil.Isconnected;
            grBoxAdministration.Visible = FrmAccueil.IsRmodo;
            btLogin.Visible = FrmAccueil.Isconnected;
        }

    }
}
