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

namespace BDDR_DM1
{
    /// <summary>
    /// Logique d'interaction pour ClubSportif.xaml
    /// </summary>
    public partial class AddClubSportif : Window
    {
        public AddClubSportif()
        {
            InitializeComponent();
        }

        void Return_Click(object sender, RoutedEventArgs e)
        {
            Window homePageWin = new HomePage();
            this.Close();
            homePageWin.Show();
        }

        void onClickAdd(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = DBManager.User.Length;
                char index = DBManager.User[n - 1];

                int code = Convert.ToInt32(club_sportif_code.Text.ToString());
                string nom = joueur_nom.Text.ToString();
                DateTime dateCreation = joueur_date_creation.SelectedDate.Value;
                int dirigeant = Convert.ToInt32(joueur_dirigeant.Text.ToString());
                string nationalite = joueur_ville.Text.ToString();
                int region = Convert.ToInt32(joueur_region.Text.ToString());

                string sqlStatement = "INSERT INTO ClubSportif" + index + " VALUES(" + code + ", '" + nom + "', " + dateCreation.Display()
                    + ", " + dirigeant + ", '" + nationalite + "', " + region + ")";
                DBManager.Insert(sqlStatement);
            }
            catch (Exception ex)
            {

                MessageBox.Show("mauvais type de donnée entré");
            }
        }
    }
}
