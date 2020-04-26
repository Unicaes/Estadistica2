namespace Estadistica.Views
{
    using Estadistica.Functions;
    using System;
    using System.Windows.Forms;
    public partial class InfoVariable : Form
    {
        public InfoVariable()
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
        #region Ni idea

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        } 
        #endregion
        void CargarDatosAgrupados()
        {
            this.lblAmplitud.Text = DatosConjunto.Instance.ancho.ToString();
            this.lblClases.Text = DatosConjunto.Instance.k.ToString();
            this.lblMedia.Text = DatosConjunto.Instance.media.ToString();
            this.lblMediana.Text = DatosConjunto.Instance.mediana.ToString();
            this.lblModa.Text = DatosConjunto.Instance.moda.ToString();
            this.lblRango.Text = DatosConjunto.Instance.rango.ToString();
            this.lblVarianza.Text = DatosConjunto.Instance.varianza.ToString();
            this.lblQ1.Text = DatosConjunto.Instance.q1.ToString();
            this.lblQ3.Text = DatosConjunto.Instance.q3.ToString();
        }
        void CargarDatosSimples()
        {
            this.lblMedia.Text = DatosSimples.Instance.media.ToString();
            this.lblMediana.Text = DatosSimples.Instance.mediana.ToString();
            this.lblModa.Text = DatosSimples.Instance.moda.ToString();
            this.lblVarianza.Text = DatosSimples.Instance.varianza.ToString();
            this.lblQ1.Text = DatosSimples.Instance.q1.ToString();
            this.lblQ3.Text = DatosSimples.Instance.q3.ToString();
        }
    }
}
