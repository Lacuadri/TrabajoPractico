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

namespace BancoDeSangreCórdoba.CapaPresentación.ABMGerencias
{
    public partial class FormEditarGerencia : Form
    {
        Gerencias ger;
        public FormEditarGerencia(Gerencias g)
        {
            InitializeComponent();
            ger = g;
            txtNombreGerencia.Enabled = false;
            txtLegajoSupervisor.Enabled = false;
            txtIdDireccion.Enabled = false;

            txtIdDireccion.Text = g.IdDir.ToString();
            txtNombreGerencia.Text = g.Nombre;
            txtLegajoSupervisor.Text = g.LegSup.ToString();
            CargarComboIdDireccionLegajoSupervisor();
        }

        private void CargarComboIdDireccionLegajoSupervisor()
        {
            try
            {
                
                cmbLegajo.DataSource = AD_Gerencias.ObtenerIdDireccion();
                cmbLegajo.DisplayMember = "legajo_supervisor";
                cmbLegajo.ValueMember = "legajo_supervisor";
                cmbLegajo.SelectedIndex = -1;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el combo direccion");
            }
        }

        private void btnCancelarEdit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarEdit_Click(object sender, EventArgs e)
        {
            Gerencias g = ObtenerDatosGerencia();
            bool resultado = AD_Gerencias.ActualizarGerencias(int.Parse(txtIdDireccion.Text.ToString()), g);
            if (resultado)
            {
                MessageBox.Show("Se actualizo con exito la gerencia");
                (System.Windows.Forms.Application.OpenForms["FormABMGerencias"] as FormABMGerencias).CargarGrilla();
                Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar gerencia");
            }
        }

        private Gerencias ObtenerDatosGerencia()
        {
            Gerencias ger = new Gerencias();
            ger.Nombre = txtNuevoNombreGerencia.Text.Trim();
            ger.LegSup = (int)cmbLegajo.SelectedValue;
            return ger;
        }
    }
}
