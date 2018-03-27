using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPEJouetAVSG
{
    class Personne
    {
        private Int32 id;
        private string nom;
        private string prenom;
        private string MDP;
        private string cp;
        private string adresse;
        private Int32 numerotel;

        public Personne(string Pnom,string Pprenom, string PMDP,string Pcp,string Padresse,Int32 Pnumerotel)
        {
            
            
            nom = Pnom;
            prenom = Pprenom;
            MDP = PMDP;
            cp = Pcp;
            adresse = Padresse;
            numerotel = Pnumerotel;
            
        }

        public Int32 getId()
        {
            return id;
        }
        public string getNom()
        {
            return nom;
        }
        public string getPrenom()
        {
            return prenom;
        }
        public string getMDP()
        {
            return MDP;
        }
        public string getcp()
        {
            return cp;
        }
        public string getAdresse()
        {
            return adresse;
        }
        public Int32 getNumerotel()
        {
            return numerotel;
        }


    }

}
