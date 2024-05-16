using MyStackV_.Pacotes.Telas;
using MyStackV_;
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

namespace MyStack.Pacotes.Telas
{
    /// <summary>
    /// Interação lógica para CadastrarProduto.xam
    /// </summary>
    public partial class CadastrarProduto : Page
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.NavigateToPage(new PaginaInicial());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.NavigateToPage(new CadastrarSaida());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.NavigateToPage(new CadastrarEntrada());
        }
    }
}
