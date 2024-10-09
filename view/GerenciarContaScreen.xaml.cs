using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using UVVFintech.control;
using UVVFintech.model;

namespace UVVFintech.View
{
    /// <summary>
    /// Lógica interna para GerenciarContaScreen.xaml
    /// </summary>
    public partial class GerenciarContaScreen : Window
    {
        private GerenciadorDeContas objClasseConta = new();
        private BindingList<Conta> objClasseListDataGridConta = new();
        public GerenciarContaScreen()
        {
            InitializeComponent();
            DataGrid_Conta.ItemsSource = objClasseListDataGridConta;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
