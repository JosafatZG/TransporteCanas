namespace Transportes_Canas
{
    partial class FrmAgregarMotorista
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.txtPasaporte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoMotorista = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.frmProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.frmProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "DUI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Licencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "NIT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pasaporte";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 27);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(293, 30);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(586, 27);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(313, 30);
            this.txtApellido.TabIndex = 7;
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(76, 83);
            this.txtDui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(335, 30);
            this.txtDui.TabIndex = 8;
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(547, 83);
            this.txtNit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(352, 30);
            this.txtNit.TabIndex = 9;
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(118, 144);
            this.txtLicencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(293, 30);
            this.txtLicencia.TabIndex = 10;
            // 
            // txtPasaporte
            // 
            this.txtPasaporte.Location = new System.Drawing.Point(606, 144);
            this.txtPasaporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasaporte.Name = "txtPasaporte";
            this.txtPasaporte.Size = new System.Drawing.Size(293, 30);
            this.txtPasaporte.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo de motorista";
            // 
            // cmbTipoMotorista
            // 
            this.cmbTipoMotorista.FormattingEnabled = true;
            this.cmbTipoMotorista.Items.AddRange(new object[] {
            "Propio",
            "Agregado"});
            this.cmbTipoMotorista.Location = new System.Drawing.Point(195, 213);
            this.cmbTipoMotorista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoMotorista.Name = "cmbTipoMotorista";
            this.cmbTipoMotorista.Size = new System.Drawing.Size(216, 31);
            this.cmbTipoMotorista.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(433, 327);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(133, 45);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmProvider
            // 
            this.frmProvider.ContainerControl = this;
            // 
            // FrmAgregarMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 487);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbTipoMotorista);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPasaporte);
            this.Controls.Add(this.txtLicencia);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmAgregarMotorista";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Motorista";
            ((System.ComponentModel.ISupportInitialize)(this.frmProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.TextBox txtPasaporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoMotorista;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider frmProvider;
    }
}