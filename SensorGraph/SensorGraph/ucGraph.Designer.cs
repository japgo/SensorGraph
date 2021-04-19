namespace SensorGraph
{
	partial class ucGraph
	{
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lbReal = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lbAve = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lbMax = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbMin = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.lbTitle = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
			this.tableLayoutPanel1.Controls.Add(this.lbReal, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.lbAve, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.lbMax, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.lbMin, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.graph, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lbTitle, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 360);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// lbReal
			// 
			this.lbReal.AutoSize = true;
			this.lbReal.BackColor = System.Drawing.SystemColors.Control;
			this.lbReal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbReal.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lbReal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbReal.Location = new System.Drawing.Point(126, 315);
			this.lbReal.Name = "lbReal";
			this.lbReal.Size = new System.Drawing.Size(200, 45);
			this.lbReal.TabIndex = 12;
			this.lbReal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label8.Location = new System.Drawing.Point(3, 315);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(117, 45);
			this.label8.TabIndex = 11;
			this.label8.Text = "실시간";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbAve
			// 
			this.lbAve.AutoSize = true;
			this.lbAve.BackColor = System.Drawing.SystemColors.Control;
			this.lbAve.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbAve.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lbAve.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbAve.Location = new System.Drawing.Point(126, 270);
			this.lbAve.Name = "lbAve";
			this.lbAve.Size = new System.Drawing.Size(200, 45);
			this.lbAve.TabIndex = 10;
			this.lbAve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(3, 270);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(117, 45);
			this.label6.TabIndex = 9;
			this.label6.Text = "AVE";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbMax
			// 
			this.lbMax.AutoSize = true;
			this.lbMax.BackColor = System.Drawing.SystemColors.Control;
			this.lbMax.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbMax.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lbMax.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbMax.Location = new System.Drawing.Point(126, 225);
			this.lbMax.Name = "lbMax";
			this.lbMax.Size = new System.Drawing.Size(200, 45);
			this.lbMax.TabIndex = 8;
			this.lbMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(3, 225);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 45);
			this.label4.TabIndex = 7;
			this.label4.Text = "MAX";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbMin
			// 
			this.lbMin.AutoSize = true;
			this.lbMin.BackColor = System.Drawing.SystemColors.Control;
			this.lbMin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbMin.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lbMin.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbMin.Location = new System.Drawing.Point(126, 180);
			this.lbMin.Name = "lbMin";
			this.lbMin.Size = new System.Drawing.Size(200, 45);
			this.lbMin.TabIndex = 6;
			this.lbMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(3, 180);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 45);
			this.label2.TabIndex = 5;
			this.label2.Text = "MIN";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// graph
			// 
			chartArea1.Name = "ChartArea1";
			this.graph.ChartAreas.Add(chartArea1);
			this.tableLayoutPanel1.SetColumnSpan(this.graph, 2);
			this.graph.Dock = System.Windows.Forms.DockStyle.Fill;
			legend1.Enabled = false;
			legend1.Name = "Legend1";
			this.graph.Legends.Add(legend1);
			this.graph.Location = new System.Drawing.Point(3, 48);
			this.graph.Name = "graph";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.graph.Series.Add(series1);
			this.graph.Size = new System.Drawing.Size(323, 129);
			this.graph.TabIndex = 2;
			this.graph.Text = "chart1";
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.tableLayoutPanel1.SetColumnSpan(this.lbTitle, 2);
			this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbTitle.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lbTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbTitle.Location = new System.Drawing.Point(3, 0);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(323, 45);
			this.lbTitle.TabIndex = 4;
			this.lbTitle.Text = "1차축 센서1 그래프";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ucGraph
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "ucGraph";
			this.Size = new System.Drawing.Size(329, 360);
			this.Load += new System.EventHandler(this.ucGraph_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lbReal;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lbAve;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbMax;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbMin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataVisualization.Charting.Chart graph;
		private System.Windows.Forms.Label lbTitle;
	}
}
