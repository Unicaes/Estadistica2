using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
            if (SideBar.Width==270)
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
    }
}
