using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Position;
using Transportes_Canas.Utility;
using Transportes_Canas.ViewModel;

namespace Transportes_Canas.Views
{
    public partial class FrmMotorista : Form
    {
        private DriverViewModel driverViewModel = new DriverViewModel();
        private Validate val;


        public FrmMotorista()
        {
            InitializeComponent();
            this.cmbDriverStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.dgvDriver.ReadOnly = true;
            this.dgvDriver.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.val = new Validate(this.frmErrorProvider);
            this.InitBinding();
        }

        private void InitBinding()
        {
            this.txtName.DataBindings.Clear();
            this.txtLastName.DataBindings.Clear();
            this.mTxtDui.DataBindings.Clear();
            this.mTxtLicense.DataBindings.Clear();
            this.mtxtTelephone.DataBindings.Clear();
            this.mTxtPassport.DataBindings.Clear();
            this.cmbDriverStatus.DataBindings.Clear();
            this.dgvDriver.DataBindings.Clear();

            this.txtName.DataBindings.Add("Text", this.driverViewModel, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            this.txtLastName.DataBindings.Add("Text", this.driverViewModel, "LastName", false, DataSourceUpdateMode.OnPropertyChanged);
            this.mTxtDui.DataBindings.Add("Text", this.driverViewModel, "Dui", false, DataSourceUpdateMode.OnPropertyChanged);
            this.mTxtLicense.DataBindings.Add("Text", this.driverViewModel, "License", false, DataSourceUpdateMode.OnPropertyChanged);
            this.mtxtTelephone.DataBindings.Add("Text", this.driverViewModel, "Telephone", false, DataSourceUpdateMode.OnPropertyChanged);
            this.mTxtPassport.DataBindings.Add("Text", this.driverViewModel, "Passport", false, DataSourceUpdateMode.OnPropertyChanged);

            // Add Driver status
            this.cmbDriverStatus.DataBindings.Add("DataSource", this.driverViewModel, "DriverStatus", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbDriverStatus.ValueMember = "Id";
            this.cmbDriverStatus.DisplayMember = "Description";
            this.cmbDriverStatus.DataBindings.Add("SelectedValue", this.driverViewModel, "StatusId", false, DataSourceUpdateMode.OnPropertyChanged);

            // Add driver list in datagridview
            this.dgvDriver.DataBindings.Add("DataSource", this.driverViewModel, "ListDriver", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                if (driverViewModel.SaveDriver())
                {
                    MessageBox.Show("Motorista ingresado correctamente", "Ingreso exitoso");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al ingresar un motorista", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DgvDriver_BindingContextChanged(object sender, EventArgs e)
        {
            if (this.dgvDriver.Rows.Count > 0)
            {
                this.dgvDriver.Columns[0].Visible = false;
                this.dgvDriver.Columns[1].HeaderText = "Nombre";
                this.dgvDriver.Columns[2].HeaderText = "Apellido";
                this.dgvDriver.Columns[3].HeaderText = "DUI";
                this.dgvDriver.Columns[4].HeaderText = "# de Licencia";
                this.dgvDriver.Columns[5].HeaderText = "Teléfono";
                this.dgvDriver.Columns[6].HeaderText = "# de pasaporte";
                this.dgvDriver.Columns[7].HeaderText = "Estado";
            }
        }

        private void DgvDriver_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var idSelected = int.Parse(dgvDriver.Rows[e.RowIndex].Cells[0].Value.ToString());
                driverViewModel.GetDriver(idSelected);
            }
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                if (driverViewModel.Id > -1)
                {
                    if (driverViewModel.UpdateDriver())
                    {
                        MessageBox.Show("Motorista modificado correctamente", "Modificación exitosa");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al modificar un motorista", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar a un motorista", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (driverViewModel.Id > -1)
            {
                if (driverViewModel.DeleteDriver())
                {
                    MessageBox.Show("Motorista eliminado correctamente", "Eliminación exitosa");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar un motorista", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar a un motorista", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Boolean ValidateForm()
        {
            this.frmErrorProvider.Clear();
            bool a = this.val.ValidateString(txtName, "Debes ingresar un nombre");
            bool b = this.val.ValidateString(txtLastName, "Debes ingresar un apellido");
            bool c = this.val.ValidateDui(mTxtDui, "Debes ingresar un número de DUI válido");
            bool d = this.val.ValidateNitOrLicense(mTxtLicense, "Debes ingresar un número de licencia válido");
            bool e = this.val.ValidateTelephoneSV(mtxtTelephone, "Debes ingresar un número de teléfono");
            bool f = this.val.ValidatePassport(mTxtPassport, "Debes ingresar un número de pasaporte");
            bool g = this.val.ValidatePositiveNumber(cmbDriverStatus, "Debes elegir una estado");

            return (a && b && c && d && e && f && g);
        }
    }
}
