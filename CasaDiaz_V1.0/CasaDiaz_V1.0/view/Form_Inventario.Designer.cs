namespace CasaDiaz_V1._0.view
{
    partial class Form_Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Inventario));
            this.BTN_CERRAR_INVENTARIO = new System.Windows.Forms.Button();
            this.BTN_MINIMIZAR_INVENTARIO = new System.Windows.Forms.Button();
            this.PIC_BOX_INVENTARIO = new System.Windows.Forms.PictureBox();
            this.LBL_INVENTARIO_INVENTARIO = new System.Windows.Forms.Label();
            this.GB_BUSCADOR_INVENTARIO = new System.Windows.Forms.GroupBox();
            this.BTN_INVENTARIO_LIMPIAR = new System.Windows.Forms.Button();
            this.BTN_INVENTARIO_BUSCAR = new System.Windows.Forms.Button();
            this.TXT_INVENTARIO_LIMPIAR = new System.Windows.Forms.TextBox();
            this.RB_BUSCAR_PROVEEDOR = new System.Windows.Forms.RadioButton();
            this.RB_INVENTARIO_NOMBRE = new System.Windows.Forms.RadioButton();
            this.RB_INVENTARIO_CODIGO = new System.Windows.Forms.RadioButton();
            this.RB_INVENTARIO_TODOS = new System.Windows.Forms.RadioButton();
            this.GB_INVENTARIOS_TABLA = new System.Windows.Forms.GroupBox();
            this.DGV_INVENTARIO = new System.Windows.Forms.DataGridView();
            this.GB_OPCIONES = new System.Windows.Forms.GroupBox();
            this.BTN_REVISAR_PRODUCTO = new System.Windows.Forms.Button();
            this.BTN_ELIMINAR_PRODUCTO = new System.Windows.Forms.Button();
            this.BTN_RENOVAR_PRODUCTO = new System.Windows.Forms.Button();
            this.BTN_NUEVO_PRODUCTO = new System.Windows.Forms.Button();
            this.PRO_PRODUCTOS_CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRODUCTOS_NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRODUCTOS_CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PROVEEDOR_NOMBREFANTASIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRODUCTOS_PRECIOVENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRODUCTOS_ULTIMAREPOSICION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_BOX_INVENTARIO)).BeginInit();
            this.GB_BUSCADOR_INVENTARIO.SuspendLayout();
            this.GB_INVENTARIOS_TABLA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_INVENTARIO)).BeginInit();
            this.GB_OPCIONES.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_CERRAR_INVENTARIO
            // 
            this.BTN_CERRAR_INVENTARIO.FlatAppearance.BorderSize = 0;
            this.BTN_CERRAR_INVENTARIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CERRAR_INVENTARIO.Image = ((System.Drawing.Image)(resources.GetObject("BTN_CERRAR_INVENTARIO.Image")));
            this.BTN_CERRAR_INVENTARIO.Location = new System.Drawing.Point(770, 12);
            this.BTN_CERRAR_INVENTARIO.Name = "BTN_CERRAR_INVENTARIO";
            this.BTN_CERRAR_INVENTARIO.Size = new System.Drawing.Size(43, 45);
            this.BTN_CERRAR_INVENTARIO.TabIndex = 0;
            this.BTN_CERRAR_INVENTARIO.UseVisualStyleBackColor = true;
            this.BTN_CERRAR_INVENTARIO.Click += new System.EventHandler(this.BTN_CERRAR_INVENTARIO_Click);
            // 
            // BTN_MINIMIZAR_INVENTARIO
            // 
            this.BTN_MINIMIZAR_INVENTARIO.FlatAppearance.BorderSize = 0;
            this.BTN_MINIMIZAR_INVENTARIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_MINIMIZAR_INVENTARIO.Image = ((System.Drawing.Image)(resources.GetObject("BTN_MINIMIZAR_INVENTARIO.Image")));
            this.BTN_MINIMIZAR_INVENTARIO.Location = new System.Drawing.Point(721, 12);
            this.BTN_MINIMIZAR_INVENTARIO.Name = "BTN_MINIMIZAR_INVENTARIO";
            this.BTN_MINIMIZAR_INVENTARIO.Size = new System.Drawing.Size(43, 45);
            this.BTN_MINIMIZAR_INVENTARIO.TabIndex = 1;
            this.BTN_MINIMIZAR_INVENTARIO.UseVisualStyleBackColor = true;
            this.BTN_MINIMIZAR_INVENTARIO.Click += new System.EventHandler(this.BTN_MINIMIZAR_INVENTARIO_Click);
            // 
            // PIC_BOX_INVENTARIO
            // 
            this.PIC_BOX_INVENTARIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PIC_BOX_INVENTARIO.Image = ((System.Drawing.Image)(resources.GetObject("PIC_BOX_INVENTARIO.Image")));
            this.PIC_BOX_INVENTARIO.Location = new System.Drawing.Point(17, 12);
            this.PIC_BOX_INVENTARIO.Name = "PIC_BOX_INVENTARIO";
            this.PIC_BOX_INVENTARIO.Size = new System.Drawing.Size(65, 70);
            this.PIC_BOX_INVENTARIO.TabIndex = 2;
            this.PIC_BOX_INVENTARIO.TabStop = false;
            this.PIC_BOX_INVENTARIO.WaitOnLoad = true;
            // 
            // LBL_INVENTARIO_INVENTARIO
            // 
            this.LBL_INVENTARIO_INVENTARIO.AutoSize = true;
            this.LBL_INVENTARIO_INVENTARIO.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_INVENTARIO_INVENTARIO.Location = new System.Drawing.Point(93, 22);
            this.LBL_INVENTARIO_INVENTARIO.Name = "LBL_INVENTARIO_INVENTARIO";
            this.LBL_INVENTARIO_INVENTARIO.Size = new System.Drawing.Size(201, 50);
            this.LBL_INVENTARIO_INVENTARIO.TabIndex = 3;
            this.LBL_INVENTARIO_INVENTARIO.Text = "Inventario";
            // 
            // GB_BUSCADOR_INVENTARIO
            // 
            this.GB_BUSCADOR_INVENTARIO.Controls.Add(this.BTN_INVENTARIO_LIMPIAR);
            this.GB_BUSCADOR_INVENTARIO.Controls.Add(this.BTN_INVENTARIO_BUSCAR);
            this.GB_BUSCADOR_INVENTARIO.Controls.Add(this.TXT_INVENTARIO_LIMPIAR);
            this.GB_BUSCADOR_INVENTARIO.Controls.Add(this.RB_BUSCAR_PROVEEDOR);
            this.GB_BUSCADOR_INVENTARIO.Controls.Add(this.RB_INVENTARIO_NOMBRE);
            this.GB_BUSCADOR_INVENTARIO.Controls.Add(this.RB_INVENTARIO_CODIGO);
            this.GB_BUSCADOR_INVENTARIO.Controls.Add(this.RB_INVENTARIO_TODOS);
            this.GB_BUSCADOR_INVENTARIO.Location = new System.Drawing.Point(17, 88);
            this.GB_BUSCADOR_INVENTARIO.Name = "GB_BUSCADOR_INVENTARIO";
            this.GB_BUSCADOR_INVENTARIO.Size = new System.Drawing.Size(791, 56);
            this.GB_BUSCADOR_INVENTARIO.TabIndex = 4;
            this.GB_BUSCADOR_INVENTARIO.TabStop = false;
            this.GB_BUSCADOR_INVENTARIO.Text = "Buscador";
            this.GB_BUSCADOR_INVENTARIO.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BTN_INVENTARIO_LIMPIAR
            // 
            this.BTN_INVENTARIO_LIMPIAR.Location = new System.Drawing.Point(710, 16);
            this.BTN_INVENTARIO_LIMPIAR.Name = "BTN_INVENTARIO_LIMPIAR";
            this.BTN_INVENTARIO_LIMPIAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_INVENTARIO_LIMPIAR.TabIndex = 6;
            this.BTN_INVENTARIO_LIMPIAR.Text = "Limpiar";
            this.BTN_INVENTARIO_LIMPIAR.UseVisualStyleBackColor = true;
            // 
            // BTN_INVENTARIO_BUSCAR
            // 
            this.BTN_INVENTARIO_BUSCAR.Location = new System.Drawing.Point(630, 16);
            this.BTN_INVENTARIO_BUSCAR.Name = "BTN_INVENTARIO_BUSCAR";
            this.BTN_INVENTARIO_BUSCAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_INVENTARIO_BUSCAR.TabIndex = 5;
            this.BTN_INVENTARIO_BUSCAR.Text = "Buscar";
            this.BTN_INVENTARIO_BUSCAR.UseVisualStyleBackColor = true;
            // 
            // TXT_INVENTARIO_LIMPIAR
            // 
            this.TXT_INVENTARIO_LIMPIAR.Location = new System.Drawing.Point(408, 18);
            this.TXT_INVENTARIO_LIMPIAR.Name = "TXT_INVENTARIO_LIMPIAR";
            this.TXT_INVENTARIO_LIMPIAR.Size = new System.Drawing.Size(216, 20);
            this.TXT_INVENTARIO_LIMPIAR.TabIndex = 4;
            // 
            // RB_BUSCAR_PROVEEDOR
            // 
            this.RB_BUSCAR_PROVEEDOR.AutoSize = true;
            this.RB_BUSCAR_PROVEEDOR.Location = new System.Drawing.Point(310, 19);
            this.RB_BUSCAR_PROVEEDOR.Name = "RB_BUSCAR_PROVEEDOR";
            this.RB_BUSCAR_PROVEEDOR.Size = new System.Drawing.Size(74, 17);
            this.RB_BUSCAR_PROVEEDOR.TabIndex = 3;
            this.RB_BUSCAR_PROVEEDOR.TabStop = true;
            this.RB_BUSCAR_PROVEEDOR.Text = "Proveedor";
            this.RB_BUSCAR_PROVEEDOR.UseVisualStyleBackColor = true;
            // 
            // RB_INVENTARIO_NOMBRE
            // 
            this.RB_INVENTARIO_NOMBRE.AutoSize = true;
            this.RB_INVENTARIO_NOMBRE.Location = new System.Drawing.Point(219, 19);
            this.RB_INVENTARIO_NOMBRE.Name = "RB_INVENTARIO_NOMBRE";
            this.RB_INVENTARIO_NOMBRE.Size = new System.Drawing.Size(62, 17);
            this.RB_INVENTARIO_NOMBRE.TabIndex = 2;
            this.RB_INVENTARIO_NOMBRE.TabStop = true;
            this.RB_INVENTARIO_NOMBRE.Text = "Nombre";
            this.RB_INVENTARIO_NOMBRE.UseVisualStyleBackColor = true;
            // 
            // RB_INVENTARIO_CODIGO
            // 
            this.RB_INVENTARIO_CODIGO.AutoSize = true;
            this.RB_INVENTARIO_CODIGO.Location = new System.Drawing.Point(128, 19);
            this.RB_INVENTARIO_CODIGO.Name = "RB_INVENTARIO_CODIGO";
            this.RB_INVENTARIO_CODIGO.Size = new System.Drawing.Size(58, 17);
            this.RB_INVENTARIO_CODIGO.TabIndex = 1;
            this.RB_INVENTARIO_CODIGO.TabStop = true;
            this.RB_INVENTARIO_CODIGO.Text = "Codigo";
            this.RB_INVENTARIO_CODIGO.UseVisualStyleBackColor = true;
            // 
            // RB_INVENTARIO_TODOS
            // 
            this.RB_INVENTARIO_TODOS.AutoSize = true;
            this.RB_INVENTARIO_TODOS.Location = new System.Drawing.Point(46, 19);
            this.RB_INVENTARIO_TODOS.Name = "RB_INVENTARIO_TODOS";
            this.RB_INVENTARIO_TODOS.Size = new System.Drawing.Size(55, 17);
            this.RB_INVENTARIO_TODOS.TabIndex = 0;
            this.RB_INVENTARIO_TODOS.TabStop = true;
            this.RB_INVENTARIO_TODOS.Text = "Todos";
            this.RB_INVENTARIO_TODOS.UseVisualStyleBackColor = true;
            // 
            // GB_INVENTARIOS_TABLA
            // 
            this.GB_INVENTARIOS_TABLA.Controls.Add(this.DGV_INVENTARIO);
            this.GB_INVENTARIOS_TABLA.Location = new System.Drawing.Point(17, 150);
            this.GB_INVENTARIOS_TABLA.Name = "GB_INVENTARIOS_TABLA";
            this.GB_INVENTARIOS_TABLA.Size = new System.Drawing.Size(791, 392);
            this.GB_INVENTARIOS_TABLA.TabIndex = 5;
            this.GB_INVENTARIOS_TABLA.TabStop = false;
            this.GB_INVENTARIOS_TABLA.Text = "Tabla";
            // 
            // DGV_INVENTARIO
            // 
            this.DGV_INVENTARIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_INVENTARIO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRO_PRODUCTOS_CODIGO,
            this.PRO_PRODUCTOS_NOMBRE,
            this.PRO_PRODUCTOS_CANTIDAD,
            this.PRO_PROVEEDOR_NOMBREFANTASIA,
            this.PRO_PRODUCTOS_PRECIOVENTA,
            this.PRO_PRODUCTOS_ULTIMAREPOSICION});
            this.DGV_INVENTARIO.EnableHeadersVisualStyles = false;
            this.DGV_INVENTARIO.Location = new System.Drawing.Point(6, 19);
            this.DGV_INVENTARIO.Name = "DGV_INVENTARIO";
            this.DGV_INVENTARIO.ReadOnly = true;
            this.DGV_INVENTARIO.Size = new System.Drawing.Size(779, 359);
            this.DGV_INVENTARIO.TabIndex = 0;
            // 
            // GB_OPCIONES
            // 
            this.GB_OPCIONES.Controls.Add(this.BTN_REVISAR_PRODUCTO);
            this.GB_OPCIONES.Controls.Add(this.BTN_ELIMINAR_PRODUCTO);
            this.GB_OPCIONES.Controls.Add(this.BTN_RENOVAR_PRODUCTO);
            this.GB_OPCIONES.Controls.Add(this.BTN_NUEVO_PRODUCTO);
            this.GB_OPCIONES.Location = new System.Drawing.Point(17, 548);
            this.GB_OPCIONES.Name = "GB_OPCIONES";
            this.GB_OPCIONES.Size = new System.Drawing.Size(791, 128);
            this.GB_OPCIONES.TabIndex = 6;
            this.GB_OPCIONES.TabStop = false;
            this.GB_OPCIONES.Text = "Opciones";
            // 
            // BTN_REVISAR_PRODUCTO
            // 
            this.BTN_REVISAR_PRODUCTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_REVISAR_PRODUCTO.Image = ((System.Drawing.Image)(resources.GetObject("BTN_REVISAR_PRODUCTO.Image")));
            this.BTN_REVISAR_PRODUCTO.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_REVISAR_PRODUCTO.Location = new System.Drawing.Point(642, 19);
            this.BTN_REVISAR_PRODUCTO.Name = "BTN_REVISAR_PRODUCTO";
            this.BTN_REVISAR_PRODUCTO.Size = new System.Drawing.Size(100, 92);
            this.BTN_REVISAR_PRODUCTO.TabIndex = 3;
            this.BTN_REVISAR_PRODUCTO.Text = "Revisar";
            this.BTN_REVISAR_PRODUCTO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_REVISAR_PRODUCTO.UseVisualStyleBackColor = true;
            // 
            // BTN_ELIMINAR_PRODUCTO
            // 
            this.BTN_ELIMINAR_PRODUCTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ELIMINAR_PRODUCTO.Image = ((System.Drawing.Image)(resources.GetObject("BTN_ELIMINAR_PRODUCTO.Image")));
            this.BTN_ELIMINAR_PRODUCTO.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_ELIMINAR_PRODUCTO.Location = new System.Drawing.Point(440, 19);
            this.BTN_ELIMINAR_PRODUCTO.Name = "BTN_ELIMINAR_PRODUCTO";
            this.BTN_ELIMINAR_PRODUCTO.Size = new System.Drawing.Size(100, 92);
            this.BTN_ELIMINAR_PRODUCTO.TabIndex = 2;
            this.BTN_ELIMINAR_PRODUCTO.Text = "Eliminar";
            this.BTN_ELIMINAR_PRODUCTO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_ELIMINAR_PRODUCTO.UseVisualStyleBackColor = true;
            this.BTN_ELIMINAR_PRODUCTO.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTN_RENOVAR_PRODUCTO
            // 
            this.BTN_RENOVAR_PRODUCTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RENOVAR_PRODUCTO.Image = ((System.Drawing.Image)(resources.GetObject("BTN_RENOVAR_PRODUCTO.Image")));
            this.BTN_RENOVAR_PRODUCTO.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_RENOVAR_PRODUCTO.Location = new System.Drawing.Point(237, 19);
            this.BTN_RENOVAR_PRODUCTO.Name = "BTN_RENOVAR_PRODUCTO";
            this.BTN_RENOVAR_PRODUCTO.Size = new System.Drawing.Size(100, 92);
            this.BTN_RENOVAR_PRODUCTO.TabIndex = 1;
            this.BTN_RENOVAR_PRODUCTO.Text = "Renovar";
            this.BTN_RENOVAR_PRODUCTO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_RENOVAR_PRODUCTO.UseVisualStyleBackColor = true;
            // 
            // BTN_NUEVO_PRODUCTO
            // 
            this.BTN_NUEVO_PRODUCTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NUEVO_PRODUCTO.Image = ((System.Drawing.Image)(resources.GetObject("BTN_NUEVO_PRODUCTO.Image")));
            this.BTN_NUEVO_PRODUCTO.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_NUEVO_PRODUCTO.Location = new System.Drawing.Point(46, 19);
            this.BTN_NUEVO_PRODUCTO.Name = "BTN_NUEVO_PRODUCTO";
            this.BTN_NUEVO_PRODUCTO.Size = new System.Drawing.Size(100, 92);
            this.BTN_NUEVO_PRODUCTO.TabIndex = 0;
            this.BTN_NUEVO_PRODUCTO.Text = "Nuevo";
            this.BTN_NUEVO_PRODUCTO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_NUEVO_PRODUCTO.UseVisualStyleBackColor = true;
            // 
            // PRO_PRODUCTOS_CODIGO
            // 
            this.PRO_PRODUCTOS_CODIGO.HeaderText = "Codigo de Barras";
            this.PRO_PRODUCTOS_CODIGO.Name = "PRO_PRODUCTOS_CODIGO";
            this.PRO_PRODUCTOS_CODIGO.ReadOnly = true;
            this.PRO_PRODUCTOS_CODIGO.Width = 150;
            // 
            // PRO_PRODUCTOS_NOMBRE
            // 
            this.PRO_PRODUCTOS_NOMBRE.HeaderText = "Nombre";
            this.PRO_PRODUCTOS_NOMBRE.Name = "PRO_PRODUCTOS_NOMBRE";
            this.PRO_PRODUCTOS_NOMBRE.ReadOnly = true;
            this.PRO_PRODUCTOS_NOMBRE.Width = 200;
            // 
            // PRO_PRODUCTOS_CANTIDAD
            // 
            this.PRO_PRODUCTOS_CANTIDAD.HeaderText = "Cantidad";
            this.PRO_PRODUCTOS_CANTIDAD.Name = "PRO_PRODUCTOS_CANTIDAD";
            this.PRO_PRODUCTOS_CANTIDAD.ReadOnly = true;
            this.PRO_PRODUCTOS_CANTIDAD.Width = 85;
            // 
            // PRO_PROVEEDOR_NOMBREFANTASIA
            // 
            this.PRO_PROVEEDOR_NOMBREFANTASIA.HeaderText = "Proveedor";
            this.PRO_PROVEEDOR_NOMBREFANTASIA.Name = "PRO_PROVEEDOR_NOMBREFANTASIA";
            this.PRO_PROVEEDOR_NOMBREFANTASIA.ReadOnly = true;
            // 
            // PRO_PRODUCTOS_PRECIOVENTA
            // 
            this.PRO_PRODUCTOS_PRECIOVENTA.HeaderText = "Precio Local";
            this.PRO_PRODUCTOS_PRECIOVENTA.Name = "PRO_PRODUCTOS_PRECIOVENTA";
            this.PRO_PRODUCTOS_PRECIOVENTA.ReadOnly = true;
            // 
            // PRO_PRODUCTOS_ULTIMAREPOSICION
            // 
            this.PRO_PRODUCTOS_ULTIMAREPOSICION.HeaderText = "Ultima Reposicion";
            this.PRO_PRODUCTOS_ULTIMAREPOSICION.Name = "PRO_PRODUCTOS_ULTIMAREPOSICION";
            this.PRO_PRODUCTOS_ULTIMAREPOSICION.ReadOnly = true;
            // 
            // Form_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(825, 688);
            this.Controls.Add(this.GB_OPCIONES);
            this.Controls.Add(this.GB_INVENTARIOS_TABLA);
            this.Controls.Add(this.GB_BUSCADOR_INVENTARIO);
            this.Controls.Add(this.LBL_INVENTARIO_INVENTARIO);
            this.Controls.Add(this.PIC_BOX_INVENTARIO);
            this.Controls.Add(this.BTN_MINIMIZAR_INVENTARIO);
            this.Controls.Add(this.BTN_CERRAR_INVENTARIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Inventario";
            this.Text = "inventario_form";
            this.Load += new System.EventHandler(this.inventario_form_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.inventario_form_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_BOX_INVENTARIO)).EndInit();
            this.GB_BUSCADOR_INVENTARIO.ResumeLayout(false);
            this.GB_BUSCADOR_INVENTARIO.PerformLayout();
            this.GB_INVENTARIOS_TABLA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_INVENTARIO)).EndInit();
            this.GB_OPCIONES.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_CERRAR_INVENTARIO;
        private System.Windows.Forms.Button BTN_MINIMIZAR_INVENTARIO;
        private System.Windows.Forms.PictureBox PIC_BOX_INVENTARIO;
        private System.Windows.Forms.Label LBL_INVENTARIO_INVENTARIO;
        private System.Windows.Forms.GroupBox GB_BUSCADOR_INVENTARIO;
        private System.Windows.Forms.RadioButton RB_BUSCAR_PROVEEDOR;
        private System.Windows.Forms.RadioButton RB_INVENTARIO_NOMBRE;
        private System.Windows.Forms.RadioButton RB_INVENTARIO_CODIGO;
        private System.Windows.Forms.RadioButton RB_INVENTARIO_TODOS;
        private System.Windows.Forms.Button BTN_INVENTARIO_LIMPIAR;
        private System.Windows.Forms.Button BTN_INVENTARIO_BUSCAR;
        private System.Windows.Forms.TextBox TXT_INVENTARIO_LIMPIAR;
        private System.Windows.Forms.GroupBox GB_INVENTARIOS_TABLA;
        private System.Windows.Forms.DataGridView DGV_INVENTARIO;
        private System.Windows.Forms.GroupBox GB_OPCIONES;
        private System.Windows.Forms.Button BTN_REVISAR_PRODUCTO;
        private System.Windows.Forms.Button BTN_ELIMINAR_PRODUCTO;
        private System.Windows.Forms.Button BTN_RENOVAR_PRODUCTO;
        private System.Windows.Forms.Button BTN_NUEVO_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTOS_CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTOS_NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTOS_CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PROVEEDOR_NOMBREFANTASIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTOS_PRECIOVENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTOS_ULTIMAREPOSICION;
    }
}