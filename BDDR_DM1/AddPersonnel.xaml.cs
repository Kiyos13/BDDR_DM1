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
    /// Logique d'interaction pour AddPersonnel.xaml
    /// </summary>
    public partial class AddPersonnel : Window
    {
        public AddPersonnel()
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

                int code = Convert.ToInt32(personnel_code.Text.ToString());
                string nom = personnel_nom.Text.ToString();
                string prenom = personnel_prenom.Text.ToString();
                DateTime dateNaissance = personnel_date_naissance.SelectedDate.Value;
                string fonction = personnel_fonction.Text.ToString();
                int region= Convert.ToInt32(personnel_region.Text.ToString());
                string ville = personnel_ville.Text.ToString();

                string sqlStatement = "INSERT INTO Personnel" + index + " VALUES(" + code+ ", '" + nom + "', '" + prenom
                    + "', " + dateNaissance.Display() + ", '" + fonction + "', " + region + ", '" + ville + "')";
                DBManager.Insert(sqlStatement);
            }
            catch (Exception ex)
            {

                MessageBox.Show("mauvais type de donnée entré");
            }
        }
    }
}
