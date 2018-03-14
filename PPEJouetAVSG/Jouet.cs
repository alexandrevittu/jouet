using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPEJouetAVSG
{
    class Jouet
    {
        private Int32 id;
        private string libelle;
        private Int32 prix;
        private Categorie categorie;
        private Trancheage trancheage;

        public Jouet(string Plibelle,Int32 Pprix,Categorie Pcategorie,Trancheage Ptrancheage)
        {
            
            libelle = Plibelle;
            prix = Pprix;
            categorie = Pcategorie;
            trancheage = Ptrancheage;
        }

        public Int32 getId()
        {
            return id;
        }
        public string getLibelle()
        {
            return libelle;
        }
        public Int32 getPrix()
        {
            return prix;
        }
        public Categorie getcategorie()
        {
            return categorie;
        }
        public Trancheage gettrancheage()
        {
            return trancheage;
        }

        public string InfoJouet
        {
            get { return "Jouet : " + getLibelle() + " Prix : " + getPrix() + " Categorie : " + getcategorie().getLibelle() + " Tranche Age : " + gettrancheage().getAgeMin() + "-" + gettrancheage().getAgeMax(); }
        }
    }
}
