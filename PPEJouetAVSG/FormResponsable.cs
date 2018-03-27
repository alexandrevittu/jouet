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
    public partial class FormResponsable : Form
    {
        public FormResponsable()
        {
            InitializeComponent();
        }

        private void btneditlist2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formaddjouet fenetrejouet = new Formaddjouet();
            fenetrejouet.ShowDialog();
            this.Show();
        }

        private void btnrecap_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRecapitulatif fenetrerecap = new FormRecapitulatif();
            fenetrerecap.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormJouetCategorie fenetrejouetcategorie = new FormJouetCategorie();
            fenetrejouetcategorie.ShowDialog();
            this.Show();
        }

        private void btnaddemploye_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formaddemploye fenetreajoutemploye = new Formaddemploye();
            fenetreajoutemploye.ShowDialog();
            this.Show();
        }

        private void editjouet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formaddjouet fenetrejouet = new Formaddjouet();
            fenetrejouet.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormJouetCategorie fenetrejouetcategorie = new FormJouetCategorie();
            fenetrejouetcategorie.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRecapitulatif fenetrerecap = new FormRecapitulatif();
            fenetrerecap.ShowDialog();
            this.Show();

        }

        

    }
}
