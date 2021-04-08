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
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.panelSubMenu = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSave = new System.Windows.Forms.Button();
			this.panelSubMenu.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(195, 227);
			this.maskedTextBox1.Mask = "000.000.000.000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(172, 25);
			this.maskedTextBox1.TabIndex = 0;
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
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// ucSetupView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.panelSubMenu);
			this.Controls.Add(this.maskedTextBox1);
			this.Name = "ucSetupView";
			this.Size = new System.Drawing.Size(1709, 999);
			this.panelSubMenu.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.Panel panelSubMenu;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnSave;
	}
}
