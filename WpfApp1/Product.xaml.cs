using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    public partial class Product : Window
    {
        public bool Isok = false;
     //  private DB.Product pr;
        public Product()
        {
            InitializeComponent();
        }
        public Product(DB.Product Pro)
        {
            InitializeComponent();
            Isok = false;
            Product_txt.Text = Pro.Name;
            Country_txt.Text = Pro.Country;
            Cost_txt.Text = Pro.Coust.ToString();
        }
        private bool Check()
        {
            try
            {
                double num = Convert.ToDouble(Cost_txt.Text);
                return Product_txt.Text.Length != 0 && Product_txt.Text != " " && Country_txt.Text != " " && Country_txt.Text.Length > 0 && num > 0;
            }
            catch {return false;}
        }
        private void Ok_btn_Click(object sender, RoutedEventArgs e)
        {
            Isok = true;
            if (Check())
            {
             //   pr =new DB.Product(Product_txt.Text, Country_txt.Text, Convert.ToDouble(Cost_txt.Text));
                MainWindow.Prct = new UserControl1(new DB.Product(Product_txt.Text, Country_txt.Text, Convert.ToDouble(Cost_txt.Text)));
                Close();
            }
        }
    }
}
