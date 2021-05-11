using BancoDeSangreCórdoba.CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeSangreCórdoba.CapaPresentación.AMBTipoDonacion
{
    public partial class FormAltaTipoDonacion : Form
    {
        public FormAltaTipoDonacion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha cancelado la operacion");
            Close();
        }

        private void btnAceptarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = AD_TiposDonaciones.insertarTipoDonacion(Convert.ToString(txtNombreTipoDonacionAlta.Text));
                if (resultado)
                {
                    MessageBox.Show("Se ha cargado el tipo de donacion con exito");
                    (System.Windows.Forms.Application.OpenForms["FormABMTipoDonacion"] as FormABMTipoDonacion).CargarGrilla();
                    Close();

                }
                else
                {
                    MessageBox.Show("Error al cargar tipo de donacion");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el tipo de donacion");
                txtNombreTipoDonacionAlta.Focus();
            }
        }
    }
}
