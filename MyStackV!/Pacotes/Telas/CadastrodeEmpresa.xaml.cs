using MyStack.Pacotes.Entidades;
using MyStack.Pacotes.Telas;
using MyStackV_.Pacotes.BancodeDados;
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

    public partial class CadastrodeEmpresa : Page
    {
        Usuario usuario;
        Empresa empresa;
        ConexãoBD bd;
        EmpresaBD empdb;
        UsuarioBD usuarioBD;
        public CadastrodeEmpresa()
        {
            empdb = new EmpresaBD();    
            empresa = new Empresa();
            usuario = new Usuario();    
            bd = new ConexãoBD();
            usuarioBD = new UsuarioBD();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var Caixas = new[] { SenhaEmpresa, SenhaRepUsu, SenhaEmpresa, Senha, Email, NomeEmpresa, Usuario };
           
            if (Caixas.Any(textBox => string.IsNullOrEmpty(textBox.Text)))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            else
            {
                string senha1, senha2, senha3, senha4;
               
                senha1 = Senha.Text;
                senha2 = SenhaRepUsu.Text;
                senha3 = SenhaEmpresa.Text;
                senha4 = SenharepEmpresa.Text;

                if (senha1 == senha2)
                {
                   
                    if (senha3 == senha4)
                    {
                        
                        usuario.setLogar(Usuario.Text);
                        empresa.setEmail(Email.Text);
                        empresa.setNomeEmpresa(NomeEmpresa.Text);
                        usuario.setSenha(senha1);
                        empresa.setSenhaempresa(senha3);
                    
                        bool voltar = empdb.IncluirEmpresa();
                        if(voltar == true)
                        {
                            usuario.setNivel(3);
                            string nomear = "Usuario Primario";
                            usuario.setNomeusuario(nomear);
                            empdb.ColocarIdEmpresa(empresa.getEmail());
                            MessageBox.Show("Cadastro da empresa Realizado com Sucesso");
                            int colocar = empdb.ColocarIdEmpresa(empresa.getEmail());
                            usuario.setIdempresa(colocar);
                            usuarioBD.IncluirUsuario();
                           
                        }
                        else
                        {
                            MessageBox.Show("Erro no Cadastro");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Senhas não Conhencidem");
                    }

                }
            }
           

         

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.NavigateToPage(new Login());
        }
    }
}
