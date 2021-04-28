namespace SensorGraph
{
	partial class ucSetupView
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
			this.btnSave = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tbAxis1ServerPORT = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbAxis1ServerIP = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.tbAxis2ServerIP = new System.Windows.Forms.TextBox();
			this.tbAxis2ServerPORT = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.tbInterval = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.panelSubMenu.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
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
			this.panelSubMenu.TabIndex = 9;
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
			this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1707, 166);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// btnSave
			// 
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSave.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnSave.Location = new System.Drawing.Point(40, 30);
			this.btnSave.Margin = new System.Windows.Forms.Padding(40, 30, 40, 30);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(163, 106);
			this.btnSave.TabIndex = 0;
			this.btnSave.TabStop = false;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel2.Controls.Add(this.tbAxis1ServerPORT, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.tbAxis1ServerIP, 1, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(127, 250);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(432, 99);
			this.tableLayoutPanel2.TabIndex = 10;
			// 
			// tbAxis1ServerPORT
			// 
			this.tbAxis1ServerPORT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbAxis1ServerPORT.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tbAxis1ServerPORT.Location = new System.Drawing.Point(176, 68);
			this.tbAxis1ServerPORT.Name = "tbAxis1ServerPORT";
			this.tbAxis1ServerPORT.Size = new System.Drawing.Size(252, 26);
			this.tbAxis1ServerPORT.TabIndex = 1;
			this.tbAxis1ServerPORT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(1, 65);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(171, 33);
			this.label4.TabIndex = 7;
			this.label4.Text = "SERVER PORT";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(1, 32);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(171, 32);
			this.label3.TabIndex = 6;
			this.label3.Text = "SERVER IP";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.tableLayoutPanel2.SetColumnSpan(this.label1, 2);
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(1, 1);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(430, 30);
			this.label1.TabIndex = 5;
			this.label1.Text = "1차축 통신 설정";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbAxis1ServerIP
			// 
			this.tbAxis1ServerIP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbAxis1ServerIP.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tbAxis1ServerIP.Location = new System.Drawing.Point(176, 35);
			this.tbAxis1ServerIP.Name = "tbAxis1ServerIP";
			this.tbAxis1ServerIP.Size = new System.Drawing.Size(252, 26);
			this.tbAxis1ServerIP.TabIndex = 0;
			this.tbAxis1ServerIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel3.Controls.Add(this.tbAxis2ServerIP, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.tbAxis2ServerPORT, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(127, 384);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(432, 98);
			this.tableLayoutPanel3.TabIndex = 11;
			// 
			// tbAxis2ServerIP
			// 
			this.tbAxis2ServerIP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbAxis2ServerIP.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tbAxis2ServerIP.Location = new System.Drawing.Point(176, 35);
			this.tbAxis2ServerIP.Name = "tbAxis2ServerIP";
			this.tbAxis2ServerIP.Size = new System.Drawing.Size(252, 26);
			this.tbAxis2ServerIP.TabIndex = 2;
			this.tbAxis2ServerIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbAxis2ServerPORT
			// 
			this.tbAxis2ServerPORT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbAxis2ServerPORT.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tbAxis2ServerPORT.Location = new System.Drawing.Point(176, 68);
			this.tbAxis2ServerPORT.Name = "tbAxis2ServerPORT";
			this.tbAxis2ServerPORT.Size = new System.Drawing.Size(252, 26);
			this.tbAxis2ServerPORT.TabIndex = 3;
			this.tbAxis2ServerPORT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(1, 32);
			this.label5.Margin = new System.Windows.Forms.Padding(0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(171, 32);
			this.label5.TabIndex = 9;
			this.label5.Text = "SERVER PORT";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(1, 65);
			this.label6.Margin = new System.Windows.Forms.Padding(0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(171, 32);
			this.label6.TabIndex = 8;
			this.label6.Text = "SERVER IP";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.tableLayoutPanel3.SetColumnSpan(this.label2, 2);
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(1, 1);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(430, 30);
			this.label2.TabIndex = 6;
			this.label2.Text = "2차축 통신 설정";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel4.Controls.Add(this.tbInterval, 1, 1);
			this.tableLayoutPanel4.Controls.Add(this.label7, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.label9, 0, 0);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(127, 518);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 3;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(432, 98);
			this.tableLayoutPanel4.TabIndex = 12;
			// 
			// tbInterval
			// 
			this.tbInterval.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbInterval.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tbInterval.Location = new System.Drawing.Point(176, 35);
			this.tbInterval.Name = "tbInterval";
			this.tbInterval.Size = new System.Drawing.Size(252, 26);
			this.tbInterval.TabIndex = 4;
			this.tbInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(1, 32);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(171, 32);
			this.label7.TabIndex = 9;
			this.label7.Text = "INTERVAL (msec)";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.tableLayoutPanel4.SetColumnSpan(this.label9, 2);
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label9.Location = new System.Drawing.Point(1, 1);
			this.label9.Margin = new System.Windows.Forms.Padding(0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(430, 30);
			this.label9.TabIndex = 6;
			this.label9.Text = "공통 설정";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ucSetupView
			// 
			this.AccessibleDescription = " ";
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.tableLayoutPanel4);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.panelSubMenu);
			this.Name = "ucSetupView";
			this.Size = new System.Drawing.Size(1709, 999);
			this.Load += new System.EventHandler(this.ucSetupView_Load);
			this.panelSubMenu.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelSubMenu;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbAxis1ServerPORT;
		private System.Windows.Forms.TextBox tbAxis1ServerIP;
		private System.Windows.Forms.TextBox tbAxis2ServerIP;
		private System.Windows.Forms.TextBox tbAxis2ServerPORT;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.TextBox tbInterval;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
	}
}
