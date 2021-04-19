using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SensorGraph
{
	public partial class ucMainView : UserControl
	{
		List<DateTime> times = new List<DateTime>();
		List<double> g1_1 = new List<double>();
		List<double> g1_2 = new List<double>();
		List<double> g1_3 = new List<double>();
		List<double> g1_4 = new List<double>();
		List<double> g2_1 = new List<double>();
		List<double> g2_2 = new List<double>();
		List<double> g2_3 = new List<double>();
		List<double> g2_4 = new List<double>();

		DateTime start_time = new DateTime();
		DateTime end_time = new DateTime();

		public ucMainView()
		{
			InitializeComponent();
		}

		private void background_work_init()
		{
			bwGraphRefresh.DoWork += BwGraphRefresh_DoWork;
			bwGraphRefresh.ProgressChanged += BwGraphRefresh_ProgressChanged;
			bwGraphRefresh.RunWorkerCompleted += BwGraphRefresh_RunWorkerCompleted;
			bwGraphRefresh.WorkerReportsProgress = true;
			bwGraphRefresh.WorkerSupportsCancellation = true;
		}


		private void ucMainView_Load( object sender, EventArgs e )
		{
			background_work_init();
			ui_init();
		}

		private void ui_init()
		{
			ucGraph1_1.set_title( "1차축 센서1 그래프" );
			ucGraph1_2.set_title( "1차축 센서2 그래프" );
			ucGraph1_3.set_title( "1차축 센서3 그래프" );
			ucGraph1_4.set_title( "1차축 센서4 그래프" );

			ucGraph2_1.set_title( "2차축 센서1 그래프" );
			ucGraph2_2.set_title( "2차축 센서2 그래프" );
			ucGraph2_3.set_title( "2차축 센서3 그래프" );
			ucGraph2_4.set_title( "2차축 센서4 그래프" );
		}

		private void btnStart_Click( object sender, EventArgs e )
		{
			start_time = DateTime.Now;
			bwGraphRefresh.RunWorkerAsync();
		}

		private void btnStop_Click( object sender, EventArgs e )
		{
			end_time = DateTime.Now;
			bwGraphRefresh.CancelAsync();
		}

		private void BwGraphRefresh_ProgressChanged( object sender, ProgressChangedEventArgs e )
		{
			var v = ( List<double> )e.UserState;
			ucGraph1_1.add_value( v[ 0 ] ); g1_1.Add( v[ 0 ] );
			ucGraph1_2.add_value( v[ 1 ] ); g1_2.Add( v[ 1 ] );
			ucGraph1_3.add_value( v[ 2 ] ); g1_3.Add( v[ 2 ] );
			ucGraph1_4.add_value( v[ 3 ] ); g1_4.Add( v[ 3 ] );

			ucGraph2_1.add_value( v[ 4 ] ); g2_1.Add( v[ 4 ] );
			ucGraph2_2.add_value( v[ 5 ] ); g2_2.Add( v[ 5 ] );
			ucGraph2_3.add_value( v[ 6 ] ); g2_3.Add( v[ 6 ] );
			ucGraph2_4.add_value( v[ 7 ] ); g2_4.Add( v[ 7 ] );

			ucGraph1_1.set_min( g1_1.Min() ); ucGraph1_1.set_max( g1_1.Max() ); ucGraph1_1.set_ave( g1_1.Average() );
			ucGraph1_2.set_min( g1_2.Min() ); ucGraph1_2.set_max( g1_2.Max() ); ucGraph1_2.set_ave( g1_2.Average() );
			ucGraph1_3.set_min( g1_3.Min() ); ucGraph1_3.set_max( g1_3.Max() ); ucGraph1_3.set_ave( g1_3.Average() );
			ucGraph1_4.set_min( g1_4.Min() ); ucGraph1_4.set_max( g1_4.Max() ); ucGraph1_4.set_ave( g1_4.Average() );

			ucGraph2_1.set_min( g2_1.Min() ); ucGraph2_1.set_max( g2_1.Max() ); ucGraph2_1.set_ave( g2_1.Average() );
			ucGraph2_2.set_min( g2_2.Min() ); ucGraph2_2.set_max( g2_2.Max() ); ucGraph2_2.set_ave( g2_2.Average() );
			ucGraph2_3.set_min( g2_3.Min() ); ucGraph2_3.set_max( g2_3.Max() ); ucGraph2_3.set_ave( g2_3.Average() );
			ucGraph2_4.set_min( g2_4.Min() ); ucGraph2_4.set_max( g2_4.Max() ); ucGraph2_4.set_ave( g2_4.Average() );

			times.Add( DateTime.Now );
		}

		private void BwGraphRefresh_DoWork( object sender, DoWorkEventArgs e )
		{
			while( true )
			{
				if( bwGraphRefresh.CancellationPending )
					break;

				System.Threading.Thread.Sleep( 100 );

				Random rand = new Random();
				List<double> d = new List<double>();
				d.Add( rand.Next( 5000 ) / 100.0 );
				d.Add( rand.Next( 5000 ) / 100.0 );
				d.Add( rand.Next( 5000 ) / 100.0 );
				d.Add( rand.Next( 5000 ) / 100.0 );
				d.Add( rand.Next( 5000 ) / 100.0 );
				d.Add( rand.Next( 5000 ) / 100.0 );
				d.Add( rand.Next( 5000 ) / 100.0 );
				d.Add( rand.Next( 5000 ) / 100.0 );

				bwGraphRefresh.ReportProgress( 0, d );
			}
		}

		private void BwGraphRefresh_RunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e )
		{
			// save
			string text = ",1차축 센서1,1차축 센서2,1차축 센서3,1차축 센서4,2차축 센서1,2차축 센서2,2차축 센서3,2차축 센서4,\r\n" +
				"MIN," + g1_1.Min().ToString( "0.000" ) + "," + g1_2.Min().ToString( "0.000" ) + "," + g1_3.Min().ToString( "0.000" ) + "," + g1_4.Min().ToString( "0.000" ) + "," + g2_1.Min().ToString( "0.000" ) + "," + g2_2.Min().ToString( "0.000" ) + "," + g2_3.Min().ToString( "0.000" ) + "," + g2_4.Min().ToString( "0.000" ) + ",\r\n" +
				"MAX," + g1_1.Max().ToString( "0.000" ) + "," + g1_2.Max().ToString( "0.000" ) + "," + g1_3.Max().ToString( "0.000" ) + "," + g1_4.Max().ToString( "0.000" ) + "," + g2_1.Max().ToString( "0.000" ) + "," + g2_2.Max().ToString( "0.000" ) + "," + g2_3.Max().ToString( "0.000" ) + "," + g2_4.Max().ToString( "0.000" ) + ",\r\n" +
				"AVE," + g1_1.Average().ToString( "0.000" ) + "," + g1_2.Average().ToString( "0.000" ) + "," + g1_3.Average().ToString( "0.000" ) + "," + g1_4.Average().ToString( "0.000" ) + "," + g2_1.Average().ToString( "0.000" ) + "," + g2_2.Average().ToString( "0.000" ) + "," + g2_3.Average().ToString( "0.000" ) + "," + g2_4.Average().ToString( "0.000" ) + ",\r\n";

			for( int idx = 0; idx < times.Count; idx++ )
			{
				text += times[ idx ].ToString( "yyyy-MM-dd HH:mm:ss.fff" ) + "," + g1_1[ idx ].ToString( "0.000" ) + "," + g1_2[ idx ].ToString( "0.000" ) + "," + g1_3[ idx ].ToString( "0.000" ) + "," + g1_4[ idx ].ToString( "0.000" ) + "," + g2_1[ idx ].ToString( "0.000" ) + "," + g2_2[ idx ].ToString( "0.000" ) + "," + g2_3[ idx ].ToString( "0.000" ) + "," + g2_4[ idx ].ToString( "0.000" ) + ",\r\n"; 
			}
			
			string filename = string.Format( "{0}\\{1}-{2}_Data.csv", System.IO.Directory.GetCurrentDirectory(), start_time.ToString( "yyyyMMddHHmmss" ), end_time.ToString( "yyyyMMddHHmmss" ) );
			File.WriteAllText( filename, text, Encoding.UTF8 );
		}
	}
}
