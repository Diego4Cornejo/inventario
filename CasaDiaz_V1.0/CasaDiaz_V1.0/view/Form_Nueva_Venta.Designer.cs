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
            this.LBL_VENTA_NUEVA = new System.Windows.Forms.Label();
            this.PIC_BOX_NUEVOVENTA = new System.Windows.Forms.PictureBox();
            this.GB_DATOS_CLIENTES = new System.Windows.Forms.GroupBox();
            this.CB_REGISTRARCLIENTE_VENTA = new System.Windows.Forms.CheckBox();
            this.LBL_GUION_CLIENTE = new System.Windows.Forms.Label();
            this.TXT_DV_CLIENTE = new System.Windows.Forms.TextBox();
            this.LBL_RUT_CLIENTE = new System.Windows.Forms.Label();
            this.TXT_RUT_CLIENTE = new System.Windows.Forms.TextBox();
            this.TXT_NOMBRE_CLIENTE = new System.Windows.Forms.TextBox();
            this.LBL_NOMBRE_CLIENTE = new System.Windows.Forms.Label();
            this.TXT_EMAILCLIENTE_VENTA = new System.Windows.Forms.TextBox();
            this.LBL_EMAIL_CLIENTE = new System.Windows.Forms.Label();
            this.GB_PRODUCTOS_VENTA = new System.Windows.Forms.GroupBox();
            this.DGV_VENTA = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_TOTAL_VENTA = new System.Windows.Forms.TextBox();
            this.TXT_PAGO_VENTA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_VUELTO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PRO_PRODUCTOS_CODIGODEBARRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRODUCTOS_NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRODUCTO_PRECIOVENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VE_VENTA_CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_GUARDAR = new System.Windows.Forms.Button();
            this.BTN_LIMPIAR = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.GB_FECHADEVENTA = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_BOX_NUEVOVENTA)).BeginInit();
            this.GB_DATOS_CLIENTES.SuspendLayout();
            this.GB_PRODUCTOS_VENTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VENTA)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.GB_DATOS_CLIENTES.Controls.Add(this.TXT_EMAILCLIENTE_VENTA);
            this.GB_DATOS_CLIENTES.Controls.Add(this.LBL_EMAIL_CLIENTE);
            this.GB_DATOS_CLIENTES.Controls.Add(this.TXT_NOMBRE_CLIENTE);
            this.GB_DATOS_CLIENTES.Controls.Add(this.CB_REGISTRARCLIENTE_VENTA);
            this.GB_DATOS_CLIENTES.Controls.Add(this.LBL_NOMBRE_CLIENTE);
            this.GB_DATOS_CLIENTES.Controls.Add(this.TXT_DV_CLIENTE);
            this.GB_DATOS_CLIENTES.Controls.Add(this.LBL_GUION_CLIENTE);
            this.GB_DATOS_CLIENTES.Controls.Add(this.TXT_RUT_CLIENTE);
            this.GB_DATOS_CLIENTES.Controls.Add(this.LBL_RUT_CLIENTE);
            this.GB_DATOS_CLIENTES.Location = new System.Drawing.Point(12, 101);
            this.GB_DATOS_CLIENTES.Name = "GB_DATOS_CLIENTES";
            this.GB_DATOS_CLIENTES.Size = new System.Drawing.Size(581, 126);
            this.GB_DATOS_CLIENTES.TabIndex = 17;
            this.GB_DATOS_CLIENTES.TabStop = false;
            this.GB_DATOS_CLIENTES.Text = "Datos Clientes:";
            // 
            // CB_REGISTRARCLIENTE_VENTA
            // 
            this.CB_REGISTRARCLIENTE_VENTA.AutoSize = true;
            this.CB_REGISTRARCLIENTE_VENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_REGISTRARCLIENTE_VENTA.Location = new System.Drawing.Point(26, 31);
            this.CB_REGISTRARCLIENTE_VENTA.Name = "CB_REGISTRARCLIENTE_VENTA";
            this.CB_REGISTRARCLIENTE_VENTA.Size = new System.Drawing.Size(163, 24);
            this.CB_REGISTRARCLIENTE_VENTA.TabIndex = 0;
            this.CB_REGISTRARCLIENTE_VENTA.Text = "Registrar Cliente";
            this.CB_REGISTRARCLIENTE_VENTA.UseVisualStyleBackColor = true;
            this.CB_REGISTRARCLIENTE_VENTA.CheckedChanged += new System.EventHandler(this.CB_REGISTRARCLIENTE_VENTA_CheckedChanged);
            // 
            // LBL_GUION_CLIENTE
            // 
            this.LBL_GUION_CLIENTE.AutoSize = true;
            this.LBL_GUION_CLIENTE.Location = new System.Drawing.Point(489, 36);
            this.LBL_GUION_CLIENTE.Name = "LBL_GUION_CLIENTE";
            this.LBL_GUION_CLIENTE.Size = new System.Drawing.Size(10, 13);
            this.LBL_GUION_CLIENTE.TabIndex = 3;
            this.LBL_GUION_CLIENTE.Text = "-";
            // 
            // TXT_DV_CLIENTE
            // 
            this.TXT_DV_CLIENTE.Enabled = false;
            this.TXT_DV_CLIENTE.Location = new System.Drawing.Point(505, 33);
            this.TXT_DV_CLIENTE.Name = "TXT_DV_CLIENTE";
            this.TXT_DV_CLIENTE.Size = new System.Drawing.Size(32, 20);
            this.TXT_DV_CLIENTE.TabIndex = 4;
            // 
            // LBL_RUT_CLIENTE
            // 
            this.LBL_RUT_CLIENTE.AutoSize = true;
            this.LBL_RUT_CLIENTE.Location = new System.Drawing.Point(300, 37);
            this.LBL_RUT_CLIENTE.Name = "LBL_RUT_CLIENTE";
            this.LBL_RUT_CLIENTE.Size = new System.Drawing.Size(27, 13);
            this.LBL_RUT_CLIENTE.TabIndex = 1;
            this.LBL_RUT_CLIENTE.Text = "Rut:";
            this.LBL_RUT_CLIENTE.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXT_RUT_CLIENTE
            // 
            this.TXT_RUT_CLIENTE.Enabled = false;
            this.TXT_RUT_CLIENTE.Location = new System.Drawing.Point(333, 33);
            this.TXT_RUT_CLIENTE.Name = "TXT_RUT_CLIENTE";
            this.TXT_RUT_CLIENTE.Size = new System.Drawing.Size(150, 20);
            this.TXT_RUT_CLIENTE.TabIndex = 2;
            // 
            // TXT_NOMBRE_CLIENTE
            // 
            this.TXT_NOMBRE_CLIENTE.Enabled = false;
            this.TXT_NOMBRE_CLIENTE.Location = new System.Drawing.Point(76, 74);
            this.TXT_NOMBRE_CLIENTE.Name = "TXT_NOMBRE_CLIENTE";
            this.TXT_NOMBRE_CLIENTE.Size = new System.Drawing.Size(194, 20);
            this.TXT_NOMBRE_CLIENTE.TabIndex = 6;
            // 
            // LBL_NOMBRE_CLIENTE
            // 
            this.LBL_NOMBRE_CLIENTE.AutoSize = true;
            this.LBL_NOMBRE_CLIENTE.Location = new System.Drawing.Point(23, 78);
            this.LBL_NOMBRE_CLIENTE.Name = "LBL_NOMBRE_CLIENTE";
            this.LBL_NOMBRE_CLIENTE.Size = new System.Drawing.Size(47, 13);
            this.LBL_NOMBRE_CLIENTE.TabIndex = 5;
            this.LBL_NOMBRE_CLIENTE.Text = "Nombre:";
            // 
            // TXT_EMAILCLIENTE_VENTA
            // 
            this.TXT_EMAILCLIENTE_VENTA.Enabled = false;
            this.TXT_EMAILCLIENTE_VENTA.Location = new System.Drawing.Point(330, 74);
            this.TXT_EMAILCLIENTE_VENTA.Name = "TXT_EMAILCLIENTE_VENTA";
            this.TXT_EMAILCLIENTE_VENTA.Size = new System.Drawing.Size(207, 20);
            this.TXT_EMAILCLIENTE_VENTA.TabIndex = 8;
            // 
            // LBL_EMAIL_CLIENTE
            // 
            this.LBL_EMAIL_CLIENTE.AutoSize = true;
            this.LBL_EMAIL_CLIENTE.Location = new System.Drawing.Point(289, 78);
            this.LBL_EMAIL_CLIENTE.Name = "LBL_EMAIL_CLIENTE";
            this.LBL_EMAIL_CLIENTE.Size = new System.Drawing.Size(35, 13);
            this.LBL_EMAIL_CLIENTE.TabIndex = 7;
            this.LBL_EMAIL_CLIENTE.Text = "Email:";
            // 
            // GB_PRODUCTOS_VENTA
            // 
            this.GB_PRODUCTOS_VENTA.Controls.Add(this.DGV_VENTA);
            this.GB_PRODUCTOS_VENTA.Location = new System.Drawing.Point(12, 233);
            this.GB_PRODUCTOS_VENTA.Name = "GB_PRODUCTOS_VENTA";
            this.GB_PRODUCTOS_VENTA.Size = new System.Drawing.Size(581, 413);
            this.GB_PRODUCTOS_VENTA.TabIndex = 18;
            this.GB_PRODUCTOS_VENTA.TabStop = false;
            this.GB_PRODUCTOS_VENTA.Text = "Productos";
            // 
            // DGV_VENTA
            // 
            this.DGV_VENTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VENTA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRO_PRODUCTOS_CODIGODEBARRA,
            this.PRO_PRODUCTOS_NOMBRE,
            this.PRO_PRODUCTO_PRECIOVENTA,
            this.VE_VENTA_CANTIDAD});
            this.DGV_VENTA.Location = new System.Drawing.Point(6, 19);
            this.DGV_VENTA.Name = "DGV_VENTA";
            this.DGV_VENTA.Size = new System.Drawing.Size(569, 388);
            this.DGV_VENTA.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_VUELTO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TXT_PAGO_VENTA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXT_TOTAL_VENTA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(599, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 225);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Venta";
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
            // TXT_PAGO_VENTA
            // 
            this.TXT_PAGO_VENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PAGO_VENTA.Location = new System.Drawing.Point(84, 99);
            this.TXT_PAGO_VENTA.Name = "TXT_PAGO_VENTA";
            this.TXT_PAGO_VENTA.Size = new System.Drawing.Size(186, 35);
            this.TXT_PAGO_VENTA.TabIndex = 6;
            this.TXT_PAGO_VENTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // TXT_VUELTO
            // 
            this.TXT_VUELTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_VUELTO.Location = new System.Drawing.Point(84, 158);
            this.TXT_VUELTO.Name = "TXT_VUELTO";
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
            // PRO_PRODUCTOS_CODIGODEBARRA
            // 
            this.PRO_PRODUCTOS_CODIGODEBARRA.HeaderText = "Codigo de barras";
            this.PRO_PRODUCTOS_CODIGODEBARRA.Name = "PRO_PRODUCTOS_CODIGODEBARRA";
            this.PRO_PRODUCTOS_CODIGODEBARRA.Width = 135;
            // 
            // PRO_PRODUCTOS_NOMBRE
            // 
            this.PRO_PRODUCTOS_NOMBRE.HeaderText = "Nombre del producto";
            this.PRO_PRODUCTOS_NOMBRE.Name = "PRO_PRODUCTOS_NOMBRE";
            this.PRO_PRODUCTOS_NOMBRE.Width = 170;
            // 
            // PRO_PRODUCTO_PRECIOVENTA
            // 
            this.PRO_PRODUCTO_PRECIOVENTA.HeaderText = "Precio";
            this.PRO_PRODUCTO_PRECIOVENTA.Name = "PRO_PRODUCTO_PRECIOVENTA";
            this.PRO_PRODUCTO_PRECIOVENTA.Width = 120;
            // 
            // VE_VENTA_CANTIDAD
            // 
            this.VE_VENTA_CANTIDAD.HeaderText = "Cantidad";
            this.VE_VENTA_CANTIDAD.Name = "VE_VENTA_CANTIDAD";
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_GUARDAR.Image = ((System.Drawing.Image)(resources.GetObject("BTN_GUARDAR.Image")));
            this.BTN_GUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_GUARDAR.Location = new System.Drawing.Point(654, 332);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(129, 106);
            this.BTN_GUARDAR.TabIndex = 20;
            this.BTN_GUARDAR.Text = "Guardar";
            this.BTN_GUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_GUARDAR.UseVisualStyleBackColor = true;
            // 
            // BTN_LIMPIAR
            // 
            this.BTN_LIMPIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LIMPIAR.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LIMPIAR.Image")));
            this.BTN_LIMPIAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_LIMPIAR.Location = new System.Drawing.Point(789, 354);
            this.BTN_LIMPIAR.Name = "BTN_LIMPIAR";
            this.BTN_LIMPIAR.Size = new System.Drawing.Size(80, 60);
            this.BTN_LIMPIAR.TabIndex = 21;
            this.BTN_LIMPIAR.Text = "Limpiar";
            this.BTN_LIMPIAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_LIMPIAR.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // GB_FECHADEVENTA
            // 
            this.GB_FECHADEVENTA.Controls.Add(this.label7);
            this.GB_FECHADEVENTA.Controls.Add(this.dateTimePicker1);
            this.GB_FECHADEVENTA.Location = new System.Drawing.Point(600, 583);
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
            // Form_Nueva_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(904, 658);
            this.Controls.Add(this.GB_FECHADEVENTA);
            this.Controls.Add(this.BTN_LIMPIAR);
            this.Controls.Add(this.BTN_GUARDAR);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GB_PRODUCTOS_VENTA);
            this.Controls.Add(this.GB_DATOS_CLIENTES);
            this.Controls.Add(this.LBL_VENTA_NUEVA);
            this.Controls.Add(this.PIC_BOX_NUEVOVENTA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Nueva_Venta";
            this.Text = "Form_Nueva_Venta";
            ((System.ComponentModel.ISupportInitialize)(this.PIC_BOX_NUEVOVENTA)).EndInit();
            this.GB_DATOS_CLIENTES.ResumeLayout(false);
            this.GB_DATOS_CLIENTES.PerformLayout();
            this.GB_PRODUCTOS_VENTA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VENTA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GB_FECHADEVENTA.ResumeLayout(false);
            this.GB_FECHADEVENTA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_VENTA_NUEVA;
        private System.Windows.Forms.PictureBox PIC_BOX_NUEVOVENTA;
        private System.Windows.Forms.GroupBox GB_DATOS_CLIENTES;
        private System.Windows.Forms.CheckBox CB_REGISTRARCLIENTE_VENTA;
        private System.Windows.Forms.TextBox TXT_EMAILCLIENTE_VENTA;
        private System.Windows.Forms.Label LBL_EMAIL_CLIENTE;
        private System.Windows.Forms.TextBox TXT_NOMBRE_CLIENTE;
        private System.Windows.Forms.Label LBL_NOMBRE_CLIENTE;
        private System.Windows.Forms.TextBox TXT_DV_CLIENTE;
        private System.Windows.Forms.Label LBL_GUION_CLIENTE;
        private System.Windows.Forms.TextBox TXT_RUT_CLIENTE;
        private System.Windows.Forms.Label LBL_RUT_CLIENTE;
        private System.Windows.Forms.GroupBox GB_PRODUCTOS_VENTA;
        private System.Windows.Forms.DataGridView DGV_VENTA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_TOTAL_VENTA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_VUELTO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_PAGO_VENTA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTOS_CODIGODEBARRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTOS_NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTO_PRECIOVENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VE_VENTA_CANTIDAD;
        private System.Windows.Forms.Button BTN_GUARDAR;
        private System.Windows.Forms.Button BTN_LIMPIAR;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox GB_FECHADEVENTA;
        private System.Windows.Forms.Label label7;
    }
}