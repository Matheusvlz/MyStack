using MyStack.Pacotes.Entidades;
using MyStackV_.Pacotes.BancodeDados;
using MyStack.Pacotes.Telas;
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

namespace MyStackV_.Pacotes.Telas
{
   
    public partial class CadastroUsuario : Page
    {
        Login login;
        Usuario usuario;
        UsuarioBD usuariobd;
        public CadastroUsuario()
        {
            usuariobd = new UsuarioBD();
            usuario = new Usuario();
            login = new Login();    
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.NavigateToPage(new PaginaInicial());
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Caixas = new[] { NomeDeUsuario };
            var Senhas = new[] { SenhadeUsuario, RepetirSenha };

            if (Caixas.Any(textBox => string.IsNullOrEmpty(textBox.Text)) && Senhas.Any(PasswordBox => string.IsNullOrEmpty(PasswordBox.Password)))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            else
            {
                string valorSelecionado = NivelUsuario.SelectedItem != null ? ((ComboBoxItem)NivelUsuario.SelectedItem).Content.ToString() : "";
                string a = "1";
                usuario.setLogar(NomeDeUsuario.Text);
                usuario.setNivel(Convert.ToInt32(valorSelecionado));        
                usuario.setSenha(SenhadeUsuario.Password);
                usuario.setIdempresa(login.ColocarId());
               bool status =  usuariobd.IncluirUsuario();
                if (status == true)
                {
                    MessageBox.Show("Usuario Cadastrado com Sucesso!!!");
                }
                else
                {
                    MessageBox.Show("Erro no Cadastrado");
                }

            }
          
           
        }
    

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
