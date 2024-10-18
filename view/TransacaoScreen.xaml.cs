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

namespace UVVFintech.View
{
    /// <summary>
    /// Lógica interna para TransacaoScreen.xaml
    /// </summary>
    public partial class TransacaoScreen : Window
    {
        public TransacaoScreen()
        {
            InitializeComponent();
        }

        private void Button_Saque_Click(object sender, RoutedEventArgs e)
        {
            var ownedWindow = new SaqueScreen();
            ownedWindow.Owner = this;
            ownedWindow.Show();
            this.Visibility = Visibility.Hidden;
        }
        private void Button_Deposito_Click(object sender, RoutedEventArgs e)
        {
            var ownedWindow = new DepositoScreen();
            ownedWindow.Owner = this;
            ownedWindow.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void Button_Transferencia_Click(object sender, RoutedEventArgs e)
        {
            var ownedWindow = new TransferenciaScreen();
            ownedWindow.Owner = this;
            ownedWindow.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void Button_Outro_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Voltar_Click(object sender, RoutedEventArgs e)
        {
            var ownedWindow = new ContaScreen();
            ownedWindow.Owner = this;
            ownedWindow.Show();
            this.Visibility = Visibility.Hidden;
        }
    }
}
