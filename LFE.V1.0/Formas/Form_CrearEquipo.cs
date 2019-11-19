using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFE.V1._0.Formas
{
    public partial class Form_CrearEquipo : Form
    {
        public Form_CrearEquipo()
        {
            InitializeComponent();
            BloquearOcultar();
        }
        private void BloquearOcultar()
        {
            buttonCrear.Enabled = false;
            labelDisponible.Visible = false;
            labelNoDisponbile.Visible = false;
            textBoxNombreEquipo.Clear();

        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            var Verificar = new Datos.Equipos();
            if (textBoxNombreEquipo.Text == "")
            {
                MessageBox.Show("No se permiten espacios en blanco");
                BloquearOcultar();
            }
            else
            {
                if (Verificar.LeerDatos(textBoxNombreEquipo.Text) == true)
                {
                    labelDisponible.Visible = true;
                    buttonCrear.Enabled = true;
                }
                else
                {
                    labelNoDisponbile.Visible = true ;
                    
                }

                
            }
            
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            var Verificar = new Datos.Equipos();
            Verificar.EscribirDato(textBoxNombreEquipo.Text);
            MessageBox.Show("Creado con exito");
            BloquearOcultar();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            BloquearOcultar();
        }
    }
}
