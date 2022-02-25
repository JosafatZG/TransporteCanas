using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADS_PROYECT
{
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
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
            AbrirFormHija(new Asignacion());
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(Menu.Width == 55)
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
            }else
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

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Asignación de Viajes";
            AbrirFormHija(new Asignacion());
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMotorista_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Motorista";
            AbrirFormHija(new Motorista());
        }

        private void AbrirFormHija(Object formhija)
        {
            if(this.Body.Controls.Count > 0)
            {
                this.Body.Controls.RemoveAt(0);
            }
            Form frm = formhija as Form;
            frm.TopLevel = false;
            this.Body.Controls.Add(frm);
            this.Body.Tag = frm;
            frm.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Cliente";
            AbrirFormHija(new Cliente());
        }

        private void btnOrigenDestino_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Origenes y Destinos";
            AbrirFormHija(new OrigenDestino());
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Viajes";
            AbrirFormHija(new Viaje());
        }

        private void btnUnidades_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Unidades";
            AbrirFormHija(new Unidades());
        }
    }
}
