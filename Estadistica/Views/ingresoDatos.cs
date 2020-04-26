using Estadistica.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica.Views
{
    public partial class ingresoDatos : Form
    {
        private int nfilas=0, ncolumnas=0;
        public ingresoDatos()
        {
            InitializeComponent();
            TopLevel = false;
            //this.dataGridView1.BackgroundColor = Color.FromArgb(39, 41, 61);
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Rows.Add();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (nfilas<this.dataGridView1.Rows.Count && ncolumnas<this.dataGridView1.Columns.Count)
            {
                double resultado=0;
                string texto = this.datoIngresado.Text;
                if (!Double.TryParse(texto,out resultado))
                {
                    MessageBox.Show("El valor \" "+texto+" \" no es valido", "Error");
                    return;
                }
                this.dataGridView1.Rows[nfilas].Cells[ncolumnas].Value = resultado;
                nfilas++;
                if (nfilas.Equals(this.dataGridView1.Rows.Count))
                {
                    nfilas = 0;
                    ncolumnas++;
                }
            }
            else
            {
                MessageBox.Show("No queda espacio en la tabla para valores, por favor modifique la dimension de la tabla","Error");
            }
            this.datoIngresado.Text = String.Empty;
            this.datoIngresado.Focus();
        }

        private void filas_ValueChanged(object sender, EventArgs e)
        {
            var x = (NumericUpDown)sender;
            int num = (int)x.Value;
            if (num>this.dataGridView1.Rows.Count)
            {
                this.dataGridView1.Rows.Add();
            }
            else
            {
                this.dataGridView1.Rows.RemoveAt(num-1);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DatosConjunto.Instance.Limpiar();
            DatosSimples.Instance.Limpiar();
            Configuracion.agrupados = false;
            Configuracion.muestra = false;
            List<double> datos = new List<double>();
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < this.dataGridView1.Columns.Count; j++)
                {
                    if (this.dataGridView1.Rows[i].Cells[j].Value!=null)
                    {
                        datos.Add(((double)this.dataGridView1.Rows[i].Cells[j].Value));
                    }
                }
            }
            if (datosMuestra.Checked)
            {
                Configuracion.muestra = true;
            }
            else
            {
                Configuracion.muestra = false;
            }
            if (siAgrupado.Checked)
            {
                Configuracion.agrupados = true;
                DatosConjunto.Instance.CalcularClases(datos.Count);
                DatosConjunto.Instance.CalcularRango(datos.Max(), datos.Min());
                DatosConjunto.Instance.CalcularAncho();
                DatosConjunto.Instance.CalcularDatos(datos);
                DatosConjunto.Instance.CalcularCuartiles(datos);
            }
            else
            {
                Configuracion.agrupados = false;
                DatosSimples.Instance.CalcularDatos(datos);
            }
        }

        private void columnas_ValueChanged(object sender, EventArgs e)
        {
            var x = (NumericUpDown)sender;
            int num = (int)x.Value;
            if (num > this.dataGridView1.Columns.Count)
            {
                this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            }
            else
            {
                this.dataGridView1.Columns.RemoveAt(num);
            }
        }
    }
}
