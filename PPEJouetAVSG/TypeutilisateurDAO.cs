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
    class TypeutilisateurDAO : DAO<Typeutilisateur>
    {
        private Typeutilisateur typeuti;

        public override bool create(Typeutilisateur Object)
        {
            throw new NotImplementedException();
        }
        public override bool delete(Typeutilisateur Object)
        {
            throw new NotImplementedException();
        }
        public override Typeutilisateur find(int id)
        {
            throw new NotImplementedException();
        }
        public override List<Typeutilisateur> findAll()
        {
            throw new NotImplementedException();
        }
        public override bool update(Typeutilisateur Object)
        {
            throw new NotImplementedException();
        }

        public override List<Typeutilisateur> find(int id, int id2)
        {
            throw new NotImplementedException();
        }

        public override Int32 utilisateurExiste(string id, string mdp)
        {

            seConnecter();



            SqlCommand maCommande;
            string requete = "SELECT count(typePersonne) FROM Personne where nom ='" + id + "' AND MDP='" + mdp + "'";
            maCommande = new SqlCommand(requete, laConnection);


            int result = (int)maCommande.ExecuteScalar();

            seDeconnecter();

            return result;

        }

        public override Int32 getTypeutilisateur(string id, string mdp)
        {
            seConnecter();

            SqlCommand maCommande;
            string requete = "SELECT typePersonne FROM Personne where nom ='" + id + "' AND MDP='" + mdp + "'";
            maCommande = new SqlCommand(requete, laConnection);
            Int32 typeuti = (int)maCommande.ExecuteScalar();
            return typeuti;
        }
    }
}
