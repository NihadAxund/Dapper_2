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
        public void Update(Product pro)
        {
            var sql = "UPDATE Product SET Name=@Name, " +
                "Country=@Country,Coust = @Coust WHERE Id=@Id";
            dbs.Query<int>(sql, new
            {
                @Id = pro.Id,
                @Name = pro.Name,
                @Country = pro.Country,
                @Coust = pro.Coust
            }).FirstOrDefault();
           
        }
        public IEnumerable<DB.Product> GetAll()
        {
            var sql = "SELECT * FROM Product;";
            List<DB.Product> products = dbs.Query<DB.Product>(sql).ToList();
            return dbs.Query<DB.Product>(sql).ToList();
        }
        public bool Remove(int id)
        {
            dbs.Execute("DELETE FROM Product WHERE Id=@Id", new { @id = id });
            return true;
        }
        public  bool Add_Product(Product pro)
        {
            try
            {
                var sql = "INSERT INTO Product (Name, Country,Coust)" +
                "VALUES(@Name, @Country,@Coust);";
                dbs.Query<int>(sql, new
                {
                    @Name = pro.Name,
                    @Country = pro.Country,
                    @Coust = pro.Coust
                }).FirstOrDefault();
            }
            catch (Exception)
            {
                return false ;
            }
            return true;
        }
        public  bool Remove_Product() {
            return false; 
        }
    }
}
