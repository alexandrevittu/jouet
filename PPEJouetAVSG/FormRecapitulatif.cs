using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PPEJouetAVSG
{
    public partial class FormRecapitulatif : Form
    {
        public FormRecapitulatif()
        {
            InitializeComponent();
            SqlConnection Connection = new SqlConnection("Data Source = WIN-921C8FKTGAE; Initial Catalog=slam2018JouetAVSG; User ID=vittu;Password=vittu");
            SqlDataAdapter adapter = new SqlDataAdapter(@"select distinct libelle as 'nom du jouet',count(*) as 'nombre a commander' from enfant INNER JOIN Jouet ON enfant.idJouet = Jouet.id where idJouet is not null group by libelle", Connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1listjouet.DataSource = dt;
        }

        private void FormRecapitulatif_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'slam2018JouetAVSGDataSet.enfant'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.enfantTableAdapter.Fill(this.slam2018JouetAVSGDataSet.enfant);

        }

    }
}
