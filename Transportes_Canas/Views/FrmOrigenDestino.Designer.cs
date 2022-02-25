namespace Transportes_Canas.Views
{
    partial class FrmOrigenDestino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrigenDestino));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbStateOriginPlace = new System.Windows.Forms.ComboBox();
            this.cmbCityOriginPlace = new System.Windows.Forms.ComboBox();
            this.cmbCountryOriginPlace = new System.Windows.Forms.ComboBox();
            this.txtDescriptionOriginPlace = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvOriginPlace = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbStateDestinationPlace = new System.Windows.Forms.ComboBox();
            this.cmbCityDestinationPlace = new System.Windows.Forms.ComboBox();
            this.cmbCountryDestinationPlace = new System.Windows.Forms.ComboBox();
            this.txtDescriptionDestinationPlace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvDestinationPlace = new System.Windows.Forms.DataGridView();
            this.frmErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOriginPlace)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinationPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1096, 671);
            this.tabControl1.TabIndex = 62;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.tabPage1.Controls.Add(this.cmbStateOriginPlace);
            this.tabPage1.Controls.Add(this.cmbCityOriginPlace);
            this.tabPage1.Controls.Add(this.cmbCountryOriginPlace);
            this.tabPage1.Controls.Add(this.txtDescriptionOriginPlace);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.bunifuImageButton1);
            this.tabPage1.Controls.Add(this.bunifuSeparator1);
            this.tabPage1.Controls.Add(this.bunifuImageButton3);
            this.tabPage1.Controls.Add(this.bunifuImageButton2);
            this.tabPage1.Controls.Add(this.dgvOriginPlace);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1088, 642);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lugar de origen";
            // 
            // cmbStateOriginPlace
            // 
            this.cmbStateOriginPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStateOriginPlace.FormattingEnabled = true;
            this.cmbStateOriginPlace.Location = new System.Drawing.Point(806, 10);
            this.cmbStateOriginPlace.Name = "cmbStateOriginPlace";
            this.cmbStateOriginPlace.Size = new System.Drawing.Size(232, 24);
            this.cmbStateOriginPlace.TabIndex = 82;
            this.cmbStateOriginPlace.SelectedIndexChanged += new System.EventHandler(this.CmbStateOriginPlace_SelectedIndexChanged);
            this.cmbStateOriginPlace.SelectedValueChanged += new System.EventHandler(this.CmbStateOriginPlace_SelectedValueChanged);
            // 
            // cmbCityOriginPlace
            // 
            this.cmbCityOriginPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCityOriginPlace.FormattingEnabled = true;
            this.cmbCityOriginPlace.Location = new System.Drawing.Point(110, 76);
            this.cmbCityOriginPlace.Name = "cmbCityOriginPlace";
            this.cmbCityOriginPlace.Size = new System.Drawing.Size(255, 24);
            this.cmbCityOriginPlace.TabIndex = 81;
            // 
            // cmbCountryOriginPlace
            // 
            this.cmbCountryOriginPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountryOriginPlace.FormattingEnabled = true;
            this.cmbCountryOriginPlace.Location = new System.Drawing.Point(89, 5);
            this.cmbCountryOriginPlace.Name = "cmbCountryOriginPlace";
            this.cmbCountryOriginPlace.Size = new System.Drawing.Size(276, 24);
            this.cmbCountryOriginPlace.TabIndex = 80;
            this.cmbCountryOriginPlace.SelectedIndexChanged += new System.EventHandler(this.CmbCountryOriginPlace_SelectedIndexChanged);
            this.cmbCountryOriginPlace.SelectedValueChanged += new System.EventHandler(this.CmbCountryOriginPlace_SelectedValueChanged);
            // 
            // txtDescriptionOriginPlace
            // 
            this.txtDescriptionOriginPlace.Location = new System.Drawing.Point(151, 158);
            this.txtDescriptionOriginPlace.Multiline = true;
            this.txtDescriptionOriginPlace.Name = "txtDescriptionOriginPlace";
            this.txtDescriptionOriginPlace.Size = new System.Drawing.Size(887, 94);
            this.txtDescriptionOriginPlace.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(591, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 23);
            this.label6.TabIndex = 72;
            this.label6.Text = "Estado/Departamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 71;
            this.label5.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 69;
            this.label2.Text = "Ciudad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 67;
            this.label1.Text = "País:";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(976, 303);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(106, 107);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 63;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(7, 259);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1075, 18);
            this.bunifuSeparator1.TabIndex = 66;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(976, 529);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(106, 107);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 65;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.BunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(976, 416);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(106, 107);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 64;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.BunifuImageButton2_Click);
            // 
            // dgvOriginPlace
            // 
            this.dgvOriginPlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOriginPlace.Location = new System.Drawing.Point(7, 303);
            this.dgvOriginPlace.Name = "dgvOriginPlace";
            this.dgvOriginPlace.ReadOnly = true;
            this.dgvOriginPlace.RowHeadersWidth = 51;
            this.dgvOriginPlace.RowTemplate.Height = 24;
            this.dgvOriginPlace.Size = new System.Drawing.Size(963, 333);
            this.dgvOriginPlace.TabIndex = 62;
            this.dgvOriginPlace.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOriginPlace_CellDoubleClick);
            this.dgvOriginPlace.BindingContextChanged += new System.EventHandler(this.DgvOriginPlace_BindingContextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.tabPage2.Controls.Add(this.cmbStateDestinationPlace);
            this.tabPage2.Controls.Add(this.cmbCityDestinationPlace);
            this.tabPage2.Controls.Add(this.cmbCountryDestinationPlace);
            this.tabPage2.Controls.Add(this.txtDescriptionDestinationPlace);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.bunifuImageButton4);
            this.tabPage2.Controls.Add(this.bunifuSeparator2);
            this.tabPage2.Controls.Add(this.bunifuImageButton5);
            this.tabPage2.Controls.Add(this.bunifuImageButton6);
            this.tabPage2.Controls.Add(this.dgvDestinationPlace);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1088, 642);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lugar de destino";
            // 
            // cmbStateDestinationPlace
            // 
            this.cmbStateDestinationPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStateDestinationPlace.FormattingEnabled = true;
            this.cmbStateDestinationPlace.Location = new System.Drawing.Point(824, 11);
            this.cmbStateDestinationPlace.Name = "cmbStateDestinationPlace";
            this.cmbStateDestinationPlace.Size = new System.Drawing.Size(214, 24);
            this.cmbStateDestinationPlace.TabIndex = 95;
            this.cmbStateDestinationPlace.SelectedIndexChanged += new System.EventHandler(this.CmbStateDestinationPlace_SelectedIndexChanged);
            this.cmbStateDestinationPlace.SelectedValueChanged += new System.EventHandler(this.CmbStateDestinationPlace_SelectedValueChanged);
            // 
            // cmbCityDestinationPlace
            // 
            this.cmbCityDestinationPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCityDestinationPlace.FormattingEnabled = true;
            this.cmbCityDestinationPlace.Location = new System.Drawing.Point(112, 78);
            this.cmbCityDestinationPlace.Name = "cmbCityDestinationPlace";
            this.cmbCityDestinationPlace.Size = new System.Drawing.Size(257, 24);
            this.cmbCityDestinationPlace.TabIndex = 94;
            // 
            // cmbCountryDestinationPlace
            // 
            this.cmbCountryDestinationPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountryDestinationPlace.FormattingEnabled = true;
            this.cmbCountryDestinationPlace.Location = new System.Drawing.Point(91, 7);
            this.cmbCountryDestinationPlace.Name = "cmbCountryDestinationPlace";
            this.cmbCountryDestinationPlace.Size = new System.Drawing.Size(278, 24);
            this.cmbCountryDestinationPlace.TabIndex = 93;
            this.cmbCountryDestinationPlace.SelectedIndexChanged += new System.EventHandler(this.CmbCountryDestinationPlace_SelectedIndexChanged);
            this.cmbCountryDestinationPlace.SelectedValueChanged += new System.EventHandler(this.CmbCountryDestinationPlace_SelectedValueChanged);
            // 
            // txtDescriptionDestinationPlace
            // 
            this.txtDescriptionDestinationPlace.Location = new System.Drawing.Point(153, 160);
            this.txtDescriptionDestinationPlace.Multiline = true;
            this.txtDescriptionDestinationPlace.Name = "txtDescriptionDestinationPlace";
            this.txtDescriptionDestinationPlace.Size = new System.Drawing.Size(885, 82);
            this.txtDescriptionDestinationPlace.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(609, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 23);
            this.label3.TabIndex = 88;
            this.label3.Text = "Estado/Departamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 87;
            this.label4.Text = "Descripción:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 86;
            this.label7.Text = "Ciudad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(29, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 85;
            this.label8.Text = "País:";
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(976, 294);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(106, 107);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 81;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.BunifuImageButton4_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(9, 249);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1072, 38);
            this.bunifuSeparator2.TabIndex = 84;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(976, 520);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(106, 107);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 83;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            this.bunifuImageButton5.Click += new System.EventHandler(this.BunifuImageButton5_Click);
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(976, 407);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(106, 107);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 82;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.BunifuImageButton6_Click);
            // 
            // dgvDestinationPlace
            // 
            this.dgvDestinationPlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinationPlace.Location = new System.Drawing.Point(9, 294);
            this.dgvDestinationPlace.Name = "dgvDestinationPlace";
            this.dgvDestinationPlace.ReadOnly = true;
            this.dgvDestinationPlace.RowHeadersWidth = 51;
            this.dgvDestinationPlace.RowTemplate.Height = 24;
            this.dgvDestinationPlace.Size = new System.Drawing.Size(961, 333);
            this.dgvDestinationPlace.TabIndex = 80;
            this.dgvDestinationPlace.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDestinationPlace_CellContentClick);
            this.dgvDestinationPlace.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDestinationPlace_CellContentDoubleClick);
            this.dgvDestinationPlace.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDestinationPlace_CellDoubleClick);
            this.dgvDestinationPlace.BindingContextChanged += new System.EventHandler(this.DgvDestinationPlace_BindingContextChanged);
            // 
            // frmErrorProvider
            // 
            this.frmErrorProvider.ContainerControl = this;
            // 
            // FrmOrigenDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1200, 695);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrigenDestino";
            this.Text = "FrmOrigenDestino";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOriginPlace)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinationPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.DataGridView dgvOriginPlace;
        private System.Windows.Forms.ErrorProvider frmErrorProvider;
        private System.Windows.Forms.TextBox txtDescriptionOriginPlace;
        private System.Windows.Forms.TextBox txtDescriptionDestinationPlace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private System.Windows.Forms.DataGridView dgvDestinationPlace;
        private System.Windows.Forms.ComboBox cmbStateOriginPlace;
        private System.Windows.Forms.ComboBox cmbCityOriginPlace;
        private System.Windows.Forms.ComboBox cmbCountryOriginPlace;
        private System.Windows.Forms.ComboBox cmbStateDestinationPlace;
        private System.Windows.Forms.ComboBox cmbCityDestinationPlace;
        private System.Windows.Forms.ComboBox cmbCountryDestinationPlace;
    }
}