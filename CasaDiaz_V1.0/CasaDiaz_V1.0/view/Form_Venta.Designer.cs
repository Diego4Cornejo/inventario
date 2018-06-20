namespace CasaDiaz_V1._0.view
{
    partial class Form_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Venta));
            this.GB_OPCIONES_VENTA = new System.Windows.Forms.GroupBox();
            this.BTN_REVISAR_VENTA = new System.Windows.Forms.Button();
            this.BTN_ELIMINAR_VENTA = new System.Windows.Forms.Button();
            this.BTN_ACTUALIZAR_VENTA = new System.Windows.Forms.Button();
            this.BTN_NUEVA_VENTA = new System.Windows.Forms.Button();
            this.GB_VENTAS_TABLA = new System.Windows.Forms.GroupBox();
            this.DGV_VENTAS = new System.Windows.Forms.DataGridView();
            this.PRO_PRODUCTO_CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRODUCTO_NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRODUCTO_CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRODUCTO_MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRODUCTO_PRECIOLOCAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRODUCTO_FECHADEENTREGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GB_BUSCADOR_VENTA = new System.Windows.Forms.GroupBox();
            this.BTN_VENTA_LIMPIAR = new System.Windows.Forms.Button();
            this.BTN_VENTA_BUSCAR = new System.Windows.Forms.Button();
            this.TXT_VENTA_BUSCAR = new System.Windows.Forms.TextBox();
            this.RB_VENTA_PROVEEDOR = new System.Windows.Forms.RadioButton();
            this.RB_VENTA_NOMBRE = new System.Windows.Forms.RadioButton();
            this.RB_VENTA_CODIGO = new System.Windows.Forms.RadioButton();
            this.RB_VENTA_TODOS = new System.Windows.Forms.RadioButton();
            this.LBL_VENTA_VENTA = new System.Windows.Forms.Label();
            this.PIC_BOX_VENTA = new System.Windows.Forms.PictureBox();
            this.GB_OPCIONES_VENTA.SuspendLayout();
            this.GB_VENTAS_TABLA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VENTAS)).BeginInit();
            this.GB_BUSCADOR_VENTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_BOX_VENTA)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_OPCIONES_VENTA
            // 
            this.GB_OPCIONES_VENTA.Controls.Add(this.BTN_REVISAR_VENTA);
            this.GB_OPCIONES_VENTA.Controls.Add(this.BTN_ELIMINAR_VENTA);
            this.GB_OPCIONES_VENTA.Controls.Add(this.BTN_ACTUALIZAR_VENTA);
            this.GB_OPCIONES_VENTA.Controls.Add(this.BTN_NUEVA_VENTA);
            this.GB_OPCIONES_VENTA.Location = new System.Drawing.Point(14, 548);
            this.GB_OPCIONES_VENTA.Name = "GB_OPCIONES_VENTA";
            this.GB_OPCIONES_VENTA.Size = new System.Drawing.Size(791, 128);
            this.GB_OPCIONES_VENTA.TabIndex = 13;
            this.GB_OPCIONES_VENTA.TabStop = false;
            this.GB_OPCIONES_VENTA.Text = "Opciones";
            // 
            // BTN_REVISAR_VENTA
            // 
            this.BTN_REVISAR_VENTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_REVISAR_VENTA.Image = ((System.Drawing.Image)(resources.GetObject("BTN_REVISAR_VENTA.Image")));
            this.BTN_REVISAR_VENTA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_REVISAR_VENTA.Location = new System.Drawing.Point(642, 19);
            this.BTN_REVISAR_VENTA.Name = "BTN_REVISAR_VENTA";
            this.BTN_REVISAR_VENTA.Size = new System.Drawing.Size(100, 92);
            this.BTN_REVISAR_VENTA.TabIndex = 3;
            this.BTN_REVISAR_VENTA.Text = "Revisar";
            this.BTN_REVISAR_VENTA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_REVISAR_VENTA.UseVisualStyleBackColor = true;
            // 
            // BTN_ELIMINAR_VENTA
            // 
            this.BTN_ELIMINAR_VENTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ELIMINAR_VENTA.Image = ((System.Drawing.Image)(resources.GetObject("BTN_ELIMINAR_VENTA.Image")));
            this.BTN_ELIMINAR_VENTA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_ELIMINAR_VENTA.Location = new System.Drawing.Point(440, 19);
            this.BTN_ELIMINAR_VENTA.Name = "BTN_ELIMINAR_VENTA";
            this.BTN_ELIMINAR_VENTA.Size = new System.Drawing.Size(100, 92);
            this.BTN_ELIMINAR_VENTA.TabIndex = 2;
            this.BTN_ELIMINAR_VENTA.Text = "Eliminar";
            this.BTN_ELIMINAR_VENTA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_ELIMINAR_VENTA.UseVisualStyleBackColor = true;
            // 
            // BTN_ACTUALIZAR_VENTA
            // 
            this.BTN_ACTUALIZAR_VENTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ACTUALIZAR_VENTA.Image = ((System.Drawing.Image)(resources.GetObject("BTN_ACTUALIZAR_VENTA.Image")));
            this.BTN_ACTUALIZAR_VENTA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_ACTUALIZAR_VENTA.Location = new System.Drawing.Point(237, 19);
            this.BTN_ACTUALIZAR_VENTA.Name = "BTN_ACTUALIZAR_VENTA";
            this.BTN_ACTUALIZAR_VENTA.Size = new System.Drawing.Size(100, 92);
            this.BTN_ACTUALIZAR_VENTA.TabIndex = 1;
            this.BTN_ACTUALIZAR_VENTA.Text = "Renovar";
            this.BTN_ACTUALIZAR_VENTA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_ACTUALIZAR_VENTA.UseVisualStyleBackColor = true;
            // 
            // BTN_NUEVA_VENTA
            // 
            this.BTN_NUEVA_VENTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NUEVA_VENTA.Image = ((System.Drawing.Image)(resources.GetObject("BTN_NUEVA_VENTA.Image")));
            this.BTN_NUEVA_VENTA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_NUEVA_VENTA.Location = new System.Drawing.Point(46, 19);
            this.BTN_NUEVA_VENTA.Name = "BTN_NUEVA_VENTA";
            this.BTN_NUEVA_VENTA.Size = new System.Drawing.Size(100, 92);
            this.BTN_NUEVA_VENTA.TabIndex = 0;
            this.BTN_NUEVA_VENTA.Text = "Nuevo";
            this.BTN_NUEVA_VENTA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_NUEVA_VENTA.UseVisualStyleBackColor = true;
            this.BTN_NUEVA_VENTA.Click += new System.EventHandler(this.BTN_NUEVA_VENTA_Click);
            // 
            // GB_VENTAS_TABLA
            // 
            this.GB_VENTAS_TABLA.Controls.Add(this.DGV_VENTAS);
            this.GB_VENTAS_TABLA.Location = new System.Drawing.Point(14, 150);
            this.GB_VENTAS_TABLA.Name = "GB_VENTAS_TABLA";
            this.GB_VENTAS_TABLA.Size = new System.Drawing.Size(791, 392);
            this.GB_VENTAS_TABLA.TabIndex = 12;
            this.GB_VENTAS_TABLA.TabStop = false;
            this.GB_VENTAS_TABLA.Text = "Tabla";
            // 
            // DGV_VENTAS
            // 
            this.DGV_VENTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VENTAS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRO_PRODUCTO_CODIGO,
            this.PRO_PRODUCTO_NOMBRE,
            this.PRO_PRODUCTO_CANTIDAD,
            this.PRO_PRODUCTO_MARCA,
            this.PRO_PRODUCTO_PRECIOLOCAL,
            this.PRO_PRODUCTO_FECHADEENTREGA});
            this.DGV_VENTAS.EnableHeadersVisualStyles = false;
            this.DGV_VENTAS.Location = new System.Drawing.Point(6, 19);
            this.DGV_VENTAS.Name = "DGV_VENTAS";
            this.DGV_VENTAS.ReadOnly = true;
            this.DGV_VENTAS.Size = new System.Drawing.Size(779, 359);
            this.DGV_VENTAS.TabIndex = 0;
            // 
            // PRO_PRODUCTO_CODIGO
            // 
            this.PRO_PRODUCTO_CODIGO.HeaderText = "Codigo";
            this.PRO_PRODUCTO_CODIGO.Name = "PRO_PRODUCTO_CODIGO";
            this.PRO_PRODUCTO_CODIGO.ReadOnly = true;
            this.PRO_PRODUCTO_CODIGO.Width = 150;
            // 
            // PRO_PRODUCTO_NOMBRE
            // 
            this.PRO_PRODUCTO_NOMBRE.HeaderText = "Nombre";
            this.PRO_PRODUCTO_NOMBRE.Name = "PRO_PRODUCTO_NOMBRE";
            this.PRO_PRODUCTO_NOMBRE.ReadOnly = true;
            this.PRO_PRODUCTO_NOMBRE.Width = 200;
            // 
            // PRO_PRODUCTO_CANTIDAD
            // 
            this.PRO_PRODUCTO_CANTIDAD.HeaderText = "Cantidad";
            this.PRO_PRODUCTO_CANTIDAD.Name = "PRO_PRODUCTO_CANTIDAD";
            this.PRO_PRODUCTO_CANTIDAD.ReadOnly = true;
            this.PRO_PRODUCTO_CANTIDAD.Width = 85;
            // 
            // PRO_PRODUCTO_MARCA
            // 
            this.PRO_PRODUCTO_MARCA.HeaderText = "Marca";
            this.PRO_PRODUCTO_MARCA.Name = "PRO_PRODUCTO_MARCA";
            this.PRO_PRODUCTO_MARCA.ReadOnly = true;
            // 
            // PRO_PRODUCTO_PRECIOLOCAL
            // 
            this.PRO_PRODUCTO_PRECIOLOCAL.HeaderText = "Precio Local";
            this.PRO_PRODUCTO_PRECIOLOCAL.Name = "PRO_PRODUCTO_PRECIOLOCAL";
            this.PRO_PRODUCTO_PRECIOLOCAL.ReadOnly = true;
            // 
            // PRO_PRODUCTO_FECHADEENTREGA
            // 
            this.PRO_PRODUCTO_FECHADEENTREGA.HeaderText = "Fecha de entrega";
            this.PRO_PRODUCTO_FECHADEENTREGA.Name = "PRO_PRODUCTO_FECHADEENTREGA";
            this.PRO_PRODUCTO_FECHADEENTREGA.ReadOnly = true;
            // 
            // GB_BUSCADOR_VENTA
            // 
            this.GB_BUSCADOR_VENTA.Controls.Add(this.BTN_VENTA_LIMPIAR);
            this.GB_BUSCADOR_VENTA.Controls.Add(this.BTN_VENTA_BUSCAR);
            this.GB_BUSCADOR_VENTA.Controls.Add(this.TXT_VENTA_BUSCAR);
            this.GB_BUSCADOR_VENTA.Controls.Add(this.RB_VENTA_PROVEEDOR);
            this.GB_BUSCADOR_VENTA.Controls.Add(this.RB_VENTA_NOMBRE);
            this.GB_BUSCADOR_VENTA.Controls.Add(this.RB_VENTA_CODIGO);
            this.GB_BUSCADOR_VENTA.Controls.Add(this.RB_VENTA_TODOS);
            this.GB_BUSCADOR_VENTA.Location = new System.Drawing.Point(14, 88);
            this.GB_BUSCADOR_VENTA.Name = "GB_BUSCADOR_VENTA";
            this.GB_BUSCADOR_VENTA.Size = new System.Drawing.Size(791, 56);
            this.GB_BUSCADOR_VENTA.TabIndex = 11;
            this.GB_BUSCADOR_VENTA.TabStop = false;
            this.GB_BUSCADOR_VENTA.Text = "Buscador";
            // 
            // BTN_VENTA_LIMPIAR
            // 
            this.BTN_VENTA_LIMPIAR.Location = new System.Drawing.Point(710, 16);
            this.BTN_VENTA_LIMPIAR.Name = "BTN_VENTA_LIMPIAR";
            this.BTN_VENTA_LIMPIAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_VENTA_LIMPIAR.TabIndex = 6;
            this.BTN_VENTA_LIMPIAR.Text = "Limpiar";
            this.BTN_VENTA_LIMPIAR.UseVisualStyleBackColor = true;
            // 
            // BTN_VENTA_BUSCAR
            // 
            this.BTN_VENTA_BUSCAR.Location = new System.Drawing.Point(630, 16);
            this.BTN_VENTA_BUSCAR.Name = "BTN_VENTA_BUSCAR";
            this.BTN_VENTA_BUSCAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_VENTA_BUSCAR.TabIndex = 5;
            this.BTN_VENTA_BUSCAR.Text = "Buscar";
            this.BTN_VENTA_BUSCAR.UseVisualStyleBackColor = true;
            // 
            // TXT_VENTA_BUSCAR
            // 
            this.TXT_VENTA_BUSCAR.Location = new System.Drawing.Point(408, 18);
            this.TXT_VENTA_BUSCAR.Name = "TXT_VENTA_BUSCAR";
            this.TXT_VENTA_BUSCAR.Size = new System.Drawing.Size(216, 20);
            this.TXT_VENTA_BUSCAR.TabIndex = 4;
            // 
            // RB_VENTA_PROVEEDOR
            // 
            this.RB_VENTA_PROVEEDOR.AutoSize = true;
            this.RB_VENTA_PROVEEDOR.Location = new System.Drawing.Point(310, 19);
            this.RB_VENTA_PROVEEDOR.Name = "RB_VENTA_PROVEEDOR";
            this.RB_VENTA_PROVEEDOR.Size = new System.Drawing.Size(74, 17);
            this.RB_VENTA_PROVEEDOR.TabIndex = 3;
            this.RB_VENTA_PROVEEDOR.TabStop = true;
            this.RB_VENTA_PROVEEDOR.Text = "Proveedor";
            this.RB_VENTA_PROVEEDOR.UseVisualStyleBackColor = true;
            // 
            // RB_VENTA_NOMBRE
            // 
            this.RB_VENTA_NOMBRE.AutoSize = true;
            this.RB_VENTA_NOMBRE.Location = new System.Drawing.Point(219, 19);
            this.RB_VENTA_NOMBRE.Name = "RB_VENTA_NOMBRE";
            this.RB_VENTA_NOMBRE.Size = new System.Drawing.Size(62, 17);
            this.RB_VENTA_NOMBRE.TabIndex = 2;
            this.RB_VENTA_NOMBRE.TabStop = true;
            this.RB_VENTA_NOMBRE.Text = "Nombre";
            this.RB_VENTA_NOMBRE.UseVisualStyleBackColor = true;
            // 
            // RB_VENTA_CODIGO
            // 
            this.RB_VENTA_CODIGO.AutoSize = true;
            this.RB_VENTA_CODIGO.Location = new System.Drawing.Point(128, 19);
            this.RB_VENTA_CODIGO.Name = "RB_VENTA_CODIGO";
            this.RB_VENTA_CODIGO.Size = new System.Drawing.Size(58, 17);
            this.RB_VENTA_CODIGO.TabIndex = 1;
            this.RB_VENTA_CODIGO.TabStop = true;
            this.RB_VENTA_CODIGO.Text = "Codigo";
            this.RB_VENTA_CODIGO.UseVisualStyleBackColor = true;
            // 
            // RB_VENTA_TODOS
            // 
            this.RB_VENTA_TODOS.AutoSize = true;
            this.RB_VENTA_TODOS.Location = new System.Drawing.Point(46, 19);
            this.RB_VENTA_TODOS.Name = "RB_VENTA_TODOS";
            this.RB_VENTA_TODOS.Size = new System.Drawing.Size(55, 17);
            this.RB_VENTA_TODOS.TabIndex = 0;
            this.RB_VENTA_TODOS.TabStop = true;
            this.RB_VENTA_TODOS.Text = "Todos";
            this.RB_VENTA_TODOS.UseVisualStyleBackColor = true;
            // 
            // LBL_VENTA_VENTA
            // 
            this.LBL_VENTA_VENTA.AutoSize = true;
            this.LBL_VENTA_VENTA.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_VENTA_VENTA.Location = new System.Drawing.Point(90, 22);
            this.LBL_VENTA_VENTA.Name = "LBL_VENTA_VENTA";
            this.LBL_VENTA_VENTA.Size = new System.Drawing.Size(137, 50);
            this.LBL_VENTA_VENTA.TabIndex = 10;
            this.LBL_VENTA_VENTA.Text = "Ventas";
            // 
            // PIC_BOX_VENTA
            // 
            this.PIC_BOX_VENTA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PIC_BOX_VENTA.Image = ((System.Drawing.Image)(resources.GetObject("PIC_BOX_VENTA.Image")));
            this.PIC_BOX_VENTA.Location = new System.Drawing.Point(14, 12);
            this.PIC_BOX_VENTA.Name = "PIC_BOX_VENTA";
            this.PIC_BOX_VENTA.Size = new System.Drawing.Size(65, 70);
            this.PIC_BOX_VENTA.TabIndex = 9;
            this.PIC_BOX_VENTA.TabStop = false;
            this.PIC_BOX_VENTA.WaitOnLoad = true;
            // 
            // Form_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(825, 688);
            this.Controls.Add(this.GB_OPCIONES_VENTA);
            this.Controls.Add(this.GB_VENTAS_TABLA);
            this.Controls.Add(this.GB_BUSCADOR_VENTA);
            this.Controls.Add(this.LBL_VENTA_VENTA);
            this.Controls.Add(this.PIC_BOX_VENTA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Venta";
            this.Text = "Form_Venta";
            this.GB_OPCIONES_VENTA.ResumeLayout(false);
            this.GB_VENTAS_TABLA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VENTAS)).EndInit();
            this.GB_BUSCADOR_VENTA.ResumeLayout(false);
            this.GB_BUSCADOR_VENTA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_BOX_VENTA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_OPCIONES_VENTA;
        private System.Windows.Forms.Button BTN_REVISAR_VENTA;
        private System.Windows.Forms.Button BTN_ELIMINAR_VENTA;
        private System.Windows.Forms.Button BTN_ACTUALIZAR_VENTA;
        private System.Windows.Forms.Button BTN_NUEVA_VENTA;
        private System.Windows.Forms.GroupBox GB_VENTAS_TABLA;
        private System.Windows.Forms.DataGridView DGV_VENTAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTO_CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTO_NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTO_CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTO_MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTO_PRECIOLOCAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTO_FECHADEENTREGA;
        private System.Windows.Forms.GroupBox GB_BUSCADOR_VENTA;
        private System.Windows.Forms.Button BTN_VENTA_LIMPIAR;
        private System.Windows.Forms.Button BTN_VENTA_BUSCAR;
        private System.Windows.Forms.TextBox TXT_VENTA_BUSCAR;
        private System.Windows.Forms.RadioButton RB_VENTA_PROVEEDOR;
        private System.Windows.Forms.RadioButton RB_VENTA_NOMBRE;
        private System.Windows.Forms.RadioButton RB_VENTA_CODIGO;
        private System.Windows.Forms.RadioButton RB_VENTA_TODOS;
        private System.Windows.Forms.Label LBL_VENTA_VENTA;
        private System.Windows.Forms.PictureBox PIC_BOX_VENTA;
    }
}