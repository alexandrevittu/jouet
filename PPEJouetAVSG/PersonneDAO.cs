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
    class PersonneDAO: DAO<Personne>
    {
        public PersonneDAO()
        {

        }
        public override bool create(Personne Object)
        {
            SqlConnection laConnection = seConnecter();
            Int32 num;
            SqlCommand maCommande, maCommande2;
            string requete1 = "SELECT max(id) FROM Personne";
            maCommande2 = new SqlCommand(requete1, laConnection);
            num = (int)maCommande2.ExecuteScalar();
            num += 1;
            string requete2 = "insert into dbo.Personne values(" + num + ",'" + Object.getNom() + ",'" + Object.getPrenom() + ",'" + Object.getMDP() + ",'" + Object.getcp() + ",'" + Object.getAdresse() + ",'" + Object.getNumerotel() + ",'" + 2+")" ;
            maCommande = new SqlCommand(requete2, laConnection);
            int nb = maCommande.ExecuteNonQuery();

            return true;
            throw new NotImplementedException();
        }
        public override bool delete(Personne Object)
        {
            throw new NotImplementedException();
        }
        public override List<Personne> find(int id, int id2)
        {
            throw new NotImplementedException();
        }
        public override List<Personne> findAll()
        {
            throw new NotImplementedException();
        }
        public override bool update(Personne Object)
        {
            throw new NotImplementedException();
        }
        public override Personne find(int id)
        {
            throw new NotImplementedException();
        }
        public override List<Personne> findAll(string id, string mdp)
        {
            throw new NotImplementedException();
        }
        public override int getTypeutilisateur(string id, string mdp)
        {
            throw new NotImplementedException();
        }
        public override int utilisateurExiste(string id, string mdp)
        {
            throw new NotImplementedException();
        }

    }
}
