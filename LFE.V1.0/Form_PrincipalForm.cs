using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFE.V1._0
{
    public partial class Form_PrincipalForm : Form
    {
        public Form_PrincipalForm()
        {
            InitializeComponent();
            OcultarPaneles();
        }
        public void OcultarPaneles()
        {
            SubPanel1.Visible = false;
            SubPanel2.Visible = false;
            SubPanel3.Visible = false;
        }
        private void MostrarEnContenedor(Object FormChild)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form NewForm = FormChild as Form;
            NewForm.TopLevel = false;
            NewForm.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(NewForm);
            this.panelContenedor.Tag = NewForm;
            NewForm.Show();


        }

        private void buttonGestionarEquipos_Click(object sender, EventArgs e)
        {
            SubPanel1.Visible = true;
            SubPanel2.Visible = false;
            SubPanel3.Visible = false;
        }

        private void buttonGestionarJugadores_Click(object sender, EventArgs e)
        {
            SubPanel1.Visible = false;
            SubPanel2.Visible = true;
            SubPanel3.Visible = false;
        }

        private void buttonTablas_Click(object sender, EventArgs e)
        {
            SubPanel1.Visible = false;
            SubPanel2.Visible = false;
            SubPanel3.Visible = true;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCrearEquipo_Click(object sender, EventArgs e)
        {
            MostrarEnContenedor(new Formas.Form_CrearEquipo());
        }

        private void buttonEliminarEquipo_Click(object sender, EventArgs e)
        {
            MostrarEnContenedor(new Formas.Form_EliminarEquipo());
        }

        private void buttonCrearJugador_Click(object sender, EventArgs e)
        {
            MostrarEnContenedor(new Formas.Form_CrearJugador());
        }

        private void buttonTablaResultados_Click(object sender, EventArgs e)
        {
            MostrarEnContenedor(new Formas.Form_TablasResultados());
        }

        private void buttonTablaPosiciones_Click(object sender, EventArgs e)
        {
            MostrarEnContenedor(new Formas.Form_TablaPosiciones());
        }
    }
}
