
namespace BancoDeSangreCórdoba.CapaPresentación
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.maskedTxtLegajo = new System.Windows.Forms.MaskedTextBox();
            this.lblOlvidarDatos = new System.Windows.Forms.Label();
            this.linkLblClickAqui = new System.Windows.Forms.LinkLabel();
            this.lblRegistrar = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtRepetirPassword = new System.Windows.Forms.TextBox();
            this.lblRepetirPassword = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.linkLblRegistrar = new System.Windows.Forms.LinkLabel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.timerMensaje = new System.Windows.Forms.Timer(this.components);
            this.timerCargaVentana = new System.Windows.Forms.Timer(this.components);
            this.lblSaludo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresar.BackColor = System.Drawing.Color.Firebrick;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(273, 265);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(369, 35);
            this.btnIngresar.TabIndex = 79;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Visible = false;
            this.btnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.Firebrick;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(273, 265);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(369, 35);
            this.btnBuscar.TabIndex = 78;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.ForeColor = System.Drawing.Color.Salmon;
            this.lblLegajo.Location = new System.Drawing.Point(418, 71);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(94, 25);
            this.lblLegajo.TabIndex = 77;
            this.lblLegajo.Text = "LEGAJO";
            this.lblLegajo.Visible = false;
            // 
            // maskedTxtLegajo
            // 
            this.maskedTxtLegajo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTxtLegajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.maskedTxtLegajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTxtLegajo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxtLegajo.ForeColor = System.Drawing.Color.White;
            this.maskedTxtLegajo.Location = new System.Drawing.Point(518, 71);
            this.maskedTxtLegajo.Mask = "99999";
            this.maskedTxtLegajo.Name = "maskedTxtLegajo";
            this.maskedTxtLegajo.Size = new System.Drawing.Size(120, 27);
            this.maskedTxtLegajo.TabIndex = 69;
            this.maskedTxtLegajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTxtLegajo.ValidatingType = typeof(int);
            this.maskedTxtLegajo.Visible = false;
            // 
            // lblOlvidarDatos
            // 
            this.lblOlvidarDatos.AutoSize = true;
            this.lblOlvidarDatos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvidarDatos.ForeColor = System.Drawing.Color.White;
            this.lblOlvidarDatos.Location = new System.Drawing.Point(445, 325);
            this.lblOlvidarDatos.Name = "lblOlvidarDatos";
            this.lblOlvidarDatos.Size = new System.Drawing.Size(121, 16);
            this.lblOlvidarDatos.TabIndex = 75;
            this.lblOlvidarDatos.Text = "Olvidé mis datos:";
            // 
            // linkLblClickAqui
            // 
            this.linkLblClickAqui.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(144)))), ((int)(((byte)(44)))));
            this.linkLblClickAqui.AutoSize = true;
            this.linkLblClickAqui.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblClickAqui.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLblClickAqui.Location = new System.Drawing.Point(568, 320);
            this.linkLblClickAqui.Name = "linkLblClickAqui";
            this.linkLblClickAqui.Size = new System.Drawing.Size(86, 21);
            this.linkLblClickAqui.TabIndex = 60;
            this.linkLblClickAqui.TabStop = true;
            this.linkLblClickAqui.Text = "Click aquí";
            this.linkLblClickAqui.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblClickAqui_LinkClicked);
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.AutoSize = true;
            this.lblRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrar.ForeColor = System.Drawing.Color.White;
            this.lblRegistrar.Location = new System.Drawing.Point(256, 324);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(78, 16);
            this.lblRegistrar.TabIndex = 74;
            this.lblRegistrar.Text = "Soy nuevo:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.BackColor = System.Drawing.Color.Firebrick;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(273, 265);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(369, 35);
            this.btnRegistrar.TabIndex = 73;
            this.btnRegistrar.Text = "REGISTRARME";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Visible = false;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // txtRepetirPassword
            // 
            this.txtRepetirPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.txtRepetirPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRepetirPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepetirPassword.ForeColor = System.Drawing.Color.White;
            this.txtRepetirPassword.Location = new System.Drawing.Point(423, 186);
            this.txtRepetirPassword.Name = "txtRepetirPassword";
            this.txtRepetirPassword.Size = new System.Drawing.Size(217, 27);
            this.txtRepetirPassword.TabIndex = 72;
            this.txtRepetirPassword.UseSystemPasswordChar = true;
            this.txtRepetirPassword.Visible = false;
            // 
            // lblRepetirPassword
            // 
            this.lblRepetirPassword.AutoSize = true;
            this.lblRepetirPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetirPassword.ForeColor = System.Drawing.Color.Salmon;
            this.lblRepetirPassword.Location = new System.Drawing.Point(270, 189);
            this.lblRepetirPassword.Name = "lblRepetirPassword";
            this.lblRepetirPassword.Size = new System.Drawing.Size(139, 19);
            this.lblRepetirPassword.TabIndex = 71;
            this.lblRepetirPassword.Text = "Repetir password";
            this.lblRepetirPassword.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar.Enabled = false;
            this.progressBar.Location = new System.Drawing.Point(273, 265);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(369, 35);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 61;
            this.progressBar.Visible = false;
            // 
            // linkLblRegistrar
            // 
            this.linkLblRegistrar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(144)))), ((int)(((byte)(44)))));
            this.linkLblRegistrar.AutoSize = true;
            this.linkLblRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblRegistrar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLblRegistrar.Location = new System.Drawing.Point(336, 321);
            this.linkLblRegistrar.Name = "linkLblRegistrar";
            this.linkLblRegistrar.Size = new System.Drawing.Size(103, 21);
            this.linkLblRegistrar.TabIndex = 59;
            this.linkLblRegistrar.TabStop = true;
            this.linkLblRegistrar.Text = "Registrarme";
            this.linkLblRegistrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblRegistrar_LinkClicked);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.DarkGray;
            this.lblMensaje.Location = new System.Drawing.Point(270, 234);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(170, 19);
            this.lblMensaje.TabIndex = 58;
            this.lblMensaje.Text = "Mensajes del sistema";
            this.lblMensaje.Visible = false;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.Firebrick;
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.Location = new System.Drawing.Point(273, 265);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(369, 35);
            this.btnAcceder.TabIndex = 57;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.BtnAcceder_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(423, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(217, 31);
            this.txtPassword.TabIndex = 55;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(423, 107);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(217, 31);
            this.txtUsuario.TabIndex = 54;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Salmon;
            this.lblPassword.Location = new System.Drawing.Point(268, 149);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(140, 28);
            this.lblPassword.TabIndex = 56;
            this.lblPassword.Text = "PASSWORD";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Salmon;
            this.lblUsuario.Location = new System.Drawing.Point(267, 106);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(132, 32);
            this.lblUsuario.TabIndex = 53;
            this.lblUsuario.Text = "USUARIO";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BancoDeSangreCórdoba.Properties.Resources.Hemoglobin;
            this.pictureBoxLogo.Location = new System.Drawing.Point(13, 79);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(200, 193);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 80;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(59, 275);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(97, 36);
            this.lblHora.TabIndex = 81;
            this.lblHora.Text = "HORA";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(49, 325);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 15);
            this.lblFecha.TabIndex = 82;
            this.lblFecha.Text = "FECHA";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Salmon;
            this.lblTitulo.Location = new System.Drawing.Point(265, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(384, 44);
            this.lblTitulo.TabIndex = 83;
            this.lblTitulo.Text = "INGRESO AL SISTEMA";
            // 
            // timerDate
            // 
            this.timerDate.Enabled = true;
            this.timerDate.Tick += new System.EventHandler(this.TimerDate_Tick);
            // 
            // timerMensaje
            // 
            this.timerMensaje.Enabled = true;
            this.timerMensaje.Interval = 3000;
            this.timerMensaje.Tick += new System.EventHandler(this.TimerMensaje_Tick);
            // 
            // timerCargaVentana
            // 
            this.timerCargaVentana.Interval = 40;
            this.timerCargaVentana.Tick += new System.EventHandler(this.TimerCargaVentana_Tick);
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.ForeColor = System.Drawing.Color.Salmon;
            this.lblSaludo.Location = new System.Drawing.Point(111, 15);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(130, 44);
            this.lblSaludo.TabIndex = 84;
            this.lblSaludo.Text = "           ";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.maskedTxtLegajo);
            this.Controls.Add(this.lblOlvidarDatos);
            this.Controls.Add(this.linkLblClickAqui);
            this.Controls.Add(this.lblRegistrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtRepetirPassword);
            this.Controls.Add(this.lblRepetirPassword);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.linkLblRegistrar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblSaludo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BANCO DE SANGRE CÓRDOBA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.MaskedTextBox maskedTxtLegajo;
        private System.Windows.Forms.Label lblOlvidarDatos;
        private System.Windows.Forms.LinkLabel linkLblClickAqui;
        private System.Windows.Forms.Label lblRegistrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtRepetirPassword;
        private System.Windows.Forms.Label lblRepetirPassword;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.LinkLabel linkLblRegistrar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.Timer timerMensaje;
        private System.Windows.Forms.Timer timerCargaVentana;
        private System.Windows.Forms.Label lblSaludo;
    }
}