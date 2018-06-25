namespace CasaDiaz_V1._0.view
{
    partial class RenovarInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenovarInventario));
            this.BTN_LIMPIAR_PRODUCTO = new System.Windows.Forms.Button();
            this.BTN_GUARDAR_PRODUCTO = new System.Windows.Forms.Button();
            this.GB_DATOS_PROVEEDOR = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NDW_AGREGAR_CANTIDAD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NDW_CANTIDAD_ACTUAL = new System.Windows.Forms.NumericUpDown();
            this.DTP_FECHADEREPOSICION = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_MARCA_RENOVAR = new System.Windows.Forms.TextBox();
            this.LBL_MARCA_PRODUCTO = new System.Windows.Forms.Label();
            this.TXT_NOMBRE_RENOVAR = new System.Windows.Forms.TextBox();
            this.LBL_NOMBRE_PRODUCTO = new System.Windows.Forms.Label();
            this.TXT_RENOVAR_CODIGODEBARRA = new System.Windows.Forms.TextBox();
            this.LBL_CODIGODEBARRAS = new System.Windows.Forms.Label();
            this.LBL_PROVEEDOR_NUEVO = new System.Windows.Forms.Label();
            this.PIC_BOX_NUEVOPROVEEDOR = new System.Windows.Forms.PictureBox();
            this.GB_DATOS_PROVEEDOR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NDW_AGREGAR_CANTIDAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NDW_CANTIDAD_ACTUAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_BOX_NUEVOPROVEEDOR)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_LIMPIAR_PRODUCTO
            // 
            this.BTN_LIMPIAR_PRODUCTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LIMPIAR_PRODUCTO.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LIMPIAR_PRODUCTO.Image")));
            this.BTN_LIMPIAR_PRODUCTO.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_LIMPIAR_PRODUCTO.Location = new System.Drawing.Point(251, 398);
            this.BTN_LIMPIAR_PRODUCTO.Name = "BTN_LIMPIAR_PRODUCTO";
            this.BTN_LIMPIAR_PRODUCTO.Size = new System.Drawing.Size(119, 65);
            this.BTN_LIMPIAR_PRODUCTO.TabIndex = 29;
            this.BTN_LIMPIAR_PRODUCTO.Text = "Limpiar";
            this.BTN_LIMPIAR_PRODUCTO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_LIMPIAR_PRODUCTO.UseVisualStyleBackColor = true;
            // 
            // BTN_GUARDAR_PRODUCTO
            // 
            this.BTN_GUARDAR_PRODUCTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_GUARDAR_PRODUCTO.Image = ((System.Drawing.Image)(resources.GetObject("BTN_GUARDAR_PRODUCTO.Image")));
            this.BTN_GUARDAR_PRODUCTO.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_GUARDAR_PRODUCTO.Location = new System.Drawing.Point(115, 398);
            this.BTN_GUARDAR_PRODUCTO.Name = "BTN_GUARDAR_PRODUCTO";
            this.BTN_GUARDAR_PRODUCTO.Size = new System.Drawing.Size(114, 65);
            this.BTN_GUARDAR_PRODUCTO.TabIndex = 28;
            this.BTN_GUARDAR_PRODUCTO.Text = "Guardar";
            this.BTN_GUARDAR_PRODUCTO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_GUARDAR_PRODUCTO.UseVisualStyleBackColor = true;
            this.BTN_GUARDAR_PRODUCTO.Click += new System.EventHandler(this.BTN_GUARDAR_PRODUCTO_Click);
            // 
            // GB_DATOS_PROVEEDOR
            // 
            this.GB_DATOS_PROVEEDOR.Controls.Add(this.label4);
            this.GB_DATOS_PROVEEDOR.Controls.Add(this.label3);
            this.GB_DATOS_PROVEEDOR.Controls.Add(this.NDW_AGREGAR_CANTIDAD);
            this.GB_DATOS_PROVEEDOR.Controls.Add(this.label2);
            this.GB_DATOS_PROVEEDOR.Controls.Add(this.NDW_CANTIDAD_ACTUAL);
            this.GB_DATOS_PROVEEDOR.Controls.Add(this.DTP_FECHADEREPOSICION);
            this.GB_DATOS_PROVEEDOR.Controls.Add(this.label1);
            this.GB_DATOS_PROVEEDOR.Controls.Add(this.TXT_MARCA_RENOVAR);
            this.GB_DATOS_PROVEEDOR.Controls.Add(this.LBL_MARCA_PRODUCTO);
            this.GB_DATOS_PROVEEDOR.Controls.Add(this.TXT_NOMBRE_RENOVAR);
            this.GB_DATOS_PROVEEDOR.Controls.Add(this.LBL_NOMBRE_PRODUCTO);
            this.GB_DATOS_PROVEEDOR.Controls.Add(this.TXT_RENOVAR_CODIGODEBARRA);
            this.GB_DATOS_PROVEEDOR.Controls.Add(this.LBL_CODIGODEBARRAS);
            this.GB_DATOS_PROVEEDOR.Location = new System.Drawing.Point(12, 88);
            this.GB_DATOS_PROVEEDOR.Name = "GB_DATOS_PROVEEDOR";
            this.GB_DATOS_PROVEEDOR.Size = new System.Drawing.Size(468, 301);
            this.GB_DATOS_PROVEEDOR.TabIndex = 27;
            this.GB_DATOS_PROVEEDOR.TabStop = false;
            this.GB_DATOS_PROVEEDOR.Text = "Información del Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Agregar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Actual:";
            // 
            // NDW_AGREGAR_CANTIDAD
            // 
            this.NDW_AGREGAR_CANTIDAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NDW_AGREGAR_CANTIDAD.Location = new System.Drawing.Point(224, 260);
            this.NDW_AGREGAR_CANTIDAD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NDW_AGREGAR_CANTIDAD.Name = "NDW_AGREGAR_CANTIDAD";
            this.NDW_AGREGAR_CANTIDAD.Size = new System.Drawing.Size(153, 22);
            this.NDW_AGREGAR_CANTIDAD.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cantidad de Productos:";
            // 
            // NDW_CANTIDAD_ACTUAL
            // 
            this.NDW_CANTIDAD_ACTUAL.Enabled = false;
            this.NDW_CANTIDAD_ACTUAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NDW_CANTIDAD_ACTUAL.Location = new System.Drawing.Point(224, 218);
            this.NDW_CANTIDAD_ACTUAL.Name = "NDW_CANTIDAD_ACTUAL";
            this.NDW_CANTIDAD_ACTUAL.ReadOnly = true;
            this.NDW_CANTIDAD_ACTUAL.Size = new System.Drawing.Size(153, 22);
            this.NDW_CANTIDAD_ACTUAL.TabIndex = 12;
            this.NDW_CANTIDAD_ACTUAL.ValueChanged += new System.EventHandler(this.NDW_CANTIDAD_ACTUAL_ValueChanged);
            // 
            // DTP_FECHADEREPOSICION
            // 
            this.DTP_FECHADEREPOSICION.Enabled = false;
            this.DTP_FECHADEREPOSICION.Location = new System.Drawing.Point(177, 179);
            this.DTP_FECHADEREPOSICION.Name = "DTP_FECHADEREPOSICION";
            this.DTP_FECHADEREPOSICION.Size = new System.Drawing.Size(200, 20);
            this.DTP_FECHADEREPOSICION.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha de reposicion:";
            // 
            // TXT_MARCA_RENOVAR
            // 
            this.TXT_MARCA_RENOVAR.Enabled = false;
            this.TXT_MARCA_RENOVAR.Location = new System.Drawing.Point(134, 133);
            this.TXT_MARCA_RENOVAR.Name = "TXT_MARCA_RENOVAR";
            this.TXT_MARCA_RENOVAR.ReadOnly = true;
            this.TXT_MARCA_RENOVAR.Size = new System.Drawing.Size(243, 20);
            this.TXT_MARCA_RENOVAR.TabIndex = 9;
            // 
            // LBL_MARCA_PRODUCTO
            // 
            this.LBL_MARCA_PRODUCTO.AutoSize = true;
            this.LBL_MARCA_PRODUCTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MARCA_PRODUCTO.Location = new System.Drawing.Point(88, 136);
            this.LBL_MARCA_PRODUCTO.Name = "LBL_MARCA_PRODUCTO";
            this.LBL_MARCA_PRODUCTO.Size = new System.Drawing.Size(40, 13);
            this.LBL_MARCA_PRODUCTO.TabIndex = 8;
            this.LBL_MARCA_PRODUCTO.Text = "Marca:";
            // 
            // TXT_NOMBRE_RENOVAR
            // 
            this.TXT_NOMBRE_RENOVAR.Enabled = false;
            this.TXT_NOMBRE_RENOVAR.Location = new System.Drawing.Point(134, 73);
            this.TXT_NOMBRE_RENOVAR.Multiline = true;
            this.TXT_NOMBRE_RENOVAR.Name = "TXT_NOMBRE_RENOVAR";
            this.TXT_NOMBRE_RENOVAR.ReadOnly = true;
            this.TXT_NOMBRE_RENOVAR.Size = new System.Drawing.Size(243, 46);
            this.TXT_NOMBRE_RENOVAR.TabIndex = 5;
            // 
            // LBL_NOMBRE_PRODUCTO
            // 
            this.LBL_NOMBRE_PRODUCTO.AutoSize = true;
            this.LBL_NOMBRE_PRODUCTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NOMBRE_PRODUCTO.Location = new System.Drawing.Point(78, 76);
            this.LBL_NOMBRE_PRODUCTO.Name = "LBL_NOMBRE_PRODUCTO";
            this.LBL_NOMBRE_PRODUCTO.Size = new System.Drawing.Size(50, 13);
            this.LBL_NOMBRE_PRODUCTO.TabIndex = 4;
            this.LBL_NOMBRE_PRODUCTO.Text = "Nombre :";
            // 
            // TXT_RENOVAR_CODIGODEBARRA
            // 
            this.TXT_RENOVAR_CODIGODEBARRA.Enabled = false;
            this.TXT_RENOVAR_CODIGODEBARRA.Location = new System.Drawing.Point(134, 32);
            this.TXT_RENOVAR_CODIGODEBARRA.Name = "TXT_RENOVAR_CODIGODEBARRA";
            this.TXT_RENOVAR_CODIGODEBARRA.ReadOnly = true;
            this.TXT_RENOVAR_CODIGODEBARRA.Size = new System.Drawing.Size(243, 20);
            this.TXT_RENOVAR_CODIGODEBARRA.TabIndex = 1;
            // 
            // LBL_CODIGODEBARRAS
            // 
            this.LBL_CODIGODEBARRAS.AutoSize = true;
            this.LBL_CODIGODEBARRAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CODIGODEBARRAS.Location = new System.Drawing.Point(37, 35);
            this.LBL_CODIGODEBARRAS.Name = "LBL_CODIGODEBARRAS";
            this.LBL_CODIGODEBARRAS.Size = new System.Drawing.Size(91, 13);
            this.LBL_CODIGODEBARRAS.TabIndex = 0;
            this.LBL_CODIGODEBARRAS.Text = "Codigo de Barras:";
            // 
            // LBL_PROVEEDOR_NUEVO
            // 
            this.LBL_PROVEEDOR_NUEVO.AutoSize = true;
            this.LBL_PROVEEDOR_NUEVO.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PROVEEDOR_NUEVO.Location = new System.Drawing.Point(83, 22);
            this.LBL_PROVEEDOR_NUEVO.Name = "LBL_PROVEEDOR_NUEVO";
            this.LBL_PROVEEDOR_NUEVO.Size = new System.Drawing.Size(335, 50);
            this.LBL_PROVEEDOR_NUEVO.TabIndex = 26;
            this.LBL_PROVEEDOR_NUEVO.Text = "Renovar Producto";
            this.LBL_PROVEEDOR_NUEVO.Click += new System.EventHandler(this.LBL_PROVEEDOR_NUEVO_Click);
            // 
            // PIC_BOX_NUEVOPROVEEDOR
            // 
            this.PIC_BOX_NUEVOPROVEEDOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PIC_BOX_NUEVOPROVEEDOR.Image = ((System.Drawing.Image)(resources.GetObject("PIC_BOX_NUEVOPROVEEDOR.Image")));
            this.PIC_BOX_NUEVOPROVEEDOR.Location = new System.Drawing.Point(12, 12);
            this.PIC_BOX_NUEVOPROVEEDOR.Name = "PIC_BOX_NUEVOPROVEEDOR";
            this.PIC_BOX_NUEVOPROVEEDOR.Size = new System.Drawing.Size(65, 70);
            this.PIC_BOX_NUEVOPROVEEDOR.TabIndex = 25;
            this.PIC_BOX_NUEVOPROVEEDOR.TabStop = false;
            this.PIC_BOX_NUEVOPROVEEDOR.WaitOnLoad = true;
            // 
            // RenovarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(492, 475);
            this.Controls.Add(this.BTN_LIMPIAR_PRODUCTO);
            this.Controls.Add(this.BTN_GUARDAR_PRODUCTO);
            this.Controls.Add(this.GB_DATOS_PROVEEDOR);
            this.Controls.Add(this.LBL_PROVEEDOR_NUEVO);
            this.Controls.Add(this.PIC_BOX_NUEVOPROVEEDOR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RenovarInventario";
            this.Text = "Renovar Producto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RenovarInventario_FormClosed);
            this.Load += new System.EventHandler(this.RenovarInventario_Load);
            this.GB_DATOS_PROVEEDOR.ResumeLayout(false);
            this.GB_DATOS_PROVEEDOR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NDW_AGREGAR_CANTIDAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NDW_CANTIDAD_ACTUAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_BOX_NUEVOPROVEEDOR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_LIMPIAR_PRODUCTO;
        private System.Windows.Forms.Button BTN_GUARDAR_PRODUCTO;
        private System.Windows.Forms.GroupBox GB_DATOS_PROVEEDOR;
        private System.Windows.Forms.TextBox TXT_MARCA_RENOVAR;
        private System.Windows.Forms.Label LBL_MARCA_PRODUCTO;
        private System.Windows.Forms.TextBox TXT_NOMBRE_RENOVAR;
        private System.Windows.Forms.Label LBL_NOMBRE_PRODUCTO;
        private System.Windows.Forms.TextBox TXT_RENOVAR_CODIGODEBARRA;
        private System.Windows.Forms.Label LBL_CODIGODEBARRAS;
        private System.Windows.Forms.Label LBL_PROVEEDOR_NUEVO;
        private System.Windows.Forms.PictureBox PIC_BOX_NUEVOPROVEEDOR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NDW_AGREGAR_CANTIDAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NDW_CANTIDAD_ACTUAL;
        private System.Windows.Forms.DateTimePicker DTP_FECHADEREPOSICION;
        private System.Windows.Forms.Label label1;
    }
}