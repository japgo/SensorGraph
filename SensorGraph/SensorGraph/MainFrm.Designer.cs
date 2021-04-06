
namespace SensorGraph
{
	partial class MainFrm
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.SensorGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.bwGraphRefresh = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.SensorGraph)).BeginInit();
			this.SuspendLayout();
			// 
			// SensorGraph
			// 
			chartArea7.Name = "ChartArea1";
			this.SensorGraph.ChartAreas.Add(chartArea7);
			legend7.Name = "Legend1";
			this.SensorGraph.Legends.Add(legend7);
			this.SensorGraph.Location = new System.Drawing.Point(12, 105);
			this.SensorGraph.Name = "SensorGraph";
			series7.ChartArea = "ChartArea1";
			series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series7.Legend = "Legend1";
			series7.Name = "Series1";
			this.SensorGraph.Series.Add(series7);
			this.SensorGraph.Size = new System.Drawing.Size(905, 280);
			this.SensorGraph.TabIndex = 0;
			this.SensorGraph.Text = "chart1";
			// 
			// MainFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1920, 1080);
			this.ControlBox = false;
			this.Controls.Add(this.SensorGraph);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainFrm";
			this.Text = "MainFrm";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
			this.Shown += new System.EventHandler(this.MainFrm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.SensorGraph)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart SensorGraph;
		private System.ComponentModel.BackgroundWorker bwGraphRefresh;
	}
}

