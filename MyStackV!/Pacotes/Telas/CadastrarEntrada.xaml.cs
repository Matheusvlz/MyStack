using MyStack.Pacotes.Entidades;
using MyStackV_.Pacotes.BancodeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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

namespace MyStackV_.Pacotes.Telas
{
    /// <summary>
    /// Interação lógica para CadastrarEntrada.xam
    /// </summary>
    public partial class CadastrarEntrada : Page
    {
        Produto produto;
        ProdutoBD produtobd;
        public CadastrarEntrada()
        {
            produtobd = new ProdutoBD();    
            produto = new Produto();
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.NavigateToPage(new PaginaInicial());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Caixas = new[] { Botao1, Botao2 };

            if (Caixas.Any(textBox => string.IsNullOrEmpty(textBox.Text)))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            else
            {
                produto.SetNomeproduto(Botao1.Text);
                produto.SetDescricao(Botao2.Text);
                produtobd.CadastrarProduto();
                
            }
        }
    }
}
