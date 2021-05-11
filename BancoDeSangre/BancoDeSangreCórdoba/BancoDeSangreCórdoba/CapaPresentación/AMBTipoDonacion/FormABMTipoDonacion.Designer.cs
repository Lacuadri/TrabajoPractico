
namespace BancoDeSangreCórdoba.CapaPresentación.AMBTipoDonacion
{
    partial class FormABMTipoDonacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormABMTipoDonacion));
            this.gbOpcionesTipoDonacion = new System.Windows.Forms.GroupBox();
            this.imgQuit = new System.Windows.Forms.PictureBox();
            this.imgDelete = new System.Windows.Forms.PictureBox();
            this.imgAdd = new System.Windows.Forms.PictureBox();
            this.imgEdit = new System.Windows.Forms.PictureBox();
            this.lblABMTipoDonacion = new System.Windows.Forms.Label();
            this.dgTiposDonaciones = new System.Windows.Forms.DataGridView();
            this.id_tipoDonacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tipoDonacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbListadoTiposDonaciones = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizarTipoDonaciones = new System.Windows.Forms.Button();
            this.btnConsultarTipoDonacion = new System.Windows.Forms.Button();
            this.txtBusquedaTipoDonacion = new System.Windows.Forms.TextBox();
            this.lblTipoDonacionesBusqueda = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.gbOpcionesTipoDonacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTiposDonaciones)).BeginInit();
            this.gbListadoTiposDonaciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOpcionesTipoDonacion
            // 
            this.gbOpcionesTipoDonacion.Controls.Add(this.imgQuit);
            this.gbOpcionesTipoDonacion.Controls.Add(this.imgDelete);
            this.gbOpcionesTipoDonacion.Controls.Add(this.imgAdd);
            this.gbOpcionesTipoDonacion.Controls.Add(this.imgEdit);
            this.gbOpcionesTipoDonacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcionesTipoDonacion.Location = new System.Drawing.Point(27, 344);
            this.gbOpcionesTipoDonacion.Name = "gbOpcionesTipoDonacion";
            this.gbOpcionesTipoDonacion.Size = new System.Drawing.Size(745, 74);
            this.gbOpcionesTipoDonacion.TabIndex = 1;
            this.gbOpcionesTipoDonacion.TabStop = false;
            this.gbOpcionesTipoDonacion.Text = "Opciones ABM";
            // 
            // imgQuit
            // 
            this.imgQuit.Image = ((System.Drawing.Image)(resources.GetObject("imgQuit.Image")));
            this.imgQuit.Location = new System.Drawing.Point(698, 25);
            this.imgQuit.Name = "imgQuit";
            this.imgQuit.Size = new System.Drawing.Size(41, 38);
            this.imgQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgQuit.TabIndex = 4;
            this.imgQuit.TabStop = false;
            this.imgQuit.Click += new System.EventHandler(this.imgQuit_Click);
            // 
            // imgDelete
            // 
            this.imgDelete.Image = ((System.Drawing.Image)(resources.GetObject("imgDelete.Image")));
            this.imgDelete.Location = new System.Drawing.Point(281, 25);
            this.imgDelete.Name = "imgDelete";
            this.imgDelete.Size = new System.Drawing.Size(41, 38);
            this.imgDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgDelete.TabIndex = 2;
            this.imgDelete.TabStop = false;
            this.toolTip3.SetToolTip(this.imgDelete, "Elimine un tipo de donacion");
            this.imgDelete.Click += new System.EventHandler(this.imgDelete_Click);
            // 
            // imgAdd
            // 
            this.imgAdd.Image = ((System.Drawing.Image)(resources.GetObject("imgAdd.Image")));
            this.imgAdd.Location = new System.Drawing.Point(147, 25);
            this.imgAdd.Name = "imgAdd";
            this.imgAdd.Size = new System.Drawing.Size(41, 38);
            this.imgAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgAdd.TabIndex = 1;
            this.imgAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.imgAdd, "Inserte un nuevo tipo de donacion");
            this.imgAdd.Click += new System.EventHandler(this.imgAdd_Click);
            // 
            // imgEdit
            // 
            this.imgEdit.Image = ((System.Drawing.Image)(resources.GetObject("imgEdit.Image")));
            this.imgEdit.Location = new System.Drawing.Point(211, 25);
            this.imgEdit.Name = "imgEdit";
            this.imgEdit.Size = new System.Drawing.Size(41, 38);
            this.imgEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgEdit.TabIndex = 3;
            this.imgEdit.TabStop = false;
            this.toolTip2.SetToolTip(this.imgEdit, "Modifique los datos de un tipo de donacion");
            this.imgEdit.Click += new System.EventHandler(this.imgEdit_Click);
            // 
            // lblABMTipoDonacion
            // 
            this.lblABMTipoDonacion.AutoSize = true;
            this.lblABMTipoDonacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABMTipoDonacion.ForeColor = System.Drawing.Color.White;
            this.lblABMTipoDonacion.Location = new System.Drawing.Point(23, 21);
            this.lblABMTipoDonacion.Name = "lblABMTipoDonacion";
            this.lblABMTipoDonacion.Size = new System.Drawing.Size(205, 24);
            this.lblABMTipoDonacion.TabIndex = 2;
            this.lblABMTipoDonacion.Text = "AMB TIPO DONACION";
            // 
            // dgTiposDonaciones
            // 
            this.dgTiposDonaciones.AllowUserToAddRows = false;
            this.dgTiposDonaciones.AllowUserToDeleteRows = false;
            this.dgTiposDonaciones.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgTiposDonaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTiposDonaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tipoDonacion,
            this.nombre_tipoDonacion});
            this.dgTiposDonaciones.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgTiposDonaciones.Location = new System.Drawing.Point(6, 29);
            this.dgTiposDonaciones.Name = "dgTiposDonaciones";
            this.dgTiposDonaciones.ReadOnly = true;
            this.dgTiposDonaciones.Size = new System.Drawing.Size(226, 234);
            this.dgTiposDonaciones.TabIndex = 3;
            this.dgTiposDonaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTiposDonaciones_CellContentClick);
            // 
            // id_tipoDonacion
            // 
            this.id_tipoDonacion.DataPropertyName = "id_tipo_donacion";
            this.id_tipoDonacion.Frozen = true;
            this.id_tipoDonacion.HeaderText = "Id";
            this.id_tipoDonacion.Name = "id_tipoDonacion";
            this.id_tipoDonacion.ReadOnly = true;
            this.id_tipoDonacion.Width = 40;
            // 
            // nombre_tipoDonacion
            // 
            this.nombre_tipoDonacion.DataPropertyName = "nombre";
            this.nombre_tipoDonacion.Frozen = true;
            this.nombre_tipoDonacion.HeaderText = "Nombre";
            this.nombre_tipoDonacion.Name = "nombre_tipoDonacion";
            this.nombre_tipoDonacion.ReadOnly = true;
            this.nombre_tipoDonacion.Width = 150;
            // 
            // gbListadoTiposDonaciones
            // 
            this.gbListadoTiposDonaciones.Controls.Add(this.dgTiposDonaciones);
            this.gbListadoTiposDonaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListadoTiposDonaciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbListadoTiposDonaciones.Location = new System.Drawing.Point(27, 69);
            this.gbListadoTiposDonaciones.Name = "gbListadoTiposDonaciones";
            this.gbListadoTiposDonaciones.Size = new System.Drawing.Size(252, 269);
            this.gbListadoTiposDonaciones.TabIndex = 4;
            this.gbListadoTiposDonaciones.TabStop = false;
            this.gbListadoTiposDonaciones.Text = "  Listado Tipos Donaciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizarTipoDonaciones);
            this.groupBox1.Controls.Add(this.btnConsultarTipoDonacion);
            this.groupBox1.Controls.Add(this.txtBusquedaTipoDonacion);
            this.groupBox1.Controls.Add(this.lblTipoDonacionesBusqueda);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(346, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 269);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnActualizarTipoDonaciones
            // 
            this.btnActualizarTipoDonaciones.BackColor = System.Drawing.Color.RosyBrown;
            this.btnActualizarTipoDonaciones.Location = new System.Drawing.Point(291, 89);
            this.btnActualizarTipoDonaciones.Name = "btnActualizarTipoDonaciones";
            this.btnActualizarTipoDonaciones.Size = new System.Drawing.Size(91, 28);
            this.btnActualizarTipoDonaciones.TabIndex = 3;
            this.btnActualizarTipoDonaciones.Text = "Actualizar";
            this.btnActualizarTipoDonaciones.UseVisualStyleBackColor = false;
            this.btnActualizarTipoDonaciones.Click += new System.EventHandler(this.btnActualizarTipoDonaciones_Click);
            // 
            // btnConsultarTipoDonacion
            // 
            this.btnConsultarTipoDonacion.BackColor = System.Drawing.Color.RosyBrown;
            this.btnConsultarTipoDonacion.Location = new System.Drawing.Point(291, 36);
            this.btnConsultarTipoDonacion.Name = "btnConsultarTipoDonacion";
            this.btnConsultarTipoDonacion.Size = new System.Drawing.Size(91, 28);
            this.btnConsultarTipoDonacion.TabIndex = 2;
            this.btnConsultarTipoDonacion.Text = "Consultar";
            this.btnConsultarTipoDonacion.UseVisualStyleBackColor = false;
            this.btnConsultarTipoDonacion.Click += new System.EventHandler(this.btnConsultarTipoDonacion_Click);
            // 
            // txtBusquedaTipoDonacion
            // 
            this.txtBusquedaTipoDonacion.BackColor = System.Drawing.Color.Salmon;
            this.txtBusquedaTipoDonacion.Location = new System.Drawing.Point(156, 38);
            this.txtBusquedaTipoDonacion.Name = "txtBusquedaTipoDonacion";
            this.txtBusquedaTipoDonacion.Size = new System.Drawing.Size(100, 26);
            this.txtBusquedaTipoDonacion.TabIndex = 1;
            // 
            // lblTipoDonacionesBusqueda
            // 
            this.lblTipoDonacionesBusqueda.AutoSize = true;
            this.lblTipoDonacionesBusqueda.Location = new System.Drawing.Point(17, 39);
            this.lblTipoDonacionesBusqueda.Name = "lblTipoDonacionesBusqueda";
            this.lblTipoDonacionesBusqueda.Size = new System.Drawing.Size(111, 20);
            this.lblTipoDonacionesBusqueda.TabIndex = 0;
            this.lblTipoDonacionesBusqueda.Text = "Tipo Donacion";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.tootipAlta);
            // 
            // toolTip2
            // 
            this.toolTip2.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipModificacion);
            // 
            // toolTip3
            // 
            this.toolTip3.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipBaja);
            // 
            // FormABMTipoDonacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbListadoTiposDonaciones);
            this.Controls.Add(this.lblABMTipoDonacion);
            this.Controls.Add(this.gbOpcionesTipoDonacion);
            this.Name = "FormABMTipoDonacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMTipoDonacion";
            this.Load += new System.EventHandler(this.FormABMTipoDonacion_Load);
            this.gbOpcionesTipoDonacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTiposDonaciones)).EndInit();
            this.gbListadoTiposDonaciones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpcionesTipoDonacion;
        private System.Windows.Forms.PictureBox imgQuit;
        private System.Windows.Forms.PictureBox imgDelete;
        private System.Windows.Forms.PictureBox imgAdd;
        private System.Windows.Forms.PictureBox imgEdit;
        private System.Windows.Forms.Label lblABMTipoDonacion;
        private System.Windows.Forms.DataGridView dgTiposDonaciones;
        private System.Windows.Forms.GroupBox gbListadoTiposDonaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipoDonacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tipoDonacion;
        private System.Windows.Forms.Button btnConsultarTipoDonacion;
        private System.Windows.Forms.TextBox txtBusquedaTipoDonacion;
        private System.Windows.Forms.Label lblTipoDonacionesBusqueda;
        private System.Windows.Forms.Button btnActualizarTipoDonaciones;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}