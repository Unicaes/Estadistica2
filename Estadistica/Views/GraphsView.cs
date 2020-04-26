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
    public partial class GraphsView : Form
    {
        public GraphsView()
        {
            InitializeComponent();
            TopLevel = false;
            if (Configuracion.agrupados)
            {
                CargarDatosAgrupados();
            }
            else
            {
                CargarDatosSimples();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            chart1.Series["ChartFrecuencia"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            chart1.Series["ChartFrecuencia"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }
        void CargarDatosSimples()
        {
            foreach (KeyValuePair<double,int> item in DatosSimples.Instance.conteo)
            {
                this.chart1.Series["ChartFrecuencia"].Points.AddXY(item.Key.ToString(), item.Value);
            }
        }
        void CargarDatosAgrupados()
        {
            for (int i = 0; i < DatosConjunto.Instance.k; i++)
            {
                this.chart1.Series["ChartFrecuencia"].Points.AddXY(DatosConjunto.Instance.Li[i]+"-"+DatosConjunto.Instance.Ls[i], DatosConjunto.Instance.f[i]);
            }
        }
    }
}
