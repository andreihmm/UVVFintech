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
    /// Lógica interna para CriarClienteScreen.xaml
    /// </summary>
    public partial class CriarClienteScreen : Window
    {
        public CriarClienteScreen()
        {
            InitializeComponent();
        }

        private void Button_Voltar_Click(object sender, RoutedEventArgs e)
        {
            var ownedWindow = new InicialGerenteScreen();
            ownedWindow.Owner = this;
            ownedWindow.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void Button_AdicionarCliente_Click(object sender, RoutedEventArgs e)
        {
            var ownedWindow = new ContaScreen();
            ownedWindow.Owner = this;
            ownedWindow.Show();
            this.Visibility = Visibility.Hidden;
        }
    }
}
