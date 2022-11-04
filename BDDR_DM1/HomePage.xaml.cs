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
    /// Logique d'interaction pour HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
            int n = DBManager.User.Length;
            char index = DBManager.User[n - 1];
            DataTable calendarData = DBManager.Select("select * from Calendrier" + index);
            calendrierHomePage.ItemsSource = null;
            calendrierHomePage.ItemsSource = calendarData.DefaultView;
            calendrierHomePage.Items.Refresh();
        }

        void CS_Click(object sender, RoutedEventArgs e)
        {
            Window clubSportifWin = new ListCS();
            this.Close();
            clubSportifWin.Show();
        }

        void Match_Click(object sender, RoutedEventArgs e)
        {
            Window matchWin = new ListMatch();
            this.Close();
            matchWin.Show();
        }

        void Stade_Click(object sender, RoutedEventArgs e)
        {
            Window stadeWin = new ListStade();
            this.Close();
            stadeWin.Show();
        }

        void Deconnect_Click(object sender, RoutedEventArgs e)
        {
            Window connectWin = new MainWindow();
            this.Close();
            connectWin.Show();
        }

        void Add_Click(object sender, RoutedEventArgs e)
        {
        }

    }
}
