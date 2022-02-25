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
    public partial class FrmCliente : Form
    {
        private ClientViewModel clientViewModel = new ClientViewModel();
        private Validate val;

        public FrmCliente()
        {
            InitializeComponent();
            this.val = new Validate(this.frmErrorProvider);
            this.dgvClient.ReadOnly = true;
            this.dgvClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.InitBinding();
        }

        private void InitBinding()
        {

            this.txtName.DataBindings.Clear();
            this.txtAddress.DataBindings.Clear();
            this.txtEmail.DataBindings.Clear();
            this.mtxtTelephone.DataBindings.Clear();
            this.cmbCountry.DataBindings.Clear();
            this.cmbState.DataBindings.Clear();
            this.cmbCity.DataBindings.Clear();

            this.txtName.DataBindings.Add("Text", this.clientViewModel, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            this.txtAddress.DataBindings.Add("Text", this.clientViewModel, "Address", false, DataSourceUpdateMode.OnPropertyChanged);
            this.txtEmail.DataBindings.Add("Text", this.clientViewModel, "Email", false, DataSourceUpdateMode.OnPropertyChanged);
            this.mtxtTelephone.DataBindings.Add("Text", this.clientViewModel, "Telephone", false, DataSourceUpdateMode.OnPropertyChanged);
            this.dgvClient.DataBindings.Add("DataSource", this.clientViewModel, "ListClient", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbCountry.DataBindings.Add("DataSource", this.clientViewModel, "ListCountries", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbCountry.ValueMember = "Id";
            this.cmbCountry.DisplayMember = "Country";
            this.cmbCountry.DataBindings.Add("SelectedValue", this.clientViewModel, "IdCountry", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbState.DataBindings.Add("DataSource", this.clientViewModel, "ListStates", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbState.ValueMember = "Id";
            this.cmbState.DisplayMember = "State";
            this.cmbState.DataBindings.Add("SelectedValue", this.clientViewModel, "IdState", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbCity.DataBindings.Add("DataSource", this.clientViewModel, "ListCities", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbCity.ValueMember = "Id";
            this.cmbCity.DisplayMember = "City";
            this.cmbCity.DataBindings.Add("SelectedValue", this.clientViewModel, "IdCity", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                if (clientViewModel.SaveClient())
                {
                    MessageBox.Show("Cliente ingresado correctamente", "Ingreso exitoso");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al ingresar un cliente", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Boolean ValidateForm()
        {
            this.frmErrorProvider.Clear();
            bool a = this.val.ValidateString(txtName, "Debes ingresar un nombre");
            bool b = this.val.ValidateString(txtAddress, "Debes ingresar una dirección");
            bool c = this.val.ValidateTelephoneSV(mtxtTelephone, "Debes ingresar un número de teléfono");
            bool d = this.val.ValidateEmail(txtEmail, "Debes ingresar un email válido");
            bool f = this.val.ValidatePositiveNumber(cmbCity, "Debes elegir una ciudad");

            return (a && b && c && d && f);
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                if (clientViewModel.Id > -1)
                {
                    if (clientViewModel.UpdateClient())
                    {
                        MessageBox.Show("Cliente modificado correctamente", "Modificación exitosa");

                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al modificar un cliente", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar a un cliente", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DgvClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var idSelected = int.Parse(dgvClient.Rows[e.RowIndex].Cells[0].Value.ToString());
                clientViewModel.GetClient(idSelected);
            }
        }

        private void DgvClient_BindingContextChanged(object sender, EventArgs e)
        {
            if (this.dgvClient.Rows.Count > 0)
            {
                this.dgvClient.Columns[0].Visible = false;
                this.dgvClient.Columns[1].HeaderText = "Nombre";
                this.dgvClient.Columns[2].HeaderText = "Dirección";
                this.dgvClient.Columns[3].HeaderText = "Teléfono";
                this.dgvClient.Columns[4].HeaderText = "Correo electrónico";
                this.dgvClient.Columns[5].HeaderText = "Ubicación";
            }
        }

        private void CmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.clientViewModel.FillListStatesByCountry();
        }

        private void CmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.clientViewModel.FillListCitiesByState();
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (clientViewModel.Id > -1)
            {
                if (clientViewModel.DeleteClient())
                {
                    MessageBox.Show("Cliente elimninado correctamente", "Eliminación exitosa");

                }
                else
                {
                    MessageBox.Show("Cliente tiene data asignada", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar a un cliente", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
