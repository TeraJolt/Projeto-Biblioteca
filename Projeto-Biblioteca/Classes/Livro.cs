using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Biblioteca.Classes
{
    public class Livro
    {
        string titulo, isbn, local_edicao, editora, autor;
        public Livro(string titulo, string isbn, string local_edicao, string editora, string autor)
        {
            setTitulo(titulo);
            setIsbn(isbn);
            setLocal_edicao(local_edicao);
            setEditora(editora);
            setAutor(autor);
        }
        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public string getTitulo()
        {
            return titulo;
        }
        public void setIsbn(string isbn)
        {
            this.isbn = isbn;
        }
        public string getIsbn()
        {
            return isbn;
        }
        public void setLocal_edicao(string local_edicao)
        {
            this.local_edicao = local_edicao;
        }
        public string getLocal_edicao()
        {
            return local_edicao;
        }
        public void setEditora(string editora)
        {
            this.editora = editora;
        }
        public string getEditora()
        {
            return editora;
        }
        public void setAutor(string autor)
        {
            this.autor = autor;
        }
        public string getAutor()
        {
            return autor;
        }
    }
}
