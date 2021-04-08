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

		private void MainFrm_Load( object sender, EventArgs e )
		{
			ucMainView.Dock = DockStyle.Fill;
			panelView.Controls.Add( ucMainView );

			ucSetupView.Dock = DockStyle.Fill;
			panelView.Controls.Add( ucSetupView );



			//SensorGraph.Series.Clear();
			//foreach( var name in sensor_names )
			//{
			//	SensorGraph.Series.Add( name );
			//	SensorGraph.Series[ name ].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			//}

			//bwGraphRefresh.DoWork += BwGraphRefresh_DoWork;
			//bwGraphRefresh.ProgressChanged += BwGraphRefresh_ProgressChanged;
			//bwGraphRefresh.WorkerReportsProgress = true;
			//bwGraphRefresh.WorkerSupportsCancellation = true;


		}

		private void BwGraphRefresh_ProgressChanged( object sender, ProgressChangedEventArgs e )
		{
			//var v = ( List<double> )e.UserState;
			//for( int i = 0; i < v.Count; i++ )
			//{
			//	SensorGraph?.Series[ i ]?.Points.Add( v[ i ] );
			//}
		}

		private void BwGraphRefresh_DoWork( object sender, DoWorkEventArgs e )
		{
			//while( true )
			//{
			//	if( bwGraphRefresh.CancellationPending )
			//		break;

			//	System.Threading.Thread.Sleep( 100 );

			//	Random rand = new Random();
			//	List<double> d = new List<double>();
			//	d.Add( rand.Next( 5000 ) / 100.0 );
			//	d.Add( rand.Next( 5000 ) / 100.0 );
			//	d.Add( rand.Next( 5000 ) / 100.0 );
			//	d.Add( rand.Next( 5000 ) / 100.0 );

			//	bwGraphRefresh.ReportProgress( count++, d );
			//}
		}

		private void MainFrm_Shown( object sender, EventArgs e )
		{
			//bwGraphRefresh.RunWorkerAsync();
		}

		private void MainFrm_FormClosing( object sender, FormClosingEventArgs e )
		{
			//bwGraphRefresh.CancelAsync();
		}

		private void btnMenu_CheckedChanged( object sender, EventArgs e )
		{
			ucMainView.Visible = btnMainMenu.Checked;
			ucSetupView.Visible = btnSetupMenu.Checked;
		}

		private void btnExit_Click( object sender, EventArgs e )
		{
			Close();
		}
	}
}
