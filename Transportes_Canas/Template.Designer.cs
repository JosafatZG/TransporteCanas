namespace ADS_PROYECT
{
    partial class Template
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Template));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Menu = new System.Windows.Forms.Panel();
            this.btnMotorista = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOrigenDestino = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAsignacion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnViajes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUnidades = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBurger = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Body = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tranPanel = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBurger)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Header.Controls.Add(this.lblTitle);
            this.Header.Controls.Add(this.bunifuImageButton2);
            this.Header.Controls.Add(this.bunifuImageButton1);
            this.tranPanel.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1080, 70);
            this.Header.TabIndex = 0;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.tranPanel.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(881, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(101, 70);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click_1);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.tranPanel.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(979, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(101, 70);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Menu.Controls.Add(this.btnMotorista);
            this.Menu.Controls.Add(this.btnCliente);
            this.Menu.Controls.Add(this.btnOrigenDestino);
            this.Menu.Controls.Add(this.btnAsignacion);
            this.Menu.Controls.Add(this.btnViajes);
            this.Menu.Controls.Add(this.btnUnidades);
            this.Menu.Controls.Add(this.btnBurger);
            this.Menu.Controls.Add(this.label2);
            this.tranPanel.SetDecoration(this.Menu, BunifuAnimatorNS.DecorationType.None);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Font = new System.Drawing.Font("Copperplate Gothic Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(0, 70);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(380, 650);
            this.Menu.TabIndex = 1;
            // 
            // btnMotorista
            // 
            this.btnMotorista.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.btnMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMotorista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMotorista.BorderRadius = 0;
            this.btnMotorista.ButtonText = "Motorista";
            this.btnMotorista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tranPanel.SetDecoration(this.btnMotorista, BunifuAnimatorNS.DecorationType.None);
            this.btnMotorista.DisabledColor = System.Drawing.Color.Gray;
            this.btnMotorista.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMotorista.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMotorista.Iconimage")));
            this.btnMotorista.Iconimage_right = null;
            this.btnMotorista.Iconimage_right_Selected = null;
            this.btnMotorista.Iconimage_Selected = null;
            this.btnMotorista.IconMarginLeft = 10;
            this.btnMotorista.IconMarginRight = 0;
            this.btnMotorista.IconRightVisible = true;
            this.btnMotorista.IconRightZoom = 0D;
            this.btnMotorista.IconVisible = true;
            this.btnMotorista.IconZoom = 100D;
            this.btnMotorista.IsTab = false;
            this.btnMotorista.Location = new System.Drawing.Point(0, 153);
            this.btnMotorista.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.btnMotorista.Name = "btnMotorista";
            this.btnMotorista.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMotorista.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.btnMotorista.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMotorista.selected = false;
            this.btnMotorista.Size = new System.Drawing.Size(380, 74);
            this.btnMotorista.TabIndex = 12;
            this.btnMotorista.Text = "Motorista";
            this.btnMotorista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMotorista.Textcolor = System.Drawing.Color.White;
            this.btnMotorista.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotorista.Click += new System.EventHandler(this.btnMotorista_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.BorderRadius = 0;
            this.btnCliente.ButtonText = "Cliente";
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tranPanel.SetDecoration(this.btnCliente, BunifuAnimatorNS.DecorationType.None);
            this.btnCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCliente.Iconimage")));
            this.btnCliente.Iconimage_right = null;
            this.btnCliente.Iconimage_right_Selected = null;
            this.btnCliente.Iconimage_Selected = null;
            this.btnCliente.IconMarginLeft = 10;
            this.btnCliente.IconMarginRight = 0;
            this.btnCliente.IconRightVisible = true;
            this.btnCliente.IconRightZoom = 0D;
            this.btnCliente.IconVisible = true;
            this.btnCliente.IconZoom = 100D;
            this.btnCliente.IsTab = false;
            this.btnCliente.Location = new System.Drawing.Point(0, 227);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCliente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.btnCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCliente.selected = false;
            this.btnCliente.Size = new System.Drawing.Size(380, 74);
            this.btnCliente.TabIndex = 11;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCliente.Textcolor = System.Drawing.Color.White;
            this.btnCliente.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnOrigenDestino
            // 
            this.btnOrigenDestino.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.btnOrigenDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnOrigenDestino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrigenDestino.BorderRadius = 0;
            this.btnOrigenDestino.ButtonText = "Origen y Destino";
            this.btnOrigenDestino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tranPanel.SetDecoration(this.btnOrigenDestino, BunifuAnimatorNS.DecorationType.None);
            this.btnOrigenDestino.DisabledColor = System.Drawing.Color.Gray;
            this.btnOrigenDestino.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOrigenDestino.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOrigenDestino.Iconimage")));
            this.btnOrigenDestino.Iconimage_right = null;
            this.btnOrigenDestino.Iconimage_right_Selected = null;
            this.btnOrigenDestino.Iconimage_Selected = null;
            this.btnOrigenDestino.IconMarginLeft = 10;
            this.btnOrigenDestino.IconMarginRight = 0;
            this.btnOrigenDestino.IconRightVisible = true;
            this.btnOrigenDestino.IconRightZoom = 0D;
            this.btnOrigenDestino.IconVisible = true;
            this.btnOrigenDestino.IconZoom = 100D;
            this.btnOrigenDestino.IsTab = false;
            this.btnOrigenDestino.Location = new System.Drawing.Point(0, 522);
            this.btnOrigenDestino.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.btnOrigenDestino.Name = "btnOrigenDestino";
            this.btnOrigenDestino.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnOrigenDestino.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.btnOrigenDestino.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOrigenDestino.selected = false;
            this.btnOrigenDestino.Size = new System.Drawing.Size(380, 74);
            this.btnOrigenDestino.TabIndex = 10;
            this.btnOrigenDestino.Text = "Origen y Destino";
            this.btnOrigenDestino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrigenDestino.Textcolor = System.Drawing.Color.White;
            this.btnOrigenDestino.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrigenDestino.Click += new System.EventHandler(this.btnOrigenDestino_Click);
            // 
            // btnAsignacion
            // 
            this.btnAsignacion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.btnAsignacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAsignacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsignacion.BorderRadius = 0;
            this.btnAsignacion.ButtonText = "Asignación de Viajes";
            this.btnAsignacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tranPanel.SetDecoration(this.btnAsignacion, BunifuAnimatorNS.DecorationType.None);
            this.btnAsignacion.DisabledColor = System.Drawing.Color.Gray;
            this.btnAsignacion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAsignacion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAsignacion.Iconimage")));
            this.btnAsignacion.Iconimage_right = null;
            this.btnAsignacion.Iconimage_right_Selected = null;
            this.btnAsignacion.Iconimage_Selected = null;
            this.btnAsignacion.IconMarginLeft = 10;
            this.btnAsignacion.IconMarginRight = 0;
            this.btnAsignacion.IconRightVisible = true;
            this.btnAsignacion.IconRightZoom = 0D;
            this.btnAsignacion.IconVisible = true;
            this.btnAsignacion.IconZoom = 100D;
            this.btnAsignacion.IsTab = false;
            this.btnAsignacion.Location = new System.Drawing.Point(0, 450);
            this.btnAsignacion.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.btnAsignacion.Name = "btnAsignacion";
            this.btnAsignacion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAsignacion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.btnAsignacion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAsignacion.selected = false;
            this.btnAsignacion.Size = new System.Drawing.Size(380, 74);
            this.btnAsignacion.TabIndex = 9;
            this.btnAsignacion.Text = "Asignación de Viajes";
            this.btnAsignacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignacion.Textcolor = System.Drawing.Color.White;
            this.btnAsignacion.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignacion.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // btnViajes
            // 
            this.btnViajes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.btnViajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnViajes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViajes.BorderRadius = 0;
            this.btnViajes.ButtonText = "Viajes";
            this.btnViajes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tranPanel.SetDecoration(this.btnViajes, BunifuAnimatorNS.DecorationType.None);
            this.btnViajes.DisabledColor = System.Drawing.Color.Gray;
            this.btnViajes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViajes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnViajes.Iconimage")));
            this.btnViajes.Iconimage_right = null;
            this.btnViajes.Iconimage_right_Selected = null;
            this.btnViajes.Iconimage_Selected = null;
            this.btnViajes.IconMarginLeft = 10;
            this.btnViajes.IconMarginRight = 0;
            this.btnViajes.IconRightVisible = true;
            this.btnViajes.IconRightZoom = 0D;
            this.btnViajes.IconVisible = true;
            this.btnViajes.IconZoom = 100D;
            this.btnViajes.IsTab = false;
            this.btnViajes.Location = new System.Drawing.Point(0, 378);
            this.btnViajes.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnViajes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.btnViajes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViajes.selected = false;
            this.btnViajes.Size = new System.Drawing.Size(380, 74);
            this.btnViajes.TabIndex = 8;
            this.btnViajes.Text = "Viajes";
            this.btnViajes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViajes.Textcolor = System.Drawing.Color.White;
            this.btnViajes.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViajes.Click += new System.EventHandler(this.btnViajes_Click);
            // 
            // btnUnidades
            // 
            this.btnUnidades.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.btnUnidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUnidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnidades.BorderRadius = 0;
            this.btnUnidades.ButtonText = "Unidades";
            this.btnUnidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tranPanel.SetDecoration(this.btnUnidades, BunifuAnimatorNS.DecorationType.None);
            this.btnUnidades.DisabledColor = System.Drawing.Color.Gray;
            this.btnUnidades.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUnidades.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUnidades.Iconimage")));
            this.btnUnidades.Iconimage_right = null;
            this.btnUnidades.Iconimage_right_Selected = null;
            this.btnUnidades.Iconimage_Selected = null;
            this.btnUnidades.IconMarginLeft = 10;
            this.btnUnidades.IconMarginRight = 0;
            this.btnUnidades.IconRightVisible = true;
            this.btnUnidades.IconRightZoom = 0D;
            this.btnUnidades.IconVisible = true;
            this.btnUnidades.IconZoom = 100D;
            this.btnUnidades.IsTab = false;
            this.btnUnidades.Location = new System.Drawing.Point(0, 304);
            this.btnUnidades.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.btnUnidades.Name = "btnUnidades";
            this.btnUnidades.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUnidades.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.btnUnidades.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUnidades.selected = false;
            this.btnUnidades.Size = new System.Drawing.Size(380, 74);
            this.btnUnidades.TabIndex = 7;
            this.btnUnidades.Text = "Unidades";
            this.btnUnidades.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnidades.Textcolor = System.Drawing.Color.White;
            this.btnUnidades.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnidades.Click += new System.EventHandler(this.btnUnidades_Click);
            // 
            // btnBurger
            // 
            this.btnBurger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBurger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tranPanel.SetDecoration(this.btnBurger, BunifuAnimatorNS.DecorationType.None);
            this.btnBurger.Image = ((System.Drawing.Image)(resources.GetObject("btnBurger.Image")));
            this.btnBurger.ImageActive = null;
            this.btnBurger.Location = new System.Drawing.Point(275, 37);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.Size = new System.Drawing.Size(71, 71);
            this.btnBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBurger.TabIndex = 4;
            this.btnBurger.TabStop = false;
            this.btnBurger.Zoom = 10;
            this.btnBurger.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tranPanel.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bienvenido";
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.tranPanel.SetDecoration(this.Body, BunifuAnimatorNS.DecorationType.None);
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(380, 70);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(700, 650);
            this.Body.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // tranPanel
            // 
            this.tranPanel.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.tranPanel.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.tranPanel.DefaultAnimation = animation2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.tranPanel.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.lblTitle.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(357, 38);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Asignación de Viajes";
            // 
            // Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Header);
            this.tranPanel.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Template";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBurger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnMotorista;
        private Bunifu.Framework.UI.BunifuFlatButton btnCliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnOrigenDestino;
        private Bunifu.Framework.UI.BunifuFlatButton btnAsignacion;
        private Bunifu.Framework.UI.BunifuFlatButton btnViajes;
        private Bunifu.Framework.UI.BunifuFlatButton btnUnidades;
        private Bunifu.Framework.UI.BunifuImageButton btnBurger;
        private System.Windows.Forms.Label label2;
        private BunifuAnimatorNS.BunifuTransition tranPanel;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        protected System.Windows.Forms.Panel Body;
        private System.Windows.Forms.Label lblTitle;
    }
}

