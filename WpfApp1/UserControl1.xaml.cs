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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public DB.Product pro { get; set; } = new DB.Product();
        public UserControl1()
        {
            InitializeComponent();
        }
        public UserControl1(DB.Product PRDT)
        {
            InitializeComponent();
            pro = PRDT;
            Name_txt.Content = PRDT.Name;
            Country_txt.Content = PRDT.Country;
            Coust_txt.Content = PRDT.Coust;
        }
    }
}
