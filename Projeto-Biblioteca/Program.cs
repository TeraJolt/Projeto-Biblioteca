using Projeto_Biblioteca.Connects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Biblioteca
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                ConectaBD conectaBD = new ConectaBD();
                LoginService loginService = new LoginService(conectaBD); 
                Login login = new Login(loginService);

                DashboardService dashboardService = new DashboardService(conectaBD);
                Dashboard dashboard = new Dashboard(dashboardService);

                EmprestimosService emprestimosService = new EmprestimosService(conectaBD);
                GestEmprestimos gestEmprestimos = new GestEmprestimos(emprestimosService, conectaBD);

                CatalogosService catalogosService = new CatalogosService(conectaBD);
                GestCatalogos gestCatalogos = new GestCatalogos(catalogosService, conectaBD);

                ConectaAssociado conectaAssociado = new ConectaAssociado(conectaBD);
                GestAssociado gestAssociado = new GestAssociado(conectaAssociado, conectaBD);

                login.LoginSucesso += (sender, e) =>
                {
                    dashboard.Show();
                    login.Hide();
                };
                dashboard.abrirTelaGestEmprestimos += (sender, e) =>
                {
                    if(gestEmprestimos == null || gestEmprestimos.IsDisposed)
                    {
                        gestEmprestimos = new GestEmprestimos(emprestimosService, conectaBD);
                    }
                    gestEmprestimos.Show();
                };
                dashboard.abrirTelaGestCatalogos += (sender, e) =>
                {
                    if (gestCatalogos == null || gestCatalogos.IsDisposed)
                    {
                        gestCatalogos = new GestCatalogos(catalogosService, conectaBD);
                    }
                    gestCatalogos.Show();
                };
                dashboard.abrirTelaGestAssociados += (sender, e) =>
                {
                    if (gestAssociado == null || gestAssociado.IsDisposed)
                    {
                        gestAssociado = new GestAssociado(conectaAssociado, conectaBD);
                    }
                    gestAssociado.Show();
                };

                Application.Run(login);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
            
        }
    }
}
