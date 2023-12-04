using Projeto_Biblioteca.Classes;
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
    public partial class GestCatalogos : Form
    {
        private readonly CatalogosService catalogosService;
        private readonly ConectaBD conectaBD;
        public GestCatalogos(CatalogosService _catalogosService, ConectaBD _conectaBD)
        {
            catalogosService = _catalogosService;
            conectaBD = _conectaBD;
            InitializeComponent();
        }

        private void btnPesquisaTituloLivro_Click(object sender, EventArgs e)
        {
            string tituloLivro = txtTituloLivro.Text;
            listTituloLivro.DataSource = conectaBD.PesquisaLista("SELECT titulo FROM livros WHERE titulo LIKE @titulo ORDER BY titulo", "titulo", tituloLivro);
        }

        private void listTituloLivro_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (listTituloLivro.SelectedIndex != -1)
            {
                Livro livro = catalogosService.ExibeDadosLivro(listTituloLivro.SelectedItem.ToString());
                
                tituloDados.Text = livro.getTitulo();
                isbnDados.Text = livro.getIsbn();
                locEdicaoDados.Text = livro.getLocal_edicao();
                editoraDados.Text = livro.getEditora();
                autorDados.Text = livro.getAutor();
            }
        }

        private void btnOkAcrescentarExemplar_Click(object sender, EventArgs e)
        {
            string tituloLivro = tituloDados.Text;
            string qtdeString = qtdeExemplaresAdicionais.Value.ToString();
            int qtde = int.Parse(qtdeString);

            string retorno = catalogosService.AdicionarExemplares(tituloLivro, qtde);

            MessageBox.Show(retorno,"Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void GestCatalogos_Load(object sender, EventArgs e)
        {
            comboEditoraAdd.DataSource = conectaBD.PesquisaLista("SELECT nome FROM editora","nome");
            comboAutorAdd.DataSource = conectaBD.PesquisaLista("SELECT nome FROM autor", "nome");
        }

        private void btnLimparAdd_Click(object sender, EventArgs e)
        {
            txtTituloAdd.Text = "";
            txtIsbnAdd.Text = "";
            txtLocalEdicaoAdd.Text = "";
            comboEditoraAdd.DataSource = conectaBD.PesquisaLista("SELECT nome FROM editora", "nome");
            comboAutorAdd.DataSource = conectaBD.PesquisaLista("SELECT nome FROM autor", "nome");
        }

        private void btnAdicionarAdd_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloAdd.Text;
            string isbn = txtIsbnAdd.Text;
            string localEdicao = txtLocalEdicaoAdd.Text;
            string editora = comboEditoraAdd.Text;
            string autor = comboAutorAdd.Text;

            Livro livro = new Livro(titulo,isbn,localEdicao,editora,autor);

            string retorno = catalogosService.AdicionarLivro(livro);

            MessageBox.Show(retorno,"Informação!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void txtTituloLivro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
