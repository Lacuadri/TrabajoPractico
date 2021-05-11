using BancoDeSangreCórdoba.CapaAccesoDatos;
using BancoDeSangreCórdoba.CapaLógica;
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
    public partial class FormEditarTipoDonacion : Form
    {
        TipoDonaciones tipo;
        public FormEditarTipoDonacion(TipoDonaciones td)
        {
            InitializeComponent();
            tipo = td;
            txtNombreTipoDonacionEdit.Text = td.nombreTiposDonaciones;
            txtNombreTipoDonacionEdit.Enabled = false;

        }

        private void btnCancelarEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operacion Cancelada");
            Close();

        }

        private void btnAceptarEdit_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = AD_TiposDonaciones.EditarTipoDonacion(txtNuevoNombreTipoDonacionEdit.Text,tipo.id_TipoDonaciones);
                if (resultado)
                {
                    MessageBox.Show("Se modifico el puesto exitosamente");
                    (System.Windows.Forms.Application.OpenForms["FormABMTipoDonacion"] as FormABMTipoDonacion).CargarGrilla();
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al modificar el Puesto!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar el Puesto!");
                txtNuevoNombreTipoDonacionEdit.Focus();
            }
        }
        
    }
}
