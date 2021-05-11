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

namespace BancoDeSangreCórdoba.CapaPresentación.ABMPuestos
{
    public partial class FrmBajaPuesto : Form
    {
        Puesto p;
        ValidacionTxt validacion = new ValidacionTxt();
        public FrmBajaPuesto(Puesto puesto)
        {
            
            InitializeComponent();
            Puesto p = puesto;
            txtLetra.Text = p.letraPuesto;
            txtLetra.Enabled = false;
            
        }

        private void FrmBajaPuesto_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //falta validar si se escribio algo en el txt
            //falta validar si el puesto se encuantra en la base dde Datos
            try
            {
                lblLetra.Visible = false;
                bool resultado = AD_Puestos.eliminarPuesto(txtLetra.Text);
                if (resultado)
                {
                    MessageBox.Show("Se dio la baja del puesto exitosamente");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al borrar el Puesto!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al borrar el Puesto!");
                txtLetra.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtLetra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetraMayuscula(e);
        }
    }
}
