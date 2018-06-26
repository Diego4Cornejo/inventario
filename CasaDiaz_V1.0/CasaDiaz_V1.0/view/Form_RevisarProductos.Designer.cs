namespace CasaDiaz_V1._0.view
{
    partial class Form_RevisarProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RevisarProductos));
            this.GB_INVENTARIOS_TABLA = new System.Windows.Forms.GroupBox();
            this.DGV_INVENTARIO = new System.Windows.Forms.DataGridView();
            this.PRO_PRODUCTOS_CODIGODEBARRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRODUCTOS_NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRODUCTOS_STOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRODUCTOS_MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRODUCTOS_PRECIOVENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRUDUCTOS_ULTIMAREPOSICION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GB_INVENTARIOS_TABLA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_INVENTARIO)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_INVENTARIOS_TABLA
            // 
            this.GB_INVENTARIOS_TABLA.Controls.Add(this.DGV_INVENTARIO);
            this.GB_INVENTARIOS_TABLA.Location = new System.Drawing.Point(6, 12);
            this.GB_INVENTARIOS_TABLA.Name = "GB_INVENTARIOS_TABLA";
            this.GB_INVENTARIOS_TABLA.Size = new System.Drawing.Size(791, 392);
            this.GB_INVENTARIOS_TABLA.TabIndex = 6;
            this.GB_INVENTARIOS_TABLA.TabStop = false;
            this.GB_INVENTARIOS_TABLA.Text = "Tabla";
            // 
            // DGV_INVENTARIO
            // 
            this.DGV_INVENTARIO.AllowUserToAddRows = false;
            this.DGV_INVENTARIO.AllowUserToDeleteRows = false;
            this.DGV_INVENTARIO.AllowUserToResizeColumns = false;
            this.DGV_INVENTARIO.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_INVENTARIO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_INVENTARIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_INVENTARIO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRO_PRODUCTOS_CODIGODEBARRA,
            this.PRO_PRODUCTOS_NOMBRE,
            this.PRO_PRODUCTOS_STOCK,
            this.PRO_PRODUCTOS_MARCA,
            this.PRO_PRODUCTOS_PRECIOVENTA,
            this.PRO_PRUDUCTOS_ULTIMAREPOSICION});
            this.DGV_INVENTARIO.EnableHeadersVisualStyles = false;
            this.DGV_INVENTARIO.Location = new System.Drawing.Point(6, 19);
            this.DGV_INVENTARIO.Name = "DGV_INVENTARIO";
            this.DGV_INVENTARIO.ReadOnly = true;
            this.DGV_INVENTARIO.Size = new System.Drawing.Size(779, 359);
            this.DGV_INVENTARIO.TabIndex = 0;
            // 
            // PRO_PRODUCTOS_CODIGODEBARRA
            // 
            this.PRO_PRODUCTOS_CODIGODEBARRA.HeaderText = "Codigo de Barras";
            this.PRO_PRODUCTOS_CODIGODEBARRA.Name = "PRO_PRODUCTOS_CODIGODEBARRA";
            this.PRO_PRODUCTOS_CODIGODEBARRA.ReadOnly = true;
            this.PRO_PRODUCTOS_CODIGODEBARRA.Width = 140;
            // 
            // PRO_PRODUCTOS_NOMBRE
            // 
            this.PRO_PRODUCTOS_NOMBRE.HeaderText = "Nombre";
            this.PRO_PRODUCTOS_NOMBRE.Name = "PRO_PRODUCTOS_NOMBRE";
            this.PRO_PRODUCTOS_NOMBRE.ReadOnly = true;
            this.PRO_PRODUCTOS_NOMBRE.Width = 190;
            // 
            // PRO_PRODUCTOS_STOCK
            // 
            this.PRO_PRODUCTOS_STOCK.HeaderText = "Stock";
            this.PRO_PRODUCTOS_STOCK.Name = "PRO_PRODUCTOS_STOCK";
            this.PRO_PRODUCTOS_STOCK.ReadOnly = true;
            this.PRO_PRODUCTOS_STOCK.Width = 85;
            // 
            // PRO_PRODUCTOS_MARCA
            // 
            this.PRO_PRODUCTOS_MARCA.HeaderText = "Marca";
            this.PRO_PRODUCTOS_MARCA.Name = "PRO_PRODUCTOS_MARCA";
            this.PRO_PRODUCTOS_MARCA.ReadOnly = true;
            // 
            // PRO_PRODUCTOS_PRECIOVENTA
            // 
            this.PRO_PRODUCTOS_PRECIOVENTA.HeaderText = "Precio Local";
            this.PRO_PRODUCTOS_PRECIOVENTA.Name = "PRO_PRODUCTOS_PRECIOVENTA";
            this.PRO_PRODUCTOS_PRECIOVENTA.ReadOnly = true;
            // 
            // PRO_PRUDUCTOS_ULTIMAREPOSICION
            // 
            this.PRO_PRUDUCTOS_ULTIMAREPOSICION.HeaderText = "Ultima Reposicion";
            this.PRO_PRUDUCTOS_ULTIMAREPOSICION.Name = "PRO_PRUDUCTOS_ULTIMAREPOSICION";
            this.PRO_PRUDUCTOS_ULTIMAREPOSICION.ReadOnly = true;
            this.PRO_PRUDUCTOS_ULTIMAREPOSICION.Width = 120;
            // 
            // Form_RevisarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(805, 420);
            this.Controls.Add(this.GB_INVENTARIOS_TABLA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_RevisarProductos";
            this.Text = "Revisar Productos";
            this.Load += new System.EventHandler(this.Form_RevisarProductos_Load);
            this.GB_INVENTARIOS_TABLA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_INVENTARIO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_INVENTARIOS_TABLA;
        private System.Windows.Forms.DataGridView DGV_INVENTARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTOS_CODIGODEBARRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTOS_NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTOS_STOCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTOS_MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRODUCTOS_PRECIOVENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRUDUCTOS_ULTIMAREPOSICION;
    }
}