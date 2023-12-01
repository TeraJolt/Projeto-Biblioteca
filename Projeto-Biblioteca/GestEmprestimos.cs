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
    public partial class GestEmprestimos : Form
    {
        private readonly EmprestimosService emprestimosService;
        private readonly ConectaBD conectaBD;
        public GestEmprestimos(EmprestimosService _emprestimosService, ConectaBD _conectaBD)
        {
            InitializeComponent();
            emprestimosService = _emprestimosService;
            conectaBD = _conectaBD;
        }

        private void GestEmprestimos_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnPesquisaNomeAssociado_Click(object sender, EventArgs e)
        {
            string nomeInserido = txtNomeAssociado.Text;
            List<string> resultados = conectaBD.PesquisaLista("SELECT nome FROM associado WHERE nome LIKE @nome","nome",nomeInserido);
            listNomeAssociado.DataSource = resultados;           
        }

        private void listNomeAssociado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listNomeAssociado.SelectedIndex != -1)
            {
                labelAssociado.Text = listNomeAssociado.SelectedItem.ToString();
            }
        }
        private void btnPesquisaTituloLivro_Click(object sender, EventArgs e)
        {
            string tituloInserido = txtTituloLivro.Text;
            List<string> resultados = conectaBD.PesquisaLista("SELECT l.titulo FROM exemplar ex"+
                                                            " INNER JOIN livros l ON l.cod = ex.cod_livro"+
                                                            " LEFT JOIN exemplares_emprestimo ee ON ee.cod_exemplar = ex.cod"+
                                                            " WHERE l.titulo LIKE @titulo GROUP BY l.titulo HAVING COUNT(ex.cod_livro) - COUNT(CASE WHEN ee.cod_emprest IS NOT NULL THEN 1 END) > 0" +
                                                            " ORDER BY l.titulo;","titulo",tituloInserido);
            listTituloLivro.DataSource = resultados;
        }
        private void listTituloLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTituloLivro.SelectedIndex != -1)
            {
                labelLivro.Text = listTituloLivro.SelectedItem.ToString();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string nomeAssociado = labelAssociado.Text;
            string tituloLivro = labelLivro.Text;
            string[] dataTupla = selecionaData.Text.Split('/');
            string data = dataTupla[2] + "-" + dataTupla[1] + "-" + dataTupla[0];

            string retorno = emprestimosService.RegistrarEmprestimo(nomeAssociado, tituloLivro, data);

            MessageBox.Show(retorno, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtNomeAssociado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (this.AcceptButton == null)
                {
                    this.btnPesquisaNomeAssociado.PerformClick();
                }
            }
        }

        private void txtTituloLivro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (this.AcceptButton == null)
                {
                    this.btnPesquisaTituloLivro.PerformClick();
                }
            }
        }

        private void btnPesquisaNomeAssociadoDev_Click(object sender, EventArgs e)
        {
            string nomeAssociado = txtNomeAssociadoDev.Text;
            try
            {
                DataTable resultadoAssEmp = emprestimosService.AssociadosComEmprestimo(nomeAssociado);
                if (resultadoAssEmp.Rows.Count > 0)
                {
                    dGridNomeAssociado.DataSource = resultadoAssEmp;
                }
                else
                {
                    MessageBox.Show("Nenhum resultado encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dGridNomeAssociado.DataSource = null;
                    listaExemplaresDev.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dGridNomeAssociado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dGridNomeAssociado.Rows[e.RowIndex];

                object nomeAssociado = row.Cells[0].Value;
                object dataEmprestimo = row.Cells[1].Value;
                string[] dataEmprestimoTratada = dataEmprestimo.ToString().Split(' ');
                
                nomeAssociadoDev.Text = nomeAssociado.ToString();
                dataEmprestimoDev.Text = dataEmprestimoTratada[0];

                string[] data = dataEmprestimoTratada[0].Split('/');
                string dataBD = $"{data[2]}-{data[1]}-{data[0]}";

                List<string> listaExemplares = emprestimosService.ListaExemplares(nomeAssociado.ToString(), dataBD);

                listaExemplaresDev.DataSource = listaExemplares;
            }
        }

        private void btnOkDev_Click(object sender, EventArgs e)
        {
            string nomeAssociado = nomeAssociadoDev.Text;
            string[] dataEmprestimo = dataEmprestimoDev.Text.Split('/');
            string dataDB = $"{dataEmprestimo[2]}-{dataEmprestimo[1]}-{dataEmprestimo[0]}";

            string retorno = emprestimosService.EncerrarEmprestimo(nomeAssociado, dataDB);
            
            dGridNomeAssociado.DataSource = null;
            listaExemplaresDev.DataSource = null;

            nomeAssociadoDev.Text = "--";
            dataEmprestimoDev.Text = "--";

            MessageBox.Show(retorno, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtNomeAssociadoDev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (this.AcceptButton == null)
                {
                    this.btnPesquisaNomeAssociadoDev.PerformClick();
                }
            }
        }
    }
}
