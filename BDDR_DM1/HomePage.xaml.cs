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

        private void Add_Joueur_Click(object sender, RoutedEventArgs e)
        {
            Window addJoueurtWin = new AddJoueur();
            this.Close();
            addJoueurtWin.Show();
        }

        private void Add_Equipe_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Staff_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Personnel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Stade_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Dirigeant_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_CS_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Palmares_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
