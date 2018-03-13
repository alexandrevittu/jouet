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
    class TrancheageDAO : DAO<Trancheage>
    {
        

        public TrancheageDAO()
        {

        }
        public override bool create(Trancheage Object)
        {
            throw new NotImplementedException();
        }
        public override bool delete(Trancheage Object)
        {
            throw new NotImplementedException();
        }
        public override Trancheage find(int id)
        {
            throw new NotImplementedException();
        }
        public override List<Trancheage> findAll()
        {
            List<Trancheage> lestrancheage = new List<Trancheage>();
            SqlConnection laConnection = seConnecter();

            SqlCommand maCommande;
            string requete = "SELECT * FROM TrancheAge";
            maCommande = new SqlCommand(requete, laConnection);

            SqlDataReader Listtranche = maCommande.ExecuteReader();

            while (Listtranche.Read())  
            {
                Int32 id = (int)Listtranche["code"];
                Int32 agemin = (int)Listtranche["TrancheAgeMin"];
                Int32 agemax = (int)Listtranche["TrancheAgeMax"];
                lestrancheage.Add(new Trancheage(id, agemin, agemax));
            }
            Listtranche.Close();
            return lestrancheage;
            throw new NotImplementedException();
        }
        public override bool update(Trancheage Object)
        {
            throw new NotImplementedException();
        }

        public override List<Trancheage> find(int id, int id2)
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

        public override List<Trancheage> findAll(string id, string mdp)
        {
            throw new NotImplementedException();
        }


    }
}
