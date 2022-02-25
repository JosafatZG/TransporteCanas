using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportes_Canas.Information;
using Transportes_Canas.Utility;
using Transportes_Canas.ViewModel;

namespace Transportes_Canas.Views
{
    public partial class FrmViaje : Form
    {
        private WorkTripViewModel workTripViewModel = new WorkTripViewModel();
        private Validate val;

        public FrmViaje()
        {
            InitializeComponent();
            this.cmbClient.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDestination.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbOrigin.DropDownStyle = ComboBoxStyle.DropDownList;

            this.dgvWorkTrip.ReadOnly = true;
            this.dgvWorkTrip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.val = new Validate(this.fmrErrorProvider);
            this.InitBinding();
        }

        private void InitBinding()
        {
            this.cmbClient.DataBindings.Clear();
            this.cmbDestination.DataBindings.Clear();
            this.cmbOrigin.DataBindings.Clear();
            this.dgvWorkTrip.DataBindings.Clear();
            this.txtDescription.DataBindings.Clear();
            this.txtPrice.DataBindings.Clear();
            this.txtPaymentDriver.DataBindings.Clear();
            this.dgvWorkTrip.DataBindings.Clear();

            this.txtDescription.DataBindings.Add("Text", this.workTripViewModel, "Description", false, DataSourceUpdateMode.OnPropertyChanged);
            this.txtPrice.DataBindings.Add("Text", this.workTripViewModel, "Price", false, DataSourceUpdateMode.OnPropertyChanged);
            this.txtPaymentDriver.DataBindings.Add("Text", this.workTripViewModel, "DriverPayment", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbClient.DataBindings.Add("DataSource", this.workTripViewModel, "ClientList", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbClient.ValueMember = "Id";
            this.cmbClient.DisplayMember = "FullAddress";
            this.cmbClient.DataBindings.Add("SelectedValue", this.workTripViewModel, "IdClient", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbDestination.DataBindings.Add("DataSource", this.workTripViewModel, "DestinationPlaceList", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbDestination.ValueMember = "Id";
            this.cmbDestination.DisplayMember = "FullName";
            this.cmbDestination.DataBindings.Add("SelectedValue", this.workTripViewModel, "IdDestination", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbOrigin.DataBindings.Add("DataSource", this.workTripViewModel, "OriginPlaceList", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbOrigin.ValueMember = "Id";
            this.cmbOrigin.DisplayMember = "FullName";
            this.cmbOrigin.DataBindings.Add("SelectedValue", this.workTripViewModel, "IdOrigin", false, DataSourceUpdateMode.OnPropertyChanged);

            this.dgvWorkTrip.DataBindings.Add("DataSource", this.workTripViewModel, "WorkTripList", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                if (workTripViewModel.SaveWorkTrip())
                {
                    MessageBox.Show("Viaje ingresado correctamente", "Ingreso exitoso");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al ingresar un viaje", "Error de ingreso");
                }
            }
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                if (workTripViewModel.Id > -1)
                {
                    if (workTripViewModel.UpdateWorkTrip())
                    {
                        MessageBox.Show("Viaje modificado correctamente", "Modificación exitosa");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al modificar un viaje", "Error de modificación");
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar a un viaje", "Error de modificación");
                }
            }
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (workTripViewModel.Id > -1)
            {
                if (workTripViewModel.DeleteWorkTrip())
                {
                    MessageBox.Show("Vaije eliminado correctamente", "Eliminación exitosa");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar un viaje", "Error de eliminación");
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar a un viaje", "Error de eliminación");
            }
        }

        private Boolean ValidateForm()
        {
            this.fmrErrorProvider.Clear();
            bool a = this.val.ValidateString(txtDescription, "Debes ingresar una descripcion");
            bool b = this.val.ValidatePositiveNumber(cmbClient, "Debes elegir un cliente");
            bool c = this.val.ValidatePositiveNumber(cmbOrigin, "Debes elegir un lugar de origen");
            bool d = this.val.ValidatePositiveNumber(cmbDestination, "Debes elegir un lugar de destino");
            bool e = true;
            bool f = true;

            if (e && f)
            {
                try
                {
                    var price = Convert.ToDecimal(txtPrice.Text.ToString());
                    var driverPayment = Convert.ToDecimal(txtPaymentDriver.Text.ToString());

                    

                    if (driverPayment <= 0 || price <= 0)
                    {
                        fmrErrorProvider.SetError(txtPaymentDriver, "Precios deben ser mayor a cero");
                        e = false;
                        f = false;
                    }
                    else
                    {
                        if (driverPayment >= price)
                        {
                            fmrErrorProvider.SetError(txtPaymentDriver, "El precio a pagar al chofer debe ser menor al costo del viaje");
                            e = false;
                            f = false;
                        }
                    }
                }
                catch
                { }
                
            }

            return (a && b && c && d && e && f);
        }

        private void DgvWorkTrip_BindingContextChanged(object sender, EventArgs e)
        {
            if (this.dgvWorkTrip.Rows.Count > 0)
            {
                this.dgvWorkTrip.Columns[0].Visible = false;
                this.dgvWorkTrip.Columns[1].HeaderText = "País, estado, ciudad de origen";
                this.dgvWorkTrip.Columns[2].HeaderText = "Dirección de origen";
                this.dgvWorkTrip.Columns[3].HeaderText = "País, estado, ciudad de destino";
                this.dgvWorkTrip.Columns[4].HeaderText = "Dirección de destino";
                this.dgvWorkTrip.Columns[5].HeaderText = "Descripción de carga";
                this.dgvWorkTrip.Columns[6].HeaderText = "Cliente";
                this.dgvWorkTrip.Columns[7].HeaderText = "Precio";
                this.dgvWorkTrip.Columns[8].HeaderText = "Pago de motorista";
            }
        }

        private void DgvWorkTrip_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var idSelected = int.Parse(dgvWorkTrip.Rows[e.RowIndex].Cells[0].Value.ToString());
                workTripViewModel.GetWorkTrip(idSelected);
            }
        }

        private void CmbOrigin_DrawItem(object sender, DrawItemEventArgs e)
        {
        }
    }
}
