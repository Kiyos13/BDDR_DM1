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
    /// Logique d'interaction pour AddJoueur.xaml
    /// </summary>
    public partial class AddJoueur : Window
    {
        public AddJoueur()
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

            int code = Convert.ToInt32(joueur_code.Text.ToString());
            string nom = joueur_nom.Text.ToString();
            string prenom = joueur_prenom.Text.ToString();
            DateTime dob = joueur_date_naissance.SelectedDate.Value;
            string nationalite = joueur_nationalite.Text.ToString();
            int poids = Convert.ToInt32(joueur_poids.Text.ToString());
            int taille = Convert.ToInt32(joueur_taille.Text.ToString());
            string classe = joueur_classe.Text.ToString();

            string sqlStatement = "INSERT INTO Joueur" + index + " VALUES(" + code + ", '" + nom + "', '" + prenom + "', " + dob.Display()
                + ", '" + nationalite + "', " + poids + ", " + taille + ", '" + classe + "')";
            DBManager.Insert(sqlStatement);
        }

    }
}
