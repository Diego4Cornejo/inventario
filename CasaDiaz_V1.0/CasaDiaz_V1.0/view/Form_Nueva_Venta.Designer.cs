namespace CasaDiaz_V1._0.view
{
    partial class Form_Nueva_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Nueva_Venta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LBL_VENTA_NUEVA = new System.Windows.Forms.Label();
            this.PIC_BOX_NUEVOVENTA = new System.Windows.Forms.PictureBox();
            this.GB_DATOS_CLIENTES = new System.Windows.Forms.GroupBox();
            this.TXT_NOMBRE_CLIENTE = new System.Windows.Forms.TextBox();
            this.LBL_NOMBRE_CLIENTE = new System.Windows.Forms.Label();
            this.TXT_DV_CLIENTE = new System.Windows.Forms.TextBox();
            this.LBL_GUION_CLIENTE = new System.Windows.Forms.Label();
            this.TXT_RUT_CLIENTE = new System.Windows.Forms.TextBox();
            this.LBL_RUT_CLIENTE = new System.Windows.Forms.Label();
            this.GB_PRODUCTOS_VENTA = new System.Windows.Forms.GroupBox();
            this.TXT_LISTA_DEPRODUCTOS = new System.Windows.Forms.Button();
            this.TXT_DETALLES_PRODUCTO = new System.Windows.Forms.Button();
            this.BTN_BORRAR_PRODUCTO = new System.Windows.Forms.Button();
            this.BTN_AGREGAR_PRODUCTO = new System.Windows.Forms.Button();
            this.NDW_CANTIDAD = new System.Windows.Forms.NumericUpDown();
            this.LBL_CANTIDAD = new System.Windows.Forms.Label();
            this.TXT_CODIGODEBARRA = new System.Windows.Forms.TextBox();
            this.LBL_CODIGODEBARRA = new System.Windows.Forms.Label();
            this.DGV_VENTA = new System.Windows.Forms.DataGridView();
            this.PRO_PRODUCTOS_CODIGODEBARRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRODUCTOS_NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRODUCTOS_PRECIOVENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENTA_PRODUCTOS_CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRODUCTOS_STOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GB_TOTALVENTA = new System.Windows.Forms.GroupBox();
            this.TXT_VUELTO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_PAGO_VENTA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_TOTAL_VENTA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_GUARDAR = new System.Windows.Forms.Button();
            this.BTN_LIMPIAR = new System.Windows.Forms.Button();
            this.DTP_FECHAACTUAL = new System.Windows.Forms.DateTimePicker();
            this.GB_FECHADEVENTA = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LBL_NUMERO_DEVENTA = new System.Windows.Forms.Label();
            this.LBL_NUMERODEVENTA = new System.Windows.Forms.Label();
            this.RB_NOREGISTRAR = new System.Windows.Forms.RadioButton();
            this.RB_CLIENTE_REGISTRARCLIENTE = new System.Windows.Forms.RadioButton();
            this.RB_CLIENTE_YAREGISTRADO = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_BOX_NUEVOVENTA)).BeginInit();
            this.GB_DATOS_CLIENTES.SuspendLayout();
            this.GB_PRODUCTOS_VENTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NDW_CANTIDAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VENTA)).BeginInit();
            this.GB_TOTALVENTA.SuspendLayout();
            this.GB_FECHADEVENTA.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_VENTA_NUEVA
            // 
            this.LBL_VENTA_NUEVA.AutoSize = true;
            this.LBL_VENTA_NUEVA.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_VENTA_NUEVA.Location = new System.Drawing.Point(83, 23);
            this.LBL_VENTA_NUEVA.Name = "LBL_VENTA_NUEVA";
            this.LBL_VENTA_NUEVA.Size = new System.Drawing.Size(241, 50);
            this.LBL_VENTA_NUEVA.TabIndex = 16;
            this.LBL_VENTA_NUEVA.Text = "Nueva Venta";
            this.LBL_VENTA_NUEVA.Click += new System.EventHandler(this.LBL_VENTA_NUEVA_Click);
            // 
            // PIC_BOX_NUEVOVENTA
            // 
            this.PIC_BOX_NUEVOVENTA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PIC_BOX_NUEVOVENTA.Image = ((System.Drawing.Image)(resources.GetObject("PIC_BOX_NUEVOVENTA.Image")));
            this.PIC_BOX_NUEVOVENTA.Location = new System.Drawing.Point(12, 12);
            this.PIC_BOX_NUEVOVENTA.Name = "PIC_BOX_NUEVOVENTA";
            this.PIC_BOX_NUEVOVENTA.Size = new System.Drawing.Size(65, 70);
            this.PIC_BOX_NUEVOVENTA.TabIndex = 15;
            this.PIC_BOX_NUEVOVENTA.TabStop = false;
            this.PIC_BOX_NUEVOVENTA.WaitOnLoad = true;
            // 
            // GB_DATOS_CLIENTES
            // 
            this.GB_DATOS_CLIENTES.Controls.Add(this.RB_CLIENTE_YAREGISTRADO);
            this.GB_DATOS_CLIENTES.Controls.Add(this.RB_CLIENTE_REGISTRARCLIENTE);
            this.GB_DATOS_CLIENTES.Controls.Add(this.RB_NOREGISTRAR);
            this.GB_DATOS_CLIENTES.Controls.Add(this.TXT_NOMBRE_CLIENTE);
            this.GB_DATOS_CLIENTES.Controls.Add(this.LBL_NOMBRE_CLIENTE);
            this.GB_DATOS_CLIENTES.Controls.Add(this.TXT_DV_CLIENTE);
            this.GB_DATOS_CLIENTES.Controls.Add(this.LBL_GUION_CLIENTE);
            this.GB_DATOS_CLIENTES.Controls.Add(this.TXT_RUT_CLIENTE);
            this.GB_DATOS_CLIENTES.Controls.Add(this.LBL_RUT_CLIENTE);
            this.GB_DATOS_CLIENTES.Location = new System.Drawing.Point(12, 101);
            this.GB_DATOS_CLIENTES.Name = "GB_DATOS_CLIENTES";
            this.GB_DATOS_CLIENTES.Size = new System.Drawing.Size(682, 126);
            this.GB_DATOS_CLIENTES.TabIndex = 17;
            this.GB_DATOS_CLIENTES.TabStop = false;
            this.GB_DATOS_CLIENTES.Text = "Datos Clientes:";
            // 
            // TXT_NOMBRE_CLIENTE
            // 
            this.TXT_NOMBRE_CLIENTE.Enabled = false;
            this.TXT_NOMBRE_CLIENTE.Location = new System.Drawing.Point(403, 72);
            this.TXT_NOMBRE_CLIENTE.Name = "TXT_NOMBRE_CLIENTE";
            this.TXT_NOMBRE_CLIENTE.Size = new System.Drawing.Size(194, 20);
            this.TXT_NOMBRE_CLIENTE.TabIndex = 6;
            // 
            // LBL_NOMBRE_CLIENTE
            // 
            this.LBL_NOMBRE_CLIENTE.AutoSize = true;
            this.LBL_NOMBRE_CLIENTE.Location = new System.Drawing.Point(350, 76);
            this.LBL_NOMBRE_CLIENTE.Name = "LBL_NOMBRE_CLIENTE";
            this.LBL_NOMBRE_CLIENTE.Size = new System.Drawing.Size(47, 13);
            this.LBL_NOMBRE_CLIENTE.TabIndex = 5;
            this.LBL_NOMBRE_CLIENTE.Text = "Nombre:";
            // 
            // TXT_DV_CLIENTE
            // 
            this.TXT_DV_CLIENTE.Enabled = false;
            this.TXT_DV_CLIENTE.Location = new System.Drawing.Point(258, 72);
            this.TXT_DV_CLIENTE.Name = "TXT_DV_CLIENTE";
            this.TXT_DV_CLIENTE.Size = new System.Drawing.Size(32, 20);
            this.TXT_DV_CLIENTE.TabIndex = 4;
            // 
            // LBL_GUION_CLIENTE
            // 
            this.LBL_GUION_CLIENTE.AutoSize = true;
            this.LBL_GUION_CLIENTE.Location = new System.Drawing.Point(242, 75);
            this.LBL_GUION_CLIENTE.Name = "LBL_GUION_CLIENTE";
            this.LBL_GUION_CLIENTE.Size = new System.Drawing.Size(10, 13);
            this.LBL_GUION_CLIENTE.TabIndex = 3;
            this.LBL_GUION_CLIENTE.Text = "-";
            // 
            // TXT_RUT_CLIENTE
            // 
            this.TXT_RUT_CLIENTE.Enabled = false;
            this.TXT_RUT_CLIENTE.Location = new System.Drawing.Point(86, 72);
            this.TXT_RUT_CLIENTE.Name = "TXT_RUT_CLIENTE";
            this.TXT_RUT_CLIENTE.Size = new System.Drawing.Size(150, 20);
            this.TXT_RUT_CLIENTE.TabIndex = 2;
            // 
            // LBL_RUT_CLIENTE
            // 
            this.LBL_RUT_CLIENTE.AutoSize = true;
            this.LBL_RUT_CLIENTE.Location = new System.Drawing.Point(53, 76);
            this.LBL_RUT_CLIENTE.Name = "LBL_RUT_CLIENTE";
            this.LBL_RUT_CLIENTE.Size = new System.Drawing.Size(27, 13);
            this.LBL_RUT_CLIENTE.TabIndex = 1;
            this.LBL_RUT_CLIENTE.Text = "Rut:";
            this.LBL_RUT_CLIENTE.Click += new System.EventHandler(this.label1_Click);
            // 
            // GB_PRODUCTOS_VENTA
            // 
            this.GB_PRODUCTOS_VENTA.Controls.Add(this.TXT_LISTA_DEPRODUCTOS);
            this.GB_PRODUCTOS_VENTA.Controls.Add(this.TXT_DETALLES_PRODUCTO);
            this.GB_PRODUCTOS_VENTA.Controls.Add(this.BTN_BORRAR_PRODUCTO);
            this.GB_PRODUCTOS_VENTA.Controls.Add(this.BTN_AGREGAR_PRODUCTO);
            this.GB_PRODUCTOS_VENTA.Controls.Add(this.NDW_CANTIDAD);
            this.GB_PRODUCTOS_VENTA.Controls.Add(this.LBL_CANTIDAD);
            this.GB_PRODUCTOS_VENTA.Controls.Add(this.TXT_CODIGODEBARRA);
            this.GB_PRODUCTOS_VENTA.Controls.Add(this.LBL_CODIGODEBARRA);
            this.GB_PRODUCTOS_VENTA.Controls.Add(this.DGV_VENTA);
            this.GB_PRODUCTOS_VENTA.Location = new System.Drawing.Point(12, 233);
            this.GB_PRODUCTOS_VENTA.Name = "GB_PRODUCTOS_VENTA";
            this.GB_PRODUCTOS_VENTA.Size = new System.Drawing.Size(682, 438);
            this.GB_PRODUCTOS_VENTA.TabIndex = 18;
            this.GB_PRODUCTOS_VENTA.TabStop = false;
            this.GB_PRODUCTOS_VENTA.Text = "Productos";
            // 
            // TXT_LISTA_DEPRODUCTOS
            // 
            this.TXT_LISTA_DEPRODUCTOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TXT_LISTA_DEPRODUCTOS.Image = ((System.Drawing.Image)(resources.GetObject("TXT_LISTA_DEPRODUCTOS.Image")));
            this.TXT_LISTA_DEPRODUCTOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TXT_LISTA_DEPRODUCTOS.Location = new System.Drawing.Point(380, 354);
            this.TXT_LISTA_DEPRODUCTOS.Name = "TXT_LISTA_DEPRODUCTOS";
            this.TXT_LISTA_DEPRODUCTOS.Size = new System.Drawing.Size(101, 78);
            this.TXT_LISTA_DEPRODUCTOS.TabIndex = 27;
            this.TXT_LISTA_DEPRODUCTOS.Text = "Lista de productos";
            this.TXT_LISTA_DEPRODUCTOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TXT_LISTA_DEPRODUCTOS.UseVisualStyleBackColor = true;
            this.TXT_LISTA_DEPRODUCTOS.Click += new System.EventHandler(this.button2_Click);
            // 
            // TXT_DETALLES_PRODUCTO
            // 
            this.TXT_DETALLES_PRODUCTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TXT_DETALLES_PRODUCTO.Image = ((System.Drawing.Image)(resources.GetObject("TXT_DETALLES_PRODUCTO.Image")));
            this.TXT_DETALLES_PRODUCTO.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TXT_DETALLES_PRODUCTO.Location = new System.Drawing.Point(269, 354);
            this.TXT_DETALLES_PRODUCTO.Name = "TXT_DETALLES_PRODUCTO";
            this.TXT_DETALLES_PRODUCTO.Size = new System.Drawing.Size(101, 78);
            this.TXT_DETALLES_PRODUCTO.TabIndex = 26;
            this.TXT_DETALLES_PRODUCTO.Text = "Detalles del producto";
            this.TXT_DETALLES_PRODUCTO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TXT_DETALLES_PRODUCTO.UseVisualStyleBackColor = true;
            // 
            // BTN_BORRAR_PRODUCTO
            // 
            this.BTN_BORRAR_PRODUCTO.Enabled = false;
            this.BTN_BORRAR_PRODUCTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BORRAR_PRODUCTO.Image = ((System.Drawing.Image)(resources.GetObject("BTN_BORRAR_PRODUCTO.Image")));
            this.BTN_BORRAR_PRODUCTO.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_BORRAR_PRODUCTO.Location = new System.Drawing.Point(158, 354);
            this.BTN_BORRAR_PRODUCTO.Name = "BTN_BORRAR_PRODUCTO";
            this.BTN_BORRAR_PRODUCTO.Size = new System.Drawing.Size(101, 78);
            this.BTN_BORRAR_PRODUCTO.TabIndex = 25;
            this.BTN_BORRAR_PRODUCTO.Text = "Eliminar";
            this.BTN_BORRAR_PRODUCTO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_BORRAR_PRODUCTO.UseVisualStyleBackColor = true;
            this.BTN_BORRAR_PRODUCTO.Click += new System.EventHandler(this.BTN_BORRAR_PRODUCTO_Click);
            // 
            // BTN_AGREGAR_PRODUCTO
            // 
            this.BTN_AGREGAR_PRODUCTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AGREGAR_PRODUCTO.Image = ((System.Drawing.Image)(resources.GetObject("BTN_AGREGAR_PRODUCTO.Image")));
            this.BTN_AGREGAR_PRODUCTO.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_AGREGAR_PRODUCTO.Location = new System.Drawing.Point(554, 10);
            this.BTN_AGREGAR_PRODUCTO.Name = "BTN_AGREGAR_PRODUCTO";
            this.BTN_AGREGAR_PRODUCTO.Size = new System.Drawing.Size(101, 66);
            this.BTN_AGREGAR_PRODUCTO.TabIndex = 24;
            this.BTN_AGREGAR_PRODUCTO.Text = "Agregar";
            this.BTN_AGREGAR_PRODUCTO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_AGREGAR_PRODUCTO.UseVisualStyleBackColor = true;
            this.BTN_AGREGAR_PRODUCTO.Click += new System.EventHandler(this.BTN_AGREGAR_PRODUCTO_Click);
            // 
            // NDW_CANTIDAD
            // 
            this.NDW_CANTIDAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NDW_CANTIDAD.Location = new System.Drawing.Point(468, 23);
            this.NDW_CANTIDAD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NDW_CANTIDAD.Name = "NDW_CANTIDAD";
            this.NDW_CANTIDAD.Size = new System.Drawing.Size(64, 31);
            this.NDW_CANTIDAD.TabIndex = 12;
            this.NDW_CANTIDAD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LBL_CANTIDAD
            // 
            this.LBL_CANTIDAD.AutoSize = true;
            this.LBL_CANTIDAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CANTIDAD.Location = new System.Drawing.Point(376, 29);
            this.LBL_CANTIDAD.Name = "LBL_CANTIDAD";
            this.LBL_CANTIDAD.Size = new System.Drawing.Size(86, 20);
            this.LBL_CANTIDAD.TabIndex = 11;
            this.LBL_CANTIDAD.Text = "Cantidad:";
            // 
            // TXT_CODIGODEBARRA
            // 
            this.TXT_CODIGODEBARRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CODIGODEBARRA.Location = new System.Drawing.Point(184, 22);
            this.TXT_CODIGODEBARRA.Name = "TXT_CODIGODEBARRA";
            this.TXT_CODIGODEBARRA.Size = new System.Drawing.Size(186, 31);
            this.TXT_CODIGODEBARRA.TabIndex = 10;
            this.TXT_CODIGODEBARRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_CODIGODEBARRA.TextChanged += new System.EventHandler(this.TXT_CODIGODEBARRA_TextChanged);
            this.TXT_CODIGODEBARRA.Leave += new System.EventHandler(this.TXT_CODIGODEBARRA_Leave);
            // 
            // LBL_CODIGODEBARRA
            // 
            this.LBL_CODIGODEBARRA.AutoSize = true;
            this.LBL_CODIGODEBARRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CODIGODEBARRA.Location = new System.Drawing.Point(22, 26);
            this.LBL_CODIGODEBARRA.Name = "LBL_CODIGODEBARRA";
            this.LBL_CODIGODEBARRA.Size = new System.Drawing.Size(156, 20);
            this.LBL_CODIGODEBARRA.TabIndex = 1;
            this.LBL_CODIGODEBARRA.Text = "Codigo De Barras:";
            // 
            // DGV_VENTA
            // 
            this.DGV_VENTA.AllowUserToAddRows = false;
            this.DGV_VENTA.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_VENTA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_VENTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VENTA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRO_PRODUCTOS_CODIGODEBARRA,
            this.PRO_PRODUCTOS_NOMBRE,
            this.PRO_PRODUCTOS_PRECIOVENTA,
            this.VENTA_PRODUCTOS_CANTIDAD,
            this.PRO_PRODUCTOS_STOCK});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_VENTA.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_VENTA.Location = new System.Drawing.Point(6, 82);
            this.DGV_VENTA.Name = "DGV_VENTA";
            this.DGV_VENTA.ReadOnly = true;
            this.DGV_VENTA.Size = new System.Drawing.Size(670, 266);
            this.DGV_VENTA.TabIndex = 0;
            this.DGV_VENTA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_VENTA_CellClick);
            // 
            // PRO_PRODUCTOS_CODIGODEBARRA
            // 
            this.PRO_PRODUCTOS_CODIGODEBARRA.HeaderText = "Codigo de barras";
            this.PRO_PRODUCTOS_CODIGODEBARRA.Name = "PRO_PRODUCTOS_CODIGODEBARRA";
            this.PRO_PRODUCTOS_CODIGODEBARRA.ReadOnly = true;
            this.PRO_PRODUCTOS_CODIGODEBARRA.Width = 133;
            // 
            // PRO_PRODUCTOS_NOMBRE
            // 
            this.PRO_PRODUCTOS_NOMBRE.HeaderText = "Nombre del producto";
            this.PRO_PRODUCTOS_NOMBRE.Name = "PRO_PRODUCTOS_NOMBRE";
            this.PRO_PRODUCTOS_NOMBRE.ReadOnly = true;
            this.PRO_PRODUCTOS_NOMBRE.Width = 192;
            // 
            // PRO_PRODUCTOS_PRECIOVENTA
            // 
            this.PRO_PRODUCTOS_PRECIOVENTA.HeaderText = "Precio";
            this.PRO_PRODUCTOS_PRECIOVENTA.Name = "PRO_PRODUCTOS_PRECIOVENTA";
            this.PRO_PRODUCTOS_PRECIOVENTA.ReadOnly = true;
            // 
            // VENTA_PRODUCTOS_CANTIDAD
            // 
            this.VENTA_PRODUCTOS_CANTIDAD.HeaderText = "Cantidad";
            this.VENTA_PRODUCTOS_CANTIDAD.Name = "VENTA_PRODUCTOS_CANTIDAD";
            this.VENTA_PRODUCTOS_CANTIDAD.ReadOnly = true;
            // 
            // PRO_PRODUCTOS_STOCK
            // 
            this.PRO_PRODUCTOS_STOCK.HeaderText = "Stock";
            this.PRO_PRODUCTOS_STOCK.Name = "PRO_PRODUCTOS_STOCK";
            this.PRO_PRODUCTOS_STOCK.ReadOnly = true;
            // 
            // GB_TOTALVENTA
            // 
            this.GB_TOTALVENTA.Controls.Add(this.TXT_VUELTO);
            this.GB_TOTALVENTA.Controls.Add(this.label5);
            this.GB_TOTALVENTA.Controls.Add(this.label6);
            this.GB_TOTALVENTA.Controls.Add(this.TXT_PAGO_VENTA);
            this.GB_TOTALVENTA.Controls.Add(this.label3);
            this.GB_TOTALVENTA.Controls.Add(this.label4);
            this.GB_TOTALVENTA.Controls.Add(this.TXT_TOTAL_VENTA);
            this.GB_TOTALVENTA.Controls.Add(this.label2);
            this.GB_TOTALVENTA.Controls.Add(this.label1);
            this.GB_TOTALVENTA.Location = new System.Drawing.Point(718, 101);
            this.GB_TOTALVENTA.Name = "GB_TOTALVENTA";
            this.GB_TOTALVENTA.Size = new System.Drawing.Size(293, 225);
            this.GB_TOTALVENTA.TabIndex = 19;
            this.GB_TOTALVENTA.TabStop = false;
            this.GB_TOTALVENTA.Text = "Total Venta";
            // 
            // TXT_VUELTO
            // 
            this.TXT_VUELTO.Enabled = false;
            this.TXT_VUELTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_VUELTO.Location = new System.Drawing.Point(84, 158);
            this.TXT_VUELTO.Name = "TXT_VUELTO";
            this.TXT_VUELTO.ReadOnly = true;
            this.TXT_VUELTO.Size = new System.Drawing.Size(186, 35);
            this.TXT_VUELTO.TabIndex = 9;
            this.TXT_VUELTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Vuelto:";
            // 
            // TXT_PAGO_VENTA
            // 
            this.TXT_PAGO_VENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PAGO_VENTA.Location = new System.Drawing.Point(84, 99);
            this.TXT_PAGO_VENTA.Name = "TXT_PAGO_VENTA";
            this.TXT_PAGO_VENTA.Size = new System.Drawing.Size(186, 35);
            this.TXT_PAGO_VENTA.TabIndex = 6;
            this.TXT_PAGO_VENTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_PAGO_VENTA.Leave += new System.EventHandler(this.TXT_PAGO_VENTA_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pago:";
            // 
            // TXT_TOTAL_VENTA
            // 
            this.TXT_TOTAL_VENTA.Enabled = false;
            this.TXT_TOTAL_VENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_TOTAL_VENTA.Location = new System.Drawing.Point(84, 37);
            this.TXT_TOTAL_VENTA.Name = "TXT_TOTAL_VENTA";
            this.TXT_TOTAL_VENTA.ReadOnly = true;
            this.TXT_TOTAL_VENTA.Size = new System.Drawing.Size(186, 35);
            this.TXT_TOTAL_VENTA.TabIndex = 3;
            this.TXT_TOTAL_VENTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_GUARDAR.Image = ((System.Drawing.Image)(resources.GetObject("BTN_GUARDAR.Image")));
            this.BTN_GUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_GUARDAR.Location = new System.Drawing.Point(773, 332);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(129, 106);
            this.BTN_GUARDAR.TabIndex = 20;
            this.BTN_GUARDAR.Text = "Guardar";
            this.BTN_GUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_GUARDAR.UseVisualStyleBackColor = true;
            this.BTN_GUARDAR.Click += new System.EventHandler(this.BTN_GUARDAR_Click);
            // 
            // BTN_LIMPIAR
            // 
            this.BTN_LIMPIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LIMPIAR.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LIMPIAR.Image")));
            this.BTN_LIMPIAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_LIMPIAR.Location = new System.Drawing.Point(908, 354);
            this.BTN_LIMPIAR.Name = "BTN_LIMPIAR";
            this.BTN_LIMPIAR.Size = new System.Drawing.Size(80, 60);
            this.BTN_LIMPIAR.TabIndex = 21;
            this.BTN_LIMPIAR.Text = "Limpiar";
            this.BTN_LIMPIAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_LIMPIAR.UseVisualStyleBackColor = true;
            // 
            // DTP_FECHAACTUAL
            // 
            this.DTP_FECHAACTUAL.Location = new System.Drawing.Point(83, 25);
            this.DTP_FECHAACTUAL.Name = "DTP_FECHAACTUAL";
            this.DTP_FECHAACTUAL.Size = new System.Drawing.Size(200, 20);
            this.DTP_FECHAACTUAL.TabIndex = 22;
            // 
            // GB_FECHADEVENTA
            // 
            this.GB_FECHADEVENTA.Controls.Add(this.label7);
            this.GB_FECHADEVENTA.Controls.Add(this.DTP_FECHAACTUAL);
            this.GB_FECHADEVENTA.Location = new System.Drawing.Point(718, 614);
            this.GB_FECHADEVENTA.Name = "GB_FECHADEVENTA";
            this.GB_FECHADEVENTA.Size = new System.Drawing.Size(292, 57);
            this.GB_FECHADEVENTA.TabIndex = 23;
            this.GB_FECHADEVENTA.TabStop = false;
            this.GB_FECHADEVENTA.Text = "Fecha de venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fecha:";
            // 
            // LBL_NUMERO_DEVENTA
            // 
            this.LBL_NUMERO_DEVENTA.AutoSize = true;
            this.LBL_NUMERO_DEVENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NUMERO_DEVENTA.Location = new System.Drawing.Point(849, 12);
            this.LBL_NUMERO_DEVENTA.Name = "LBL_NUMERO_DEVENTA";
            this.LBL_NUMERO_DEVENTA.Size = new System.Drawing.Size(116, 16);
            this.LBL_NUMERO_DEVENTA.TabIndex = 24;
            this.LBL_NUMERO_DEVENTA.Text = "Numero de Venta:";
            this.LBL_NUMERO_DEVENTA.Click += new System.EventHandler(this.label8_Click);
            // 
            // LBL_NUMERODEVENTA
            // 
            this.LBL_NUMERODEVENTA.AutoSize = true;
            this.LBL_NUMERODEVENTA.BackColor = System.Drawing.Color.Gray;
            this.LBL_NUMERODEVENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NUMERODEVENTA.Location = new System.Drawing.Point(883, 36);
            this.LBL_NUMERODEVENTA.Name = "LBL_NUMERODEVENTA";
            this.LBL_NUMERODEVENTA.Size = new System.Drawing.Size(34, 37);
            this.LBL_NUMERODEVENTA.TabIndex = 25;
            this.LBL_NUMERODEVENTA.Text = "1";
            // 
            // RB_NOREGISTRAR
            // 
            this.RB_NOREGISTRAR.AutoSize = true;
            this.RB_NOREGISTRAR.Checked = true;
            this.RB_NOREGISTRAR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_NOREGISTRAR.Location = new System.Drawing.Point(70, 28);
            this.RB_NOREGISTRAR.Name = "RB_NOREGISTRAR";
            this.RB_NOREGISTRAR.Size = new System.Drawing.Size(150, 21);
            this.RB_NOREGISTRAR.TabIndex = 7;
            this.RB_NOREGISTRAR.TabStop = true;
            this.RB_NOREGISTRAR.Text = "No Registrar Cliente";
            this.RB_NOREGISTRAR.UseVisualStyleBackColor = true;
            // 
            // RB_CLIENTE_REGISTRARCLIENTE
            // 
            this.RB_CLIENTE_REGISTRARCLIENTE.AutoSize = true;
            this.RB_CLIENTE_REGISTRARCLIENTE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_CLIENTE_REGISTRARCLIENTE.Location = new System.Drawing.Point(286, 27);
            this.RB_CLIENTE_REGISTRARCLIENTE.Name = "RB_CLIENTE_REGISTRARCLIENTE";
            this.RB_CLIENTE_REGISTRARCLIENTE.Size = new System.Drawing.Size(126, 21);
            this.RB_CLIENTE_REGISTRARCLIENTE.TabIndex = 8;
            this.RB_CLIENTE_REGISTRARCLIENTE.Text = "Registrar cliente";
            this.RB_CLIENTE_REGISTRARCLIENTE.UseVisualStyleBackColor = true;
            // 
            // RB_CLIENTE_YAREGISTRADO
            // 
            this.RB_CLIENTE_YAREGISTRADO.AutoSize = true;
            this.RB_CLIENTE_YAREGISTRADO.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_CLIENTE_YAREGISTRADO.Location = new System.Drawing.Point(484, 28);
            this.RB_CLIENTE_YAREGISTRADO.Name = "RB_CLIENTE_YAREGISTRADO";
            this.RB_CLIENTE_YAREGISTRADO.Size = new System.Drawing.Size(154, 21);
            this.RB_CLIENTE_YAREGISTRADO.TabIndex = 9;
            this.RB_CLIENTE_YAREGISTRADO.Text = "Cliente ya registrado";
            this.RB_CLIENTE_YAREGISTRADO.UseVisualStyleBackColor = true;
            // 
            // Form_Nueva_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1023, 683);
            this.Controls.Add(this.LBL_NUMERODEVENTA);
            this.Controls.Add(this.LBL_NUMERO_DEVENTA);
            this.Controls.Add(this.GB_FECHADEVENTA);
            this.Controls.Add(this.BTN_LIMPIAR);
            this.Controls.Add(this.BTN_GUARDAR);
            this.Controls.Add(this.GB_TOTALVENTA);
            this.Controls.Add(this.GB_PRODUCTOS_VENTA);
            this.Controls.Add(this.GB_DATOS_CLIENTES);
            this.Controls.Add(this.LBL_VENTA_NUEVA);
            this.Controls.Add(this.PIC_BOX_NUEVOVENTA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Nueva_Venta";
            this.Text = "Nueva Venta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Nueva_Venta_FormClosed);
            this.Load += new System.EventHandler(this.Form_Nueva_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_BOX_NUEVOVENTA)).EndInit();
            this.GB_DATOS_CLIENTES.ResumeLayout(false);
            this.GB_DATOS_CLIENTES.PerformLayout();
            this.GB_PRODUCTOS_VENTA.ResumeLayout(false);
            this.GB_PRODUCTOS_VENTA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NDW_CANTIDAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VENTA)).EndInit();
            this.GB_TOTALVENTA.ResumeLayout(false);
            this.GB_TOTALVENTA.PerformLayout();
            this.GB_FECHADEVENTA.ResumeLayout(false);
            this.GB_FECHADEVENTA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_VENTA_NUEVA;
        private System.Windows.Forms.PictureBox PIC_BOX_NUEVOVENTA;
        private System.Windows.Forms.GroupBox GB_DATOS_CLIENTES;
        private System.Windows.Forms.TextBox TXT_NOMBRE_CLIENTE;
        private System.Windows.Forms.Label LBL_NOMBRE_CLIENTE;
        private System.Windows.Forms.TextBox TXT_DV_CLIENTE;
        private System.Windows.Forms.Label LBL_GUION_CLIENTE;
        private System.Windows.Forms.TextBox TXT_RUT_CLIENTE;
        private System.Windows.Forms.Label LBL_RUT_CLIENTE;
        private System.Windows.Forms.GroupBox GB_PRODUCTOS_VENTA;
        private System.Windows.Forms.DataGridView DGV_VENTA;
        private System.Windows.Forms.GroupBox GB_TOTALVENTA;
        private System.Windows.Forms.TextBox TXT_TOTAL_VENTA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_VUELTO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_PAGO_VENTA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_GUARDAR;
        private System.Windows.Forms.Button BTN_LIMPIAR;
        private System.Windows.Forms.DateTimePicker DTP_FECHAACTUAL;
        private System.Windows.Forms.GroupBox GB_FECHADEVENTA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_CODIGODEBARRA;
        private System.Windows.Forms.Label LBL_CODIGODEBARRA;
        private System.Windows.Forms.Label LBL_CANTIDAD;
        private System.Windows.Forms.NumericUpDown NDW_CANTIDAD;
        private System.Windows.Forms.Button BTN_AGREGAR_PRODUCTO;
        private System.Windows.Forms.Button BTN_BORRAR_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTOS_CODIGODEBARRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTOS_NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTOS_PRECIOVENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENTA_PRODUCTOS_CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTOS_STOCK;
        private System.Windows.Forms.Button TXT_LISTA_DEPRODUCTOS;
        private System.Windows.Forms.Button TXT_DETALLES_PRODUCTO;
        private System.Windows.Forms.Label LBL_NUMERO_DEVENTA;
        private System.Windows.Forms.Label LBL_NUMERODEVENTA;
        private System.Windows.Forms.RadioButton RB_CLIENTE_YAREGISTRADO;
        private System.Windows.Forms.RadioButton RB_CLIENTE_REGISTRARCLIENTE;
        private System.Windows.Forms.RadioButton RB_NOREGISTRAR;
    }
}