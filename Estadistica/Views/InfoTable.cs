using Estadistica.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica.Views
{
    public partial class InfoTable : Form
    {
        public InfoTable()
        {
            InitializeComponent();
            TopLevel = false;
            if (Configuracion.agrupados)
            {
                this.dataGridView1.Columns.Add("Limite Inferior","Limite Inferior");
                this.dataGridView1.Columns.Add("Limite Superior","Limite Superior");
                this.dataGridView1.Columns.Add("Marca de Clase","Marca de Clase");
                this.dataGridView1.Columns.Add("Frecuencia", "Frecuencia");
                this.dataGridView1.Columns.Add("Frecuencia Acumulada", "Frecuencia Acumulada");
                this.dataGridView1.Columns.Add("Frecuencia Relativa", "Frecuencia Relativa");
                this.dataGridView1.Columns.Add("(Marca - Media)^2", "(Marca - Media)^2");
                this.dataGridView1.Columns.Add("(Marca * Frecuencia)^2 * f", "(Marca * Frecuencia)^2 * f");
                CargarDatosAgrupados();
                MessageBox.Show(DatosConjunto.media.ToString());
            }
            else
            {
                this.dataGridView1.Columns.Add("Datos", "Datos");
                this.dataGridView1.Columns.Add("Frecuencia", "Frecuencia");
            }
        }
        void CargarDatosAgrupados()
        {
            for (int i = 0; i < DatosConjunto.k; i++)
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[i].Cells[0].Value = DatosConjunto.Li[i];
                this.dataGridView1.Rows[i].Cells[1].Value = DatosConjunto.Ls[i];
                this.dataGridView1.Rows[i].Cells[2].Value = DatosConjunto.x[i];
                this.dataGridView1.Rows[i].Cells[3].Value = DatosConjunto.f[i];
                this.dataGridView1.Rows[i].Cells[4].Value = DatosConjunto.Fa[i];
                this.dataGridView1.Rows[i].Cells[5].Value = DatosConjunto.Fr[i];
                this.dataGridView1.Rows[i].Cells[6].Value = DatosConjunto.xmediaCuad[i];
                this.dataGridView1.Rows[i].Cells[7].Value = DatosConjunto.xmediaCuadF[i];
            }
        }
    }
}
