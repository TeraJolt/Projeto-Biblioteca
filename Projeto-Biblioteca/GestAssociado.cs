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
    public partial class GestAssociado : Form
    {
        private readonly ConectaAssociado conectaAssociado;
        private readonly ConectaBD conectaBD;
        public GestAssociado(ConectaAssociado _conectaAssociado, ConectaBD _conectaBD)
        {
            InitializeComponent();
            conectaAssociado = _conectaAssociado;
            conectaBD = _conectaBD;
        }

        private void btnPesquisaNomeAssociado_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisaNome.Text;

            List<string> lista = conectaBD.PesquisaLista("SELECT nome FROM associado WHERE nome LIKE @nome", "nome",pesquisa);
            listNomeAssociado.DataSource = lista;
        }

        private void listNomeAssociado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listNomeAssociado.SelectedIndex != -1)
            {
                Associado associado = conectaAssociado.ExibeDadosAssociado(listNomeAssociado.SelectedItem.ToString());

                labelCod.Text = conectaBD.getCampo("SELECT cod FROM associado WHERE nome = @nome", "nome", associado.getNome(),"cod");
                textNome.Text = associado.getNome();
                textEndereco.Text = associado.getEndereco();
                textTelefone.Text = associado.getTelefone();
                textEmail.Text = associado.getEmail();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisaNome.Text = "";
            listNomeAssociado.DataSource = null;
            labelCod.Text = "--";
            textNome.Text = "";
            textEndereco.Text = "";
            textEmail.Text = "";
            textTelefone.Text = "";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = textNome.Text;
            string endereco = textEndereco.Text;
            string email = textEmail.Text;
            string telefone = textTelefone.Text;

            Associado associado = new Associado(nome, endereco, telefone, email);

            string retorno = conectaAssociado.AdicionarAssociado(associado);

            MessageBox.Show(retorno, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string cod = labelCod.Text;
            string nome = textNome.Text;
            string endereco = textEndereco.Text;
            string email = textEmail.Text;
            string telefone = textTelefone.Text;

            Associado associado = new Associado(nome, endereco, telefone, email);

            string retorno = conectaAssociado.AtualizarAssociado(associado, cod);

            MessageBox.Show(retorno, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
