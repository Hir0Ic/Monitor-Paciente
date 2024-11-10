namespace Monitor_Paciente_Simulador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chRespiratoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chOxigeno = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chCardiaca = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblOxigeno = new System.Windows.Forms.Label();
            this.lblFrecuenciaRespiratoria = new System.Windows.Forms.Label();
            this.lblRitmoCardiaco = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chRespiratoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chOxigeno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCardiaca)).BeginInit();
            this.SuspendLayout();
            // 
            // chRespiratoria
            // 
            chartArea1.Name = "ChartArea1";
            this.chRespiratoria.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chRespiratoria.Legends.Add(legend1);
            this.chRespiratoria.Location = new System.Drawing.Point(27, 25);
            this.chRespiratoria.Name = "chRespiratoria";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chRespiratoria.Series.Add(series1);
            this.chRespiratoria.Size = new System.Drawing.Size(762, 140);
            this.chRespiratoria.TabIndex = 0;
            this.chRespiratoria.Text = "chart1";
            // 
            // chOxigeno
            // 
            chartArea2.Name = "ChartArea1";
            this.chOxigeno.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chOxigeno.Legends.Add(legend2);
            this.chOxigeno.Location = new System.Drawing.Point(27, 171);
            this.chOxigeno.Name = "chOxigeno";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chOxigeno.Series.Add(series2);
            this.chOxigeno.Size = new System.Drawing.Size(762, 140);
            this.chOxigeno.TabIndex = 1;
            this.chOxigeno.Text = "chart2";
            // 
            // chCardiaca
            // 
            chartArea3.Name = "ChartArea1";
            this.chCardiaca.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chCardiaca.Legends.Add(legend3);
            this.chCardiaca.Location = new System.Drawing.Point(27, 317);
            this.chCardiaca.Name = "chCardiaca";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chCardiaca.Series.Add(series3);
            this.chCardiaca.Size = new System.Drawing.Size(762, 140);
            this.chCardiaca.TabIndex = 2;
            this.chCardiaca.Text = "chart3";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(869, 441);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(114, 16);
            this.lblTemperatura.TabIndex = 3;
            this.lblTemperatura.Text = "Temperatura: 0 °C";
            // 
            // lblOxigeno
            // 
            this.lblOxigeno.AutoSize = true;
            this.lblOxigeno.Location = new System.Drawing.Point(886, 193);
            this.lblOxigeno.Name = "lblOxigeno";
            this.lblOxigeno.Size = new System.Drawing.Size(82, 16);
            this.lblOxigeno.TabIndex = 4;
            this.lblOxigeno.Text = "Oxígeno: 0%";
            // 
            // lblFrecuenciaRespiratoria
            // 
            this.lblFrecuenciaRespiratoria.AutoSize = true;
            this.lblFrecuenciaRespiratoria.Location = new System.Drawing.Point(834, 83);
            this.lblFrecuenciaRespiratoria.Name = "lblFrecuenciaRespiratoria";
            this.lblFrecuenciaRespiratoria.Size = new System.Drawing.Size(196, 16);
            this.lblFrecuenciaRespiratoria.TabIndex = 5;
            this.lblFrecuenciaRespiratoria.Text = "Frecuencia Respiratoria: 0 BPM";
            // 
            // lblRitmoCardiaco
            // 
            this.lblRitmoCardiaco.AutoSize = true;
            this.lblRitmoCardiaco.Location = new System.Drawing.Point(855, 330);
            this.lblRitmoCardiaco.Name = "lblRitmoCardiaco";
            this.lblRitmoCardiaco.Size = new System.Drawing.Size(145, 16);
            this.lblRitmoCardiaco.TabIndex = 6;
            this.lblRitmoCardiaco.Text = "Ritmo Cardíaco: 0 BPM";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(872, 542);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(967, 542);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 9;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 577);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblRitmoCardiaco);
            this.Controls.Add(this.lblFrecuenciaRespiratoria);
            this.Controls.Add(this.lblOxigeno);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.chCardiaca);
            this.Controls.Add(this.chOxigeno);
            this.Controls.Add(this.chRespiratoria);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chRespiratoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chOxigeno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCardiaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chRespiratoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart chOxigeno;
        private System.Windows.Forms.DataVisualization.Charting.Chart chCardiaca;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblOxigeno;
        private System.Windows.Forms.Label lblFrecuenciaRespiratoria;
        private System.Windows.Forms.Label lblRitmoCardiaco;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
    }
}

