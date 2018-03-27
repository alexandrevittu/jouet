using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPEJouetAVSG
{
    class Trancheage
    {
        private Int32 code;
        private Int32 TrancheAgeMin;
        private Int32 TrancheAgeMax;

        public Int32 Code
        {
            get { return code; }
            set { code = value; }
        }



        public string info
        {
            get { return TrancheAgeMin+"-"+TrancheAgeMax; }
            
        }


        public Trancheage(Int32 Pcode,Int32 Ptrancheagemin,Int32 Ptrancheagemax)
        {
            code = Pcode;
            TrancheAgeMin = Ptrancheagemin;
            TrancheAgeMax = Ptrancheagemax;
        }

        public Int32 getCode()
        {
            return code;
        }
        public Int32 getAgeMin()
        {
            return TrancheAgeMin;
        }
        public Int32 getAgeMax()
        {
            return TrancheAgeMax;
        }
    }
}
