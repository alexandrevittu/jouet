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
    class CategorieDAO : DAO<Categorie>
    {

        //private Categorie lacategorie;

        public CategorieDAO()
        {

        }
        public override bool create(Categorie Object)
        {
            throw new NotImplementedException();
        }
        public override bool delete(Categorie Object)
        {
            throw new NotImplementedException();
        }
        public override Categorie find(int id)
        {
            throw new NotImplementedException();
        }
        public override List<Categorie> findAll()
        {
            List<Categorie> lescategories = new List<Categorie>();
            SqlConnection laConnection = seConnecter();

            SqlCommand maCommande;
            string requete = "SELECT * FROM categorie";
            maCommande = new SqlCommand(requete, laConnection);

            SqlDataReader ListCategorie = maCommande.ExecuteReader();

            while (ListCategorie.Read())
            {
                Int32 id = (int)ListCategorie["id"];
                string libelle = (string)ListCategorie["libelle"];
                lescategories.Add(new Categorie(id, libelle));
            }
            ListCategorie.Close();
            return lescategories;
            throw new NotImplementedException();
        }
        public override bool update(Categorie Object)
        {
            throw new NotImplementedException();
        }

        public override List<Categorie> find(int id, int id2)
        {
            throw new NotImplementedException();
        }

        public override int utilisateurExiste(string id, string mdp)
        {
            throw new NotImplementedException();
        }

        public override int getTypeutilisateur(string id, string mdp)
        {
            throw new NotImplementedException();
        }

        public override List<Categorie> findAll(string id,string mdp)
        {
            throw new NotImplementedException();
        }

        public string getLibelleCat(int idCat)
        {
            string libelle;
            SqlConnection laConnection = seConnecter();

            SqlCommand maCommande;
            string requete = "SELECT libelle FROM categorie WHERE id = "+idCat;
            maCommande = new SqlCommand(requete, laConnection);

            libelle = (string)maCommande.ExecuteScalar();
            return libelle;
        }

    }
}
