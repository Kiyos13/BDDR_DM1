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
    /// Logique d'interaction pour AddStaff.xaml
    /// </summary>
    public partial class AddStaff : Window
    {
        public AddStaff()
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

            try
            {
                int codeStaff = Convert.ToInt32(staff_code_staff.Text.ToString());
                string nom = staff_nom.Text.ToString();
                int codeClub = Convert.ToInt32(staff_code_club.Text.ToString());
                string fonction = staff_fonction.Text.ToString();

                string sqlStatement = "INSERT INTO StaffTechnique" + index + " VALUES(" + codeStaff + ", '" + nom + "', '"
                    + fonction + "', " + codeClub + ")";
                DBManager.Insert(sqlStatement);
            }
            catch (Exception ex)
            {
                MessageBox.Show("mauvais type de donnée entré");
            }
        }
    }
}
