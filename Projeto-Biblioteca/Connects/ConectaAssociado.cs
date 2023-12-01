using Projeto_Biblioteca.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Biblioteca.Connects
{
    public class ConectaAssociado
    {
        private readonly ConectaBD conectaBD;

        public ConectaAssociado(ConectaBD _conectaBD)
        {
            conectaBD = _conectaBD;
        }

        public Associado ExibeDadosAssociado(string nomeAssociado)
        {
            string cmdGetDadosAssociado = "SELECT nome, endereco, telefone, email FROM associado WHERE nome = @nome";
            string nome, endereco, telefone, email;
            try
            {
                using (SqlConnection conexao = conectaBD.AbrirConexao())
                {
                    using (SqlCommand comando = new SqlCommand(cmdGetDadosAssociado, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", nomeAssociado);
                        using (SqlDataReader leitor = comando.ExecuteReader())
                        {
                            if (leitor.Read())
                            {
                                nome = leitor["nome"].ToString();
                                endereco = leitor["endereco"].ToString();
                                telefone = leitor["telefone"].ToString();
                                email = leitor["email"].ToString();

                                Associado associado = new Associado(nome,endereco,telefone,email);
                                return associado;
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
        public string AdicionarAssociado(Associado associado)
        {
            string nome = associado.getNome();
            string endereco = associado.getEndereco();
            string email = associado.getEmail();
            string telefone = associado.getTelefone();

            string cmdInsertAssociado = "INSERT INTO associado (nome, endereco, email, telefone) VALUES (@nome, @endereco, @email, @telefone)";

            try{
                using (SqlConnection conexao = conectaBD.AbrirConexao())
                {
                    using(SqlCommand comando = new SqlCommand(cmdInsertAssociado, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@endereco", endereco);
                        comando.Parameters.AddWithValue("@email", email);
                        comando.Parameters.AddWithValue("@telefone", telefone);

                        comando.ExecuteNonQuery();
                        return $"O associado {nome} foi adicionado!";
                    }
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        
        public string AtualizarAssociado(Associado associado, string cod)
        {
            string nome = associado.getNome();
            string endereco = associado.getEndereco();
            string email = associado.getEmail();
            string telefone = associado.getTelefone();

            string cmdAtualizarAssociado = "UPDATE associado SET nome = @nome, endereco = @endereco, email = @email, telefone = @telefone WHERE cod = @cod";

            try
            {
                using (SqlConnection conexao = conectaBD.AbrirConexao())
                {
                    using(SqlCommand comando = new SqlCommand(cmdAtualizarAssociado, conexao)){
                        comando.Parameters.AddWithValue("@nome",nome);
                        comando.Parameters.AddWithValue("@endereco",endereco);
                        comando.Parameters.AddWithValue("@email",email);
                        comando.Parameters.AddWithValue("@telefone",telefone);
                        comando.Parameters.AddWithValue("@cod",cod);
                        
                        comando.ExecuteNonQuery();
                        return "Cadastro Atualizado!";
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
