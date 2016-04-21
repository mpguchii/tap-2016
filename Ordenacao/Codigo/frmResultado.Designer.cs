namespace Ordenacao
{
    partial class frmResultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultado));
            this.gDados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dDados = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.gDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).BeginInit();
            this.SuspendLayout();
            // 
            // gDados
            // 
            chartArea1.Name = "ChartArea1";
            this.gDados.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.gDados.Legends.Add(legend1);
            this.gDados.Location = new System.Drawing.Point(28, 12);
            this.gDados.Name = "gDados";
            this.gDados.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.gDados.Series.Add(series1);
            this.gDados.Size = new System.Drawing.Size(360, 198);
            this.gDados.TabIndex = 0;
            this.gDados.Text = "gDados";
            // 
            // dDados
            // 
            this.dDados.DataSetName = "NewDataSet";
            // 
            // frmResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 222);
            this.Controls.Add(this.gDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.frmResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart gDados;
        private System.Data.DataSet dDados;


    }
}