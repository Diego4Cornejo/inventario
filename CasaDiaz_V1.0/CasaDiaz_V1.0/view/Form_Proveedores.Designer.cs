namespace CasaDiaz_V1._0.view
{
    partial class Form_Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Proveedores));
            this.GB_PROVEEDORES_OPCIONES = new System.Windows.Forms.GroupBox();
            this.BTN_REVISAR_PROVEEDOR = new System.Windows.Forms.Button();
            this.BTN_ELIMINAR_PROVEEDOR = new System.Windows.Forms.Button();
            this.BTN_MODIFICAR_PROVEEDOR = new System.Windows.Forms.Button();
            this.BTN_NUEVO_PROVEEDOR = new System.Windows.Forms.Button();
            this.GB_PROVEEDORES_TABLA = new System.Windows.Forms.GroupBox();
            this.DGV_PROVEEDORES = new System.Windows.Forms.DataGridView();
            this.PRO_PROVEEDORES_RUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PROVEEDORES_RAZONSOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PROVEEDORES_GIRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PROVEEDORES_TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PROVEEDORES_MOVIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GB_BUSCADOR_PROVEEDOR = new System.Windows.Forms.GroupBox();
            this.BTN_PROVEEDOR_LIMPIAR = new System.Windows.Forms.Button();
            this.BTN_PROVEEDOR_BUSCAR = new System.Windows.Forms.Button();
            this.TXT_PROVEEDOR_BUSCAR = new System.Windows.Forms.TextBox();
            this.RB = new System.Windows.Forms.RadioButton();
            this.RB_PROVEEDOR_NOMBRE = new System.Windows.Forms.RadioButton();
            this.RB_PROVEEDOR_CODIGO = new System.Windows.Forms.RadioButton();
            this.RB_PROVEEDOR_TODOS = new System.Windows.Forms.RadioButton();
            this.LBL_PROVEEDORES_PROVEEDORES = new System.Windows.Forms.Label();
            this.PIC_BOX_PROVEEDORES = new System.Windows.Forms.PictureBox();
            this.GB_PROVEEDORES_OPCIONES.SuspendLayout();
            this.GB_PROVEEDORES_TABLA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PROVEEDORES)).BeginInit();
            this.GB_BUSCADOR_PROVEEDOR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_BOX_PROVEEDORES)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_PROVEEDORES_OPCIONES
            // 
            this.GB_PROVEEDORES_OPCIONES.Controls.Add(this.BTN_REVISAR_PROVEEDOR);
            this.GB_PROVEEDORES_OPCIONES.Controls.Add(this.BTN_ELIMINAR_PROVEEDOR);
            this.GB_PROVEEDORES_OPCIONES.Controls.Add(this.BTN_MODIFICAR_PROVEEDOR);
            this.GB_PROVEEDORES_OPCIONES.Controls.Add(this.BTN_NUEVO_PROVEEDOR);
            this.GB_PROVEEDORES_OPCIONES.Location = new System.Drawing.Point(17, 548);
            this.GB_PROVEEDORES_OPCIONES.Name = "GB_PROVEEDORES_OPCIONES";
            this.GB_PROVEEDORES_OPCIONES.Size = new System.Drawing.Size(791, 128);
            this.GB_PROVEEDORES_OPCIONES.TabIndex = 13;
            this.GB_PROVEEDORES_OPCIONES.TabStop = false;
            this.GB_PROVEEDORES_OPCIONES.Text = "Opciones";
            // 
            // BTN_REVISAR_PROVEEDOR
            // 
            this.BTN_REVISAR_PROVEEDOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_REVISAR_PROVEEDOR.Image = ((System.Drawing.Image)(resources.GetObject("BTN_REVISAR_PROVEEDOR.Image")));
            this.BTN_REVISAR_PROVEEDOR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_REVISAR_PROVEEDOR.Location = new System.Drawing.Point(642, 19);
            this.BTN_REVISAR_PROVEEDOR.Name = "BTN_REVISAR_PROVEEDOR";
            this.BTN_REVISAR_PROVEEDOR.Size = new System.Drawing.Size(100, 92);
            this.BTN_REVISAR_PROVEEDOR.TabIndex = 3;
            this.BTN_REVISAR_PROVEEDOR.Text = "Revisar";
            this.BTN_REVISAR_PROVEEDOR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_REVISAR_PROVEEDOR.UseVisualStyleBackColor = true;
            this.BTN_REVISAR_PROVEEDOR.Click += new System.EventHandler(this.BTN_REVISAR_PROVEEDOR_Click);
            // 
            // BTN_ELIMINAR_PROVEEDOR
            // 
            this.BTN_ELIMINAR_PROVEEDOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ELIMINAR_PROVEEDOR.Image = ((System.Drawing.Image)(resources.GetObject("BTN_ELIMINAR_PROVEEDOR.Image")));
            this.BTN_ELIMINAR_PROVEEDOR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_ELIMINAR_PROVEEDOR.Location = new System.Drawing.Point(440, 19);
            this.BTN_ELIMINAR_PROVEEDOR.Name = "BTN_ELIMINAR_PROVEEDOR";
            this.BTN_ELIMINAR_PROVEEDOR.Size = new System.Drawing.Size(100, 92);
            this.BTN_ELIMINAR_PROVEEDOR.TabIndex = 2;
            this.BTN_ELIMINAR_PROVEEDOR.Text = "Eliminar";
            this.BTN_ELIMINAR_PROVEEDOR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_ELIMINAR_PROVEEDOR.UseVisualStyleBackColor = true;
            this.BTN_ELIMINAR_PROVEEDOR.Click += new System.EventHandler(this.BTN_ELIMINAR_PROVEEDOR_Click);
            // 
            // BTN_MODIFICAR_PROVEEDOR
            // 
            this.BTN_MODIFICAR_PROVEEDOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_MODIFICAR_PROVEEDOR.Image = ((System.Drawing.Image)(resources.GetObject("BTN_MODIFICAR_PROVEEDOR.Image")));
            this.BTN_MODIFICAR_PROVEEDOR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_MODIFICAR_PROVEEDOR.Location = new System.Drawing.Point(237, 19);
            this.BTN_MODIFICAR_PROVEEDOR.Name = "BTN_MODIFICAR_PROVEEDOR";
            this.BTN_MODIFICAR_PROVEEDOR.Size = new System.Drawing.Size(100, 92);
            this.BTN_MODIFICAR_PROVEEDOR.TabIndex = 1;
            this.BTN_MODIFICAR_PROVEEDOR.Text = "Actualizar";
            this.BTN_MODIFICAR_PROVEEDOR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_MODIFICAR_PROVEEDOR.UseVisualStyleBackColor = true;
            this.BTN_MODIFICAR_PROVEEDOR.Click += new System.EventHandler(this.BTN_MODIFICAR_PROVEEDOR_Click);
            // 
            // BTN_NUEVO_PROVEEDOR
            // 
            this.BTN_NUEVO_PROVEEDOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NUEVO_PROVEEDOR.Image = ((System.Drawing.Image)(resources.GetObject("BTN_NUEVO_PROVEEDOR.Image")));
            this.BTN_NUEVO_PROVEEDOR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_NUEVO_PROVEEDOR.Location = new System.Drawing.Point(46, 19);
            this.BTN_NUEVO_PROVEEDOR.Name = "BTN_NUEVO_PROVEEDOR";
            this.BTN_NUEVO_PROVEEDOR.Size = new System.Drawing.Size(100, 92);
            this.BTN_NUEVO_PROVEEDOR.TabIndex = 0;
            this.BTN_NUEVO_PROVEEDOR.Text = "Nuevo";
            this.BTN_NUEVO_PROVEEDOR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_NUEVO_PROVEEDOR.UseVisualStyleBackColor = true;
            this.BTN_NUEVO_PROVEEDOR.Click += new System.EventHandler(this.BTN_NUEVO_PROVEEDOR_Click);
            // 
            // GB_PROVEEDORES_TABLA
            // 
            this.GB_PROVEEDORES_TABLA.Controls.Add(this.DGV_PROVEEDORES);
            this.GB_PROVEEDORES_TABLA.Location = new System.Drawing.Point(17, 150);
            this.GB_PROVEEDORES_TABLA.Name = "GB_PROVEEDORES_TABLA";
            this.GB_PROVEEDORES_TABLA.Size = new System.Drawing.Size(791, 392);
            this.GB_PROVEEDORES_TABLA.TabIndex = 12;
            this.GB_PROVEEDORES_TABLA.TabStop = false;
            this.GB_PROVEEDORES_TABLA.Text = "Tabla";
            // 
            // DGV_PROVEEDORES
            // 
            this.DGV_PROVEEDORES.AllowUserToAddRows = false;
            this.DGV_PROVEEDORES.AllowUserToDeleteRows = false;
            this.DGV_PROVEEDORES.AllowUserToResizeColumns = false;
            this.DGV_PROVEEDORES.AllowUserToResizeRows = false;
            this.DGV_PROVEEDORES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_PROVEEDORES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PROVEEDORES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRO_PROVEEDORES_RUT,
            this.PRO_PROVEEDORES_RAZONSOCIAL,
            this.PRO_PROVEEDORES_GIRO,
            this.PRO_PROVEEDORES_TELEFONO,
            this.PRO_PROVEEDORES_MOVIL});
            this.DGV_PROVEEDORES.Location = new System.Drawing.Point(6, 19);
            this.DGV_PROVEEDORES.Name = "DGV_PROVEEDORES";
            this.DGV_PROVEEDORES.ReadOnly = true;
            this.DGV_PROVEEDORES.Size = new System.Drawing.Size(779, 359);
            this.DGV_PROVEEDORES.TabIndex = 0;
            this.DGV_PROVEEDORES.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PROVEEDORES_CellClick);
            // 
            // PRO_PROVEEDORES_RUT
            // 
            this.PRO_PROVEEDORES_RUT.HeaderText = "Rut";
            this.PRO_PROVEEDORES_RUT.Name = "PRO_PROVEEDORES_RUT";
            this.PRO_PROVEEDORES_RUT.ReadOnly = true;
            this.PRO_PROVEEDORES_RUT.Width = 115;
            // 
            // PRO_PROVEEDORES_RAZONSOCIAL
            // 
            this.PRO_PROVEEDORES_RAZONSOCIAL.HeaderText = "Razón Social";
            this.PRO_PROVEEDORES_RAZONSOCIAL.Name = "PRO_PROVEEDORES_RAZONSOCIAL";
            this.PRO_PROVEEDORES_RAZONSOCIAL.ReadOnly = true;
            this.PRO_PROVEEDORES_RAZONSOCIAL.Width = 180;
            // 
            // PRO_PROVEEDORES_GIRO
            // 
            this.PRO_PROVEEDORES_GIRO.HeaderText = "Giro";
            this.PRO_PROVEEDORES_GIRO.Name = "PRO_PROVEEDORES_GIRO";
            this.PRO_PROVEEDORES_GIRO.ReadOnly = true;
            this.PRO_PROVEEDORES_GIRO.Width = 200;
            // 
            // PRO_PROVEEDORES_TELEFONO
            // 
            this.PRO_PROVEEDORES_TELEFONO.HeaderText = "Telefono";
            this.PRO_PROVEEDORES_TELEFONO.Name = "PRO_PROVEEDORES_TELEFONO";
            this.PRO_PROVEEDORES_TELEFONO.ReadOnly = true;
            this.PRO_PROVEEDORES_TELEFONO.Width = 120;
            // 
            // PRO_PROVEEDORES_MOVIL
            // 
            this.PRO_PROVEEDORES_MOVIL.HeaderText = "Movil";
            this.PRO_PROVEEDORES_MOVIL.Name = "PRO_PROVEEDORES_MOVIL";
            this.PRO_PROVEEDORES_MOVIL.ReadOnly = true;
            this.PRO_PROVEEDORES_MOVIL.Width = 120;
            // 
            // GB_BUSCADOR_PROVEEDOR
            // 
            this.GB_BUSCADOR_PROVEEDOR.Controls.Add(this.BTN_PROVEEDOR_LIMPIAR);
            this.GB_BUSCADOR_PROVEEDOR.Controls.Add(this.BTN_PROVEEDOR_BUSCAR);
            this.GB_BUSCADOR_PROVEEDOR.Controls.Add(this.TXT_PROVEEDOR_BUSCAR);
            this.GB_BUSCADOR_PROVEEDOR.Controls.Add(this.RB);
            this.GB_BUSCADOR_PROVEEDOR.Controls.Add(this.RB_PROVEEDOR_NOMBRE);
            this.GB_BUSCADOR_PROVEEDOR.Controls.Add(this.RB_PROVEEDOR_CODIGO);
            this.GB_BUSCADOR_PROVEEDOR.Controls.Add(this.RB_PROVEEDOR_TODOS);
            this.GB_BUSCADOR_PROVEEDOR.Location = new System.Drawing.Point(17, 88);
            this.GB_BUSCADOR_PROVEEDOR.Name = "GB_BUSCADOR_PROVEEDOR";
            this.GB_BUSCADOR_PROVEEDOR.Size = new System.Drawing.Size(791, 56);
            this.GB_BUSCADOR_PROVEEDOR.TabIndex = 11;
            this.GB_BUSCADOR_PROVEEDOR.TabStop = false;
            this.GB_BUSCADOR_PROVEEDOR.Text = "Buscador";
            // 
            // BTN_PROVEEDOR_LIMPIAR
            // 
            this.BTN_PROVEEDOR_LIMPIAR.Location = new System.Drawing.Point(710, 16);
            this.BTN_PROVEEDOR_LIMPIAR.Name = "BTN_PROVEEDOR_LIMPIAR";
            this.BTN_PROVEEDOR_LIMPIAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_PROVEEDOR_LIMPIAR.TabIndex = 6;
            this.BTN_PROVEEDOR_LIMPIAR.Text = "Limpiar";
            this.BTN_PROVEEDOR_LIMPIAR.UseVisualStyleBackColor = true;
            // 
            // BTN_PROVEEDOR_BUSCAR
            // 
            this.BTN_PROVEEDOR_BUSCAR.Location = new System.Drawing.Point(630, 16);
            this.BTN_PROVEEDOR_BUSCAR.Name = "BTN_PROVEEDOR_BUSCAR";
            this.BTN_PROVEEDOR_BUSCAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_PROVEEDOR_BUSCAR.TabIndex = 5;
            this.BTN_PROVEEDOR_BUSCAR.Text = "Buscar";
            this.BTN_PROVEEDOR_BUSCAR.UseVisualStyleBackColor = true;
            // 
            // TXT_PROVEEDOR_BUSCAR
            // 
            this.TXT_PROVEEDOR_BUSCAR.Location = new System.Drawing.Point(408, 18);
            this.TXT_PROVEEDOR_BUSCAR.Name = "TXT_PROVEEDOR_BUSCAR";
            this.TXT_PROVEEDOR_BUSCAR.Size = new System.Drawing.Size(216, 20);
            this.TXT_PROVEEDOR_BUSCAR.TabIndex = 4;
            // 
            // RB
            // 
            this.RB.AutoSize = true;
            this.RB.Location = new System.Drawing.Point(310, 19);
            this.RB.Name = "RB";
            this.RB.Size = new System.Drawing.Size(74, 17);
            this.RB.TabIndex = 3;
            this.RB.TabStop = true;
            this.RB.Text = "Proveedor";
            this.RB.UseVisualStyleBackColor = true;
            // 
            // RB_PROVEEDOR_NOMBRE
            // 
            this.RB_PROVEEDOR_NOMBRE.AutoSize = true;
            this.RB_PROVEEDOR_NOMBRE.Location = new System.Drawing.Point(219, 19);
            this.RB_PROVEEDOR_NOMBRE.Name = "RB_PROVEEDOR_NOMBRE";
            this.RB_PROVEEDOR_NOMBRE.Size = new System.Drawing.Size(62, 17);
            this.RB_PROVEEDOR_NOMBRE.TabIndex = 2;
            this.RB_PROVEEDOR_NOMBRE.TabStop = true;
            this.RB_PROVEEDOR_NOMBRE.Text = "Nombre";
            this.RB_PROVEEDOR_NOMBRE.UseVisualStyleBackColor = true;
            // 
            // RB_PROVEEDOR_CODIGO
            // 
            this.RB_PROVEEDOR_CODIGO.AutoSize = true;
            this.RB_PROVEEDOR_CODIGO.Location = new System.Drawing.Point(128, 19);
            this.RB_PROVEEDOR_CODIGO.Name = "RB_PROVEEDOR_CODIGO";
            this.RB_PROVEEDOR_CODIGO.Size = new System.Drawing.Size(58, 17);
            this.RB_PROVEEDOR_CODIGO.TabIndex = 1;
            this.RB_PROVEEDOR_CODIGO.TabStop = true;
            this.RB_PROVEEDOR_CODIGO.Text = "Codigo";
            this.RB_PROVEEDOR_CODIGO.UseVisualStyleBackColor = true;
            // 
            // RB_PROVEEDOR_TODOS
            // 
            this.RB_PROVEEDOR_TODOS.AutoSize = true;
            this.RB_PROVEEDOR_TODOS.Location = new System.Drawing.Point(46, 19);
            this.RB_PROVEEDOR_TODOS.Name = "RB_PROVEEDOR_TODOS";
            this.RB_PROVEEDOR_TODOS.Size = new System.Drawing.Size(55, 17);
            this.RB_PROVEEDOR_TODOS.TabIndex = 0;
            this.RB_PROVEEDOR_TODOS.TabStop = true;
            this.RB_PROVEEDOR_TODOS.Text = "Todos";
            this.RB_PROVEEDOR_TODOS.UseVisualStyleBackColor = true;
            // 
            // LBL_PROVEEDORES_PROVEEDORES
            // 
            this.LBL_PROVEEDORES_PROVEEDORES.AutoSize = true;
            this.LBL_PROVEEDORES_PROVEEDORES.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PROVEEDORES_PROVEEDORES.Location = new System.Drawing.Point(88, 22);
            this.LBL_PROVEEDORES_PROVEEDORES.Name = "LBL_PROVEEDORES_PROVEEDORES";
            this.LBL_PROVEEDORES_PROVEEDORES.Size = new System.Drawing.Size(240, 50);
            this.LBL_PROVEEDORES_PROVEEDORES.TabIndex = 10;
            this.LBL_PROVEEDORES_PROVEEDORES.Text = "Proveedores";
            // 
            // PIC_BOX_PROVEEDORES
            // 
            this.PIC_BOX_PROVEEDORES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PIC_BOX_PROVEEDORES.Image = ((System.Drawing.Image)(resources.GetObject("PIC_BOX_PROVEEDORES.Image")));
            this.PIC_BOX_PROVEEDORES.Location = new System.Drawing.Point(17, 12);
            this.PIC_BOX_PROVEEDORES.Name = "PIC_BOX_PROVEEDORES";
            this.PIC_BOX_PROVEEDORES.Size = new System.Drawing.Size(65, 70);
            this.PIC_BOX_PROVEEDORES.TabIndex = 9;
            this.PIC_BOX_PROVEEDORES.TabStop = false;
            this.PIC_BOX_PROVEEDORES.WaitOnLoad = true;
            // 
            // Form_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(825, 688);
            this.Controls.Add(this.GB_PROVEEDORES_OPCIONES);
            this.Controls.Add(this.GB_PROVEEDORES_TABLA);
            this.Controls.Add(this.GB_BUSCADOR_PROVEEDOR);
            this.Controls.Add(this.LBL_PROVEEDORES_PROVEEDORES);
            this.Controls.Add(this.PIC_BOX_PROVEEDORES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Proveedores";
            this.Text = "Form_Proveedores";
            this.Load += new System.EventHandler(this.Form_Proveedores_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Proveedores_MouseMove);
            this.GB_PROVEEDORES_OPCIONES.ResumeLayout(false);
            this.GB_PROVEEDORES_TABLA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PROVEEDORES)).EndInit();
            this.GB_BUSCADOR_PROVEEDOR.ResumeLayout(false);
            this.GB_BUSCADOR_PROVEEDOR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_BOX_PROVEEDORES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_PROVEEDORES_OPCIONES;
        private System.Windows.Forms.Button BTN_REVISAR_PROVEEDOR;
        private System.Windows.Forms.Button BTN_ELIMINAR_PROVEEDOR;
        private System.Windows.Forms.Button BTN_MODIFICAR_PROVEEDOR;
        private System.Windows.Forms.Button BTN_NUEVO_PROVEEDOR;
        private System.Windows.Forms.GroupBox GB_PROVEEDORES_TABLA;
        private System.Windows.Forms.DataGridView DGV_PROVEEDORES;
        private System.Windows.Forms.GroupBox GB_BUSCADOR_PROVEEDOR;
        private System.Windows.Forms.Button BTN_PROVEEDOR_LIMPIAR;
        private System.Windows.Forms.Button BTN_PROVEEDOR_BUSCAR;
        private System.Windows.Forms.TextBox TXT_PROVEEDOR_BUSCAR;
        private System.Windows.Forms.RadioButton RB;
        private System.Windows.Forms.RadioButton RB_PROVEEDOR_NOMBRE;
        private System.Windows.Forms.RadioButton RB_PROVEEDOR_CODIGO;
        private System.Windows.Forms.RadioButton RB_PROVEEDOR_TODOS;
        private System.Windows.Forms.Label LBL_PROVEEDORES_PROVEEDORES;
        private System.Windows.Forms.PictureBox PIC_BOX_PROVEEDORES;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PROVEEDORES_RUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PROVEEDORES_RAZONSOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PROVEEDORES_GIRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PROVEEDORES_TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PROVEEDORES_MOVIL;
    }
}