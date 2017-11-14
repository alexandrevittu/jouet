using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace PPEJouetAVSG
{
    class JouetDAO : DAO<Jouet>
    {
        //private Jouet lejouet;

        public JouetDAO()
        {

        }

        public override bool create(Jouet Object)
        {
            SqlConnection laConnection= seConnecter();
            Int32 num;
            SqlCommand maCommande, maCommande2;
            string requete1 = "SELECT max(id) FROM Jouet";
            maCommande2 = new SqlCommand(requete1, laConnection);
            num = (int)maCommande2.ExecuteScalar();
            num += 1;
            string requete2 = "insert into dbo.Jouet values(" + num + ",'" + Object.getLibelle() + "','" + Object.getPrix() + "','" + Object.getcategorie().getId() + "'," + Object.gettrancheage().getCode() + ")";
            maCommande = new SqlCommand(requete2, laConnection);
            int nb = maCommande.ExecuteNonQuery();

            return true;
            throw new NotImplementedException();
        }
        public override bool delete(Jouet Object)
        {
            throw new NotImplementedException();
        }
        public override List<Jouet> find(int idcat,int idtranche)
        {
            List<Jouet> lesjouets = new List<Jouet>();
            SqlConnection laConnection = seConnecter();

            SqlCommand maCommande;
            string requete = "SELECT * FROM Jouet WHERE idTrancheage ="+idtranche+"AND idCategorie = "+idcat;
            maCommande = new SqlCommand(requete, laConnection);

            SqlDataReader Listjouet = maCommande.ExecuteReader();

            while(Listjouet.Read())
            {
                
                string libelle = (string)Listjouet["libelle"];
                Int32 prix = (int)Listjouet["id"];
                int idcatego = (int)Listjouet["idCategorie"];
                int idtrancheage = (int)Listjouet["idTrancheAge"];
                lesjouets.Add(new Jouet(libelle, prix, new Categorie(idcatego,"egvinvre"),new Trancheage(idtrancheage,10,20)));
            }
            Listjouet.Close();
            return lesjouets;
            throw new NotImplementedException();
        }
        public override List<Jouet> findAll()
        {
            
            throw new NotImplementedException();
        }
        public override bool update(Jouet Object)
        {
            throw new NotImplementedException();
        }

    }
}
