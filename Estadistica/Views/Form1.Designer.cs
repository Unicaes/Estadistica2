namespace Estadistica
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.TopMenu = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHamburguesa = new System.Windows.Forms.PictureBox();
            this.SideBarWrapper = new System.Windows.Forms.Panel();
            this.SideBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnGraficos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTabla = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVariables = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDatos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ContentWrapper = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Curva = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.ASidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.DashboardMover = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.CurvaContenido = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHamburguesa)).BeginInit();
            this.SideBarWrapper.SuspendLayout();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ContentWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.TopMenu.Controls.Add(this.btnMinimizar);
            this.TopMenu.Controls.Add(this.btnCerrar);
            this.TopMenu.Controls.Add(this.label1);
            this.TopMenu.Controls.Add(this.btnHamburguesa);
            this.ASidebarBack.SetDecoration(this.TopMenu, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.TopMenu, BunifuAnimatorNS.DecorationType.None);
            this.TopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(1400, 80);
            this.TopMenu.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            this.AnimacionSidebar.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.ASidebarBack.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimizar.Image = global::Estadistica.Properties.Resources.Minimize_Window_2_48px;
            this.btnMinimizar.Location = new System.Drawing.Point(1322, 24);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.AnimacionSidebar.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.ASidebarBack.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrar.Image = global::Estadistica.Properties.Resources.Close_Window__2_48px;
            this.btnCerrar.Location = new System.Drawing.Point(1358, 24);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.ASidebarBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Poppins", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            // 
            // btnHamburguesa
            // 
            this.AnimacionSidebar.SetDecoration(this.btnHamburguesa, BunifuAnimatorNS.DecorationType.None);
            this.ASidebarBack.SetDecoration(this.btnHamburguesa, BunifuAnimatorNS.DecorationType.None);
            this.btnHamburguesa.Image = global::Estadistica.Properties.Resources.Menu_48px;
            this.btnHamburguesa.Location = new System.Drawing.Point(12, 24);
            this.btnHamburguesa.Name = "btnHamburguesa";
            this.btnHamburguesa.Size = new System.Drawing.Size(30, 30);
            this.btnHamburguesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHamburguesa.TabIndex = 0;
            this.btnHamburguesa.TabStop = false;
            this.btnHamburguesa.Click += new System.EventHandler(this.btnHamburguesa_Click);
            // 
            // SideBarWrapper
            // 
            this.SideBarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SideBarWrapper.Controls.Add(this.SideBar);
            this.ASidebarBack.SetDecoration(this.SideBarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SideBarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SideBarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarWrapper.Location = new System.Drawing.Point(0, 80);
            this.SideBarWrapper.Name = "SideBarWrapper";
            this.SideBarWrapper.Size = new System.Drawing.Size(300, 720);
            this.SideBarWrapper.TabIndex = 1;
            // 
            // SideBar
            // 
            this.SideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SideBar.BackgroundImage")));
            this.SideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SideBar.Controls.Add(this.label2);
            this.SideBar.Controls.Add(this.pictureBox1);
            this.SideBar.Controls.Add(this.LineaSidebar);
            this.SideBar.Controls.Add(this.btnGraficos);
            this.SideBar.Controls.Add(this.btnTabla);
            this.SideBar.Controls.Add(this.btnVariables);
            this.SideBar.Controls.Add(this.btnDatos);
            this.ASidebarBack.SetDecoration(this.SideBar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SideBar, BunifuAnimatorNS.DecorationType.None);
            this.SideBar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.SideBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.SideBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.SideBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SideBar.Location = new System.Drawing.Point(15, 20);
            this.SideBar.Name = "SideBar";
            this.SideBar.Quality = 10;
            this.SideBar.Size = new System.Drawing.Size(270, 684);
            this.SideBar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.ASidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Poppins", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "ESTADISTICA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.ASidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Estadistica.Properties.Resources.Menu_48px;
            this.pictureBox1.Location = new System.Drawing.Point(17, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.ASidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(2, 94);
            this.LineaSidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(252, 1);
            this.LineaSidebar.TabIndex = 5;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // btnGraficos
            // 
            this.btnGraficos.Activecolor = System.Drawing.Color.Transparent;
            this.btnGraficos.BackColor = System.Drawing.Color.Transparent;
            this.btnGraficos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGraficos.BorderRadius = 7;
            this.btnGraficos.ButtonText = "      Gráficos";
            this.btnGraficos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnGraficos, BunifuAnimatorNS.DecorationType.None);
            this.ASidebarBack.SetDecoration(this.btnGraficos, BunifuAnimatorNS.DecorationType.None);
            this.btnGraficos.DisabledColor = System.Drawing.Color.Gray;
            this.btnGraficos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGraficos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGraficos.Iconimage")));
            this.btnGraficos.Iconimage_right = null;
            this.btnGraficos.Iconimage_right_Selected = null;
            this.btnGraficos.Iconimage_Selected = null;
            this.btnGraficos.IconMarginLeft = 0;
            this.btnGraficos.IconMarginRight = 0;
            this.btnGraficos.IconRightVisible = true;
            this.btnGraficos.IconRightZoom = 0D;
            this.btnGraficos.IconVisible = true;
            this.btnGraficos.IconZoom = 100D;
            this.btnGraficos.IsTab = false;
            this.btnGraficos.Location = new System.Drawing.Point(2, 309);
            this.btnGraficos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnGraficos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnGraficos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGraficos.selected = false;
            this.btnGraficos.Size = new System.Drawing.Size(252, 59);
            this.btnGraficos.TabIndex = 4;
            this.btnGraficos.Text = "      Gráficos";
            this.btnGraficos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraficos.Textcolor = System.Drawing.Color.White;
            this.btnGraficos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficos.Click += new System.EventHandler(this.btnGraficos_Click);
            // 
            // btnTabla
            // 
            this.btnTabla.Activecolor = System.Drawing.Color.Transparent;
            this.btnTabla.BackColor = System.Drawing.Color.Transparent;
            this.btnTabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTabla.BorderRadius = 7;
            this.btnTabla.ButtonText = "      Tabla";
            this.btnTabla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnTabla, BunifuAnimatorNS.DecorationType.None);
            this.ASidebarBack.SetDecoration(this.btnTabla, BunifuAnimatorNS.DecorationType.None);
            this.btnTabla.DisabledColor = System.Drawing.Color.Gray;
            this.btnTabla.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabla.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTabla.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTabla.Iconimage")));
            this.btnTabla.Iconimage_right = null;
            this.btnTabla.Iconimage_right_Selected = null;
            this.btnTabla.Iconimage_Selected = null;
            this.btnTabla.IconMarginLeft = 0;
            this.btnTabla.IconMarginRight = 0;
            this.btnTabla.IconRightVisible = true;
            this.btnTabla.IconRightZoom = 0D;
            this.btnTabla.IconVisible = true;
            this.btnTabla.IconZoom = 100D;
            this.btnTabla.IsTab = false;
            this.btnTabla.Location = new System.Drawing.Point(2, 242);
            this.btnTabla.Margin = new System.Windows.Forms.Padding(4);
            this.btnTabla.Name = "btnTabla";
            this.btnTabla.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTabla.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnTabla.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTabla.selected = false;
            this.btnTabla.Size = new System.Drawing.Size(252, 59);
            this.btnTabla.TabIndex = 3;
            this.btnTabla.Text = "      Tabla";
            this.btnTabla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabla.Textcolor = System.Drawing.Color.White;
            this.btnTabla.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabla.Click += new System.EventHandler(this.btnTabla_Click);
            // 
            // btnVariables
            // 
            this.btnVariables.Activecolor = System.Drawing.Color.Transparent;
            this.btnVariables.BackColor = System.Drawing.Color.Transparent;
            this.btnVariables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVariables.BorderRadius = 7;
            this.btnVariables.ButtonText = "      Variables";
            this.btnVariables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnVariables, BunifuAnimatorNS.DecorationType.None);
            this.ASidebarBack.SetDecoration(this.btnVariables, BunifuAnimatorNS.DecorationType.None);
            this.btnVariables.DisabledColor = System.Drawing.Color.Gray;
            this.btnVariables.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVariables.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVariables.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVariables.Iconimage")));
            this.btnVariables.Iconimage_right = null;
            this.btnVariables.Iconimage_right_Selected = null;
            this.btnVariables.Iconimage_Selected = null;
            this.btnVariables.IconMarginLeft = 0;
            this.btnVariables.IconMarginRight = 0;
            this.btnVariables.IconRightVisible = true;
            this.btnVariables.IconRightZoom = 0D;
            this.btnVariables.IconVisible = true;
            this.btnVariables.IconZoom = 100D;
            this.btnVariables.IsTab = false;
            this.btnVariables.Location = new System.Drawing.Point(2, 175);
            this.btnVariables.Margin = new System.Windows.Forms.Padding(4);
            this.btnVariables.Name = "btnVariables";
            this.btnVariables.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVariables.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnVariables.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVariables.selected = false;
            this.btnVariables.Size = new System.Drawing.Size(252, 59);
            this.btnVariables.TabIndex = 2;
            this.btnVariables.Text = "      Variables";
            this.btnVariables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVariables.Textcolor = System.Drawing.Color.White;
            this.btnVariables.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnDatos
            // 
            this.btnDatos.Activecolor = System.Drawing.Color.Transparent;
            this.btnDatos.BackColor = System.Drawing.Color.Transparent;
            this.btnDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDatos.BorderRadius = 7;
            this.btnDatos.ButtonText = "      Datos";
            this.btnDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.btnDatos, BunifuAnimatorNS.DecorationType.None);
            this.ASidebarBack.SetDecoration(this.btnDatos, BunifuAnimatorNS.DecorationType.None);
            this.btnDatos.DisabledColor = System.Drawing.Color.Gray;
            this.btnDatos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDatos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDatos.Iconimage")));
            this.btnDatos.Iconimage_right = null;
            this.btnDatos.Iconimage_right_Selected = null;
            this.btnDatos.Iconimage_Selected = null;
            this.btnDatos.IconMarginLeft = 0;
            this.btnDatos.IconMarginRight = 0;
            this.btnDatos.IconRightVisible = true;
            this.btnDatos.IconRightZoom = 0D;
            this.btnDatos.IconVisible = true;
            this.btnDatos.IconZoom = 100D;
            this.btnDatos.IsTab = false;
            this.btnDatos.Location = new System.Drawing.Point(2, 108);
            this.btnDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDatos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnDatos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDatos.selected = false;
            this.btnDatos.Size = new System.Drawing.Size(252, 59);
            this.btnDatos.TabIndex = 1;
            this.btnDatos.Text = "      Datos";
            this.btnDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatos.Textcolor = System.Drawing.Color.White;
            this.btnDatos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // ContentWrapper
            // 
            this.ContentWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ContentWrapper.Controls.Add(this.ContentPanel);
            this.ASidebarBack.SetDecoration(this.ContentWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.ContentWrapper, BunifuAnimatorNS.DecorationType.None);
            this.ContentWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentWrapper.Location = new System.Drawing.Point(300, 80);
            this.ContentWrapper.Name = "ContentWrapper";
            this.ContentWrapper.Size = new System.Drawing.Size(1100, 720);
            this.ContentWrapper.TabIndex = 2;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.AnimacionSidebar.SetDecoration(this.ContentPanel, BunifuAnimatorNS.DecorationType.None);
            this.ASidebarBack.SetDecoration(this.ContentPanel, BunifuAnimatorNS.DecorationType.None);
            this.ContentPanel.Location = new System.Drawing.Point(19, 20);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1069, 684);
            this.ContentPanel.TabIndex = 0;
            // 
            // Curva
            // 
            this.Curva.ElipseRadius = 7;
            this.Curva.TargetControl = this.SideBar;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionSidebar.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 1;
            animation3.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 2F;
            animation3.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation3;
            // 
            // ASidebarBack
            // 
            this.ASidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.ASidebarBack.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.ASidebarBack.DefaultAnimation = animation4;
            // 
            // DashboardMover
            // 
            this.DashboardMover.Fixed = true;
            this.DashboardMover.Horizontal = true;
            this.DashboardMover.TargetControl = this.TopMenu;
            this.DashboardMover.Vertical = true;
            // 
            // CurvaContenido
            // 
            this.CurvaContenido.ElipseRadius = 7;
            this.CurvaContenido.TargetControl = this.ContentPanel;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.ContentWrapper);
            this.Controls.Add(this.SideBarWrapper);
            this.Controls.Add(this.TopMenu);
            this.ASidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHamburguesa)).EndInit();
            this.SideBarWrapper.ResumeLayout(false);
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ContentWrapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopMenu;
        private System.Windows.Forms.Panel SideBarWrapper;
        private System.Windows.Forms.Panel ContentWrapper;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnHamburguesa;
        private Bunifu.Framework.UI.BunifuGradientPanel SideBar;
        private Bunifu.Framework.UI.BunifuFlatButton btnGraficos;
        private Bunifu.Framework.UI.BunifuFlatButton btnTabla;
        private Bunifu.Framework.UI.BunifuFlatButton btnVariables;
        private Bunifu.Framework.UI.BunifuFlatButton btnDatos;
        private Bunifu.Framework.UI.BunifuElipse Curva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition ASidebarBack;
        private System.Windows.Forms.FlowLayoutPanel ContentPanel;
        private Bunifu.Framework.UI.BunifuDragControl DashboardMover;
        private Bunifu.Framework.UI.BunifuElipse CurvaContenido;
    }
}

