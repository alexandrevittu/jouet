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
    public partial class Formaddemploye : Form
    {
        public Formaddemploye()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = txtboxNom.Text;
            string prenom = txtboxPrenom.Text;
            string mdp = txtboxmdp.Text;
            string cp = txtboxcp.Text;
            string adresse = txtboxAdresse.Text;
            Int32 numerotel = Int32.Parse(txtboxNumtel.Text);

            Personne unepersonne = new Personne(nom, prenom, mdp, cp, adresse, numerotel);


            try
            {
                PersonneDAO personneadd = new PersonneDAO();
                MessageBox.Show("zefezfzefezf !");

                personneadd.create(unepersonne);
                MessageBox.Show("l'employe a ete ajouté !");

            }
            catch{
                MessageBox.Show("erreur de saisie !");

            }
        }
    }
}
