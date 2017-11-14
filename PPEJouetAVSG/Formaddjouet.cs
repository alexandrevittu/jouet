using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPEJouetAVSG
{
    public partial class Formaddjouet : Form
    {
        public Formaddjouet()
        {
            CategorieDAO cat = new CategorieDAO();
            TrancheageDAO tranche = new TrancheageDAO();
            InitializeComponent();
            cbcat.DataSource = cat.findAll();
            cbcat.DisplayMember = "info";
            //cbcat.ValueMember = "Id";
            cbtrancheage.DataSource = tranche.findAll();
            cbtrancheage.DisplayMember = "info";
            //cbtrancheage.ValueMember = "Code";
        }

        private void btnajouterjouet_Click(object sender, EventArgs e)
        {
            Int32 prix;
            string libelle = txtnomjouet.Text;
            prix = Int32.Parse(txtprix.Text);

            

            //Int32 idcat = Int32.Parse(cbcat.Text);
            //Int32 idtranche = Int32.Parse(cbtrancheage.Text);
            Jouet unjouet = new Jouet(libelle, prix,(Categorie)cbcat.SelectedValue,(Trancheage)cbtrancheage.SelectedValue);

            try
            {
                JouetDAO jouetaadd = new JouetDAO();
                jouetaadd.create(unjouet);
                //Passerelle.Ajouterjouet(unjouet);
                MessageBox.Show("Votre jouet a ete ajouté !");
                txtnomjouet.Clear();
                txtprix.Clear();
            }
            catch
            {
                MessageBox.Show("erreur de saisie !");
            }

        }
    }
}
