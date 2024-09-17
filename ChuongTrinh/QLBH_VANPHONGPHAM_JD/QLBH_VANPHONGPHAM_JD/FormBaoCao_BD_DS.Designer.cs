namespace QLBH_VANPHONGPHAM_JD
{
    partial class FormBaoCao_BD_DS
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartDoanhSo1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDoanhSo2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhSo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhSo2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(358, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(804, 67);
            this.label1.TabIndex = 90;
            this.label1.Text = "THÔNG TIN BIỂU ĐỒ DOANH SỐ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.08323F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.91677F));
            this.tableLayoutPanel1.Controls.Add(this.chartDoanhSo1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartDoanhSo2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1634, 833);
            this.tableLayoutPanel1.TabIndex = 91;
            // 
            // chartDoanhSo1
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhSo1.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Segoe UI", 11F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartDoanhSo1.Legends.Add(legend1);
            this.chartDoanhSo1.Location = new System.Drawing.Point(3, 3);
            this.chartDoanhSo1.Name = "chartDoanhSo1";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            series1.Legend = "Legend1";
            series1.Name = "Doanh Số";
            series1.YValuesPerPoint = 2;
            this.chartDoanhSo1.Series.Add(series1);
            this.chartDoanhSo1.Size = new System.Drawing.Size(734, 772);
            this.chartDoanhSo1.TabIndex = 0;
            this.chartDoanhSo1.Text = "chart1";
            // 
            // chartDoanhSo2
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDoanhSo2.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Segoe UI", 11F);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartDoanhSo2.Legends.Add(legend2);
            this.chartDoanhSo2.Location = new System.Drawing.Point(756, 3);
            this.chartDoanhSo2.Name = "chartDoanhSo2";
            this.chartDoanhSo2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            series2.Legend = "Legend1";
            series2.Name = "Doanh Số";
            this.chartDoanhSo2.Series.Add(series2);
            this.chartDoanhSo2.Size = new System.Drawing.Size(787, 772);
            this.chartDoanhSo2.TabIndex = 1;
            this.chartDoanhSo2.Text = "chart1";
            // 
            // FormBaoCao_BD_DS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1680, 1055);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "FormBaoCao_BD_DS";
            this.Text = "FormBaoCao_BD";
            this.Load += new System.EventHandler(this.FormBaoCao_BD_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhSo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhSo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhSo1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhSo2;
    }
}