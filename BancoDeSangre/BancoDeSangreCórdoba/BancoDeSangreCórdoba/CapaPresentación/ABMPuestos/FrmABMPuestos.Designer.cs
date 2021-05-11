
namespace BancoDeSangreCórdoba.CapaPresentación
{
    partial class FrmABMPuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMPuestos));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnConsultarPuestos = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.txtLetraPuesto = new System.Windows.Forms.TextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.tablaPuestos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picSalir = new System.Windows.Forms.PictureBox();
            this.picBorrar = new System.Windows.Forms.PictureBox();
            this.picModificar = new System.Windows.Forms.PictureBox();
            this.picAgregar = new System.Windows.Forms.PictureBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPuestos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).BeginInit();
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
            this.btnCerrar.Location = new System.Drawing.Point(1010, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(53, 53);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(135, 23);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "ABM PUESTOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnConsultarPuestos);
            this.groupBox1.Controls.Add(this.chkTodos);
            this.groupBox1.Controls.Add(this.txtLetraPuesto);
            this.groupBox1.Controls.Add(this.lblPuesto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(421, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 360);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(269, 105);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(135, 45);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnConsultarPuestos
            // 
            this.btnConsultarPuestos.Location = new System.Drawing.Point(269, 44);
            this.btnConsultarPuestos.Name = "btnConsultarPuestos";
            this.btnConsultarPuestos.Size = new System.Drawing.Size(135, 45);
            this.btnConsultarPuestos.TabIndex = 3;
            this.btnConsultarPuestos.Text = "Consultar";
            this.btnConsultarPuestos.UseVisualStyleBackColor = true;
            this.btnConsultarPuestos.Click += new System.EventHandler(this.btnConsultarPuestos_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(18, 105);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(131, 28);
            this.chkTodos.TabIndex = 2;
            this.chkTodos.Text = "Listar Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // txtLetraPuesto
            // 
            this.txtLetraPuesto.Location = new System.Drawing.Point(103, 44);
            this.txtLetraPuesto.Name = "txtLetraPuesto";
            this.txtLetraPuesto.Size = new System.Drawing.Size(100, 29);
            this.txtLetraPuesto.TabIndex = 1;
            this.txtLetraPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetraPuesto_KeyPress);
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(14, 49);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(73, 24);
            this.lblPuesto.TabIndex = 0;
            this.lblPuesto.Text = "Puesto:";
            // 
            // tablaPuestos
            // 
            this.tablaPuestos.AllowUserToAddRows = false;
            this.tablaPuestos.AllowUserToDeleteRows = false;
            this.tablaPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Puesto});
            this.tablaPuestos.Location = new System.Drawing.Point(34, 120);
            this.tablaPuestos.Name = "tablaPuestos";
            this.tablaPuestos.ReadOnly = true;
            this.tablaPuestos.Size = new System.Drawing.Size(292, 303);
            this.tablaPuestos.TabIndex = 8;
            this.tablaPuestos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPuestos_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 360);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado De Puestos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picSalir);
            this.groupBox3.Controls.Add(this.picBorrar);
            this.groupBox3.Controls.Add(this.picModificar);
            this.groupBox3.Controls.Add(this.picAgregar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 470);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(843, 74);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones ABM";
            // 
            // picSalir
            // 
            this.picSalir.Image = ((System.Drawing.Image)(resources.GetObject("picSalir.Image")));
            this.picSalir.Location = new System.Drawing.Point(752, 28);
            this.picSalir.Name = "picSalir";
            this.picSalir.Size = new System.Drawing.Size(55, 40);
            this.picSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSalir.TabIndex = 3;
            this.picSalir.TabStop = false;
            this.picSalir.Click += new System.EventHandler(this.picSalir_Click);
            // 
            // picBorrar
            // 
            this.picBorrar.Image = ((System.Drawing.Image)(resources.GetObject("picBorrar.Image")));
            this.picBorrar.Location = new System.Drawing.Point(172, 28);
            this.picBorrar.Name = "picBorrar";
            this.picBorrar.Size = new System.Drawing.Size(55, 40);
            this.picBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBorrar.TabIndex = 2;
            this.picBorrar.TabStop = false;
            this.picBorrar.Click += new System.EventHandler(this.picBorrar_Click);
            // 
            // picModificar
            // 
            this.picModificar.Image = ((System.Drawing.Image)(resources.GetObject("picModificar.Image")));
            this.picModificar.Location = new System.Drawing.Point(100, 28);
            this.picModificar.Name = "picModificar";
            this.picModificar.Size = new System.Drawing.Size(49, 40);
            this.picModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picModificar.TabIndex = 1;
            this.picModificar.TabStop = false;
            this.picModificar.Click += new System.EventHandler(this.picModificar_Click);
            // 
            // picAgregar
            // 
            this.picAgregar.Image = ((System.Drawing.Image)(resources.GetObject("picAgregar.Image")));
            this.picAgregar.Location = new System.Drawing.Point(30, 28);
            this.picAgregar.Name = "picAgregar";
            this.picAgregar.Size = new System.Drawing.Size(51, 40);
            this.picAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAgregar.TabIndex = 0;
            this.picAgregar.TabStop = false;
            this.picAgregar.Click += new System.EventHandler(this.picAgregar_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id_puesto";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Puesto
            // 
            this.Puesto.DataPropertyName = "letra";
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            this.Puesto.Width = 125;
            // 
            // FrmABMPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1064, 556);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tablaPuestos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmABMPuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPuestos";
            this.Load += new System.EventHandler(this.FrmABMPuestos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPuestos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tablaPuestos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConsultarPuestos;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picSalir;
        private System.Windows.Forms.PictureBox picBorrar;
        private System.Windows.Forms.PictureBox picModificar;
        private System.Windows.Forms.PictureBox picAgregar;
        private System.Windows.Forms.TextBox txtLetraPuesto;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
    }
}