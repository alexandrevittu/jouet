using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPEJouetAVSG
{
    class Enfant
    {
        private Int32 id;
        private Int32 age;

        public Enfant(Int32 Pid,Int32 Page)
        {
            id = Pid;
            age = Page;
        }

        public Int32 getId()
        {
            return id;
        }
        public Int32 getAge()
        {
            return age;
        }

        public string Info
        {
            get { return "Numero de l'enfant : "+id + " -- Age : " + age; }
        }
    }
}
