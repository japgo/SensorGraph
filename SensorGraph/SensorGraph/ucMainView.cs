using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorGraph
{
	public partial class ucMainView : UserControl
	{
		public ucMainView()
		{
			InitializeComponent();
		}

		private void background_work_init()
		{
			bwGraphRefresh.DoWork += BwGraphRefresh_DoWork;
			bwGraphRefresh.ProgressChanged += BwGraphRefresh_ProgressChanged;
			bwGraphRefresh.WorkerReportsProgress = true;
			bwGraphRefresh.WorkerSupportsCancellation = true;
		}

		private void ucMainView_Load( object sender, EventArgs e )
		{
			background_work_init();
		}

		private void btnStart_Click( object sender, EventArgs e )
		{
			bwGraphRefresh.RunWorkerAsync();
		}

		private void btnStop_Click( object sender, EventArgs e )
		{
			bwGraphRefresh.CancelAsync();
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

				bwGraphRefresh.ReportProgress( 0, d );
			}
		}

		
	}
}
