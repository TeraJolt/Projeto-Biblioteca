using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Biblioteca.Connects
{
    public class DashboardService
    {
        private readonly ConectaBD conectaBD;

        public DashboardService(ConectaBD _conectaBD)
        {
            conectaBD = _conectaBD;
        }

        public DataTable LivrosDisponiveis()
        {
            try
            {
                string conLiDisp = "SELECT l.titulo, COUNT(ex.cod_livro) - COUNT(CASE WHEN ee.cod_emprest IS NOT NULL THEN 1 END)" +
                        " AS qtde FROM exemplar ex INNER JOIN livros l ON l.cod = ex.cod_livro" +
                        " LEFT JOIN exemplares_emprestimo ee ON ee.cod_exemplar = ex.cod" +
                        " GROUP BY l.titulo HAVING COUNT(ex.cod_livro) - COUNT(CASE WHEN ee.cod_emprest IS NOT NULL THEN 1 END) > 0" + 
                        " ORDER BY l.titulo; ";

                using (SqlConnection conexao = conectaBD.AbrirConexao())
                {
                    using (SqlCommand comando = new SqlCommand(conLiDisp, conexao))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            conectaBD.FecharConexao(conexao);
                            return dataTable;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                throw;
            }
        }
        public DataTable LivrosEmprestados()
        {
            try
            {
                string conLiEmpr = "SELECT l.titulo, COUNT(ex.cod_livro) AS qtde FROM exemplar ex" +
                                    " INNER JOIN livros l ON l.cod = ex.cod_livro" +
                                    " INNER JOIN exemplares_emprestimo ee ON ee.cod_exemplar = ex.cod" +
                                    " GROUP BY l.titulo ORDER BY l.titulo; ";

                using (SqlConnection conexao = conectaBD.AbrirConexao())
                {
                    using (SqlCommand comando = new SqlCommand(conLiEmpr, conexao))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            conectaBD.FecharConexao(conexao);
                            return dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                throw;
            }
        }
    }
}
