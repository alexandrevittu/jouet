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
    abstract class DAO<T>
    {
        private static SqlConnection laConnection = null;
        public static SqlConnection seConnecter()
        {
            if(laConnection == null)
            {
                laConnection = new SqlConnection();
                laConnection.ConnectionString = "Data Source = WIN-921C8FKTGAE; Initial Catalog=slam2018JouetAVSG; User ID=vittu;Password=vittu";
                laConnection.Open();
                System.Diagnostics.Debug.WriteLine("instanciation connexion");
            }
            
            else
            {
                System.Diagnostics.Debug.WriteLine("connexion reussi");
            }
            return laConnection;
        }

        public static bool seDeconnecter()
        {
            if (laConnection != null)
            {
                laConnection.Close();
                System.Diagnostics.Debug.WriteLine(laConnection.State);
                laConnection = null;
                System.Diagnostics.Debug.WriteLine("deconnexion");
            }
            return true;
        }

        public abstract Boolean create(T Object);
        public abstract T find(Int32 id);

        public abstract List<T> findAll();
        public abstract Boolean update(T Object);
        public abstract Boolean delete(T Object);
    }
    

}
