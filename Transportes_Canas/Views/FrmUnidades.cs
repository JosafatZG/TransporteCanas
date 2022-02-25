using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportes_Canas.Utility;
using Transportes_Canas.ViewModel;

namespace Transportes_Canas.Views
{
    public partial class FrmUnidades : Form
    {
        private TruckViewModel truckViewModel = new TruckViewModel();
        private TruckBoxViewModel truckBoxViewModel = new TruckBoxViewModel();
        private VehicleBrandViewModel vehicleBrandViewModel = new VehicleBrandViewModel();
        private VehicleModelViewModel vehicleModelViewModel = new VehicleModelViewModel();
        private Validate val;

        public FrmUnidades()
        {
            InitializeComponent();
            this.cmbTruckStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.dgvTruck.ReadOnly = true;
            this.dgvBrand.ReadOnly = true;
            this.dgvModel.ReadOnly = true;
            this.dgvTruckBox.ReadOnly = true;

            this.dgvTruck.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBrand.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvModel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTruckBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.val = new Validate(this.frmErrorProvider);
            this.InitBindingTruck();
            this.InitBindingTruckBox();
            this.InitBindingBrand();
            this.InitBindingModel();
        }

        // Truck Logic
        private void InitBindingTruck()
        {
            this.txtTruckLicense.DataBindings.Clear();
            this.cmbTruckBrand.DataBindings.Clear();
            this.cmbTruckModel.DataBindings.Clear();
            this.txtTruckYear.DataBindings.Clear();
            this.cmbTruckStatus.DataBindings.Clear();
            this.dgvTruck.DataBindings.Clear();

            this.txtTruckLicense.DataBindings.Add("Text", this.truckViewModel, "VehicleLicense", false, DataSourceUpdateMode.OnPropertyChanged);
            this.txtTruckYear.DataBindings.Add("Text", this.truckViewModel, "Year", false, DataSourceUpdateMode.OnPropertyChanged);

            // Add Driver status
            this.cmbTruckStatus.DataBindings.Add("DataSource", this.truckViewModel, "TruckStatus", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbTruckStatus.ValueMember = "Id";
            this.cmbTruckStatus.DisplayMember = "Description";
            this.cmbTruckStatus.DataBindings.Add("SelectedValue", this.truckViewModel, "IdVehicleStatus", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbTruckBrand.DataBindings.Add("DataSource", this.truckViewModel, "ListBrand", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbTruckBrand.ValueMember = "Id";
            this.cmbTruckBrand.DisplayMember = "Name";
            this.cmbTruckBrand.DataBindings.Add("SelectedValue", this.truckViewModel, "IdVehicleBrand", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbTruckModel.DataBindings.Add("DataSource", this.truckViewModel, "ListModel", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbTruckModel.ValueMember = "Id";
            this.cmbTruckModel.DisplayMember = "Name";
            this.cmbTruckModel.DataBindings.Add("SelectedValue", this.truckViewModel, "IdVehicleModel", false, DataSourceUpdateMode.OnPropertyChanged);

            // Add driver list in datagridview
            this.dgvTruck.DataBindings.Add("DataSource", this.truckViewModel, "ListTruck", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (this.ValidateTruckForm())
            {
                if (truckViewModel.SaveTruck())
                {
                    MessageBox.Show("Cabezal ingresado correctamente", "Ingreso exitoso");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al ingresar un cabezal", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (this.ValidateTruckForm())
            {
                if (truckViewModel.Id > -1)
                {
                    if (truckViewModel.UpdateTruck())
                    {
                        MessageBox.Show("Cabezal modificado correctamente", "Modificación exitosa");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al modificar un cabezal", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar a un cabezal", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private Boolean ValidateTruckForm()
        {
            this.frmErrorProvider.Clear();
            bool a = this.val.ValidateString(txtTruckLicense, "Debes ingresar un número placa");
            bool b = this.val.ValidatePositiveNumber(cmbTruckModel, "Debes elegir un modelo");
            bool c = this.val.ValidatePositiveNumber(cmbTruckStatus, "Debes elegir un estado");
            bool d = this.val.ValidateVehicleYear(txtTruckYear, "Debes ingresar un año");

            return (a && b && c && d);
        }

        private void DgvTruck_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var idSelected = int.Parse(dgvTruck.Rows[e.RowIndex].Cells[0].Value.ToString());
                truckViewModel.GetTruck(idSelected);
            }
        }

        private void DgvTruck_BindingContextChanged(object sender, EventArgs e)
        {
            if (this.dgvTruck.Rows.Count > 0)
            {
                this.dgvTruck.Columns[0].Visible = false;
                this.dgvTruck.Columns[1].HeaderText = "# de Placa";
                this.dgvTruck.Columns[2].HeaderText = "Marca";
                this.dgvTruck.Columns[3].HeaderText = "Modelo";
                this.dgvTruck.Columns[4].HeaderText = "Año";
                this.dgvTruck.Columns[5].HeaderText = "Estado";
            }
        }

        // TruckBoxLogic
        private void InitBindingTruckBox()
        {
            this.txtVehicleLicenseTruckBox.DataBindings.Clear();
            this.cmbTruckBoxBrand.DataBindings.Clear();
            this.cmbTruckBoxModel.DataBindings.Clear();
            this.txtTruckBoxYear.DataBindings.Clear();
            this.cmbTruckBoxStatus.DataBindings.Clear();
            this.cmbTruckBoxType.DataBindings.Clear();
            this.dgvTruckBox.DataBindings.Clear();

            this.txtVehicleLicenseTruckBox.DataBindings.Add("Text", this.truckBoxViewModel, "VehicleLicense", false, DataSourceUpdateMode.OnPropertyChanged);
            this.txtTruckBoxYear.DataBindings.Add("Text", this.truckBoxViewModel, "Year", false, DataSourceUpdateMode.OnPropertyChanged);

            // Add Driver status
            this.cmbTruckBoxStatus.DataBindings.Add("DataSource", this.truckBoxViewModel, "TruckSBoxtatus", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbTruckBoxStatus.ValueMember = "Id";
            this.cmbTruckBoxStatus.DisplayMember = "Description";
            this.cmbTruckBoxStatus.DataBindings.Add("SelectedValue", this.truckBoxViewModel, "IdVehicleStatus", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbTruckBoxType.DataBindings.Add("DataSource", this.truckBoxViewModel, "TruckBoxType", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbTruckBoxType.ValueMember = "Id";
            this.cmbTruckBoxType.DisplayMember = "Description";
            this.cmbTruckBoxType.DataBindings.Add("SelectedValue", this.truckBoxViewModel, "IdVehicleType", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbTruckBoxBrand.DataBindings.Add("DataSource", this.truckBoxViewModel, "ListBrand", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbTruckBoxBrand.ValueMember = "Id";
            this.cmbTruckBoxBrand.DisplayMember = "Name";
            this.cmbTruckBoxBrand.DataBindings.Add("SelectedValue", this.truckBoxViewModel, "IdVehicleBrand", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbTruckBoxModel.DataBindings.Add("DataSource", this.truckBoxViewModel, "ListModel", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbTruckBoxModel.ValueMember = "Id";
            this.cmbTruckBoxModel.DisplayMember = "Name";
            this.cmbTruckBoxModel.DataBindings.Add("SelectedValue", this.truckBoxViewModel, "IdVehicleModel", false, DataSourceUpdateMode.OnPropertyChanged);

            // Add driver list in datagridview
            this.dgvTruckBox.DataBindings.Add("DataSource", this.truckBoxViewModel, "ListTruck", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (this.ValidateTruckBoxForm())
            {
                if (truckBoxViewModel.SaveTruckBox())
                {
                    MessageBox.Show("Remolque ingresado correctamente", "Ingreso exitoso");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al ingresar un remolque", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BunifuImageButton6_Click(object sender, EventArgs e)
        {
            if (this.ValidateTruckBoxForm())
            {
                if (truckBoxViewModel.Id > -1)
                {
                    if (truckBoxViewModel.UpdateTruckBox())
                    {
                        MessageBox.Show("Remolque modificado correctamente", "Modificación exitosa");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al modificar un remolque", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar a un remolque", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private Boolean ValidateTruckBoxForm()
        {
            this.frmErrorProvider.Clear();
            bool a = this.val.ValidateString(txtVehicleLicenseTruckBox, "Debes ingresar un número placa");
            bool b = this.val.ValidatePositiveNumber(cmbTruckBoxModel, "Debes elegir un modelo");
            bool c = this.val.ValidatePositiveNumber(cmbTruckBoxStatus, "Debes elegir un estado");
            bool d = this.val.ValidateVehicleYear(txtTruckBoxYear, "Debes ingresar un año");
            bool e = this.val.ValidatePositiveNumber(cmbTruckBoxType, "Debes elegir un tipo");

            return (a && b && c && d && e);
        }

        private void TabControl1_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void DgvTruckBox_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var idSelected = int.Parse(dgvTruckBox.Rows[e.RowIndex].Cells[0].Value.ToString());
                truckBoxViewModel.GetTruckBox(idSelected);
            }
        }

        private void DgvTruckBox_BindingContextChanged(object sender, EventArgs e)
        {
            if (this.dgvTruckBox.Rows.Count > 0)
            {
                this.dgvTruckBox.Columns[0].Visible = false;
                this.dgvTruckBox.Columns[1].HeaderText = "# de Placa";
                this.dgvTruckBox.Columns[2].HeaderText = "Marca";
                this.dgvTruckBox.Columns[3].HeaderText = "Modelo";
                this.dgvTruckBox.Columns[4].HeaderText = "Año";
                this.dgvTruckBox.Columns[5].HeaderText = "Estado";
                this.dgvTruckBox.Columns[6].HeaderText = "Tipo de remolque";
            }
        }

        // BrandForm
        private void InitBindingBrand()
        {
            this.txtNameBrand.DataBindings.Clear();
            this.dgvBrand.DataBindings.Clear();

            this.txtNameBrand.DataBindings.Add("Text", this.vehicleBrandViewModel, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            this.dgvBrand.DataBindings.Add("DataSource", this.vehicleBrandViewModel, "BrandList", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private Boolean ValidateVehicleBrandForm()
        {
            this.frmErrorProvider.Clear();
            bool a = this.val.ValidateString(txtNameBrand, "Debes ingresar un nombre");

            return (a);
        }


        private void BunifuImageButton12_Click(object sender, EventArgs e)
        {
            if (this.ValidateVehicleBrandForm())
            {
                if (vehicleBrandViewModel.SaveBrand())
                {
                    this.truckBoxViewModel.FillBrandList();
                    this.truckViewModel.FillBrandList();
                    this.vehicleModelViewModel.FillBrandList();
                    MessageBox.Show("Marca ingresada correctamente", "Ingreso exitoso");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al ingresar una marca", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BunifuImageButton11_Click(object sender, EventArgs e)
        {
            if (this.ValidateTruckBoxForm())
            {
                if (vehicleBrandViewModel.Id > -1)
                {
                    if (vehicleBrandViewModel.UpdateBrand())
                    {
                        this.truckBoxViewModel.FillBrandList();
                        this.truckViewModel.FillBrandList();
                        this.vehicleModelViewModel.FillBrandList();
                        MessageBox.Show("Marca modificada correctamente", "Modificación exitosa");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al modificar una marca", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar a una marca", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DgvBrand_BindingContextChanged(object sender, EventArgs e)
        {
            if (this.dgvBrand.Rows.Count > 0)
            {
                this.dgvBrand.Columns[0].Visible = false;
                this.dgvBrand.Columns[1].HeaderText = "Nombre";
            }
        }

        private void DgvBrand_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var idSelected = int.Parse(dgvBrand.Rows[e.RowIndex].Cells[0].Value.ToString());
                vehicleBrandViewModel.GetBrand(idSelected);
            }
        }

        // ModelForm
        private void InitBindingModel()
        {
            this.txtNameModel.DataBindings.Clear();
            this.cmbBrandModelForm.DataBindings.Clear();
            this.dgvModel.DataBindings.Clear();

            this.txtNameModel.DataBindings.Add("Text", this.vehicleModelViewModel, "Name", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbBrandModelForm.DataBindings.Add("DataSource", this.vehicleModelViewModel, "ListBrand", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbBrandModelForm.ValueMember = "Id";
            this.cmbBrandModelForm.DisplayMember = "Name";
            this.cmbBrandModelForm.DataBindings.Add("SelectedValue", this.vehicleModelViewModel, "IdBrand", false, DataSourceUpdateMode.OnPropertyChanged);

            this.dgvModel.DataBindings.Add("DataSource", this.vehicleModelViewModel, "ListModel", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private Boolean ValidateModelForm()
        {
            this.frmErrorProvider.Clear();
            bool a = this.val.ValidateString(txtNameModel, "Debes ingresar un nombre");
            bool b = this.val.ValidatePositiveNumber(cmbBrandModelForm, "Debes elegir una marca");

            return (a && b);
        }

        private void BunifuImageButton7_Click(object sender, EventArgs e)
        {
            if (this.ValidateModelForm())
            {
                if (vehicleModelViewModel.SaveModel())
                {
                    MessageBox.Show("Modelo ingresado correctamente", "Ingreso exitoso");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al ingresar un modelo", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BunifuImageButton8_Click(object sender, EventArgs e)
        {
            if (this.ValidateModelForm())
            {
                if (vehicleModelViewModel.Id > -1)
                {
                    if (vehicleModelViewModel.UpdateModel())
                    {
                        MessageBox.Show("Modelo modificado correctamente", "Modificación exitosa");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al modificar un modelo", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar a una marca", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DgvModel_BindingContextChanged(object sender, EventArgs e)
        {
            if (this.dgvModel.Rows.Count > 0)
            {
                this.dgvModel.Columns[0].Visible = false;
                this.dgvModel.Columns[1].HeaderText = "Modelo";
                this.dgvModel.Columns[2].HeaderText = "Marca";
            }
        }

        private void DgvModel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var idSelected = int.Parse(dgvModel.Rows[e.RowIndex].Cells[0].Value.ToString());
                vehicleModelViewModel.GetModel(idSelected);
            }
        }

        private void CmbTruckBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.truckBoxViewModel.FillModelListByBrand();
        }

        private void CmbTruckBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.truckViewModel.FillModelListByBrand();
        }

        private void BunifuImageButton10_Click(object sender, EventArgs e)
        {
            if (vehicleBrandViewModel.Id > -1)
            {
                if (vehicleBrandViewModel.DeleteBrand())
                {
                    this.truckBoxViewModel.FillBrandList();
                    this.truckViewModel.FillBrandList();
                    this.vehicleModelViewModel.FillBrandList();
                    MessageBox.Show("Marca eliminada correctamente", "Eliminación exitosa");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar una marca", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar a una marca", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BunifuImageButton9_Click(object sender, EventArgs e)
        {
            if (vehicleModelViewModel.Id > -1)
            {
                if (vehicleModelViewModel.DeleteModel())
                {
                    MessageBox.Show("Modelo eliminado correctamente", "Eliminación exitosa");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar un modelo", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar a una marca", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BunifuImageButton5_Click(object sender, EventArgs e)
        {
            if (truckBoxViewModel.Id > -1)
            {
                if (truckBoxViewModel.DeleteTruckBox())
                {
                    MessageBox.Show("Remolque eliminado correctamente", "Eliminación exitosa");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar un remolque", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar a un remolque", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (truckViewModel.Id > -1)
            {
                if (truckViewModel.DeleteTruck())
                {
                    MessageBox.Show("Cabezal eliminado correctamente", "Eliminación exitosa");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar un cabezal", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar a un cabezal", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
