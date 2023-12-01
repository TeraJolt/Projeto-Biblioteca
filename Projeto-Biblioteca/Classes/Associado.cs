using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Biblioteca.Classes
{
    public class Associado
    {
        private string nome, endereco, telefone, email;
        public Associado(string nome, string endereco, string telefone, string email)
        {
            setNome(nome);
            setEndereco(endereco);
            setTelefone(telefone);
            setEmail(email);
        } 

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }

        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }
        public string getEndereco()
        {
            return endereco;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public string getTelefone()
        {
            return telefone;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return email;
        }
    }
}
