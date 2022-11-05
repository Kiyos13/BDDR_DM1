﻿using System;
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
    /// Logique d'interaction pour AddMatch.xaml
    /// </summary>
    public partial class AddMatch : Window
    {
        public AddMatch()
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

            int codeMatch = Convert.ToInt32(match_code_match.Text.ToString());
            int nbButsA = Convert.ToInt32(match_nb_buts_a.Text.ToString());
            int nbButsB = Convert.ToInt32(match_nb_buts_b.Text.ToString());
            int spectateurs = Convert.ToInt32(match_nb_spectateurs.Text.ToString());
            int codeArbitre = Convert.ToInt32(match_code_arbitre.Text.ToString());
            int codeStade = Convert.ToInt32(match_code_stade.Text.ToString());

            string sqlStatement = "INSERT INTO Match" + index + " VALUES(" + codeMatch + ", " + nbButsA + ", " + nbButsB + ", " + spectateurs
                + ", " + codeArbitre + ", " + codeStade + ")";
            DBManager.Insert(sqlStatement);
        }
    }
}