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

namespace BancoDeSangreCórdoba.CapaPresentación.ABMPuestos
{
    public partial class FrmAltaPuesto : Form
    {

        public FrmAltaPuesto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                lblLetra.Visible = false;
                bool resultado = AD_Puestos.insertarPuesto(Convert.ToChar(txtLetra.Text));
                if (resultado)
                {
                    MessageBox.Show("Se cargo el puesto exitosamente");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al insertar el Puesto!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar el Puesto!");
                txtLetra.Focus();
            }
        }

        private void btnCancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAltaPuesto_Load(object sender, EventArgs e)
        {

        }
    }
}
