namespace CasaDiaz_V1._0.view
{
    partial class Form_Graficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Graficos));
            this.CHAR_VENTAS_DIARIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.CHAR_VENTAS_DIARIA)).BeginInit();
            this.SuspendLayout();
            // 
            // CHAR_VENTAS_DIARIA
            // 
            this.CHAR_VENTAS_DIARIA.BackColor = System.Drawing.Color.Teal;
            chartArea1.Name = "ChartArea1";
            this.CHAR_VENTAS_DIARIA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CHAR_VENTAS_DIARIA.Legends.Add(legend1);
            this.CHAR_VENTAS_DIARIA.Location = new System.Drawing.Point(27, 12);
            this.CHAR_VENTAS_DIARIA.Name = "CHAR_VENTAS_DIARIA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CHAR_VENTAS_DIARIA.Series.Add(series1);
            this.CHAR_VENTAS_DIARIA.Size = new System.Drawing.Size(553, 344);
            this.CHAR_VENTAS_DIARIA.TabIndex = 0;
            this.CHAR_VENTAS_DIARIA.Text = "CHAR_VENTAS_PORMES";
            // 
            // Form_Graficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(861, 606);
            this.Controls.Add(this.CHAR_VENTAS_DIARIA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Graficos";
            this.Text = "Graficos";
            ((System.ComponentModel.ISupportInitialize)(this.CHAR_VENTAS_DIARIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CHAR_VENTAS_DIARIA;
    }
}