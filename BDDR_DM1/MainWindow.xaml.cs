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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BDDR_DM1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        void Connect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DBManager.SetConnection(user_textbox.Text.ToString(), password_textbox.Password.ToString());
                Window homePageWin = new HomePage();
                this.Close();
                homePageWin.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("nom d'utilisateur ou mot de passe incorrect");
            }
        }

        private void Clear_Login_Click(object sender, MouseButtonEventArgs e)
        {
            if (user_textbox.Text.Equals("Nom d'utilisateur"))
                user_textbox.Text = "";
        }

        private void Clear_Password_Click(object sender, MouseButtonEventArgs e)
        {
            if (password_textbox.Password.Equals("Mot de passe"))
                password_textbox.Password = "";
        }
    }
}
