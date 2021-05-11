
namespace BancoDeSangreCórdoba.CapaPresentación.ABMGerencias
{
    partial class FormABMGerencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormABMGerencias));
            this.dgGerencias = new System.Windows.Forms.DataGridView();
            this.id_gerencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreGerencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo_supervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbGerencias = new System.Windows.Forms.GroupBox();
            this.gbOpcionesGerencias = new System.Windows.Forms.GroupBox();
            this.imgQuit = new System.Windows.Forms.PictureBox();
            this.imgDelete = new System.Windows.Forms.PictureBox();
            this.imgAdd = new System.Windows.Forms.PictureBox();
            this.imgEdit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgGerencias)).BeginInit();
            this.gbGerencias.SuspendLayout();
            this.gbOpcionesGerencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgGerencias
            // 
            this.dgGerencias.AllowUserToAddRows = false;
            this.dgGerencias.AllowUserToDeleteRows = false;
            this.dgGerencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGerencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_gerencia,
            this.nombreGerencia,
            this.id_direccion,
            this.legajo_supervisor});
            this.dgGerencias.Location = new System.Drawing.Point(6, 28);
            this.dgGerencias.Name = "dgGerencias";
            this.dgGerencias.ReadOnly = true;
            this.dgGerencias.Size = new System.Drawing.Size(444, 317);
            this.dgGerencias.TabIndex = 0;
            this.dgGerencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGerencias_CellClick);
            this.dgGerencias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGerencias_CellContentClick);
            // 
            // id_gerencia
            // 
            this.id_gerencia.DataPropertyName = "id_gerencia";
            this.id_gerencia.HeaderText = "Id";
            this.id_gerencia.Name = "id_gerencia";
            this.id_gerencia.ReadOnly = true;
            // 
            // nombreGerencia
            // 
            this.nombreGerencia.DataPropertyName = "nombre";
            this.nombreGerencia.HeaderText = "Nombre";
            this.nombreGerencia.Name = "nombreGerencia";
            this.nombreGerencia.ReadOnly = true;
            // 
            // id_direccion
            // 
            this.id_direccion.DataPropertyName = "id_direccion";
            this.id_direccion.HeaderText = "Direccion";
            this.id_direccion.Name = "id_direccion";
            this.id_direccion.ReadOnly = true;
            // 
            // legajo_supervisor
            // 
            this.legajo_supervisor.DataPropertyName = "legajo_supervisor";
            this.legajo_supervisor.HeaderText = "Legajo Supervisor";
            this.legajo_supervisor.Name = "legajo_supervisor";
            this.legajo_supervisor.ReadOnly = true;
            // 
            // gbGerencias
            // 
            this.gbGerencias.Controls.Add(this.dgGerencias);
            this.gbGerencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGerencias.Location = new System.Drawing.Point(27, 27);
            this.gbGerencias.Name = "gbGerencias";
            this.gbGerencias.Size = new System.Drawing.Size(482, 363);
            this.gbGerencias.TabIndex = 1;
            this.gbGerencias.TabStop = false;
            this.gbGerencias.Text = "ABM Gerencias";
            // 
            // gbOpcionesGerencias
            // 
            this.gbOpcionesGerencias.Controls.Add(this.imgQuit);
            this.gbOpcionesGerencias.Controls.Add(this.imgDelete);
            this.gbOpcionesGerencias.Controls.Add(this.imgAdd);
            this.gbOpcionesGerencias.Controls.Add(this.imgEdit);
            this.gbOpcionesGerencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcionesGerencias.Location = new System.Drawing.Point(12, 396);
            this.gbOpcionesGerencias.Name = "gbOpcionesGerencias";
            this.gbOpcionesGerencias.Size = new System.Drawing.Size(745, 74);
            this.gbOpcionesGerencias.TabIndex = 2;
            this.gbOpcionesGerencias.TabStop = false;
            this.gbOpcionesGerencias.Text = "Opciones ABM";
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
            this.imgEdit.Click += new System.EventHandler(this.imgEdit_Click);
            // 
            // FormABMGerencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(770, 477);
            this.Controls.Add(this.gbOpcionesGerencias);
            this.Controls.Add(this.gbGerencias);
            this.Name = "FormABMGerencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Gerencias";
            this.Load += new System.EventHandler(this.ABMGerencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGerencias)).EndInit();
            this.gbGerencias.ResumeLayout(false);
            this.gbOpcionesGerencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgGerencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_gerencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreGerencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo_supervisor;
        private System.Windows.Forms.GroupBox gbGerencias;
        private System.Windows.Forms.GroupBox gbOpcionesGerencias;
        private System.Windows.Forms.PictureBox imgQuit;
        private System.Windows.Forms.PictureBox imgDelete;
        private System.Windows.Forms.PictureBox imgAdd;
        private System.Windows.Forms.PictureBox imgEdit;
    }
}