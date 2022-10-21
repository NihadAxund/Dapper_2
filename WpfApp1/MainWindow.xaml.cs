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
using WpfApp1.DB;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public static UserControl1 Prct { get; set; }
        private DataBase db { get; set; } = new DataBase();
        public MainWindow()
        {
            InitializeComponent();
            Loading_All();
        }
        private void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void Loading_All()
        {
            
            foreach (var item in db.GetAll())
            {
                Nihad.Items.Add(new UserControl1(item));
            }
        }
        private void SHow_Product()
        {
            Product pro = new Product();
            pro.ShowDialog();
            if (pro.Isok)
            {
                Nihad.Items.Add(Prct);
            }
        }
        private void Edit_Product(UserControl1 uc1)
        {
            Product pc = new Product(uc1.pro);
            pc.ShowDialog();
            if (pc.Isok)
            {

            }
        }
        private void BTN_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                switch (btn.Name)
                {
                    case "Exit" :
                        Close();
                        break;
                    case "ADD":
                        SHow_Product();
                            break;
                    case "Remove":
                        //DataBase.Remove_Product();
                        break;
                    case "Ref":
                        if (Nihad.Items.Count!=0)
                            Nihad.Items.Clear();
                        break;
                    case "EDIT" :
                        if (Nihad.SelectedItems.Count!=0)
                        {
                            if (Nihad.SelectedItem is UserControl1 U)
                            {
                                Edit_Product(U);

                            }
                           
                        }
                        MessageBox.Show("a");
                        break;
                    default:
                        break;
                }
            }
        }


    }
}
