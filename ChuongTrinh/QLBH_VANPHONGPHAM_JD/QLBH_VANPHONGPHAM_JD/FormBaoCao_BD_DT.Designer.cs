namespace QLBH_VANPHONGPHAM_JD
{
    partial class FormBaoCao_BD_DT
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chartDoanhThu2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartDoanhThu1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(293, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(841, 67);
            this.label1.TabIndex = 92;
            this.label1.Text = "THÔNG TIN BIỂU ĐỒ DOANH THU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chartDoanhThu2
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu2.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartDoanhThu2.Legends.Add(legend1);
            this.chartDoanhThu2.Location = new System.Drawing.Point(784, 3);
            this.chartDoanhThu2.Name = "chartDoanhThu2";
            this.chartDoanhThu2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Doanh Thu";
            this.chartDoanhThu2.Series.Add(series1);
            this.chartDoanhThu2.Size = new System.Drawing.Size(785, 693);
            this.chartDoanhThu2.TabIndex = 3;
            this.chartDoanhThu2.Text = "chart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.68193F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.31807F));
            this.tableLayoutPanel1.Controls.Add(this.chartDoanhThu2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartDoanhThu1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 513F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1572, 721);
            this.tableLayoutPanel1.TabIndex = 93;
            // 
            // chartDoanhThu1
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDoanhThu1.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartDoanhThu1.Legends.Add(legend2);
            this.chartDoanhThu1.Location = new System.Drawing.Point(3, 3);
            this.chartDoanhThu1.Name = "chartDoanhThu1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Doanh Thu";
            this.chartDoanhThu1.Series.Add(series2);
            this.chartDoanhThu1.Size = new System.Drawing.Size(775, 693);
            this.chartDoanhThu1.TabIndex = 2;
            this.chartDoanhThu1.Text = "chart1";
            // 
            // FormBaoCao_BD_DT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1708, 1021);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "FormBaoCao_BD_DT";
            this.Text = "FormBaoCao_BD_DT";
            this.Load += new System.EventHandler(this.FormBaoCao_BD_DT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu1;
    }
}