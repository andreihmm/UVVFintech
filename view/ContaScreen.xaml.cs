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
using UVVFintech.view;

namespace UVVFintech.View
{
    /// <summary>
    /// Lógica interna para ContaScreen.xaml
    /// </summary>
    public partial class ContaScreen : Window
    {
        public ContaScreen()
        {
            InitializeComponent();
        }

        private void Button_Transacao_Click(object sender, RoutedEventArgs e)
        {
            var ownedWindow = new TransacaoScreen();
            ownedWindow.Owner = this;
            ownedWindow.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void Button_Menu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Sair_Click(object sender, RoutedEventArgs e)
        {
            var ownedWindow = new LoginScreen();
            ownedWindow.Owner = this;
            ownedWindow.Show();
            this.Visibility = Visibility.Hidden;
        }
    }
}
