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
    /// Logique d'interaction pour AddArbitre.xaml
    /// </summary>
    public partial class AddArbitre : Window
    {
        public AddArbitre()
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
            int n = DBManager.User.Length;
            char index = DBManager.User[n - 1];

            int code = Convert.ToInt32(arbitre_code.Text.ToString());
            string nom = arbitre_nom.Text.ToString();
            string prenom = arbitre_prenom.Text.ToString();
            DateTime dob = arbitre_date_naissance.SelectedDate.Value;
            string region = arbitre_region.Text.ToString();
            string clubPref = arbitre_club_prefere.Text.ToString();
            

            string sqlStatement = "INSERT INTO Match" + index + " VALUES(" + code + ", '" + nom + "', '" + prenom + "', " + dob.Display()
                + ", '" + clubPref + "', '" + region + "')";
            DBManager.Insert(sqlStatement);
        }
    }
}
