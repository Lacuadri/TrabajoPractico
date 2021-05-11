using BancoDeSangreCórdoba.CapaAccesoDatos;
using BancoDeSangreCórdoba.CapaLógica;
using BancoDeSangreCórdoba.CapaPresentación.ABMPuestos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeSangreCórdoba.CapaPresentación
{
    public partial class FrmABMPuestos : Form
    {
        Puesto puesto;
        ValidacionTxt validacion = new ValidacionTxt();
        public FrmABMPuestos()
        {
            InitializeComponent();
            picBorrar.Visible = false;
            picModificar.Visible = false;
            puesto = null;
        }
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void picSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaPuesto ventana = new FrmAltaPuesto();
            ventana.Show();
        }

        private void picBorrar_Click(object sender, EventArgs e)
        {
            FrmBajaPuesto ventana = new FrmBajaPuesto(puesto);
            ventana.Show();
        }
        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            txtLetraPuesto.Enabled = true;
            if (chkTodos.Checked)
            {
                txtLetraPuesto.Enabled = false;
                txtLetraPuesto.Text = "";
            }
        }

        private void FrmABMPuestos_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            try
            {
                tablaPuestos.DataSource = AD_Puestos.GetListadoPuestos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla de Puestos");
            }
        }

        private void txtLetraPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetra(e);
        }

        private void btnConsultarPuestos_Click(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                cargarGrilla();
            }
            else
            {
                if (txtLetraPuesto.Text != "")
                    tablaPuestos.DataSource = AD_Puestos.GetFiltroPuesto(Convert.ToChar(txtLetraPuesto.Text));
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void tablaPuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            picModificar.Visible = true;
            picBorrar.Visible = true;
            DataGridViewRow filaSeleccionada = tablaPuestos.Rows[indice];
            string letra = filaSeleccionada.Cells["Puesto"].Value.ToString();
            int id = Convert.ToInt32((filaSeleccionada.Cells["Id"].Value.ToString()));
            Puesto p = new Puesto(letra, id);
            puesto = p;
        }
        private void picModificar_Click(object sender, EventArgs e)
        {
            FrmModificarPuesto ventana = new FrmModificarPuesto(puesto);
            ventana.Show();
        }
    }
}
