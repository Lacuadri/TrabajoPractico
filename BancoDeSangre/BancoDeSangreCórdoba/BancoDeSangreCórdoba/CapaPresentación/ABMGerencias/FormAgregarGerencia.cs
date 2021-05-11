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
    public partial class FormAgregarGerencia : Form
    {
        public FormAgregarGerencia()
        {
            InitializeComponent();
        }

        private void btnCancelarAgregarGerencia_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void FormAgregarGerencia_Load(object sender, EventArgs e)
        {
            
            CargarComboIdDireccionLegajoSupervisor();
            
        }


        public void CargarComboIdDireccionLegajoSupervisor()
        {
            try
            {
                cmbDireccion.DataSource = AD_Gerencias.ObtenerIdDireccion();
                cmbDireccion.DisplayMember = "id_direccion";
                cmbDireccion.ValueMember = "id_direccion";
                cmbDireccion.SelectedIndex = -1;

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

        private void btnAceptarAgregarGerencia_Click(object sender, EventArgs e)
        {
            try
            {
                Gerencias ger = ObtenerDatosGerencia();
                bool resultado = AD_Gerencias.InsertarGerencia(ger);
                if (resultado)
                {
                    MessageBox.Show("Se ha cargado la gerencia correctamente");
                    (System.Windows.Forms.Application.OpenForms["FormABMGerencias"] as FormABMGerencias).CargarGrilla();
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al cargar la gerencia");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la gerencia");
            }
        }

        private Gerencias ObtenerDatosGerencia()
        {
            Gerencias ger = new Gerencias();
            ger.Nombre = txtNombreGerencia.Text.Trim();
            ger.IdDir = (int)cmbDireccion.SelectedValue;
            ger.LegSup= (int)cmbLegajo.SelectedValue;
            return ger;


        }
    }
}
