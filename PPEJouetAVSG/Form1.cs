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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            if (textBoxidentifiant.Text != "" && textBoxMDP.Text != "")
            {
                //Int32 existe = Passerelle.utilisateurExiste(textBoxidentifiant.Text, textBoxMDP.Text);

                TypeutilisateurDAO type = new TypeutilisateurDAO();
                Int32 existe = type.utilisateurExiste(textBoxidentifiant.Text, textBoxMDP.Text);

                if (existe != 0)
                {
                    string identifiant = textBoxidentifiant.Text;
                    string mdp = textBoxMDP.Text;
                    Int32 typeUtilisateur = type.getTypeutilisateur(identifiant, mdp);

                    try
                    {
                        if (typeUtilisateur == 1)
                        {
                            FormEmploye fenetreEmploye = new FormEmploye();

                            fenetreEmploye.ShowDialog();

                        }
                        else if (typeUtilisateur == 2)
                        {
                            FormResponsable fenetreReponsable = new FormResponsable();
                            fenetreReponsable.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Verifier la saisie ...");
                        }




                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Verifier la saisie ...");
                }
            }
            else
            {
                MessageBox.Show("Veuillez completez les champs ..");
            }
        }

        public TextBox TXT()
        {
            return textBoxidentifiant;

        }

        public TextBox TXTMDP()
        {
            return textBoxMDP;
        }
    }
}
