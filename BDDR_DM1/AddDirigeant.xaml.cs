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
    /// Logique d'interaction pour Dirigeant.xaml
    /// </summary>
    public partial class AddDirigeant : Window
    {
        public AddDirigeant()
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

                int code = Convert.ToInt32(dirigeant_code.Text.ToString());
                string nom = dirigeant_nom.Text.ToString();
                string prenom = dirigeant_prenom.Text.ToString();
                string profession = dirigeant_profession.Text.ToString();

                string sqlStatement = "INSERT INTO Dirigeant" + index + " VALUES(" + code + ", '" + nom + "', '" + prenom + "', '" + profession + "')";
                DBManager.Insert(sqlStatement);
            }
            catch (Exception ex)
            {

                MessageBox.Show("mauvais type de donnée entré");
            }
        }
    }
}
