using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace SensorGraph
{
	public partial class MainFrm : Form
	{
		private ucMainView ucMainView = new ucMainView();
		private ucSetupView ucSetupView = new ucSetupView();



		List<string> sensor_names = new List<string>( new string[] { "CH 1", "CH 2", "CH 3", "CH 4" } );
		int count = 1;



		public MainFrm()
		{
			InitializeComponent();
		}

		private void view_init()
		{
			ucMainView.Dock = DockStyle.Fill;
			panelView.Controls.Add( ucMainView );

			ucSetupView.Dock = DockStyle.Fill;
			panelView.Controls.Add( ucSetupView );
		}

		private void clock_init()
		{
			lbClock.Text = DateTime.Now.ToString( "yyyy-MM-dd HH:mm:ss" );
		}

		

		private void MainFrm_Load( object sender, EventArgs e )
		{
			view_init();
			clock_init();

			//SensorGraph.Series.Clear();
			//foreach( var name in sensor_names )
			//{
			//	SensorGraph.Series.Add( name );
			//	SensorGraph.Series[ name ].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			//}




		}

		

		private void MainFrm_Shown( object sender, EventArgs e )
		{
			
		}

		private void MainFrm_FormClosing( object sender, FormClosingEventArgs e )
		{
			
		}

		private void btnMenu_CheckedChanged( object sender, EventArgs e )
		{
			ucMainView.Visible = btnMainMenu.Checked;
			ucSetupView.Visible = btnSetupMenu.Checked;
		}

		private void btnExit_Click( object sender, EventArgs e )
		{
			DialogResult dr = MessageBox.Show( "종료 하시겠습니까?", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question );
			if( dr != DialogResult.OK )
				return;

			Close();
		}

		private void timerClock_Tick( object sender, EventArgs e )
		{
			lbClock.Text = DateTime.Now.ToString( "yyyy-MM-dd HH:mm:ss" );
		}
	}
}
