using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Model;

namespace Dao {
    public class dbConnexion 
    {
        private static MySqlConnection connection;
        private static string sConnection;

        public dbConnexion() {
            sConnection="user=root;password=root;server=localhost;database=coloc";
        }
         public static MySqlConnection GetConnection() {
        
            if(connection==null) {
                connection=new MySqlConnection(sConnection);
                return connection;
            }
            else {
                return connection;
            }
         }

        
    }
    
}
