
namespace BancoDeSangreCórdoba.CapaPresentación.AMBTipoDonacion
{
    partial class FormBajaTipoDonacion
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
            this.txtNombreTipoDonacionBaja = new System.Windows.Forms.TextBox();
            this.lblNombreTipoDonacionEdit = new System.Windows.Forms.Label();
            this.btnCancelarEdit = new System.Windows.Forms.Button();
            this.btnAceptarEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreTipoDonacionBaja
            // 
            this.txtNombreTipoDonacionBaja.BackColor = System.Drawing.Color.Salmon;
            this.txtNombreTipoDonacionBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTipoDonacionBaja.Location = new System.Drawing.Point(250, 26);
            this.txtNombreTipoDonacionBaja.Name = "txtNombreTipoDonacionBaja";
            this.txtNombreTipoDonacionBaja.Size = new System.Drawing.Size(171, 26);
            this.txtNombreTipoDonacionBaja.TabIndex = 15;
            // 
            // lblNombreTipoDonacionEdit
            // 
            this.lblNombreTipoDonacionEdit.AutoSize = true;
            this.lblNombreTipoDonacionEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTipoDonacionEdit.Location = new System.Drawing.Point(24, 29);
            this.lblNombreTipoDonacionEdit.Name = "lblNombreTipoDonacionEdit";
            this.lblNombreTipoDonacionEdit.Size = new System.Drawing.Size(171, 20);
            this.lblNombreTipoDonacionEdit.TabIndex = 14;
            this.lblNombreTipoDonacionEdit.Text = "Nombre Tipo Donacion";
            // 
            // btnCancelarEdit
            // 
            this.btnCancelarEdit.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCancelarEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEdit.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarEdit.Location = new System.Drawing.Point(28, 179);
            this.btnCancelarEdit.Name = "btnCancelarEdit";
            this.btnCancelarEdit.Size = new System.Drawing.Size(85, 32);
            this.btnCancelarEdit.TabIndex = 11;
            this.btnCancelarEdit.Text = "Cancelar";
            this.btnCancelarEdit.UseVisualStyleBackColor = false;
            this.btnCancelarEdit.Click += new System.EventHandler(this.btnCancelarEdit_Click);
            // 
            // btnAceptarEdit
            // 
            this.btnAceptarEdit.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAceptarEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarEdit.ForeColor = System.Drawing.Color.Black;
            this.btnAceptarEdit.Location = new System.Drawing.Point(336, 179);
            this.btnAceptarEdit.Name = "btnAceptarEdit";
            this.btnAceptarEdit.Size = new System.Drawing.Size(85, 32);
            this.btnAceptarEdit.TabIndex = 10;
            this.btnAceptarEdit.Text = "Aceptar";
            this.btnAceptarEdit.UseVisualStyleBackColor = false;
            this.btnAceptarEdit.Click += new System.EventHandler(this.btnAceptarEdit_Click);
            // 
            // FormBajaTipoDonacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(464, 229);
            this.Controls.Add(this.txtNombreTipoDonacionBaja);
            this.Controls.Add(this.lblNombreTipoDonacionEdit);
            this.Controls.Add(this.btnCancelarEdit);
            this.Controls.Add(this.btnAceptarEdit);
            this.Name = "FormBajaTipoDonacion";
            this.Text = "Baja Tipo Donacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreTipoDonacionBaja;
        private System.Windows.Forms.Label lblNombreTipoDonacionEdit;
        private System.Windows.Forms.Button btnCancelarEdit;
        private System.Windows.Forms.Button btnAceptarEdit;
    }
}