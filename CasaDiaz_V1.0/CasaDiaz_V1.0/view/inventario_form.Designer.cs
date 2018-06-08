namespace CasaDiaz_V1._0.view
{
    partial class inventario_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventario_form));
            this.BTN_CERRAR_INVENTARIO = new System.Windows.Forms.Button();
            this.BTN_MINIMIZAR_INVENTARIO = new System.Windows.Forms.Button();
            this.PIC_BOX_INVENTARIO = new System.Windows.Forms.PictureBox();
            this.LBL_INVENTARIO_INVENTARIO = new System.Windows.Forms.Label();
            this.GB_BUSCADOR_INVENTARIO = new System.Windows.Forms.GroupBox();
            this.RB_INVENTARIO_TODOS = new System.Windows.Forms.RadioButton();
            this.RB_INVENTARIO_CODIGO = new System.Windows.Forms.RadioButton();
            this.RB_INVENTARIO_NOMBRE = new System.Windows.Forms.RadioButton();
            this.RB_BUSCAR_PROVEEDOR = new System.Windows.Forms.RadioButton();
            this.TXT_INVENTARIO_LIMPIAR = new System.Windows.Forms.TextBox();
            this.BTN_INVENTARIO_BUSCAR = new System.Windows.Forms.Button();
            this.BTN_INVENTARIO_LIMPIAR = new System.Windows.Forms.Button();
            this.GB_INVENTARIOS_TABLA = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_BOX_INVENTARIO)).BeginInit();
            this.GB_BUSCADOR_INVENTARIO.SuspendLayout();
            this.GB_INVENTARIOS_TABLA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.PIC_BOX_INVENTARIO.Location = new System.Drawing.Point(22, 12);
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
            this.GB_BUSCADOR_INVENTARIO.Location = new System.Drawing.Point(22, 88);
            this.GB_BUSCADOR_INVENTARIO.Name = "GB_BUSCADOR_INVENTARIO";
            this.GB_BUSCADOR_INVENTARIO.Size = new System.Drawing.Size(791, 56);
            this.GB_BUSCADOR_INVENTARIO.TabIndex = 4;
            this.GB_BUSCADOR_INVENTARIO.TabStop = false;
            this.GB_BUSCADOR_INVENTARIO.Text = "Buscador";
            this.GB_BUSCADOR_INVENTARIO.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // TXT_INVENTARIO_LIMPIAR
            // 
            this.TXT_INVENTARIO_LIMPIAR.Location = new System.Drawing.Point(408, 18);
            this.TXT_INVENTARIO_LIMPIAR.Name = "TXT_INVENTARIO_LIMPIAR";
            this.TXT_INVENTARIO_LIMPIAR.Size = new System.Drawing.Size(216, 20);
            this.TXT_INVENTARIO_LIMPIAR.TabIndex = 4;
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
            // BTN_INVENTARIO_LIMPIAR
            // 
            this.BTN_INVENTARIO_LIMPIAR.Location = new System.Drawing.Point(710, 16);
            this.BTN_INVENTARIO_LIMPIAR.Name = "BTN_INVENTARIO_LIMPIAR";
            this.BTN_INVENTARIO_LIMPIAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_INVENTARIO_LIMPIAR.TabIndex = 6;
            this.BTN_INVENTARIO_LIMPIAR.Text = "Limpiar";
            this.BTN_INVENTARIO_LIMPIAR.UseVisualStyleBackColor = true;
            // 
            // GB_INVENTARIOS_TABLA
            // 
            this.GB_INVENTARIOS_TABLA.Controls.Add(this.dataGridView1);
            this.GB_INVENTARIOS_TABLA.Location = new System.Drawing.Point(22, 150);
            this.GB_INVENTARIOS_TABLA.Name = "GB_INVENTARIOS_TABLA";
            this.GB_INVENTARIOS_TABLA.Size = new System.Drawing.Size(791, 392);
            this.GB_INVENTARIOS_TABLA.TabIndex = 5;
            this.GB_INVENTARIOS_TABLA.TabStop = false;
            this.GB_INVENTARIOS_TABLA.Text = "Tabla";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(22, 548);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 128);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(46, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 92);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nuevo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(237, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 92);
            this.button2.TabIndex = 1;
            this.button2.Text = "Renovar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(440, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 92);
            this.button3.TabIndex = 2;
            this.button3.Text = "Eliminar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(642, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 92);
            this.button4.TabIndex = 3;
            this.button4.Text = "Revisar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // inventario_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(825, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GB_INVENTARIOS_TABLA);
            this.Controls.Add(this.GB_BUSCADOR_INVENTARIO);
            this.Controls.Add(this.LBL_INVENTARIO_INVENTARIO);
            this.Controls.Add(this.PIC_BOX_INVENTARIO);
            this.Controls.Add(this.BTN_MINIMIZAR_INVENTARIO);
            this.Controls.Add(this.BTN_CERRAR_INVENTARIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventario_form";
            this.Text = "inventario_form";
            this.Load += new System.EventHandler(this.inventario_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_BOX_INVENTARIO)).EndInit();
            this.GB_BUSCADOR_INVENTARIO.ResumeLayout(false);
            this.GB_BUSCADOR_INVENTARIO.PerformLayout();
            this.GB_INVENTARIOS_TABLA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}