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
    /// Lógica interna para DepositoScreen.xaml
    /// </summary>
    public partial class DepositoScreen : Window
    {
        public DepositoScreen()
        {
            InitializeComponent();
        }

        private void Button_Confirmar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Voltar_Click(object sender, RoutedEventArgs e)
        {
            var ownedWindow = new TransacaoScreen();
            ownedWindow.Owner = this;
            ownedWindow.Show();
            this.Visibility = Visibility.Hidden;
        }
    }
}
