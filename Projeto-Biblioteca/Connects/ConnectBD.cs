using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto_Biblioteca
{
    public class ConectaBD
    {
        private readonly string connectionString =
            "Data Source = LAPTOP-UO9FOVGK; Initial Catalog = TheLibrary;Integrated Security = True";
        /* ConectaBD(string connectionString)
        public ConectaBD(string connectionString)
        {
            _connectionString = connectionString;
        }
        */
        public SqlConnection AbrirConexao()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(connectionString);
                conexao.Open();
                return conexao;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro ao abrir a conexão: {ex.Message}");
                throw;
            }
        }

        public void FecharConexao(SqlConnection conexao)
        {
            try
            {
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro ao fechar a conexão: {ex.Message}");
                throw;
            }
        }
        public string compilaPesquisa(string entradaPesquisa)
        {
            string[] tuplaPesquisa = entradaPesquisa.Split(' ');
            string saidaPesquisa = "%";
            for (int i = 0; i < tuplaPesquisa.Length; i++)
            {
                saidaPesquisa += tuplaPesquisa[i] + "%";
            }
            return saidaPesquisa;
        }
        public List<string> PesquisaLista(string sqlCmd, string campo, string pesquisaEntrada)
        {
            List<string> resultados = new List<string>();
            string  pesquisaTratada = compilaPesquisa(pesquisaEntrada);
            try
            {
                using (SqlConnection conexao = AbrirConexao())
                {
                    using (SqlCommand comando = new SqlCommand(sqlCmd, conexao))
                    {
                        comando.Parameters.AddWithValue("@"+campo, pesquisaTratada);
                        using (SqlDataReader leitor = comando.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                resultados.Add(leitor[campo].ToString());
                            }
                        }
                    }
                    FecharConexao(conexao);
                }
            }
            catch (Exception ex)
            {
                Console.Write($"Erro: {ex.Message}");
            }
            return resultados;
        }

        public List<string> PesquisaLista(string sqlCmd,string campo)
        {
            List<string> resultados = new List<string>();
            try
            {
                using (SqlConnection conexao = AbrirConexao())
                {
                    using (SqlCommand comando = new SqlCommand(sqlCmd, conexao))
                    {
                        using (SqlDataReader leitor = comando.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                resultados.Add(leitor[campo].ToString());
                            }
                        }
                    }
                    FecharConexao(conexao);
                }
            }
            catch (Exception ex)
            {
                Console.Write($"Erro: {ex.Message}");
            }
            return resultados;
        }
        public string getCampo(string sqlCmd, string campoEntrada1, string entrada1, string campoSaida)
        {
            string resultado;
            try
            {
                using(SqlConnection conexao = AbrirConexao())
                {
                    using (SqlCommand comando = new SqlCommand(sqlCmd, conexao))
                    {
                        comando.Parameters.AddWithValue("@" + campoEntrada1, entrada1);
                        using(SqlDataReader leitor = comando.ExecuteReader())
                        {
                            if (leitor.Read())
                            {
                                resultado = leitor[campoSaida].ToString();
                                return resultado;
                            }
                        }
                    }
                    FecharConexao(conexao);
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            return null;
        }

        public string getCampo(string sqlCmd, string campoEntrada1, string entrada1, string campoEntrada2, string entrada2, string campoSaida)
        {
            string resultado;
            try
            {
                using (SqlConnection conexao = AbrirConexao())
                {
                    using (SqlCommand comando = new SqlCommand(sqlCmd, conexao))
                    {
                        comando.Parameters.AddWithValue("@" + campoEntrada1, entrada1);
                        comando.Parameters.AddWithValue("@" + campoEntrada2, entrada2);

                        using (SqlDataReader leitor = comando.ExecuteReader())
                        {
                            if (leitor.Read())
                            {
                                resultado = leitor[campoSaida].ToString();
                                return resultado;
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return "false";

        }
    }
}
