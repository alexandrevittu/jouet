using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PPEJouetAVSG
{
    public partial class FormJouetCategorie : Form
    {
        public FormJouetCategorie()
        {
            InitializeComponent();
            SqlConnection Connection = new SqlConnection("Data Source = WIN-921C8FKTGAE; Initial Catalog=slam2018JouetAVSG; User ID=vittu;Password=vittu");
            SqlDataAdapter adapter = new SqlDataAdapter(@"select distinct categorie.libelle as 'Categorie',count(*) as 'Nombre de jouet' from Jouet INNER JOIN categorie on Jouet.idCategorie = categorie.id group by categorie.libelle", Connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewjouetcategorie.DataSource = dt;
            
        }
    }
}
