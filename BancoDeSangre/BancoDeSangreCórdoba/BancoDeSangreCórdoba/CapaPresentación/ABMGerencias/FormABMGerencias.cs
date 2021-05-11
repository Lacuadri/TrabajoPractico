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
    public partial class FormABMGerencias : Form
    {
        Gerencias ger;
        public FormABMGerencias()
        {
            InitializeComponent();
            imgDelete.Visible = false;
            imgEdit.Visible = false;
            ger = null;

        }

        private void ABMGerencias_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            try
            {
                dgGerencias.DataSource = AD_Gerencias.GetListadoGerencias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla de Gerencias");
            }
        }

        private void imgQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgGerencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void imgAdd_Click(object sender, EventArgs e)
        {
            FormAgregarGerencia ventana = new FormAgregarGerencia();
            ventana.ShowDialog();

        }

        private void imgEdit_Click(object sender, EventArgs e)
        {
            FormEditarGerencia ventana = new FormEditarGerencia(ger);
            ventana.ShowDialog();
        }

        private void imgDelete_Click(object sender, EventArgs e)
        {
            FormBajaGerencias ventana = new FormBajaGerencias(ger);
            ventana.ShowDialog();

        }

        private void dgGerencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice > 0)
            {
                imgEdit.Visible = true;
                imgDelete.Visible = true;
                DataGridViewRow filaSeleccionada = dgGerencias.Rows[indice];
                string nombre = filaSeleccionada.Cells["nombreGerencia"].Value.ToString();
                int id = Convert.ToInt32((filaSeleccionada.Cells["id_gerencia"].Value.ToString()));
                int leg = Convert.ToInt32((filaSeleccionada.Cells["legajo_supervisor"].Value.ToString()));
                int direc = Convert.ToInt32((filaSeleccionada.Cells["id_direccion"].Value.ToString()));
                Gerencias g = new Gerencias(id, nombre, direc, leg);
                ger = g;
            }
        }
    }
}
