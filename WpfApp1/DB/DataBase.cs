using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WpfApp1.DB
{
    public  class DataBase
    {
        private static IDbConnection db;
        public DataBase()
        {
            Start();
        }
        private void Start()
        {
            db = new SqlConnection();
            db.ConnectionString = @"Data Source=NIHAD; Initial Catalog=Product; Integrated Security=SSPI";
        }
        public static bool Add_Product()
        {
             return false;
        }
        public static bool Remove_Product() {
            return false; 
        }
    }
}
