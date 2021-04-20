namespace SensorGraph
{
	partial class ucMainView
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
			this.panelSubMenu = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.bwGraphRefresh1 = new System.ComponentModel.BackgroundWorker();
			this.ucGraph2_4 = new SensorGraph.ucGraph();
			this.ucGraph2_3 = new SensorGraph.ucGraph();
			this.ucGraph2_2 = new SensorGraph.ucGraph();
			this.ucGraph2_1 = new SensorGraph.ucGraph();
			this.ucGraph1_4 = new SensorGraph.ucGraph();
			this.ucGraph1_3 = new SensorGraph.ucGraph();
			this.ucGraph1_2 = new SensorGraph.ucGraph();
			this.ucGraph1_1 = new SensorGraph.ucGraph();
			this.bwGraphRefresh2 = new System.ComponentModel.BackgroundWorker();
			this.panelSubMenu.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelSubMenu
			// 
			this.panelSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelSubMenu.Controls.Add(this.tableLayoutPanel1);
			this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelSubMenu.Location = new System.Drawing.Point(0, 831);
			this.panelSubMenu.Name = "panelSubMenu";
			this.panelSubMenu.Size = new System.Drawing.Size(1709, 168);
			this.panelSubMenu.TabIndex = 8;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 7;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.Controls.Add(this.btnStop, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnStart, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1707, 166);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// btnStop
			// 
			this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnStop.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnStop.Location = new System.Drawing.Point(283, 30);
			this.btnStop.Margin = new System.Windows.Forms.Padding(40, 30, 40, 30);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(163, 106);
			this.btnStop.TabIndex = 1;
			this.btnStop.Text = "STOP";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnStart.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnStart.Location = new System.Drawing.Point(40, 30);
			this.btnStart.Margin = new System.Windows.Forms.Padding(40, 30, 40, 30);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(163, 106);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "START";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// ucGraph2_4
			// 
			this.ucGraph2_4.Location = new System.Drawing.Point(1293, 517);
			this.ucGraph2_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ucGraph2_4.Name = "ucGraph2_4";
			this.ucGraph2_4.Size = new System.Drawing.Size(399, 283);
			this.ucGraph2_4.TabIndex = 7;
			// 
			// ucGraph2_3
			// 
			this.ucGraph2_3.Location = new System.Drawing.Point(868, 517);
			this.ucGraph2_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ucGraph2_3.Name = "ucGraph2_3";
			this.ucGraph2_3.Size = new System.Drawing.Size(399, 283);
			this.ucGraph2_3.TabIndex = 6;
			// 
			// ucGraph2_2
			// 
			this.ucGraph2_2.Location = new System.Drawing.Point(443, 517);
			this.ucGraph2_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ucGraph2_2.Name = "ucGraph2_2";
			this.ucGraph2_2.Size = new System.Drawing.Size(399, 283);
			this.ucGraph2_2.TabIndex = 5;
			// 
			// ucGraph2_1
			// 
			this.ucGraph2_1.Location = new System.Drawing.Point(18, 517);
			this.ucGraph2_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ucGraph2_1.Name = "ucGraph2_1";
			this.ucGraph2_1.Size = new System.Drawing.Size(399, 283);
			this.ucGraph2_1.TabIndex = 4;
			// 
			// ucGraph1_4
			// 
			this.ucGraph1_4.Location = new System.Drawing.Point(1293, 228);
			this.ucGraph1_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ucGraph1_4.Name = "ucGraph1_4";
			this.ucGraph1_4.Size = new System.Drawing.Size(399, 283);
			this.ucGraph1_4.TabIndex = 3;
			// 
			// ucGraph1_3
			// 
			this.ucGraph1_3.Location = new System.Drawing.Point(868, 228);
			this.ucGraph1_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ucGraph1_3.Name = "ucGraph1_3";
			this.ucGraph1_3.Size = new System.Drawing.Size(399, 283);
			this.ucGraph1_3.TabIndex = 2;
			// 
			// ucGraph1_2
			// 
			this.ucGraph1_2.Location = new System.Drawing.Point(443, 228);
			this.ucGraph1_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ucGraph1_2.Name = "ucGraph1_2";
			this.ucGraph1_2.Size = new System.Drawing.Size(399, 283);
			this.ucGraph1_2.TabIndex = 1;
			// 
			// ucGraph1_1
			// 
			this.ucGraph1_1.Location = new System.Drawing.Point(18, 228);
			this.ucGraph1_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ucGraph1_1.Name = "ucGraph1_1";
			this.ucGraph1_1.Size = new System.Drawing.Size(399, 283);
			this.ucGraph1_1.TabIndex = 0;
			// 
			// bwGraphRefresh2
			// 
			this.bwGraphRefresh2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwGraphRefresh2_DoWork);
			// 
			// ucMainView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.panelSubMenu);
			this.Controls.Add(this.ucGraph2_4);
			this.Controls.Add(this.ucGraph2_3);
			this.Controls.Add(this.ucGraph2_2);
			this.Controls.Add(this.ucGraph2_1);
			this.Controls.Add(this.ucGraph1_4);
			this.Controls.Add(this.ucGraph1_3);
			this.Controls.Add(this.ucGraph1_2);
			this.Controls.Add(this.ucGraph1_1);
			this.Name = "ucMainView";
			this.Size = new System.Drawing.Size(1709, 999);
			this.Load += new System.EventHandler(this.ucMainView_Load);
			this.panelSubMenu.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private ucGraph ucGraph1_1;
		private ucGraph ucGraph1_2;
		private ucGraph ucGraph1_4;
		private ucGraph ucGraph1_3;
		private ucGraph ucGraph2_4;
		private ucGraph ucGraph2_3;
		private ucGraph ucGraph2_2;
		private ucGraph ucGraph2_1;
		private System.Windows.Forms.Panel panelSubMenu;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.ComponentModel.BackgroundWorker bwGraphRefresh1;
		private System.ComponentModel.BackgroundWorker bwGraphRefresh2;
	}
}
