using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPEJouetAVSG
{
    class Categorie
    {
        private Int32 id;
        private string libelle;
        private List<Jouet> lesJouets;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public string info
        {
            get { return id+" "+libelle; }
            
        }


        public Categorie(Int32 Pid,string Plibelle)
        {
            lesJouets = new List<Jouet>();
            id = Pid;
            libelle = Plibelle;
        }
        public Int32 getId()
        {
            return id;
        }
        public string getLibelle()
        {
            return libelle;
        }
    }
}
