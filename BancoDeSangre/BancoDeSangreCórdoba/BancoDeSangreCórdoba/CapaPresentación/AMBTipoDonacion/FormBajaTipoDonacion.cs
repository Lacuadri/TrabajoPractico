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
    public partial class FormBajaTipoDonacion : Form
    {
        TipoDonaciones td;
        public FormBajaTipoDonacion(TipoDonaciones tipo)
        {
            InitializeComponent();
            TipoDonaciones td = tipo;
            txtNombreTipoDonacionBaja.Text = td.nombreTiposDonaciones;
            txtNombreTipoDonacionBaja.Enabled = false;

        }

        private void btnCancelarEdit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarEdit_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = AD_TiposDonaciones.EliminarTipoDonacion(txtNombreTipoDonacionBaja.Text);
                if (resultado)
                {
                    MessageBox.Show("Se dio la baja del puesto exitosamente");
                    (System.Windows.Forms.Application.OpenForms["FormABMTipoDonacion"] as FormABMTipoDonacion).CargarGrilla();
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al borrar el Puesto!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
