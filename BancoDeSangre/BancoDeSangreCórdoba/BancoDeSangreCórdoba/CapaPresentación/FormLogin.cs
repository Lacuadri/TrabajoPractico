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
    public partial class FormLogin : Form
    {
        private string nickname;
        private string password;
        private int legajo;
        private Usuario logueado;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void TimerDate_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void TimerMensaje_Tick(object sender, EventArgs e)
        {
            lblMensaje.ForeColor = Color.DarkGray;
            lblMensaje.Visible = false;
            timerMensaje.Stop();
        }

        private void TimerCargaVentana_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1;
            Opacity -= 0.005;
            if (progressBar.Value == 100)
            {
                timerCargaVentana.Stop();
                FormEscritorio ventana = new FormEscritorio(logueado);
                ventana.Show();
                Hide();
            }
        }
       
        private void HabilitarMensaje(string mensaje)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.Visible = true;
            timerMensaje.Start();
        }

        private void HabilitarBienvenida(Usuario usuario)
        {
            logueado = usuario;
            lblSaludo.Text = "TE DAMOS LA BIENVENIDA...";
            try
            {
                legajo = logueado.LegajoUsuario;
                Empleado empleadoLogueado = D_Empleado.GetNombreApellido(legajo);
                lblUsuario.Text = empleadoLogueado.Nombre + " " + empleadoLogueado.Apellido;
            }
            catch (Exception)
            {
                HabilitarMensaje("Problema con el acceso a la base de datos");
            }
            lblPassword.Text = "Su sesión ha sido iniciada";
            lblTitulo.Visible = false;
            lblLegajo.Visible = false;
            lblUsuario.Visible = true;
            lblPassword.Visible = true;
            txtUsuario.Visible = false;
            txtPassword.Visible = false;
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Text = "Abriendo el Sistema. Espere...por favor";
            lblMensaje.Visible = true;
            btnAcceder.Visible = false;
            btnRegistrar.Visible = false;
            btnBuscar.Visible = false;
            btnIngresar.Visible = false;
            lblRegistrar.Visible = false;
            linkLblRegistrar.Visible = false;
            lblOlvidarDatos.Visible = false;
            linkLblClickAqui.Visible = false;
            timerCargaVentana.Enabled = true;
            progressBar.Enabled = true;
            progressBar.Visible = true;
            timerMensaje.Interval = 4000;
            timerMensaje.Start();
            timerCargaVentana.Start();
        }

        private void HabilitarCampos()
        {
            lblLegajo.Visible = true;
            maskedTxtLegajo.Visible = true;

            lblUsuario.Visible = true;
            txtUsuario.Visible = true;
            txtUsuario.Text = "";

            lblPassword.Visible = true;
            txtPassword.Visible = true;
            txtPassword.Text = "";

            lblRepetirPassword.Visible = true;
            txtRepetirPassword.Visible = true;
            txtRepetirPassword.Text = "";
        }

        private void LimpiarVentana()
        {
            lblLegajo.Visible = false;
            maskedTxtLegajo.Visible = false;

            lblUsuario.Visible = false;
            txtUsuario.Visible = false;

            lblPassword.Visible = false;
            txtPassword.Visible = false;
            lblRepetirPassword.Visible = false;
            txtRepetirPassword.Visible = false;

            btnRegistrar.Visible = false;
            btnBuscar.Visible = false;
            btnIngresar.Visible = false;
        }

        private void ActualizarTitulo(string titulo)
        {
            lblTitulo.Text = titulo;
            lblUsuario.Visible = false;
            txtUsuario.Visible = false;
            lblPassword.Visible = false;
            txtPassword.Visible = false;
            btnAcceder.Visible = false;
            lblRegistrar.Visible = false;
            linkLblRegistrar.Visible = false;
            lblOlvidarDatos.Visible = false;
            linkLblClickAqui.Visible = false;
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            nickname = txtUsuario.Text;
            password = txtPassword.Text;
            try
            {
                if (D_Usuario.ValidarUsuario(nickname, password))
                {
                    logueado = D_Usuario.GetUsuario(nickname, password);
                    HabilitarBienvenida(logueado);
                }
                else
                {
                    if (nickname.Equals("") && password.Equals(""))
                    {
                        HabilitarMensaje("No ha ingresado ningún dato. Pruebe de nuevo...");
                        txtUsuario.Focus();
                    }
                    else if (nickname.Equals(""))
                    {
                        HabilitarMensaje("No ha ingresado ningún usuario. Pruebe de nuevo...");
                        txtUsuario.Focus();

                    }
                    else if (password.Equals(""))
                    {
                        HabilitarMensaje("No ingresó su password. Pruebe de nuevo...");
                        txtPassword.Focus();
                    }
                    else if (D_Usuario.ValidarNickname(nickname))
                    {
                        HabilitarMensaje("El password NO es válido. Intente nuevamente...");
                        txtPassword.Text = "";
                        txtPassword.Focus();
                    }
                    else
                    {
                        HabilitarMensaje("No se encuentra el usuario. Intente nuevamente...");
                        txtUsuario.Text = "";
                        txtUsuario.Focus();
                    }
                }
            }
            catch (Exception)
            {
                HabilitarMensaje("Problema con el acceso a la base de datos");
            }
        }

        private void LinkLblRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActualizarTitulo("ALTA DE USUARIO");
            HabilitarCampos();

            btnRegistrar.Visible = true;
            btnBuscar.Visible = false;
            btnIngresar.Visible = false;

            maskedTxtLegajo.Focus();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            nickname = txtUsuario.Text;
            password = txtPassword.Text;
            if (maskedTxtLegajo.Text.Equals(""))
            {
                HabilitarMensaje(" Debe ingresar su legajo");
                maskedTxtLegajo.Focus();
            }
            else
            {
                try
                {
                    legajo = int.Parse(maskedTxtLegajo.Text.Trim());
                    if (D_Empleado.ValidarLegajo(legajo))
                    {
                        Usuario usuario = D_Usuario.GetUsuario(legajo);
                        if (usuario != null)
                        {
                            HabilitarMensaje("Ya existe un usuario con ese legajo");
                            maskedTxtLegajo.Text = "";
                            maskedTxtLegajo.Focus();
                            txtUsuario.Text = "";
                            txtPassword.Text = "";
                            txtRepetirPassword.Text = "";
                        }
                        else 
                        {
                            if (txtUsuario.Text.Equals(""))
                            {
                                HabilitarMensaje(" Debe ingresar un usuario");
                                txtUsuario.Focus();
                            }
                            else if (txtPassword.Text.Equals("") || txtRepetirPassword.Text.Equals(""))
                            {
                                if (txtPassword.Text.Equals(""))
                                {
                                    HabilitarMensaje(" Debe ingresar un password");
                                    txtPassword.Focus();
                                }
                                else
                                {
                                    HabilitarMensaje(" Debe repetir el password para validarlo");
                                    txtRepetirPassword.Focus();
                                }
                            }
                            else if (txtPassword.Text.Equals(txtRepetirPassword.Text))
                            {
                                try
                                {
                                    if (D_Usuario.ValidarNickname(txtUsuario.Text))
                                    {
                                        HabilitarMensaje("El nombre de usuario ya se encuentra registrado");
                                        txtUsuario.Text = "";
                                        txtUsuario.Focus();
                                    }
                                    else if (D_Usuario.RegistrarUsuario(nickname, password, legajo))
                                    {
                                        LimpiarVentana();
                                        HabilitarBienvenida(D_Usuario.GetUsuario(nickname, password));
                                    }
                                    else
                                    {
                                        HabilitarMensaje("Error en la base de datos");
                                    }
                                }
                                catch (Exception)
                                {
                                    HabilitarMensaje("Problema con el acceso a la base de datos");
                                }
                            }
                            else
                            {
                                HabilitarMensaje("Los password ingresados no coinciden");
                                txtRepetirPassword.Text = "";
                                txtRepetirPassword.Focus();
                            }
                        }
                    }
                    else
                    {
                        HabilitarMensaje("No hay registrado un empleado con ese legajo");
                        maskedTxtLegajo.Text = "";
                        maskedTxtLegajo.Focus();
                        txtUsuario.Text = "";
                        txtPassword.Text = "";
                        txtRepetirPassword.Text = "";
                    }   
                }
                catch (Exception)
                {
                    HabilitarMensaje("Problema con el acceso a la base de datos");
                }
            }
        }

        private void LinkLblClickAqui_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActualizarTitulo("BUSCAR POR LEGAJO");
            HabilitarCampos();

            maskedTxtLegajo.Focus();
            
            txtUsuario.Enabled = false;
            txtPassword.Enabled = false;
            txtRepetirPassword.Enabled = false;
            btnRegistrar.Visible = false;
            btnBuscar.Visible = true;
            btnIngresar.Visible = false;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (maskedTxtLegajo.Text.Equals(""))
            {
                HabilitarMensaje(" Debe ingresar su legajo");
                maskedTxtLegajo.Focus();
            }
            else
            {
                try
                {
                    legajo = int.Parse(maskedTxtLegajo.Text.Trim());
                    Usuario usuario = D_Usuario.GetUsuario(legajo);
                    if (usuario != null)
                    {
                        txtUsuario.Text = usuario.Nickname;
                        legajo = int.Parse(maskedTxtLegajo.Text.Trim());
                        maskedTxtLegajo.Enabled = false;

                        timerMensaje.Interval = 5000;
                        lblMensaje.ForeColor = Color.White;
                        HabilitarMensaje("Usuario encontrado: Cambie su password por favor");

                        txtPassword.Enabled = true;
                        txtPassword.Focus();
                        txtRepetirPassword.Enabled = true;
                        btnBuscar.Visible = false;
                        btnIngresar.Visible = true;
                    }
                    else
                    {
                        HabilitarMensaje("Usuario inexistente en la base de datos");
                        maskedTxtLegajo.Text = "";
                        maskedTxtLegajo.Focus();
                    }
                }
                catch (Exception)
                {
                    HabilitarMensaje("Problema con el acceso a la base de datos");
                }
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            nickname = txtUsuario.Text;
            password = txtPassword.Text;
            if (txtPassword.Text.Equals("") || txtRepetirPassword.Text.Equals(""))
            {
                if (txtPassword.Text.Equals(""))
                {
                    HabilitarMensaje(" Debe ingresar un nuevo password");
                    txtPassword.Focus();
                }
                else
                {
                    HabilitarMensaje(" Debe repetir su nuevo password");
                    txtRepetirPassword.Focus();
                }
            }
            else
            {
                try
                {
                    if (txtPassword.Text.Equals(txtRepetirPassword.Text))
                    {
                        if (D_Usuario.ActualizarPasswordUsuario(legajo, password))
                        {
                            LimpiarVentana();
                            HabilitarBienvenida(D_Usuario.GetUsuario(nickname, password));
                        }
                        else
                        {
                            HabilitarMensaje("No se pudo actualizar sus datos");
                        }
                    }
                    else
                    {
                        HabilitarMensaje("Los password ingresados no coinciden");
                        txtRepetirPassword.Text = "";
                        txtRepetirPassword.Focus();
                    }
                }
                catch (Exception)
                {
                    HabilitarMensaje("Problema con el acceso a la base de datos");
                }
            }
        }
    }
}
