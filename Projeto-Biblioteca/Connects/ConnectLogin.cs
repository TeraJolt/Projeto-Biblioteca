using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Biblioteca.Connects
{
    public class LoginService
    {
        private readonly ConectaBD conectaBD;

        public LoginService(ConectaBD _conectaBD)
        {
            conectaBD = _conectaBD;
        }

        public string RealizarLogin(string cpfForm, string senhaForm)
        {
            try
            {
                string consultaLogin = "SELECT cpf, senha FROM funcionario WHERE cpf = @cpf";

                using (SqlConnection conexao = conectaBD.AbrirConexao())
                {
                    using (SqlCommand comando = new SqlCommand(consultaLogin, conexao))
                    {
                        comando.Parameters.AddWithValue("@cpf", cpfForm);
                        using (SqlDataReader leitor = comando.ExecuteReader())
                        {
                            if (leitor.Read())
                            {
                                string senhaBD = leitor["senha"].ToString();

                                if (VerificaSenha(senhaForm, senhaBD)){
                                    conectaBD.FecharConexao(conexao);
                                    return "autenticado";//"Autenticação bem-sucedida.";
                                }
                                else
                                {
                                    conectaBD.FecharConexao(conexao);
                                    return "incorreto";//"Usuário ou senha incorretos.";
                                }
                            }
                            else
                            {
                                conectaBD.FecharConexao(conexao);
                                return "nlocal";//"Usuário não encontrado.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Ocorreu um erro durante o login: {ex.Message}";
            }

        }
        private bool VerificaSenha(string senhaInserida, string senhaBanco)
        {
            return senhaInserida == senhaBanco;
        }
    }
}
