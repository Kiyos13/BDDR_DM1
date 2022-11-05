using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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
    /// Logique d'interaction pour AddMatch.xaml
    /// </summary>
    public partial class AddMatch : Window
    {
        public AddMatch()
        {
            InitializeComponent();

            int n = DBManager.User.Length;
            char index = DBManager.User[n - 1];

            DataTable allClubSportifData = DBManager.Select("select * from AllClubSportif");
            clubSportifMatch.ItemsSource = null;
            clubSportifMatch.ItemsSource = allClubSportifData.DefaultView;
            clubSportifMatch.Items.Refresh();

            DataTable allStadeData = DBManager.Select("select * from AllStade");
            stadeMatch.ItemsSource = null;
            stadeMatch.ItemsSource = allStadeData.DefaultView;
            stadeMatch.Items.Refresh();

            DataTable allArbitreData = DBManager.Select("select * from Arbitre1");
            arbitreMatch.ItemsSource = null;
            arbitreMatch.ItemsSource = allArbitreData.DefaultView;
            arbitreMatch.Items.Refresh();
        }

        void Return_Click(object sender, RoutedEventArgs e)
        {
            Window homePageWin = new HomePage();
            this.Close();
            homePageWin.Show();
        }

        void onClickAdd(object sender, RoutedEventArgs e)
        {
            int n = DBManager.User.Length;
            char index = DBManager.User[n - 1];

            DateTime date = match_date.SelectedDate.Value;
            int nbButsA = Convert.ToInt32(match_nb_buts_a.Text.ToString());
            int nbButsB = Convert.ToInt32(match_nb_buts_b.Text.ToString());
            int spectateurs = Convert.ToInt32(match_nb_spectateurs.Text.ToString());
            int codeArbitre = Convert.ToInt32(match_code_arbitre.Text.ToString());
            int codeStade = Convert.ToInt32(match_code_stade.Text.ToString());
            String heure = match_heure.Text.ToString();
            int clubA = Convert.ToInt32(match_club_a.Text.ToString());
            int clubB = Convert.ToInt32(match_club_b.Text.ToString());
            int code = DBManager.getAutoIncrement("Match" + index);

            string sqlStatement = "INSERT INTO Calendrier" + index + " VALUES(" + code + ", " + date + ", '" + heure + "', " + clubA
                + ", " + clubB + ", " + codeStade + ")";
            DBManager.Insert(sqlStatement);

            sqlStatement = "INSERT INTO Match" + index + " VALUES(" + code + ", " + nbButsA + ", " + nbButsB + ", " + spectateurs
                + ", " + codeArbitre + ", " + codeStade + ")";
            DBManager.Insert(sqlStatement);
        }
    }
}
