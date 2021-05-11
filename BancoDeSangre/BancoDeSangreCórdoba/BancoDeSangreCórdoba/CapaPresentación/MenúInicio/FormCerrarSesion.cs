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

namespace BancoDeSangreCórdoba.CapaPresentación
{
    public partial class FormCerrarSesion : Form
    {
        Usuario logueado;
        public FormCerrarSesion(Usuario logueado)
        {
            InitializeComponent();
            this.logueado = logueado;
            lblUsuario.Text = logueado.Nickname;
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSI_Click(object sender, EventArgs e)
        {
            pictureBoxPregunta.Visible = false;
            pictureBoxSalida.Visible = true;
            try
            {
                int legajo = logueado.LegajoUsuario;
                Empleado empleadoLogueado = D_Empleado.GetNombreApellido(legajo);
                lblUsuario.Text = empleadoLogueado.Nombre + " " + empleadoLogueado.Apellido;
            }
            catch (Exception)
            {
                lblUsuario.Text = logueado.Nickname;
                //MessageBox.Show("" + ex);
            }
            label.Text = "Gracias por utilizar el sistema";
            btnSI.Visible = false;
            btnNo.Visible = false;
            progressBar.Enabled = true;
            progressBar.Visible = true;
            timerCerrarSesion.Start();
            TimerCerrarSesion_Tick(sender, e);
        }

        private void TimerCerrarSesion_Tick(object sender, EventArgs e)
        {
            progressBar.Value -= 1;
            Opacity -= 0.004;
            if (progressBar.Value == 0)
            {
                timerCerrarSesion.Stop();
                Application.Exit();
            }
        }
    }
}
