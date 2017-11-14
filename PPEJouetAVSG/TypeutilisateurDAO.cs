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

        public TypeutilisateurDAO(Typeutilisateur Puti)
        {
            typeuti = Puti;
        }
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
    }
}
