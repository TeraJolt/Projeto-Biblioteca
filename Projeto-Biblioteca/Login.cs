using Projeto_Biblioteca.Connects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Biblioteca
{
    public partial class Login : Form
    {
        public event EventHandler LoginSucesso;
        private readonly LoginService loginService;
        public Login(LoginService _loginService)
        {
            InitializeComponent();
            loginService = _loginService;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text;
            string senha = txtSenha.Text;

            string autenticacao = loginService.RealizarLogin(cpf, senha);

            switch (autenticacao)
            {
                case "autenticado":
                    MessageBox.Show("Login efetuado com Sucesso!", "Sucesso");
                    Properties.Settings.Default.CpfFuncionario = cpf;
                    Properties.Settings.Default.Save();
                    OnLoginSucesso(EventArgs.Empty);
                    break;
                case "incorreto":
                    MessageBox.Show("Usuário ou senha incorretos", "Erro");
                    break;
                case "nlocal":
                    MessageBox.Show("Usuário não localizado", "Erro");
                    break;
                default:
                    MessageBox.Show(autenticacao, "Erro");
                    break;

            }
        }
        protected virtual void OnLoginSucesso(EventArgs e)
        {
            LoginSucesso?.Invoke(this, e);
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(this.AcceptButton == null)
                {
                    this.btn_login.PerformClick();
                }
            }
        }
    }
}
