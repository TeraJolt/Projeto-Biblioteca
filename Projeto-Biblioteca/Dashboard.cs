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
    public partial class Dashboard : Form
    {
        public event EventHandler abrirTelaGestEmprestimos;
        public event EventHandler abrirTelaGestCatalogos;
        public event EventHandler abrirTelaGestAssociados;

        private readonly DashboardService dashboardService;
        public Dashboard(DashboardService dashboardService)
        {
            InitializeComponent();
            this.dashboardService = dashboardService;
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exibirLivrosDisponiveis()
        {
            try
            {
                DataTable resultadoLDisp = dashboardService.LivrosDisponiveis();
                if (resultadoLDisp.Rows.Count > 0)
                {
                    dgvLivDisp.DataSource = resultadoLDisp;
                }
                else
                {
                    MessageBox.Show("Nenhum resultado encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void exibirLivrosEmprestados()
        {
            try
            {
                DataTable resultadoLDisp = dashboardService.LivrosEmprestados();
                if (resultadoLDisp.Rows.Count > 0)
                {
                    dgvLivEmpr.DataSource = resultadoLDisp;
                }
                else
                {
                    //MessageBox.Show("Nenhum resultado encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            exibirLivrosDisponiveis();
            exibirLivrosEmprestados();
        }

        private void btn_Registros_Click(object sender, EventArgs e)
        {
            OnRegistrosClick(EventArgs.Empty);
            
        }
        private void btn_Catalogos_Click(object sender, EventArgs e)
        {
            OnCatalogosClick(EventArgs.Empty);
        }
        private void btnAssociados_Click(object sender, EventArgs e)
        {
            OnAssociadosClick(EventArgs.Empty);
        }
        protected virtual void OnRegistrosClick(EventArgs e)
        {
            abrirTelaGestEmprestimos?.Invoke(this, e);
        }
        protected virtual void OnCatalogosClick(EventArgs e)
        {
            abrirTelaGestCatalogos?.Invoke(this, e);
        }
        protected virtual void OnAssociadosClick(EventArgs e)
        {
            abrirTelaGestAssociados?.Invoke(this, e);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            exibirLivrosDisponiveis();
            exibirLivrosEmprestados();
        }
    }
}
