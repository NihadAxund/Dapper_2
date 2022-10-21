using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1.DB
{
    public  class DataBase
    {
        private static IDbConnection dbs;
        public DataBase()
        {
            Start();    
        }
        private void Start()
        {
            dbs = new SqlConnection();
            dbs.ConnectionString = @"Data Source=NIHAD; Initial Catalog=Product; Integrated Security=SSPI";
        }
        public IEnumerable<DB.Product> GetAll()
        {
            var sql = "SELECT * FROM Product;";
            List<DB.Product> products = dbs.Query<DB.Product>(sql).ToList();
            return dbs.Query<DB.Product>(sql).ToList();
        }
        public  bool Add_Product()
        {
             return false;
        }
        public  bool Remove_Product() {
            return false; 
        }
    }
}
