using Projeto_Biblioteca.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Biblioteca.Connects
{
    public class CatalogosService
    {
        private readonly ConectaBD conectaBD;

        public CatalogosService(ConectaBD _conectaBD)
        {
            conectaBD = _conectaBD;
        }

        public Livro ExibeDadosLivro(string tituloLivro)
        {
            string cmdGetDadosLivro = "SELECT l.titulo, l.isbn, l.local_edicao, ed.nome AS nome_editora, a.nome AS nome_autor FROM livros_autor la"+
                " INNER JOIN autor a ON la.cod_autor = a.cod INNER JOIN livros l ON la.cod_livro = l.cod"+
                " INNER JOIN editora ed ON l.cod_editora = ed.cod WHERE l.titulo = @titulo";
            string titulo, isbn, local_edicao, editora, autor;
            try
            {
                using(SqlConnection conexao = conectaBD.AbrirConexao())
                {
                    using(SqlCommand comando = new SqlCommand(cmdGetDadosLivro, conexao))
                    {
                        comando.Parameters.AddWithValue("@titulo", tituloLivro);
                        using (SqlDataReader leitor = comando.ExecuteReader())
                        {
                            if (leitor.Read())
                            {
                                titulo = leitor["titulo"].ToString();
                                isbn = leitor["isbn"].ToString();
                                local_edicao = leitor["local_edicao"].ToString();
                                editora = leitor["nome_editora"].ToString();
                                autor = leitor["nome_autor"].ToString();

                                Livro livro = new Livro(titulo, isbn, local_edicao, editora, autor);
                                return livro; 
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
            }
            catch
            {
                return null;
            }
        }
        public string AdicionarExemplares(string tituloLivro, int qtde)
        {
            string cmdGetCodLivro = "SELECT cod FROM livros WHERE titulo = @titulo";
            string cmdInsertExemplar = "INSERT INTO exemplar (cod_livro) VALUES (@cod_livro)";

            string codLivro = conectaBD.getCampo(cmdGetCodLivro, "titulo", tituloLivro, "cod");
            try
            {
                for (int i = 0; i < qtde; i++)
                {
                    using(SqlConnection conexao = conectaBD.AbrirConexao())
                    {
                        using(SqlCommand comando = new SqlCommand(cmdInsertExemplar, conexao))
                        {
                            comando.Parameters.AddWithValue("@cod_livro", codLivro);

                            comando.ExecuteNonQuery();
                        }
                    }
                }
                return qtde + " Exemplares adicionados com sucesso";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string AdicionarLivro(Livro livro)
        {
            string titulo = livro.getTitulo();
            string isbn = livro.getIsbn();
            string localEdicao = livro.getLocal_edicao();
            string editora = livro.getEditora();
            string autor = livro.getAutor();

            string cmdGetCodEditora = "SELECT cod FROM editora WHERE nome = @nome";
            string cmdGetCodAutor = "SELECT cod FROM autor WHERE nome = @nome";

            string cmdInsertLivro = "INSERT INTO livros (titulo, isbn, local_edicao, cod_editora)" +
                " VALUES (@titulo, @isbn, @local_edicao, @cod_editora)";

            string cmdGetCodLivro = "SELECT cod FROM livros WHERE titulo = @titulo";
            string cmdInsertLivroAutor = "INSERT INTO livros_autor (cod_livro, cod_autor) VALUES (@cod_livro, @cod_autor)";

            string codEditora = conectaBD.getCampo(cmdGetCodEditora,"nome",editora,"cod");
            string codAutor = conectaBD.getCampo(cmdGetCodAutor, "nome", autor, "cod");

            try
            {
                using(SqlConnection conexao = conectaBD.AbrirConexao())
                {
                    using(SqlCommand comando = new SqlCommand(cmdInsertLivro, conexao))
                    {
                        comando.Parameters.AddWithValue("@titulo", titulo);
                        comando.Parameters.AddWithValue("@isbn", isbn);
                        comando.Parameters.AddWithValue("@local_edicao", localEdicao);
                        comando.Parameters.AddWithValue("@cod_editora", codEditora);

                        comando.ExecuteNonQuery();
                    }
                }

                string codLivro = conectaBD.getCampo(cmdGetCodLivro,"titulo",titulo,"cod");

                using(SqlConnection conexao = conectaBD.AbrirConexao())
                {
                    using (SqlCommand comando = new SqlCommand(cmdInsertLivroAutor, conexao))
                    {
                        comando.Parameters.AddWithValue("@cod_livro", codLivro);
                        comando.Parameters.AddWithValue("@cod_autor", codAutor);

                        comando.ExecuteNonQuery();
                        return "Novo livro adicionado ao sistema!";
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
