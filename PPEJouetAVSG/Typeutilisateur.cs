using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPEJouetAVSG
{
    class Typeutilisateur
    {
        private Int32 id;
        private string libelle;

        public Typeutilisateur(Int32 Pid,string Plibelle)
        {
            libelle = Plibelle;
            id = Pid;
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
