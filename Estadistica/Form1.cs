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
namespace Estadistica
{
    public partial class Form1 : Form
    {
        List<double> lista;
        public Form1()
        {
            InitializeComponent();
            lista = new List<double>();
            lista.Add(15);
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);
            lista.Add(1);
            lista.Add(9);
            lista.Add(1);
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
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var k = DatosConjunto.CalcularClases(lista.Count);
            var r = DatosConjunto.CalcularRango(lista.Max(), lista.Min());
            DatosConjunto.CalcularAncho(r,k);
            DatosConjunto.CalcularDatos(lista);
        }
    }
}
