
namespace BancoDeSangreCórdoba.CapaPresentación.AMBTipoDonacion
{
    partial class FormAltaTipoDonacion
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
            this.btnAceptarAlta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombreTipoDonacionAlta = new System.Windows.Forms.Label();
            this.txtNombreTipoDonacionAlta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptarAlta
            // 
            this.btnAceptarAlta.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAceptarAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarAlta.ForeColor = System.Drawing.Color.Black;
            this.btnAceptarAlta.Location = new System.Drawing.Point(309, 173);
            this.btnAceptarAlta.Name = "btnAceptarAlta";
            this.btnAceptarAlta.Size = new System.Drawing.Size(85, 32);
            this.btnAceptarAlta.TabIndex = 0;
            this.btnAceptarAlta.Text = "Aceptar";
            this.btnAceptarAlta.UseVisualStyleBackColor = false;
            this.btnAceptarAlta.Click += new System.EventHandler(this.btnAceptarAlta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(12, 173);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 32);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombreTipoDonacionAlta
            // 
            this.lblNombreTipoDonacionAlta.AutoSize = true;
            this.lblNombreTipoDonacionAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTipoDonacionAlta.Location = new System.Drawing.Point(12, 42);
            this.lblNombreTipoDonacionAlta.Name = "lblNombreTipoDonacionAlta";
            this.lblNombreTipoDonacionAlta.Size = new System.Drawing.Size(171, 20);
            this.lblNombreTipoDonacionAlta.TabIndex = 2;
            this.lblNombreTipoDonacionAlta.Text = "Nombre Tipo Donacion";
            // 
            // txtNombreTipoDonacionAlta
            // 
            this.txtNombreTipoDonacionAlta.BackColor = System.Drawing.Color.Salmon;
            this.txtNombreTipoDonacionAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTipoDonacionAlta.Location = new System.Drawing.Point(223, 41);
            this.txtNombreTipoDonacionAlta.Name = "txtNombreTipoDonacionAlta";
            this.txtNombreTipoDonacionAlta.Size = new System.Drawing.Size(171, 26);
            this.txtNombreTipoDonacionAlta.TabIndex = 3;
            // 
            // FormAltaTipoDonacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(406, 216);
            this.Controls.Add(this.txtNombreTipoDonacionAlta);
            this.Controls.Add(this.lblNombreTipoDonacionAlta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptarAlta);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "FormAltaTipoDonacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Tipo Donacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarAlta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombreTipoDonacionAlta;
        private System.Windows.Forms.TextBox txtNombreTipoDonacionAlta;
    }
}