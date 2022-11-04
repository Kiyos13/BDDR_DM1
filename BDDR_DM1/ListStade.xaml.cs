using System;
using System.Collections.Generic;
using System.Data;
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

namespace BDDR_DM1
{
    /// <summary>
    /// Logique d'interaction pour ListStade.xaml
    /// </summary>
    public partial class ListStade : Window
    {
        public ListStade()
        {
            InitializeComponent();

            int n = DBManager.User.Length;
            char index = DBManager.User[n - 1];

            DataTable stadeData = DBManager.Select("select * from Stade" + index);
            stadeCS.ItemsSource = null;
            stadeCS.ItemsSource = stadeData.DefaultView;
            stadeCS.Items.Refresh();
        }

        void Return_Click(object sender, RoutedEventArgs e)
        {
            Window homePageWin = new HomePage();
            this.Close();
            homePageWin.Show();
        }
    }
}
