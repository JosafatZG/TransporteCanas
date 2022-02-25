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
    public partial class FrmAsignacion : Form
    {
        private AssignmentViewModel assignmentViewModel = new AssignmentViewModel();
        private Validate val;

        public FrmAsignacion()
        {
            InitializeComponent();
            InitBinding();
            this.val = new Validate(this.fmrErrorProvider);
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            this.dtpStartDate.Format = DateTimePickerFormat.Custom;
            this.dtpEndDate.Format = DateTimePickerFormat.Custom;
            this.dtpStartDateSearch.Format = DateTimePickerFormat.Custom;
            this.dtpEndDateSearch.Format = DateTimePickerFormat.Custom;

            this.dtpStartDate.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.dtpEndDate.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.dtpStartDateSearch.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.dtpEndDateSearch.CustomFormat = "dd-MM-yyyy HH:mm:ss";            
        }

        private void InitBinding()
        {
            this.cmbClient.DataBindings.Clear();
            this.cmbWorkTrip.DataBindings.Clear();
            this.cmbTruck.DataBindings.Clear();
            this.cmbTruckBox.DataBindings.Clear();
            this.cmbDriver.DataBindings.Clear();
            this.cmbStatus.DataBindings.Clear();
            this.txtTicket.DataBindings.Clear();
            this.dtpStartDate.DataBindings.Clear();
            this.dtpEndDate.DataBindings.Clear();

            this.txtTicket.DataBindings.Add("Text", this.assignmentViewModel, "TicketNumber", false, DataSourceUpdateMode.OnPropertyChanged);
            this.dtpStartDate.DataBindings.Add("Value", this.assignmentViewModel, "StartDate", false, DataSourceUpdateMode.OnPropertyChanged);
            this.dtpEndDate.DataBindings.Add("Value", this.assignmentViewModel, "EndDate", false, DataSourceUpdateMode.OnPropertyChanged);

            this.dtpStartDateSearch.DataBindings.Add("Value", this.assignmentViewModel, "StartSearchDate", false, DataSourceUpdateMode.OnPropertyChanged);
            this.dtpEndDateSearch.DataBindings.Add("Value", this.assignmentViewModel, "EndSearchDate", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbClient.DataBindings.Add("DataSource", this.assignmentViewModel, "ClientList", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbClient.ValueMember = "Id";
            this.cmbClient.DisplayMember = "FullAddress";
            this.cmbClient.DataBindings.Add("SelectedValue", this.assignmentViewModel, "IdClient", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbWorkTrip.DataBindings.Add("DataSource", this.assignmentViewModel, "WorkTripList", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbWorkTrip.ValueMember = "Id";
            this.cmbWorkTrip.DisplayMember = "Description";
            this.cmbWorkTrip.DataBindings.Add("SelectedValue", this.assignmentViewModel, "IdWorkTrip", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbTruck.DataBindings.Add("DataSource", this.assignmentViewModel, "TruckList", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbTruck.ValueMember = "Id";
            this.cmbTruck.DisplayMember = "License";
            this.cmbTruck.DataBindings.Add("SelectedValue", this.assignmentViewModel, "IdTruck", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbTruckBox.DataBindings.Add("DataSource", this.assignmentViewModel, "TruckBoxList", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbTruckBox.ValueMember = "Id";
            this.cmbTruckBox.DisplayMember = "License";
            this.cmbTruckBox.DataBindings.Add("SelectedValue", this.assignmentViewModel, "IdTruckBox", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbDriver.DataBindings.Add("DataSource", this.assignmentViewModel, "DriverList", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbDriver.ValueMember = "Id";
            this.cmbDriver.DisplayMember = "NameInCombobox";
            this.cmbDriver.DataBindings.Add("SelectedValue", this.assignmentViewModel, "IdDriver", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbStatus.DataBindings.Add("DataSource", this.assignmentViewModel, "AssigmentStatusList", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbStatus.ValueMember = "Id";
            this.cmbStatus.DisplayMember = "Description";
            this.cmbStatus.DataBindings.Add("SelectedValue", this.assignmentViewModel, "IdAssignmentStatus", false, DataSourceUpdateMode.OnPropertyChanged);

            this.dataGridView1.DataBindings.Add("DataSource", this.assignmentViewModel, "AssignmentList", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void CmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.assignmentViewModel.FillWorkTripByClientId();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                if (this.assignmentViewModel.AssignmentActivedByTruckAndTruckBox())
                {
                    if (this.assignmentViewModel.SaveAssignment())
                    {
                        radioButton4.Checked = true;
                        MessageBox.Show("Asignación ingresada correctamente", "Ingreso exitoso");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al ingresar una asignación", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    MessageBox.Show("Existe un viaje en proceso asignado al equipo", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private Boolean ValidateForm()
        {
            this.fmrErrorProvider.Clear();
            bool a = this.val.ValidatePositiveNumber(cmbWorkTrip, "Debes elegir un viaje");
            bool b = this.val.ValidatePositiveNumber(cmbTruck, "Debes elegir un camión");
            bool c = this.val.ValidatePositiveNumber(cmbTruckBox, "Debes elegir un remolque");
            bool d = this.val.ValidatePositiveNumber(cmbStatus, "Debes elegir un estado");
            bool e = this.val.ValidateDates(dtpStartDate, dtpEndDate, "Fecha final debe ser menor a inicial");
            bool f = this.val.ValidateTicket(txtTicket, "Debes ingresar un número de ticket");

            return (a && b && c && d && e && f);
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                if (this.assignmentViewModel.Id > -1)
                {
                    if (this.assignmentViewModel.UpdateAssignment())
                    {
                        radioButton4.Checked = true;
                        MessageBox.Show("Asignación modificada correctamente", "Modificación exitosa");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al modificar una asignación", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una asignación", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var idSelected = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.assignmentViewModel.GetAssignment(idSelected);
            }
        }

        private void DataGridView1_BindingContextChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0)
            {
                this.dataGridView1.Columns[0].Visible = false;
                this.dataGridView1.Columns[1].HeaderText = "Motorista";
                this.dataGridView1.Columns[2].HeaderText = "Cliente";
                this.dataGridView1.Columns[3].HeaderText = "Viaje";
                this.dataGridView1.Columns[4].HeaderText = "Cabezal";
                this.dataGridView1.Columns[5].HeaderText = "Remolque";
                this.dataGridView1.Columns[6].HeaderText = "Fecha de inicio";
                this.dataGridView1.Columns[7].HeaderText = "Fecha final";
                this.dataGridView1.Columns[8].HeaderText = "Estado";
                this.dataGridView1.Columns[9].HeaderText = "# de Boleta";
            }
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (this.assignmentViewModel.Id > -1)
            {
                if (this.assignmentViewModel.DeleteAssignment())
                {
                    radioButton4.Checked = true;
                    MessageBox.Show("Asignación eliminada correctamente", "Eliminación exitosa");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar una asignación", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una asignación", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            bool a = this.val.ValidateDates(dtpStartDateSearch, dtpEndDateSearch, "Fecha final debe ser menor a inicial");

            if (a)
            {
                if (radioButton4.Checked) // Todo
                {
                    this.assignmentViewModel.FillAssignmentAllList();
                }
                else if (radioButton1.Checked) // En camino
                {
                    this.assignmentViewModel.GetAssignmentInProgress();
                }
                else if (radioButton2.Checked) // Entregado
                {
                    this.assignmentViewModel.GetAssignmentDone();
                }
                else if (radioButton3.Checked) // Pagado
                {
                    this.assignmentViewModel.GetAssignmentPaid();
                }
            }
        }
    }
}
