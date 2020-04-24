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
            this.chart1.Series["ChartFrecuencia"].Points.AddXY("Lunes", 1);
            this.chart1.Series["ChartFrecuencia"].Points.AddXY("Martes", 2);
            this.chart1.Series["ChartFrecuencia"].Points.AddXY("Miercoles", 0);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            chart1.Series["ChartFrecuencia"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            chart1.Series["ChartFrecuencia"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }
    }
}
