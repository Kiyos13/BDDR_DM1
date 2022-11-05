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
    /// Logique d'interaction pour Palmares.xaml
    /// </summary>
    public partial class AddPalmares : Window
    {
        public AddPalmares()
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

            int code = Convert.ToInt32(palmares_code_club.Text.ToString());
            string trophee = palmares_trophee.Text.ToString();
            int annee = Convert.ToInt32(palmares_annee.Text.ToString());
            int nbMatchsGagnes = Convert.ToInt32(palmares_nb_matchs_gagnes.Text.ToString());
            int nbMatchsPerdus = Convert.ToInt32(palmares_nb_matchs_perdus.Text.ToString());

            string sqlStatement = "INSERT INTO Palmares" + index + " VALUES(" + code + ", " + annee.ToSqlYear() + ", '" + trophee
                + "', " + nbMatchsGagnes + ", " + nbMatchsPerdus + ")";
            DBManager.Insert(sqlStatement);
        }
    }
}
