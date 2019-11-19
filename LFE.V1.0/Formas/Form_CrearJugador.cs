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
    public partial class Form_CrearJugador : Form
    {
        public Form_CrearJugador()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxGoles.Clear();
            textBoxJugador.Clear();
            radioButtonDelantero.Checked = false;
            radioButtoncentro.Checked = false;
            radioButtonDefensa.Checked = false;
            radioButtonPortero.Checked = false;
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            int NumeroGoles;
            if (textBoxJugador.Text == "" || textBoxGoles.Text == "")
            {
                MessageBox.Show("No se permiten espacios vacio");
            }
            else
            {
                try
                {
                    NumeroGoles = int.Parse(textBoxGoles.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Número Invalido");
                    textBoxGoles.Clear();
                }

            }
        }

        private void textBoxGoles_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
