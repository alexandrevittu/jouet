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
    class Passerelle
    {
        private static SqlConnection laConnection = null;

        private static bool seConnecter()
        {
            if(laConnection == null)
            {
                laConnection = new SqlConnection();
                laConnection.ConnectionString = "Data Source = WIN-921C8FKTGAE; Initial Catalog=slam2018JouetAVSG; User ID=gungor;Password=gungor";
                laConnection.Open();
                System.Diagnostics.Debug.WriteLine("instanciation connexion");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("connexion reussi");
            }
            return true;
        }

        public static bool seDeconnecter()
        {
            if(laConnection != null)
            {
                laConnection.Close();
                System.Diagnostics.Debug.WriteLine(laConnection.State);
                laConnection = null;
                System.Diagnostics.Debug.WriteLine("deconnexion");
            }
            return true;
        }

        public static Int32 getTypeutilisateur(string id,string mdp)
        {
            seConnecter();

            SqlCommand maCommande;
            string requete = "SELECT typePersonne FROM Personne where nom ='" + id + "' AND MDP='" + mdp + "'";
            maCommande = new SqlCommand(requete, laConnection);
            Int32 typeuti = (int)maCommande.ExecuteScalar();
            return typeuti;


        }
        public static List<Categorie> donnerCategorie()
        {
            List<Categorie> lescategories = new List<Categorie>();
            seConnecter();

            SqlCommand maCommande;
            string requete = "SELECT * FROM categorie";
            maCommande = new SqlCommand(requete,laConnection);

            SqlDataReader ListCategorie = maCommande.ExecuteReader();

            while (ListCategorie.Read())
            {
                Int32 id = (int)ListCategorie["id"];
                string libelle = (string)ListCategorie["libelle"];
                lescategories.Add(new Categorie(id,libelle));
            }
            ListCategorie.Close();
            return lescategories;

        }

        public static bool Ajouterjouet(Jouet unjouet)
        {
            seConnecter();
            Int32 num;
            SqlCommand maCommande, maCommande2;
            string requete1 = "SELECT max(id) FROM Jouet";
            maCommande2 = new SqlCommand(requete1, laConnection);
            num = (int)maCommande2.ExecuteScalar();
            num += 1;
            string requete2 = "insert into dbo.Jouet values("+num+",'"+unjouet.getLibelle()+"','"+unjouet.getPrix()+"','"+unjouet.getcategorie().getId()+"',"+unjouet.gettrancheage().getCode()+")";
            maCommande = new SqlCommand(requete2, laConnection);
            int nb = maCommande.ExecuteNonQuery();

            return true;
        }

        public static List<Trancheage> donnerTrancheage()
        {
            List<Trancheage> lestrancheage = new List<Trancheage>();
            seConnecter();

            SqlCommand maCommande;
            string requete = "SELECT * FROM TrancheAge";
            maCommande = new SqlCommand(requete, laConnection);
            
            SqlDataReader Listtranche = maCommande.ExecuteReader();

            while(Listtranche.Read())
            {
                Int32 id = (int)Listtranche["code"];
                Int32 agemin = (int)Listtranche["TrancheAgeMin"];
                Int32 agemax = (int)Listtranche["TrancheAgeMax"];
                lestrancheage.Add(new Trancheage(id,agemin,agemax));
            }
            Listtranche.Close();
            return lestrancheage;
        }



        public static Int32 utilisateurExiste(string id, string mdp)
        {

            seConnecter();



            SqlCommand maCommande;
            string requete = "SELECT count(typePersonne) FROM Personne where nom ='" + id + "' AND MDP='" + mdp + "'";
            maCommande = new SqlCommand(requete, laConnection);


            int result = (int)maCommande.ExecuteScalar();

            seDeconnecter();

            return result;

        }

        public static String recupNom(string nom)
        {

            return nom;
        }
    }
}
