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
    public partial class FrmOrigenDestino : Form
    {
        private OriginPlaceViewModel originPlaceViewModel = new OriginPlaceViewModel();
        private DestinationPlaceViewModel destinationPlaceViewModel = new DestinationPlaceViewModel();
        private Validate val;

        public FrmOrigenDestino()
        {
            InitializeComponent();
            this.val = new Validate(this.frmErrorProvider);
            this.InitBindingDestinationFrm();
            this.InitBindingOriginFrm();
            this.dgvOriginPlace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvOriginPlace.ReadOnly = true;
            this.dgvDestinationPlace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDestinationPlace.ReadOnly = true;
        }

        private void InitBindingOriginFrm()
        {
            this.cmbCountryOriginPlace.DataBindings.Clear();
            this.cmbStateOriginPlace.DataBindings.Clear();
            this.cmbCityOriginPlace.DataBindings.Clear();
            this.txtDescriptionOriginPlace.DataBindings.Clear();
            this.dgvOriginPlace.DataBindings.Clear();

            this.cmbCountryOriginPlace.DataBindings.Add("DataSource", this.originPlaceViewModel, "ListCountries", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbCountryOriginPlace.ValueMember = "Id";
            this.cmbCountryOriginPlace.DisplayMember = "Country";
            this.cmbCountryOriginPlace.DataBindings.Add("SelectedValue", this.originPlaceViewModel, "IdCountry", false, DataSourceUpdateMode.OnPropertyChanged);

            
            this.cmbStateOriginPlace.DataBindings.Add("DataSource", this.originPlaceViewModel, "ListStates", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbStateOriginPlace.ValueMember = "Id";
            this.cmbStateOriginPlace.DisplayMember = "State";
            this.cmbStateOriginPlace.DataBindings.Add("SelectedValue", this.originPlaceViewModel, "IdState", false, DataSourceUpdateMode.OnPropertyChanged);


            this.cmbCityOriginPlace.DataBindings.Add("DataSource", this.originPlaceViewModel, "ListCities", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbCityOriginPlace.ValueMember = "Id";
            this.cmbCityOriginPlace.DisplayMember = "City";
            this.cmbCityOriginPlace.DataBindings.Add("SelectedValue", this.originPlaceViewModel, "IdCity", false, DataSourceUpdateMode.OnPropertyChanged);

            this.txtDescriptionOriginPlace.DataBindings.Add("Text", this.originPlaceViewModel, "Description", false, DataSourceUpdateMode.OnPropertyChanged);
            this.dgvOriginPlace.DataBindings.Add("DataSource", this.originPlaceViewModel, "ListPlace", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void InitBindingDestinationFrm()
        {
            this.cmbCountryDestinationPlace.DataBindings.Clear();
            this.cmbStateDestinationPlace.DataBindings.Clear();
            this.cmbCityDestinationPlace.DataBindings.Clear();
            this.txtDescriptionDestinationPlace.DataBindings.Clear();
            this.dgvDestinationPlace.DataBindings.Clear();

            this.cmbCountryDestinationPlace.DataBindings.Add("DataSource", this.destinationPlaceViewModel, "ListCountries", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbCountryDestinationPlace.ValueMember = "Id";
            this.cmbCountryDestinationPlace.DisplayMember = "Country";
            this.cmbCountryDestinationPlace.DataBindings.Add("SelectedValue", this.destinationPlaceViewModel, "IdCountry", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbStateDestinationPlace.DataBindings.Add("DataSource", this.destinationPlaceViewModel, "ListStates", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbStateDestinationPlace.ValueMember = "Id";
            this.cmbStateDestinationPlace.DisplayMember = "State";
            this.cmbStateDestinationPlace.DataBindings.Add("SelectedValue", this.destinationPlaceViewModel, "IdState", false, DataSourceUpdateMode.OnPropertyChanged);

            this.cmbCityDestinationPlace.DataBindings.Add("DataSource", this.destinationPlaceViewModel, "ListCities", false, DataSourceUpdateMode.OnPropertyChanged);
            this.cmbCityDestinationPlace.ValueMember = "Id";
            this.cmbCityDestinationPlace.DisplayMember = "City";
            this.cmbCityDestinationPlace.DataBindings.Add("SelectedValue", this.destinationPlaceViewModel, "IdCity", false, DataSourceUpdateMode.OnPropertyChanged);

            this.txtDescriptionDestinationPlace.DataBindings.Add("Text", this.destinationPlaceViewModel, "Description", false, DataSourceUpdateMode.OnPropertyChanged);
            this.dgvDestinationPlace.DataBindings.Add("DataSource", this.destinationPlaceViewModel, "ListPlace", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private Boolean ValidateDestinationForm()
        {
            this.frmErrorProvider.Clear();
            bool a = this.val.ValidatePositiveNumber(cmbCityDestinationPlace, "Debes elegir una ciudad");
            bool b = this.val.ValidateString(txtDescriptionDestinationPlace, "Debes ingresar una descripicón");

            return (a && b);
        }

        private Boolean ValidateOriginForm()
        {
            this.frmErrorProvider.Clear();
            bool a = this.val.ValidatePositiveNumber(cmbCityOriginPlace, "Debes elegir una ciudad");
            bool b = this.val.ValidateString(txtDescriptionOriginPlace, "Debes ingresar una descripicón");

            return (a && b);
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (this.ValidateOriginForm())
            {
                if (originPlaceViewModel.SavePlace())
                {
                    MessageBox.Show("Lugar de origen ingresado correctamente", "Ingreso exitoso");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al ingresar un lugar origen", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (this.ValidateOriginForm())
            {
                if (originPlaceViewModel.Id > -1)
                {
                    if (originPlaceViewModel.UpdatePlace())
                    {
                        MessageBox.Show("Lugar de origen modificado correctamente", "Modificación exitosa");

                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al modificar un lugar de origen", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar a un lugar de origen", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DgvOriginPlace_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var idSelected = int.Parse(dgvOriginPlace.Rows[e.RowIndex].Cells[0].Value.ToString());
                originPlaceViewModel.GetPlace(idSelected);
            }
        }

        private void DgvOriginPlace_BindingContextChanged(object sender, EventArgs e)
        {
            if (this.dgvOriginPlace.Rows.Count > 0)
            {
                this.dgvOriginPlace.Columns[0].Visible = false;
                this.dgvOriginPlace.Columns[1].HeaderText = "País";
                this.dgvOriginPlace.Columns[2].HeaderText = "Estado";
                this.dgvOriginPlace.Columns[3].HeaderText = "Ciudad";
                this.dgvOriginPlace.Columns[4].HeaderText = "Descripción";
                this.dgvOriginPlace.Columns[5].HeaderText = "Dirección completa";
            }
        }

        private void BunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (this.ValidateDestinationForm())
            {
                if (destinationPlaceViewModel.SavePlace())
                {
                    MessageBox.Show("Lugar de destino ingresado correctamente", "Ingreso exitoso");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al ingresar un lugar de destino", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BunifuImageButton6_Click(object sender, EventArgs e)
        {
            if (this.ValidateDestinationForm())
            {
                if (destinationPlaceViewModel.Id > -1)
                {
                    if (destinationPlaceViewModel.UpdatePlace())
                    {
                        MessageBox.Show("Lugar de destino modificado correctamente", "Modificación exitosa");

                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al modificar un lugar de destino", "Error de modificación");
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar a un lugar de destino", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DgvDestinationPlace_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvDestinationPlace_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgvDestinationPlace_BindingContextChanged(object sender, EventArgs e)
        {
            if (this.dgvDestinationPlace.Rows.Count > 0)
            {
                this.dgvDestinationPlace.Columns[0].Visible = false;
                this.dgvDestinationPlace.Columns[1].HeaderText = "País";
                this.dgvDestinationPlace.Columns[2].HeaderText = "Estado";
                this.dgvDestinationPlace.Columns[3].HeaderText = "Ciudad";
                this.dgvDestinationPlace.Columns[4].HeaderText = "Descripción";
                this.dgvDestinationPlace.Columns[5].HeaderText = "Dirección completa";
            }
        }

        private void DgvDestinationPlace_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var idSelected = int.Parse(dgvDestinationPlace.Rows[e.RowIndex].Cells[0].Value.ToString());
                destinationPlaceViewModel.GetPlace(idSelected);
            }
        }

        private void CmbCountryOriginPlace_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbStateOriginPlace_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbCountryDestinationPlace_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void CmbStateDestinationPlace_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbCountryOriginPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.originPlaceViewModel.FillListStatesByCountry();
        }

        private void CmbStateOriginPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.originPlaceViewModel.FillListCitiesByState();
        }

        private void CmbCountryDestinationPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.destinationPlaceViewModel.FillListStatesByCountry();
        }

        private void CmbStateDestinationPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.destinationPlaceViewModel.FillListCitiesByState();
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (originPlaceViewModel.Id > -1)
            {
                if (originPlaceViewModel.DeletePlace())
                {
                    MessageBox.Show("Lugar de origen eliminado correctamente", "Eliminación exitosa");

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar un lugar de origen", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar a un lugar de origen", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BunifuImageButton5_Click(object sender, EventArgs e)
        {
            if (destinationPlaceViewModel.Id > -1)
            {
                if (destinationPlaceViewModel.DeletePlace())
                {
                    MessageBox.Show("Lugar de destino eliminado correctamente", "Eliminación exitosa");

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar un lugar de destino", "Error de eliminación");
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar a un lugar de destino", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
