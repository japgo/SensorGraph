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
			this.bwGraphRefresh2 = new System.ComponentModel.BackgroundWorker();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pbAxisConnState2 = new System.Windows.Forms.PictureBox();
			this.pbAxisConnState1 = new System.Windows.Forms.PictureBox();
			this.bwLog = new System.ComponentModel.BackgroundWorker();
			this.ucGraph2_4 = new SensorGraph.ucGraph();
			this.ucGraph2_3 = new SensorGraph.ucGraph();
			this.ucGraph2_2 = new SensorGraph.ucGraph();
			this.ucGraph2_1 = new SensorGraph.ucGraph();
			this.ucGraph1_4 = new SensorGraph.ucGraph();
			this.ucGraph1_3 = new SensorGraph.ucGraph();
			this.ucGraph1_2 = new SensorGraph.ucGraph();
			this.ucGraph1_1 = new SensorGraph.ucGraph();
			this.panelSubMenu.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbAxisConnState2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAxisConnState1)).BeginInit();
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
			this.btnStop.TabStop = false;
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
			this.btnStart.TabStop = false;
			this.btnStart.Text = "START";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// bwGraphRefresh2
			// 
			this.bwGraphRefresh2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwGraphRefresh2_DoWork);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanel2.Controls.Add(this.pbAxisConnState2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.pbAxisConnState1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 1, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(1397, 20);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(295, 109);
			this.tableLayoutPanel2.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(62, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(230, 36);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ch1 Controller State";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(62, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(230, 36);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ch2 Controller State";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pbAxisConnState2
			// 
			this.pbAxisConnState2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbAxisConnState2.Image = global::SensorGraph.Properties.Resources.gray;
			this.pbAxisConnState2.Location = new System.Drawing.Point(3, 39);
			this.pbAxisConnState2.Name = "pbAxisConnState2";
			this.pbAxisConnState2.Size = new System.Drawing.Size(53, 30);
			this.pbAxisConnState2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbAxisConnState2.TabIndex = 1;
			this.pbAxisConnState2.TabStop = false;
			// 
			// pbAxisConnState1
			// 
			this.pbAxisConnState1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pbAxisConnState1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbAxisConnState1.Image = global::SensorGraph.Properties.Resources.green;
			this.pbAxisConnState1.Location = new System.Drawing.Point(3, 3);
			this.pbAxisConnState1.Name = "pbAxisConnState1";
			this.pbAxisConnState1.Size = new System.Drawing.Size(53, 30);
			this.pbAxisConnState1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbAxisConnState1.TabIndex = 0;
			this.pbAxisConnState1.TabStop = false;
			// 
			// bwLog
			// 
			this.bwLog.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLog_DoWork);
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
			// ucMainView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.tableLayoutPanel2);
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
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbAxisConnState2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAxisConnState1)).EndInit();
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
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.PictureBox pbAxisConnState2;
		private System.Windows.Forms.PictureBox pbAxisConnState1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.BackgroundWorker bwLog;
	}
}
