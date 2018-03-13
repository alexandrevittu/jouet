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
    public partial class FormEmploye : Form
    {
        public FormEmploye()
        {
            InitializeComponent();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];


            lbl_uti.Text = "Bonjour , Mr " + ((Form1)f).TXT().Text;
            string id = ((Form1)f).TXT().Text;
            string mdp = ((Form1)f).TXTMDP().Text;

            EnfantDAO afficheEnfant = new EnfantDAO();
            cmb_enfant.DataSource = afficheEnfant.findAll(id, mdp);

            cmb_enfant.DisplayMember = "Info";
        }

        private void btn_deco_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
           
        }
    }
}
