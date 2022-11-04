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
    /// Logique d'interaction pour Stade.xaml
    /// </summary>
    public partial class AddStade : Window
    {
        public AddStade()
        {
            InitializeComponent();
        }

        void Return_Click(object sender, RoutedEventArgs e)
        {
            Window homePageWin = new HomePage();
            this.Close();
            homePageWin.Show();
        }

        private void onClickAdd(object sender, RoutedEventArgs e)
        {
            int n = DBManager.User.Length;
            char index = DBManager.User[n - 1];

            int code = Convert.ToInt32(stade_code.Text.ToString());
            string nom = stade_nom.Text.ToString();
            string ville = stade_vile.Text.ToString();
            string region = stade_region.Text.ToString();
            int capacite = Convert.ToInt32(stade_capacite.Text.ToString());

            string sqlStatement = "INSERT INTO Stade" + index + " VALUES(" + code + ", '" + nom + "', '" + ville + "', "
                + ", '" + region + "', " + capacite + "')";
            DBManager.Insert(sqlStatement);
        }
    }
}
