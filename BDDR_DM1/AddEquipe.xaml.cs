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
    /// Logique d'interaction pour AddEquipe.xaml
    /// </summary>
    public partial class AddEquipe : Window
    {
        public AddEquipe()
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

                int codeclub = Convert.ToInt32(equipe_code_club.Text.ToString());
                int codeJoueur = Convert.ToInt32(equipe_code_joueur.Text.ToString());
                DateTime dateDebut = equipe_date_debut_contrat.SelectedDate.Value;
                DateTime dateFin = equipe_date_fin_contrat.SelectedDate.Value;
                int maillot = Convert.ToInt32(equipe_numero_maillot.Text.ToString());
                string poste = equipe_poste.Text.ToString();

                string sqlStatement = "INSERT INTO Equipe" + index + " VALUES(" + codeclub + ", " + codeJoueur + ", " + dateDebut.Display()
                    + ", " + dateFin.Display() + ", " + maillot + ", '" + poste + "')";
                DBManager.Insert(sqlStatement);
            }
            catch (Exception ex)
            {

                MessageBox.Show("mauvais type de donnée entré");
            }
        }
    }
}
