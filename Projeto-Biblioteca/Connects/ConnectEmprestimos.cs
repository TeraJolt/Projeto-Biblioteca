using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Projeto_Biblioteca.Connects
{
    public class EmprestimosService
    {
        private readonly ConectaBD conectaBD;

        public EmprestimosService(ConectaBD _conectaBD)
        {
            conectaBD = _conectaBD;
        }

        public string RegistrarEmprestimo(string nomeAssociado, string tituloLivro, string data)
        {
            string cpfFuncionario = Properties.Settings.Default.CpfFuncionario;

            try
            {
                string cmdGetCodAssociado = "SELECT cod FROM associado WHERE nome = @nome";
                string cmdGetCodExemplar = "SELECT TOP 1 ex.cod FROM livros l INNER JOIN exemplar ex ON ex.cod_livro = l.cod" +
                    " WHERE l.titulo = @titulo and ex.cod NOT IN (SELECT cod_exemplar FROM exemplares_emprestimo)";
                string cmdGetCodFuncionario = "SELECT cod FROM funcionario WHERE cpf = @cpf";
                string cmdSetEmprestimo = "INSERT INTO emprestimo (data, cod_associado, cod_funcionario) VALUES (@data, @codAssociado, @codFuncionario)";
                string cmdGetCodEmprestimo = "SELECT cod FROM emprestimo WHERE cod_associado = @cod_associado AND data = @data";
                string cmdSetExempEmprest = "INSERT INTO exemplares_emprestimo (cod_exemplar, cod_emprest) VALUES (@cod_exemplar, @cod_emprestimo)";

                string codAssociado, codExemplar, codFuncionario, codEmprestimo;

                codAssociado = conectaBD.getCampo(cmdGetCodAssociado, "nome", nomeAssociado, "cod");
                codExemplar = conectaBD.getCampo(cmdGetCodExemplar, "titulo", tituloLivro, "cod");
                codFuncionario = conectaBD.getCampo(cmdGetCodFuncionario, "cpf", cpfFuncionario, "cod");
                codEmprestimo = conectaBD.getCampo(cmdGetCodEmprestimo, "cod_associado", codAssociado, "data", data, "cod");

                if (codEmprestimo == "false"){
                    try
                    {
                        using (SqlConnection conexao = conectaBD.AbrirConexao())
                        {
                            using (SqlCommand comando = new SqlCommand(cmdSetEmprestimo, conexao))
                            {
                                comando.Parameters.AddWithValue("@data", data);
                                comando.Parameters.AddWithValue("@codAssociado", codAssociado);
                                comando.Parameters.AddWithValue("@codFuncionario", codFuncionario);

                                comando.ExecuteNonQuery();
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        return ex.Message;
                    }
                }
                codEmprestimo = conectaBD.getCampo(cmdGetCodEmprestimo, "cod_associado", codAssociado, "data", data, "cod");
                try
                {
                    using (SqlConnection conexao = conectaBD.AbrirConexao())
                    {
                        using(SqlCommand comando = new SqlCommand(cmdSetExempEmprest, conexao))
                        {
                            comando.Parameters.AddWithValue("@cod_exemplar", codExemplar);
                            comando.Parameters.AddWithValue("@cod_emprestimo", codEmprestimo);

                            comando.ExecuteNonQuery();
                        }
                    }
                }
                catch(Exception ex)
                {
                    return ex.Message;
                }
                return "Empréstimo realizado com Sucesso!";
            }
            
            catch(Exception ex)
            {
                return $"Erro: {ex.Message}";
            }

        }
        public DataTable AssociadosComEmprestimo(string nomeAssociado)
        {
            string cmdGetNomeDataEmprestimo = "SELECT a.nome, e.data FROM associado a" +
                                            " INNER JOIN emprestimo e ON e.cod_associado = a.cod" +
                                            " WHERE a.nome LIKE @nome ORDER BY e.data, a.nome";
            string pesquisaAssociado = conectaBD.compilaPesquisa(nomeAssociado);

            using(SqlConnection conexao = conectaBD.AbrirConexao())
            {
                using(SqlCommand comando = new SqlCommand(cmdGetNomeDataEmprestimo, conexao))
                {
                    comando.Parameters.AddWithValue("@nome",pesquisaAssociado);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
        public List<string> ListaExemplares(string nomeAssociado, string data)
        {
            List<string> resultados = new List<string>();
            string cmdGetCodAssociado = "SELECT cod FROM associado WHERE nome = @nome";
            string cmdGetExemplares = "SELECT l.titulo FROM livros l" + 
                                    " INNER JOIN exemplar ex ON ex.cod_livro = l.cod" +
                                    " INNER JOIN exemplares_emprestimo ee ON ee.cod_exemplar = ex.cod" +
                                    " INNER JOIN emprestimo ep ON ep.cod = ee.cod_emprest" +
                                    " WHERE ep.cod_associado = @cod_associado AND ep.data = @data" +
                                    " ORDER BY l.titulo; ";

            string codAssociado = conectaBD.getCampo(cmdGetCodAssociado, "nome", nomeAssociado, "cod");
            try
            {
                using(SqlConnection conexao = conectaBD.AbrirConexao())
                {
                    using(SqlCommand comando = new SqlCommand(cmdGetExemplares,conexao))
                    {
                        comando.Parameters.AddWithValue("@cod_associado", codAssociado);
                        comando.Parameters.AddWithValue("@data", data);
                        using (SqlDataReader leitor = comando.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                resultados.Add(leitor["titulo"].ToString());
                            }

                        }
                    }
                }
            }
            catch(Exception ex)
            {
                resultados.Add($"\n{ex.Message}");
            }
            return resultados;
        }
        public string EncerrarEmprestimo(string nomeAssociado, string data)
        {
            string cmdGetCodAssociado = "SELECT cod FROM associado WHERE nome = @nome";
            string cmdGetCodEmprest = "SELECT cod FROM emprestimo WHERE cod_associado = @cod_associado AND data = @data";
            string cmdDelExempEmprest = "DELETE FROM exemplares_emprestimo WHERE cod_emprest = @cod_emprest";
            string cmdDelEmprest = "DELETE FROM emprestimo WHERE cod = @cod";

            string codAssociado = conectaBD.getCampo(cmdGetCodAssociado, "nome", nomeAssociado, "cod");
            string codEmprest = conectaBD.getCampo(cmdGetCodEmprest, "cod_associado", codAssociado, "data", data, "cod");

            try
            {
                using(SqlConnection conexao = conectaBD.AbrirConexao())
                {
                    using(SqlCommand comando = new SqlCommand(cmdDelExempEmprest, conexao))
                    {
                        comando.Parameters.AddWithValue("@cod_emprest", codEmprest);

                        comando.ExecuteNonQuery();
                    }
                }

                using (SqlConnection conexao = conectaBD.AbrirConexao())
                {
                    using (SqlCommand comando = new SqlCommand(cmdDelEmprest, conexao))
                    {
                        comando.Parameters.AddWithValue("@cod", codEmprest);

                        comando.ExecuteNonQuery();
                        return "Devolução realizada!";
                    }
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
