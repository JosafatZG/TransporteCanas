namespace Transportes_Canas.Views
{
    partial class FrmMotorista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMotorista));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Moto = new System.Windows.Forms.TabPage();
            this.mTxtPassport = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.mTxtLicense = new System.Windows.Forms.MaskedTextBox();
            this.mTxtDui = new System.Windows.Forms.MaskedTextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDriverStatus = new System.Windows.Forms.ComboBox();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDriver = new System.Windows.Forms.DataGridView();
            this.frmErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.Moto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Moto);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1111, 671);
            this.tabControl1.TabIndex = 21;
            // 
            // Moto
            // 
            this.Moto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Moto.Controls.Add(this.mTxtPassport);
            this.Moto.Controls.Add(this.mtxtTelephone);
            this.Moto.Controls.Add(this.mTxtLicense);
            this.Moto.Controls.Add(this.mTxtDui);
            this.Moto.Controls.Add(this.txtLastName);
            this.Moto.Controls.Add(this.txtName);
            this.Moto.Controls.Add(this.bunifuImageButton1);
            this.Moto.Controls.Add(this.bunifuSeparator1);
            this.Moto.Controls.Add(this.label7);
            this.Moto.Controls.Add(this.cmbDriverStatus);
            this.Moto.Controls.Add(this.bunifuImageButton3);
            this.Moto.Controls.Add(this.bunifuImageButton2);
            this.Moto.Controls.Add(this.label6);
            this.Moto.Controls.Add(this.label5);
            this.Moto.Controls.Add(this.label4);
            this.Moto.Controls.Add(this.label3);
            this.Moto.Controls.Add(this.label2);
            this.Moto.Controls.Add(this.label1);
            this.Moto.Controls.Add(this.dgvDriver);
            this.Moto.Location = new System.Drawing.Point(4, 25);
            this.Moto.Name = "Moto";
            this.Moto.Padding = new System.Windows.Forms.Padding(3);
            this.Moto.Size = new System.Drawing.Size(1103, 642);
            this.Moto.TabIndex = 0;
            this.Moto.Text = "Motorista";
            // 
            // mTxtPassport
            // 
            this.mTxtPassport.Location = new System.Drawing.Point(765, 174);
            this.mTxtPassport.Mask = "L00000000";
            this.mTxtPassport.Name = "mTxtPassport";
            this.mTxtPassport.Size = new System.Drawing.Size(292, 22);
            this.mTxtPassport.TabIndex = 49;
            // 
            // mtxtTelephone
            // 
            this.mtxtTelephone.Location = new System.Drawing.Point(906, 91);
            this.mtxtTelephone.Mask = "0000-0000";
            this.mtxtTelephone.Name = "mtxtTelephone";
            this.mtxtTelephone.Size = new System.Drawing.Size(151, 22);
            this.mtxtTelephone.TabIndex = 48;
            // 
            // mTxtLicense
            // 
            this.mTxtLicense.Location = new System.Drawing.Point(519, 91);
            this.mTxtLicense.Mask = "0000-000000-000-0";
            this.mTxtLicense.Name = "mTxtLicense";
            this.mTxtLicense.Size = new System.Drawing.Size(204, 22);
            this.mTxtLicense.TabIndex = 47;
            // 
            // mTxtDui
            // 
            this.mTxtDui.Location = new System.Drawing.Point(96, 94);
            this.mTxtDui.Mask = "00000000-0";
            this.mTxtDui.Name = "mTxtDui";
            this.mTxtDui.Size = new System.Drawing.Size(153, 22);
            this.mTxtDui.TabIndex = 46;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(744, 23);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(313, 22);
            this.txtLastName.TabIndex = 41;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(349, 22);
            this.txtName.TabIndex = 40;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(989, 252);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(107, 107);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 33;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(9, 202);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1087, 43);
            this.bunifuSeparator1.TabIndex = 38;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 37;
            this.label7.Text = "Estado:";
            // 
            // cmbDriverStatus
            // 
            this.cmbDriverStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDriverStatus.FormattingEnabled = true;
            this.cmbDriverStatus.Location = new System.Drawing.Point(136, 170);
            this.cmbDriverStatus.Name = "cmbDriverStatus";
            this.cmbDriverStatus.Size = new System.Drawing.Size(256, 24);
            this.cmbDriverStatus.TabIndex = 36;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(989, 508);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(106, 107);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 35;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.BunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(990, 379);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(107, 107);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 34;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.BunifuImageButton2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(810, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(652, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Pasaporte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(426, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Licencia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "DUI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(652, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre:";
            // 
            // dgvDriver
            // 
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Location = new System.Drawing.Point(30, 252);
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.RowHeadersWidth = 51;
            this.dgvDriver.RowTemplate.Height = 24;
            this.dgvDriver.Size = new System.Drawing.Size(933, 384);
            this.dgvDriver.TabIndex = 20;
            this.dgvDriver.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDriver_CellDoubleClick);
            this.dgvDriver.BindingContextChanged += new System.EventHandler(this.DgvDriver_BindingContextChanged);
            // 
            // frmErrorProvider
            // 
            this.frmErrorProvider.ContainerControl = this;
            // 
            // FrmMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1200, 695);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMotorista";
            this.Text = "FrmMotorista";
            this.tabControl1.ResumeLayout(false);
            this.Moto.ResumeLayout(false);
            this.Moto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Moto;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDriverStatus;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ErrorProvider frmErrorProvider;
        private System.Windows.Forms.MaskedTextBox mTxtPassport;
        private System.Windows.Forms.MaskedTextBox mtxtTelephone;
        private System.Windows.Forms.MaskedTextBox mTxtLicense;
        private System.Windows.Forms.MaskedTextBox mTxtDui;
    }
}