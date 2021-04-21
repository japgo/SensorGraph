
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
			this.components = new System.ComponentModel.Container();
			this.panelMainMenu = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSetupMenu = new System.Windows.Forms.RadioButton();
			this.btnMainMenu = new System.Windows.Forms.RadioButton();
			this.panelView = new System.Windows.Forms.Panel();
			this.panelTop = new System.Windows.Forms.Panel();
			this.lbClock = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timerClock = new System.Windows.Forms.Timer(this.components);
			this.panelMainMenu.SuspendLayout();
			this.panelTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMainMenu
			// 
			this.panelMainMenu.BackColor = System.Drawing.SystemColors.Window;
			this.panelMainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelMainMenu.Controls.Add(this.btnExit);
			this.panelMainMenu.Controls.Add(this.btnSetupMenu);
			this.panelMainMenu.Controls.Add(this.btnMainMenu);
			this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelMainMenu.Location = new System.Drawing.Point(1709, 0);
			this.panelMainMenu.Name = "panelMainMenu";
			this.panelMainMenu.Size = new System.Drawing.Size(211, 1080);
			this.panelMainMenu.TabIndex = 1;
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnExit.Location = new System.Drawing.Point(24, 946);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(161, 105);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "EXIT";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnSetupMenu
			// 
			this.btnSetupMenu.Appearance = System.Windows.Forms.Appearance.Button;
			this.btnSetupMenu.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnSetupMenu.Location = new System.Drawing.Point(26, 153);
			this.btnSetupMenu.Name = "btnSetupMenu";
			this.btnSetupMenu.Size = new System.Drawing.Size(161, 105);
			this.btnSetupMenu.TabIndex = 1;
			this.btnSetupMenu.TabStop = true;
			this.btnSetupMenu.Text = "SETUP";
			this.btnSetupMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnSetupMenu.UseVisualStyleBackColor = true;
			this.btnSetupMenu.CheckedChanged += new System.EventHandler(this.btnMenu_CheckedChanged);
			// 
			// btnMainMenu
			// 
			this.btnMainMenu.Appearance = System.Windows.Forms.Appearance.Button;
			this.btnMainMenu.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnMainMenu.Location = new System.Drawing.Point(26, 23);
			this.btnMainMenu.Name = "btnMainMenu";
			this.btnMainMenu.Size = new System.Drawing.Size(161, 105);
			this.btnMainMenu.TabIndex = 0;
			this.btnMainMenu.TabStop = true;
			this.btnMainMenu.Text = "MAIN";
			this.btnMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnMainMenu.UseVisualStyleBackColor = true;
			this.btnMainMenu.CheckedChanged += new System.EventHandler(this.btnMenu_CheckedChanged);
			// 
			// panelView
			// 
			this.panelView.BackColor = System.Drawing.SystemColors.Window;
			this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelView.Location = new System.Drawing.Point(0, 81);
			this.panelView.Name = "panelView";
			this.panelView.Size = new System.Drawing.Size(1709, 999);
			this.panelView.TabIndex = 4;
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.SystemColors.Window;
			this.panelTop.Controls.Add(this.lbClock);
			this.panelTop.Controls.Add(this.pictureBox1);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(1709, 81);
			this.panelTop.TabIndex = 5;
			// 
			// lbClock
			// 
			this.lbClock.Dock = System.Windows.Forms.DockStyle.Left;
			this.lbClock.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lbClock.Location = new System.Drawing.Point(335, 0);
			this.lbClock.Name = "lbClock";
			this.lbClock.Size = new System.Drawing.Size(118, 81);
			this.lbClock.TabIndex = 1;
			this.lbClock.Text = "2021-04-08 05:32:45";
			this.lbClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbClock.DoubleClick += new System.EventHandler(this.lbClock_DoubleClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = global::SensorGraph.Properties.Resources.huonisMark_1;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(335, 81);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// timerClock
			// 
			this.timerClock.Enabled = true;
			this.timerClock.Interval = 1000;
			this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
			// 
			// MainFrm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1920, 1080);
			this.ControlBox = false;
			this.Controls.Add(this.panelView);
			this.Controls.Add(this.panelTop);
			this.Controls.Add(this.panelMainMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainFrm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainFrm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
			this.Load += new System.EventHandler(this.MainFrm_Load);
			this.Shown += new System.EventHandler(this.MainFrm_Shown);
			this.panelMainMenu.ResumeLayout(false);
			this.panelTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelMainMenu;
		private System.Windows.Forms.Panel panelView;
		private System.Windows.Forms.RadioButton btnSetupMenu;
		private System.Windows.Forms.RadioButton btnMainMenu;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbClock;
		private System.Windows.Forms.Timer timerClock;
	}
}

