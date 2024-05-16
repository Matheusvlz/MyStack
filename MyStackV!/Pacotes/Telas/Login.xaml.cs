using MyStack.Pacotes.Entidades;
using MyStackV_;
using MyStackV_.Pacotes.BancodeDados;
using MyStackV_.Pacotes.Telas;
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

    public partial class Login : Page
    {
        ConexãoBD bd;
        Empresa emp;
        UsuarioBD usuario;
        public static int idEmp;
        public Login()
        {
            usuario = new UsuarioBD();    
            bd = new ConexãoBD();
            InitializeComponent();
            emp = new Empresa();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            LoginPag.Visibility = Visibility.Collapsed;

   
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.NavigateToPage(new CadastrodeEmpresa());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string us = b1.Text;
            string sn = b2.Text;
            bool status = usuario.ValidarAcesso(us, sn);  
           
         if(status == true)
            {
                
                LoginPag.Visibility = Visibility.Collapsed;

                idEmp = usuario.ColocarIdUsuario(us);
                MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
                mainWindow?.NavigateToPage(new PaginaInicial());
                MessageBox.Show("Deu Certo");
            }
            else
            {
                MessageBox.Show("Deu errado");
            }

        }
        public int ColocarId()
        {
            int id = idEmp;
            return id;
        }

        private void Logar_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void b1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
        
    

