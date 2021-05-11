
namespace BancoDeSangreCórdoba.CapaPresentación
{
    partial class FormCerrarSesion
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnSI = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.timerCerrarSesion = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxPregunta = new System.Windows.Forms.PictureBox();
            this.pictureBoxSalida = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPregunta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(250, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 32);
            this.label3.TabIndex = 64;
            this.label3.Text = "Banco de sangre Córdoba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(296, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 23);
            this.label2.TabIndex = 63;
            this.label2.Text = "PROYECTO PAV 1 - 3k7 - 2021";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(218, 123);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(428, 46);
            this.lblUsuario.TabIndex = 62;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar.Enabled = false;
            this.progressBar.Location = new System.Drawing.Point(236, 284);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(395, 35);
            this.progressBar.TabIndex = 61;
            this.progressBar.Value = 100;
            this.progressBar.Visible = false;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Firebrick;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(463, 284);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(168, 35);
            this.btnNo.TabIndex = 60;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // btnSI
            // 
            this.btnSI.BackColor = System.Drawing.Color.Firebrick;
            this.btnSI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSI.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnSI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btnSI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSI.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSI.ForeColor = System.Drawing.Color.White;
            this.btnSI.Location = new System.Drawing.Point(236, 284);
            this.btnSI.Name = "btnSI";
            this.btnSI.Size = new System.Drawing.Size(176, 35);
            this.btnSI.TabIndex = 59;
            this.btnSI.Text = "SI";
            this.btnSI.UseVisualStyleBackColor = false;
            this.btnSI.Click += new System.EventHandler(this.BtnSI_Click);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Salmon;
            this.label.Location = new System.Drawing.Point(218, 198);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(428, 51);
            this.label.TabIndex = 58;
            this.label.Text = "¿Quiere cerrar la sesión?";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerCerrarSesion
            // 
            this.timerCerrarSesion.Interval = 20;
            this.timerCerrarSesion.Tick += new System.EventHandler(this.TimerCerrarSesion_Tick);
            // 
            // pictureBoxPregunta
            // 
            this.pictureBoxPregunta.Image = global::BancoDeSangreCórdoba.Properties.Resources.Ayuda_164x164_;
            this.pictureBoxPregunta.Location = new System.Drawing.Point(62, 71);
            this.pictureBoxPregunta.Name = "pictureBoxPregunta";
            this.pictureBoxPregunta.Size = new System.Drawing.Size(164, 164);
            this.pictureBoxPregunta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPregunta.TabIndex = 65;
            this.pictureBoxPregunta.TabStop = false;
            // 
            // pictureBoxSalida
            // 
            this.pictureBoxSalida.Image = global::BancoDeSangreCórdoba.Properties.Resources.CerrarSesion_164x164_;
            this.pictureBoxSalida.Location = new System.Drawing.Point(62, 71);
            this.pictureBoxSalida.Name = "pictureBoxSalida";
            this.pictureBoxSalida.Size = new System.Drawing.Size(164, 164);
            this.pictureBoxSalida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSalida.TabIndex = 66;
            this.pictureBoxSalida.TabStop = false;
            // 
            // FormCerrarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.pictureBoxPregunta);
            this.Controls.Add(this.pictureBoxSalida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSI);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCerrarSesion";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CERRAR SESIÓN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPregunta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnSI;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer timerCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBoxPregunta;
        private System.Windows.Forms.PictureBox pictureBoxSalida;
    }
}