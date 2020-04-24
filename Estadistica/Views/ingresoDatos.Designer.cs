namespace Estadistica.Views
{
    partial class ingresoDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingresoDatos));
            this.Composición = new System.Windows.Forms.GroupBox();
            this.columnas = new System.Windows.Forms.NumericUpDown();
            this.filas = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ingresoColumna = new System.Windows.Forms.RadioButton();
            this.ingresoFila = new System.Windows.Forms.RadioButton();
            this.datoIngresado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.noAgrupado = new System.Windows.Forms.RadioButton();
            this.siAgrupado = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.datosPoblacion = new System.Windows.Forms.RadioButton();
            this.datosMuestra = new System.Windows.Forms.RadioButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Composición.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Composición
            // 
            this.Composición.Controls.Add(this.columnas);
            this.Composición.Controls.Add(this.filas);
            this.Composición.Controls.Add(this.label2);
            this.Composición.Controls.Add(this.label1);
            this.Composición.Font = new System.Drawing.Font("PanRoman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Composición.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Composición.Location = new System.Drawing.Point(205, 28);
            this.Composición.Name = "Composición";
            this.Composición.Size = new System.Drawing.Size(223, 106);
            this.Composición.TabIndex = 0;
            this.Composición.TabStop = false;
            this.Composición.Text = "Composición";
            // 
            // columnas
            // 
            this.columnas.Location = new System.Drawing.Point(134, 62);
            this.columnas.Name = "columnas";
            this.columnas.Size = new System.Drawing.Size(68, 28);
            this.columnas.TabIndex = 3;
            this.columnas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnas.ValueChanged += new System.EventHandler(this.columnas_ValueChanged);
            // 
            // filas
            // 
            this.filas.Location = new System.Drawing.Point(134, 24);
            this.filas.Name = "filas";
            this.filas.Size = new System.Drawing.Size(68, 28);
            this.filas.TabIndex = 2;
            this.filas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.filas.ValueChanged += new System.EventHandler(this.filas_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PanRoman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Columnas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PanRoman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ingresoColumna);
            this.groupBox1.Controls.Add(this.ingresoFila);
            this.groupBox1.Controls.Add(this.bunifuFlatButton1);
            this.groupBox1.Controls.Add(this.datoIngresado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(205, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso Datos";
            // 
            // ingresoColumna
            // 
            this.ingresoColumna.AutoSize = true;
            this.ingresoColumna.Location = new System.Drawing.Point(312, 47);
            this.ingresoColumna.Name = "ingresoColumna";
            this.ingresoColumna.Size = new System.Drawing.Size(112, 29);
            this.ingresoColumna.TabIndex = 7;
            this.ingresoColumna.Text = "Columna";
            this.ingresoColumna.UseVisualStyleBackColor = true;
            // 
            // ingresoFila
            // 
            this.ingresoFila.AutoSize = true;
            this.ingresoFila.Checked = true;
            this.ingresoFila.Location = new System.Drawing.Point(242, 47);
            this.ingresoFila.Name = "ingresoFila";
            this.ingresoFila.Size = new System.Drawing.Size(64, 29);
            this.ingresoFila.TabIndex = 6;
            this.ingresoFila.TabStop = true;
            this.ingresoFila.Text = "Fila";
            this.ingresoFila.UseVisualStyleBackColor = true;
            // 
            // datoIngresado
            // 
            this.datoIngresado.Location = new System.Drawing.Point(134, 44);
            this.datoIngresado.Name = "datoIngresado";
            this.datoIngresado.Size = new System.Drawing.Size(89, 30);
            this.datoIngresado.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dato:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.noAgrupado);
            this.groupBox2.Controls.Add(this.siAgrupado);
            this.groupBox2.Font = new System.Drawing.Font("PanRoman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(434, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 106);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agrupados";
            // 
            // noAgrupado
            // 
            this.noAgrupado.AutoSize = true;
            this.noAgrupado.Location = new System.Drawing.Point(67, 62);
            this.noAgrupado.Name = "noAgrupado";
            this.noAgrupado.Size = new System.Drawing.Size(55, 27);
            this.noAgrupado.TabIndex = 3;
            this.noAgrupado.Text = "No";
            this.noAgrupado.UseVisualStyleBackColor = true;
            // 
            // siAgrupado
            // 
            this.siAgrupado.AutoSize = true;
            this.siAgrupado.Checked = true;
            this.siAgrupado.Location = new System.Drawing.Point(67, 28);
            this.siAgrupado.Name = "siAgrupado";
            this.siAgrupado.Size = new System.Drawing.Size(48, 27);
            this.siAgrupado.TabIndex = 2;
            this.siAgrupado.TabStop = true;
            this.siAgrupado.Text = "Si";
            this.siAgrupado.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(205, 247);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(681, 256);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.datosPoblacion);
            this.groupBox3.Controls.Add(this.datosMuestra);
            this.groupBox3.Font = new System.Drawing.Font("PanRoman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(663, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 106);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipos de Datos";
            // 
            // datosPoblacion
            // 
            this.datosPoblacion.AutoSize = true;
            this.datosPoblacion.Location = new System.Drawing.Point(56, 62);
            this.datosPoblacion.Name = "datosPoblacion";
            this.datosPoblacion.Size = new System.Drawing.Size(147, 27);
            this.datosPoblacion.TabIndex = 3;
            this.datosPoblacion.Text = "De Población";
            this.datosPoblacion.UseVisualStyleBackColor = true;
            // 
            // datosMuestra
            // 
            this.datosMuestra.AutoSize = true;
            this.datosMuestra.Checked = true;
            this.datosMuestra.Location = new System.Drawing.Point(56, 28);
            this.datosMuestra.Name = "datosMuestra";
            this.datosMuestra.Size = new System.Drawing.Size(134, 27);
            this.datosMuestra.TabIndex = 2;
            this.datosMuestra.TabStop = true;
            this.datosMuestra.Text = "De Muestra";
            this.datosMuestra.UseVisualStyleBackColor = true;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 7;
            this.bunifuFlatButton2.ButtonText = "      Guardar Datos";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::Estadistica.Properties.Resources.save;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(565, 510);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(321, 59);
            this.bunifuFlatButton2.TabIndex = 6;
            this.bunifuFlatButton2.Text = "      Guardar Datos";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "Ingresar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(436, 22);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Empty;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(212, 70);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.Text = "Ingresar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // ingresoDatos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1069, 684);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Composición);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ingresoDatos";
            this.Text = "ingresoDatos";
            this.Composición.ResumeLayout(false);
            this.Composición.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Composición;
        private System.Windows.Forms.NumericUpDown columnas;
        private System.Windows.Forms.NumericUpDown filas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox datoIngresado;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.RadioButton noAgrupado;
        private System.Windows.Forms.RadioButton siAgrupado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton ingresoColumna;
        private System.Windows.Forms.RadioButton ingresoFila;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton datosPoblacion;
        private System.Windows.Forms.RadioButton datosMuestra;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}