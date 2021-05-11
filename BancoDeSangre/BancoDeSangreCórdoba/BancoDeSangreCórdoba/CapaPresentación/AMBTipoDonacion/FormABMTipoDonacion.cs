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
    public partial class FormABMTipoDonacion : Form
    {
        TipoDonaciones tipo;
        public FormABMTipoDonacion()
        {
            InitializeComponent();
            imgDelete.Visible = false;
            imgEdit.Visible = false;
            tipo = null;

        }
        public void CargarGrilla()
        {
            try
            {
                dgTiposDonaciones.DataSource = AD_TiposDonaciones.GetListadoTipoDonaciones();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FormABMTipoDonacion_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void imgAdd_Click(object sender, EventArgs e)
        {
            FormAltaTipoDonacion ventana = new FormAltaTipoDonacion();
            ventana.ShowDialog();

        }

        private void imgQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgTiposDonaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            imgEdit.Visible = true;
            imgDelete.Visible = true;
            DataGridViewRow filaSeleccionada = dgTiposDonaciones.Rows[indice];
            string nombre = filaSeleccionada.Cells["nombre_tipoDonacion"].Value.ToString();
            int id = Convert.ToInt32((filaSeleccionada.Cells["id_tipoDonacion"].Value.ToString()));
            TipoDonaciones td = new TipoDonaciones(nombre, id);
            tipo = td;

        }

        private void imgEdit_Click(object sender, EventArgs e)
        {
            FormEditarTipoDonacion ventana = new FormEditarTipoDonacion(tipo);
            ventana.ShowDialog();

        }

        private void imgDelete_Click(object sender, EventArgs e)
        {
            FormBajaTipoDonacion ventana = new FormBajaTipoDonacion(tipo);
            ventana.ShowDialog();
        }

        private void btnConsultarTipoDonacion_Click(object sender, EventArgs e)
        {
            if (txtBusquedaTipoDonacion.Text != "")
            {
                dgTiposDonaciones.DataSource = AD_TiposDonaciones.GetFiltroTipoDonacion(txtBusquedaTipoDonacion.Text);
                txtBusquedaTipoDonacion.Text = "";
            }
        }

        private void btnActualizarTipoDonaciones_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["FormABMTipoDonacion"] as FormABMTipoDonacion).CargarGrilla();

        }

        private void toolTipModificacion(object sender, PopupEventArgs e)
        {

        }

        private void tootipAlta(object sender, PopupEventArgs e)
        {

        }

        private void toolTipBaja(object sender, PopupEventArgs e)
        {

        }
    }
}
