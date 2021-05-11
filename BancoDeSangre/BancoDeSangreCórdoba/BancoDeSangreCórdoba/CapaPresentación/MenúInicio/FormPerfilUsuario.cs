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
    public partial class FormPerfilUsuario : Form
    {
        private Usuario logueado;
        private Empleado empleadoLogueado;

        public FormPerfilUsuario(Usuario logueado)
        {
            InitializeComponent();
            this.logueado = logueado;
            DatosUsuario(false);
        }

        private void TimerMensaje_Tick(object sender, EventArgs e)
        {
            lblMensaje.ForeColor = Color.DarkGray;
            lblMensaje.Visible = false;
            timerMensaje.Stop();
        }

        private void HabilitarMensaje(string mensaje)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.Visible = true;
            timerMensaje.Start();
        }

        private void DatosUsuario(bool editar)
        {
            try
            {
                empleadoLogueado = D_Empleado.GetNombreApellido(logueado.LegajoUsuario);
                lblApellido.Text = empleadoLogueado.Apellido;
                lblNombre.Text = empleadoLogueado.Nombre;
                txtUsuario.Text = logueado.Nickname;
                lblLegajo.Text = "LEGAJO: " + logueado.LegajoUsuario;
                if (editar)
                {
                    txtUsuario.Enabled = true;

                    lblPassword.Visible = true;
                    lblConfirmarPassword.Visible = true;
                    txtPassword.Visible = true;
                    txtPassword.Text = logueado.Password;
                    txtConfirmarPassword.Visible = true;
                    txtConfirmarPassword.Text = logueado.Password;

                    txtUsuario.Focus();
                }
                else
                {
                    txtUsuario.Enabled = false;

                    lblPassword.Visible = false;
                    lblConfirmarPassword.Visible = false;
                    txtPassword.Visible = false;
                    txtConfirmarPassword.Visible = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DatosUsuario(true);
            BtnEditar.Visible = false;
            BtnGuardar.Visible = true;
            BtnCancelar.Visible = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DatosUsuario(false);
            BtnEditar.Visible = true;
            BtnGuardar.Visible = false;
            BtnCancelar.Visible = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string actualizandoNickname = txtUsuario.Text.Trim();
            int legajo = logueado.LegajoUsuario;
            string actualizandoPassword = txtPassword.Text;
            if (txtUsuario.Text.Equals(""))
            {
                HabilitarMensaje("Ingresar un usuario");
                txtUsuario.Focus();
            }
            else if (txtPassword.Text.Equals("") || txtConfirmarPassword.Text.Equals(""))
            {
                if (txtPassword.Text.Equals(""))
                {
                    HabilitarMensaje("Ingresar un password");
                    txtPassword.Focus();
                }
                else
                {
                    HabilitarMensaje("Repetir password para validarlo");
                    txtConfirmarPassword.Focus();
                }
            }
            else if (txtPassword.Text.Equals(txtConfirmarPassword.Text))
            {
                try
                {
                    if (D_Usuario.ValidarNickname(txtUsuario.Text))
                    {
                        HabilitarMensaje("Usuario ya registrado");
                        txtUsuario.Text = "";
                        txtUsuario.Focus();
                    }
                    else
                    {
                        D_Usuario.ActualizarUsuario(legajo, actualizandoNickname, actualizandoPassword);
                    }
                }
                catch (Exception)
                {
                    HabilitarMensaje("Problema con la base de datos");
                }
            }
            else
            {
                HabilitarMensaje("Los password no coinciden");
                txtConfirmarPassword.Text = "";
                txtConfirmarPassword.Focus();
            }
        }
    }
}
