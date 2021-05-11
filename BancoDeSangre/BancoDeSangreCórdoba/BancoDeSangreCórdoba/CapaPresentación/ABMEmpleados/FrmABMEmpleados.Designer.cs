
namespace BancoDeSangreCórdoba.CapaPresentación.ABMEmpleados
{
    partial class FrmABMEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMEmpleados));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picBorrar = new System.Windows.Forms.PictureBox();
            this.picModificar = new System.Windows.Forms.PictureBox();
            this.picAgregar = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1011, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(53, 53);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(69, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(166, 23);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "ABM EMPLEADOS";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.picBorrar);
            this.groupBox3.Controls.Add(this.picModificar);
            this.groupBox3.Controls.Add(this.picAgregar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(97, 421);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 84);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones ABM";
            // 
            // picBorrar
            // 
            this.picBorrar.Image = ((System.Drawing.Image)(resources.GetObject("picBorrar.Image")));
            this.picBorrar.Location = new System.Drawing.Point(300, 28);
            this.picBorrar.Name = "picBorrar";
            this.picBorrar.Size = new System.Drawing.Size(55, 40);
            this.picBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBorrar.TabIndex = 2;
            this.picBorrar.TabStop = false;
            this.picBorrar.Click += new System.EventHandler(this.PicBorrar_Click);
            // 
            // picModificar
            // 
            this.picModificar.Image = ((System.Drawing.Image)(resources.GetObject("picModificar.Image")));
            this.picModificar.Location = new System.Drawing.Point(228, 28);
            this.picModificar.Name = "picModificar";
            this.picModificar.Size = new System.Drawing.Size(49, 40);
            this.picModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picModificar.TabIndex = 1;
            this.picModificar.TabStop = false;
            this.picModificar.Click += new System.EventHandler(this.PicModificar_Click);
            // 
            // picAgregar
            // 
            this.picAgregar.Image = ((System.Drawing.Image)(resources.GetObject("picAgregar.Image")));
            this.picAgregar.Location = new System.Drawing.Point(159, 28);
            this.picAgregar.Name = "picAgregar";
            this.picAgregar.Size = new System.Drawing.Size(51, 40);
            this.picAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAgregar.TabIndex = 0;
            this.picAgregar.TabStop = false;
            this.picAgregar.Click += new System.EventHandler(this.PicAgregar_Click);
            // 
            // FrmABMEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1064, 556);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmABMEmpleados";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEmpleado";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picBorrar;
        private System.Windows.Forms.PictureBox picModificar;
        private System.Windows.Forms.PictureBox picAgregar;
    }
}