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

        private void btneditlist_Click(object sender, EventArgs e)
        {
            Formaddjouet fenetrejouet = new Formaddjouet();
            fenetrejouet.ShowDialog();
        }

        private void btnrecap_Click(object sender, EventArgs e)
        {
            FormRecapitulatif fenetrerecap = new FormRecapitulatif();
            fenetrerecap.ShowDialog();
        }
    }
}
