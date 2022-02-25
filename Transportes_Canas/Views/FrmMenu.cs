using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportes_Canas.Views;

namespace Transportes_Canas.Views
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Cliente";
            AbrirFormHija(new FrmCliente());
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            btnMotorista.IconMarginLeft = 0;
            btnAsignacion.IconMarginLeft = 0;
            btnCliente.IconMarginLeft = 0;
            btnOrigenDestino.IconMarginLeft = 0;
            btnUnidades.IconMarginLeft = 0;
            btnViajes.IconMarginLeft = 0;
            btnBurger.Left += 28;
            Menu.Width = 55;
            lblTitle.Text = "Motorista";
            AbrirFormHija(new FrmMotorista());
        }

        private void AbrirFormHija(Object formhija)
        {
            if (this.Body.Controls.Count > 0)
            {
                this.Body.Controls.RemoveAt(0);
            }
            Form frm = formhija as Form;
            frm.TopLevel = false;
            this.Body.Controls.Add(frm);
            this.Body.Tag = frm;
            frm.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMotorista_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Motorista";
            AbrirFormHija(new FrmMotorista());
        }

        private void btnUnidades_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Unidades";
            AbrirFormHija(new FrmUnidades());
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Viajes";
            AbrirFormHija(new FrmViaje());
        }

        private void btnAsignacion_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Asignación de Viajes";
            AbrirFormHija(new FrmAsignacion());
        }

        private void btnOrigenDestino_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Origen y Destino";
            AbrirFormHija(new FrmOrigenDestino());
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (Menu.Width == 55)
            {
                btnMotorista.IconMarginLeft = 10;
                btnAsignacion.IconMarginLeft = 10;
                btnCliente.IconMarginLeft = 10;
                btnOrigenDestino.IconMarginLeft = 10;
                btnUnidades.IconMarginLeft = 10;
                btnViajes.IconMarginLeft = 10;
                btnBurger.Left -= 28;
                Menu.Visible = false;
                Menu.Width = 285;
                tranPanel.ShowSync(Menu);
            }
            else
            {
                btnMotorista.IconMarginLeft = 0;
                btnAsignacion.IconMarginLeft = 0;
                btnCliente.IconMarginLeft = 0;
                btnOrigenDestino.IconMarginLeft = 0;
                btnUnidades.IconMarginLeft = 0;
                btnViajes.IconMarginLeft = 0;
                btnBurger.Left += 28;
                Menu.Visible = false;
                Menu.Width = 55;
                tranPanel.ShowSync(Menu);
            }
        }
    }
}
