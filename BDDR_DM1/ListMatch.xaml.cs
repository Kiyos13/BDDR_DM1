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
    /// Logique d'interaction pour ListMatch.xaml
    /// </summary>
    public partial class ListMatch : Window
    {
        public ListMatch()
        {
            InitializeComponent();

            int n = DBManager.User.Length;
            char index = DBManager.User[n - 1];

            DataTable matchData = DBManager.Select("select * from Match" + index);
            matchCS.ItemsSource = null;
            matchCS.ItemsSource = matchData.DefaultView;
            matchCS.Items.Refresh();
        }

        void Return_Click(object sender, RoutedEventArgs e)
        {
            Window homePageWin = new HomePage();
            this.Close();
            homePageWin.Show();
        }
    }
}
