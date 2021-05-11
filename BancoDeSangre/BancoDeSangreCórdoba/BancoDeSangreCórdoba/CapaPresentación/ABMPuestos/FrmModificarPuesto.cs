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
    public partial class FrmModificarPuesto : Form
    {
        Puesto puesto;
        ValidacionTxt validacion = new ValidacionTxt();
        
        public FrmModificarPuesto(Puesto p)
        {
            InitializeComponent();
            puesto = p;
            txtLetra.Text = p.letraPuesto;
            txtLetra.Enabled = false;
            btnAceptar.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                bool resultado = AD_Puestos.modificarPuesto(txtLetra.Text, puesto.id_puesto);
                if (resultado)
                {
                    MessageBox.Show("Se modifico el puesto exitosamente");
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
                txtLetra.Focus();
            }
        }

        

        private void linkModificar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtLetra.Enabled = true;
            btnAceptar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmModificarPuesto_Load(object sender, EventArgs e)
        {

        }

        private void txtLetra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetraMayuscula(e);
        }
    }
}
