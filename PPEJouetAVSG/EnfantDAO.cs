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
    class EnfantDAO: DAO<Enfant>
    {

        public override bool create(Enfant Object)
        {
            throw new NotImplementedException();
        }

        public override bool delete(Enfant Object)
        {
            throw new NotImplementedException();
        }

        public override Enfant find(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Enfant> findAll()
        {
            throw new NotImplementedException();
        }

        public override bool update(Enfant Object)
        {
            throw new NotImplementedException();
        }

        public override List<Enfant> find(int id, int id2)
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

        public override List<Enfant> findAll(string id, string mdp)
        {
            List<Enfant> lesEnfants = new List<Enfant>();
            SqlConnection laConnection = seConnecter();

            SqlCommand laCommande;
            String requeteSql = "SELECT * FROM enfant JOIN Personne ON enfant.idPersonne=Personne.id WHERE Personne.nom='"+id+"' AND Personne.MDP='"+mdp+"'";

            laCommande = new SqlCommand(requeteSql, laConnection);

            SqlDataReader listEnfant = laCommande.ExecuteReader();


            while (listEnfant.Read())
            {
                Int32 idEnfant = (int)listEnfant["id"];
                Int32 age = (int)listEnfant["age"];
                lesEnfants.Add(new Enfant(idEnfant, age));
            }

            listEnfant.Close();
            return lesEnfants;

            throw new NotImplementedException();
            
        }

        public string getAge(int id)
        {
            SqlConnection laConnection = seConnecter();
            SqlCommand laCommande;
            String query = "SELECT age from Enfant where id = " + id + " ";

            laCommande = new SqlCommand(query, laConnection);
            string age = (string)laCommande.ExecuteScalar();
            return age;
        }
    }
}
