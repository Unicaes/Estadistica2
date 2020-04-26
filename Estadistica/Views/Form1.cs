using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estadistica.Functions;
using Estadistica.Views;

namespace Estadistica
{
    public partial class Form1 : Form
    {
        List<double> lista;
        ingresoDatos datos;
        GraphsView graficas;
        InfoTable tablas;
        InfoVariable variables;
        public Form1()
        {
            InitializeComponent();
        }
        #region Diseno
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnHamburguesa_Click(object sender, EventArgs e)
        {
            if (SideBar.Width == 270)
            {
                SideBar.Visible = false;
                SideBar.Width = 68;
                SideBarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(SideBar);
            }
            else
            {
                SideBar.Visible = false;
                SideBar.Width = 270;
                SideBarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                ASidebarBack.Show(SideBar);
            }
        }
        #endregion
        private void btnGraficos_Click(object sender, EventArgs e)
        {
            graficas = new GraphsView();
            this.ContentPanel.Controls.Clear();
            this.ContentPanel.Controls.Add(graficas);
            graficas.Show();
        }
        private void btnDatos_Click(object sender, EventArgs e)
        {
            datos = new ingresoDatos();
            this.ContentPanel.Controls.Clear();
            this.ContentPanel.Controls.Add(datos);
            datos.Show();
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            tablas = new InfoTable();
            this.ContentPanel.Controls.Clear();
            this.ContentPanel.Controls.Add(tablas);
            tablas.Show();
        }

        private void btnVariables_Click(object sender, EventArgs e)
        {
            variables = new InfoVariable();
            this.ContentPanel.Controls.Clear();
            this.ContentPanel.Controls.Add(variables);
            variables.Show();
        }
    }
}
