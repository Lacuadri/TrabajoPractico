using BancoDeSangreCórdoba.CapaLógica;
using BancoDeSangreCórdoba.CapaPresentación.ABMEmpleados;
using BancoDeSangreCórdoba.CapaPresentación.ABMGerencias;
using BancoDeSangreCórdoba.CapaPresentación.AMBTipoDonacion;
using System;
using System.Windows.Forms;

namespace BancoDeSangreCórdoba.CapaPresentación
{
    public partial class FormEscritorio : Form
    {
        private Form formularioActivo;
        private readonly Usuario logueado;
        private int segundos;
        private int minutos;
        private int horas;

        public FormEscritorio(Usuario logueado)
        {
            InitializeComponent();
            this.logueado = logueado;
            lblUsuarioLogueado.Text = "USUARIO: " + logueado.Nickname;
            btnInicio.Focus();
            panelInicio.Visible = false;
            panelMenu.Visible = false;
            DesplegarInicio();
            OcultarSubMenu();
            segundos = 0;
            minutos = 0;
            horas = 0;
            timerSesion.Start();
            Saludo();
        }

        private void PrincipalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerSesion.Stop();
            Application.Exit();
        }

        private void TimerSesion_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos == 60)
            {
                minutos++;
                segundos = 0;
            }
            if (minutos == 60)
            {
                horas++;
                minutos = 0;
            }
            lblCronometroSesion.Text = (horas <= 9 ? "0" : "") + horas + " h : " + (minutos <= 9 ? "0" : "") + minutos + " m : " + (segundos <= 9 ? "0" : "") + segundos + " s";
        }

        private void TimerMensaje_Tick(object sender, EventArgs e)
        {
            pictureBoxBurbujaDialogo.Visible = false;
            lblSaludo.Visible = false;
            timerMensaje.Stop();
        }

        private void Saludo()
        {
            pictureBoxBurbujaDialogo.Visible = true;
            lblSaludo.Visible = true;

            if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour < 6)
            {
                lblSaludo.Text = "¡Buenas...Madrugando!";
            }
            else if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
            {
                lblSaludo.Text = "¡Buenos Dias!";
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
            {
                lblSaludo.Text = "¡Buenas Tardes!";
            }
            else
            {
                lblSaludo.Text = "¡Buenas Noches!";
            }

            timerMensaje.Start();
        }

        private void AbrirFormulario(Form formulario)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(formulario);
            panelEscritorio.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
        }

        private void DesplegarInicio()
        {
            btnCerrarSesion.Text = "       CERRAR SESIÓN";
            btnAyuda.Text = "  AYUDA";
            btnInformacion.Text = "          ACERCA DE";
            btnPlegar.Text = "       INICIO";
            btnUsuario.Text = "   USUARIO";
        }

        private void OcultarSubMenu()
        {
            panelSubMenuCampaña.Visible = false;
            panelSubMenuDonaciones.Visible = false;
            panelSubMenuCiudadanos.Visible = false;
            panelSubMenuSolicitudes.Visible = false;
            panelSubMenuBanco.Visible = false;
            panelSubMenuLaboratorio.Visible = false;
            panelSubMenuGeografia.Visible = false;
            panelSubMenuGeneral.Visible = false;       
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            if (panelInicio.Visible.Equals(false))
            {
                panelInicio.Visible = true;
                panelMenu.Visible = true;
            }
            else
            {
                panelInicio.Visible = false;
                panelMenu.Visible = false;
            }
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelMenu.Visible = false;
            btnInicio.Focus();
            FormCerrarSesion ventana = new FormCerrarSesion(logueado);
            ventana.ShowDialog();
        }

        private void BtnPlegar_Click(object sender, EventArgs e)
        {
            if (panelInicio.Width.Equals(55))
            {
                panelInicio.Width = 200;
            }
            else
            {
                panelInicio.Width = 55;
            }
        }

        private void BtnCerrarSesion_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 200;
        }

        private void panelInicio_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 200;
        }

        private void BtnAyuda_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 200;
        }

        private void BtnInformacion_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 200;
        }

        private void BtnUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 200;
        }

        private void BtnInicio_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void TxtBoxBuscar_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void PanelContenidoMenu_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnDonaciones_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnSolicitudes_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnCiudadanos_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnBanco_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnLaboratorio_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnGeografia_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnGeneral_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void PanelEscritorio_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelMenu.Visible = false;
        }

        private void BtnCampaña_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnCampaña_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuCampaña);
        }

        private void BtnDonaciones_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuDonaciones);
        }

        private void BtnSolicitudes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuSolicitudes);
        }

        private void BtnCiudadanos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuCiudadanos);
        }

        private void BtnBanco_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuBanco);
        }

        private void BtnLaboratorio_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuLaboratorio);
        }

        private void BtnGeografia_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuGeografia);
        }

        private void BtnGeneral_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuGeneral);
        }

        private void BtnABMCampaña_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnReporteCampaña_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnEstadisticaCampaña_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnDonacion_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnReporteDonacion_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnEstadisticaDonacion_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnSolicitud_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnReporteSolicitud_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnEstadisticaSolicitud_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnABMDonante_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnABMBeneficiario_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnReporteDonante_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnReporteBeneficiario_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnEstadisticaDonante_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnEstadisticaBeneficiario_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnABMEmpleado_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnABMSeccion_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnABMGerencia_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnABMPuesto_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnRepEstadBanco_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnABMGrupoSanguineo_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnABMFactor_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnABMTipoDonacion_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnEstadoDonacion_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnEstadoBeneficiario_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnDiagnostico_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnRepoEstadLaboratorio_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnBarrio_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnLocalidad_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnDepartamento_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnProvincia_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnSexo_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnTipoDocumento_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnTipoTelefono_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnUnidadMedida_MouseMove(object sender, MouseEventArgs e)
        {
            panelInicio.Width = 55;
        }

        private void BtnABMPuesto_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelMenu.Visible = false;
            AbrirFormulario(new FrmABMPuestos());
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelMenu.Visible = false;
            btnInicio.Focus();
            FormPerfilUsuario ventana = new FormPerfilUsuario(logueado);
            ventana.ShowDialog();
        }

        private void BtnInformacion_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelMenu.Visible = false;
            btnInicio.Focus();
            FormAcercaSistema ventana = new FormAcercaSistema();
            ventana.ShowDialog();
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelMenu.Visible = false;
            AbrirFormulario(new FormContenidoAyuda());
        }

        private void btnABMEmpleado_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelMenu.Visible = false;
            AbrirFormulario(new FrmABMEmpleados());
        }

        private void btnABMTipoDonacion_Click(object sender, EventArgs e)
        {
            FormABMTipoDonacion ventana = new FormABMTipoDonacion();
            ventana.ShowDialog();

        }

        private void btnABMGerencia_Click(object sender, EventArgs e)
        {
            FormABMGerencias ventana = new FormABMGerencias();
            ventana.ShowDialog();
        }
    }
}
