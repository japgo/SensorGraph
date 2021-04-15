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
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SensorGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SensorGraph)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
			this.tableLayoutPanel1.Controls.Add(this.label9, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label7, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label5, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.SensorGraph, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
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
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.SystemColors.Control;
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label9.Location = new System.Drawing.Point(126, 315);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(200, 45);
			this.label9.TabIndex = 12;
			this.label9.Text = "12.345";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.Control;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(126, 270);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(200, 45);
			this.label7.TabIndex = 10;
			this.label7.Text = "12.345";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Control;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(126, 225);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(200, 45);
			this.label5.TabIndex = 8;
			this.label5.Text = "12.345";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(126, 180);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(200, 45);
			this.label3.TabIndex = 6;
			this.label3.Text = "12.345";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// SensorGraph
			// 
			chartArea1.Name = "ChartArea1";
			this.SensorGraph.ChartAreas.Add(chartArea1);
			this.tableLayoutPanel1.SetColumnSpan(this.SensorGraph, 2);
			this.SensorGraph.Dock = System.Windows.Forms.DockStyle.Fill;
			legend1.Enabled = false;
			legend1.Name = "Legend1";
			this.SensorGraph.Legends.Add(legend1);
			this.SensorGraph.Location = new System.Drawing.Point(3, 48);
			this.SensorGraph.Name = "SensorGraph";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.SensorGraph.Series.Add(series1);
			this.SensorGraph.Size = new System.Drawing.Size(323, 129);
			this.SensorGraph.TabIndex = 2;
			this.SensorGraph.Text = "chart1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(323, 45);
			this.label1.TabIndex = 4;
			this.label1.Text = "1차축 센서1 그래프";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			((System.ComponentModel.ISupportInitialize)(this.SensorGraph)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataVisualization.Charting.Chart SensorGraph;
		private System.Windows.Forms.Label label1;
	}
}
