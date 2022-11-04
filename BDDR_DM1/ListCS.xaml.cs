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
    /// Logique d'interaction pour ListCS.xaml
    /// </summary>
    public partial class ListCS : Window
    {
        public ListCS()
        {
            InitializeComponent();
            int n = DBManager.User.Length;
            char index = DBManager.User[n - 1];

            DataTable clubData = DBManager.Select("select * from ClubSportif" + index);
            clubSportifCS.ItemsSource = null;
            clubSportifCS.ItemsSource = clubData.DefaultView;
            clubSportifCS.Items.Refresh();

            DataTable dirigeantData = DBManager.Select("select * from Dirigeant" + index);
            dirigeantCS.ItemsSource = null;
            dirigeantCS.ItemsSource = dirigeantData.DefaultView;
            dirigeantCS.Items.Refresh();

            DataTable joueurData = DBManager.Select("select * from Joueur" + index);
            joueurCS.ItemsSource = null;
            joueurCS.ItemsSource = joueurData.DefaultView;
            joueurCS.Items.Refresh();

            DataTable staffData = DBManager.Select("select * from StaffTechnique" + index);
            staffCS.ItemsSource = null;
            staffCS.ItemsSource = staffData.DefaultView;
            staffCS.Items.Refresh();
        }

        void CS_R1_Click(object sender, RoutedEventArgs e)
        {
        }

        void CS_R2_Click(object sender, RoutedEventArgs e)
        {
        }

        void CS_R3_Click(object sender, RoutedEventArgs e)
        {
        }

        void CS_R4_Click(object sender, RoutedEventArgs e)
        {
        }

        void CS_R5_Click(object sender, RoutedEventArgs e)
        {
        }

        void Return_Click(object sender, RoutedEventArgs e)
        {
            Window homePageWin = new HomePage();
            this.Close();
            homePageWin.Show();
        }
    }
}
