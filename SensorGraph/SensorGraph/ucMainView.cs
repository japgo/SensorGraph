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
using System.Net.Sockets;
using System.Net;

namespace SensorGraph
{
	public partial class ucMainView : UserControl
	{
		bool simul = false;

		enum eAxis
		{
			Axis1 = 1,
			Axis2,
		}


		TcpClient tcp1 = new TcpClient();
		TcpClient tcp2 = new TcpClient();

		List<DateTime> times1 = new List<DateTime>();
		List<double> g1_1 = new List<double>();
		List<double> g1_2 = new List<double>();
		List<double> g1_3 = new List<double>();
		List<double> g1_4 = new List<double>();

		List<DateTime> times2 = new List<DateTime>();
		List<double> g2_1 = new List<double>();
		List<double> g2_2 = new List<double>();
		List<double> g2_3 = new List<double>();
		List<double> g2_4 = new List<double>();

		DateTime start_time = new DateTime();
		DateTime end_time = new DateTime();

		private object lockObject = new object();

		public ucMainView()
		{
			InitializeComponent();
		}

		private void background_work_init()
		{
			bwGraphRefresh1.DoWork += BwGraphRefresh1_DoWork;
			bwGraphRefresh1.ProgressChanged += BwGraphRefresh1_ProgressChanged;
			bwGraphRefresh1.RunWorkerCompleted += BwGraphRefresh1_RunWorkerCompleted;
			bwGraphRefresh1.WorkerReportsProgress = true;
			bwGraphRefresh1.WorkerSupportsCancellation = true;

			bwGraphRefresh2.DoWork += BwGraphRefresh2_DoWork;
			bwGraphRefresh2.ProgressChanged += BwGraphRefresh2_ProgressChanged;
			bwGraphRefresh2.RunWorkerCompleted += BwGraphRefresh2_RunWorkerCompleted;
			bwGraphRefresh2.WorkerReportsProgress = true;
			bwGraphRefresh2.WorkerSupportsCancellation = true;
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

			if( bwGraphRefresh1.IsBusy == false )
				bwGraphRefresh1.RunWorkerAsync();

			if( bwGraphRefresh2.IsBusy == false )
				bwGraphRefresh2.RunWorkerAsync();
		}

		private void btnStop_Click( object sender, EventArgs e )
		{
			end_time = DateTime.Now;
			bwGraphRefresh1.CancelAsync();
			bwGraphRefresh2.CancelAsync();

			tcp1.Close();
			tcp2.Close();
		}

		private void save_data( eAxis _axis, ref List<DateTime> times, ref List<double> g1, ref List<double> g2, ref List<double> g3, ref List<double> g4 )
		{
			string strTitle = "";
			switch( _axis )
			{
			case eAxis.Axis1:
				{
					strTitle = ",1차축 센서1,1차축 센서2,1차축 센서3,1차축 센서4,\r\n";
				}
				break;
			case eAxis.Axis2:
				{
					strTitle = ",2차축 센서1,2차축 센서2,2차축 센서3,2차축 센서4,\r\n";
				}
				break;
			default:
				{
					MessageBox.Show( "저장 실패." );
				}break;
			}

			string text = strTitle +
				"MIN," + g1.Min().ToString( "0.000" ) + "," + g2.Min().ToString( "0.000" ) + "," + g3.Min().ToString( "0.000" ) + "," + g4.Min().ToString( "0.000" ) + ",\r\n" +
				"MAX," + g1.Max().ToString( "0.000" ) + "," + g2.Max().ToString( "0.000" ) + "," + g3.Max().ToString( "0.000" ) + "," + g4.Max().ToString( "0.000" ) + ",\r\n" +
				"AVE," + g1.Average().ToString( "0.000" ) + "," + g2.Average().ToString( "0.000" ) + "," + g3.Average().ToString( "0.000" ) + "," + g4.Average().ToString( "0.000" ) + ",\r\n";

			for( int idx = 0; idx < times.Count; idx++ )
			{
				text += times[ idx ].ToString( "yyyy-MM-dd HH:mm:ss.fff" ) + "," + g1[ idx ].ToString( "0.000" ) + "," + g2[ idx ].ToString( "0.000" ) + "," + g3[ idx ].ToString( "0.000" ) + "," + g4[ idx ].ToString( "0.000" ) + ",\r\n";
			}

			string filename = string.Format( "{0}\\{1}-{2}_Data_{3}.csv", System.IO.Directory.GetCurrentDirectory(), start_time.ToString( "yyyyMMddHHmmss" ), end_time.ToString( "yyyyMMddHHmmss" ), _axis );
			File.WriteAllText( filename, text, Encoding.UTF8 );
		}

		public void set_simul( bool _simul )
		{
			simul = _simul;
		}

		private void log( string _log )
		{
			lock( lockObject )
			{
				string filename = string.Format( "{0}\\{1}_log.log", System.IO.Directory.GetCurrentDirectory(), start_time.ToString( "yyyyMMddHHmmss" ) );
				string text = DateTime.Now.ToString( "yyyy-MM-dd HH:mm:ss.fff" ) + " " + _log + "\r\n";
				File.AppendAllText( filename, text, Encoding.UTF8 );
			}
		}

		private double convert_byte_to_val( byte _high, byte _low )
		{
			short val = 0x0000;
			val |= ( short )( _high << 8 );
			val |= ( short )_low;

			if( ( val & 0x8000 ) == 0x8000 )
			{
				val = ( short )( val ^ 0x8000 );
				val *= -1;
			}

			double ret = val / 100.0;
			return ret;
		}













		private void BwGraphRefresh1_ProgressChanged( object sender, ProgressChangedEventArgs e )
		{
			try
			{
				var v = ( List<double> )e.UserState;
				ucGraph1_1.add_value( v[ 0 ] ); g1_1.Add( v[ 0 ] );
				ucGraph1_2.add_value( v[ 1 ] ); g1_2.Add( v[ 1 ] );
				ucGraph1_3.add_value( v[ 2 ] ); g1_3.Add( v[ 2 ] );
				ucGraph1_4.add_value( v[ 3 ] ); g1_4.Add( v[ 3 ] );

				ucGraph1_1.set_min( g1_1.Min() ); ucGraph1_1.set_max( g1_1.Max() ); ucGraph1_1.set_ave( g1_1.Average() );
				ucGraph1_2.set_min( g1_2.Min() ); ucGraph1_2.set_max( g1_2.Max() ); ucGraph1_2.set_ave( g1_2.Average() );
				ucGraph1_3.set_min( g1_3.Min() ); ucGraph1_3.set_max( g1_3.Max() ); ucGraph1_3.set_ave( g1_3.Average() );
				ucGraph1_4.set_min( g1_4.Min() ); ucGraph1_4.set_max( g1_4.Max() ); ucGraph1_4.set_ave( g1_4.Average() );

				times1.Add( DateTime.Now );
			}
			catch( Exception )
			{

			}
			
		}

		private void BwGraphRefresh1_DoWork( object sender, DoWorkEventArgs e )
		{
			if( simul != true )
			{
				IPEndPoint epRemote = new IPEndPoint( IPAddress.Parse( MainFrm.IP_Axis1 ), MainFrm.PORT_Axis1 );
				tcp1 = new TcpClient();
				tcp1.Connect( epRemote );

				byte[] SendBytes = { 0x02, 0x14, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x17, 0x03 };
				tcp1.Client.Send( SendBytes );

				string str = BitConverter.ToString( SendBytes );
				log( string.Format( "AXIS1 IP:{0} PORT:{1} SEND:{2}", MainFrm.IP_Axis1, MainFrm.PORT_Axis1, str ) );
			}

			while( true )
			{
				if( bwGraphRefresh1.CancellationPending )
					break;

				try
				{
					List<double> d = new List<double>() { 0, 0, 0, 0 };
					System.Threading.Thread.Sleep( 1 );

					// 양수 byte[] bytes = { 0x02, 0x14, 0x81, 0x02, 0x14, 0x02, 0x13, 0x02, 0x11, 0x02, 0x12, 0x00, 0xDF, 0x02, 0xE2, 0x01, 0x00, 0x00, 0xAD, 0x03 };
					// 음수 byte[] bytes = { 0x02, 0x14, 0x81, 0x80, 0x64, 0x02, 0x13, 0x02, 0x11, 0x02, 0x12, 0x00, 0xDF, 0x02, 0xE2, 0x01, 0x00, 0x00, 0xAD, 0x03 };
					byte[] bytes = { 0x02, 0x14, 0x81, 0x80, 0x64, 0x02, 0x13, 0x02, 0x11, 0x02, 0x12, 0x00, 0xDF, 0x02, 0xE2, 0x01, 0x00, 0x00, 0xAD, 0x03 };

					if( simul )
					{
						System.Threading.Thread.Sleep( 100 );

						Random rand = new Random();

						bytes[ 3 ] = ( byte )rand.Next( -128, 127 );
						bytes[ 4 ] = ( byte )rand.Next( -128, 127 );
						bytes[ 5 ] = ( byte )rand.Next( -128, 127 ); 
						bytes[ 6 ] = ( byte )rand.Next( -128, 127 );
						bytes[ 7 ] = ( byte )rand.Next( -128, 127 );
						bytes[ 8 ] = ( byte )rand.Next( -128, 127 );
						bytes[ 9 ] = ( byte )rand.Next( -128, 127 );
						bytes[ 10 ] = ( byte )rand.Next( -128, 127 );
					}
					else
					{
						tcp1.Client.Receive(bytes);
					}

					string str = BitConverter.ToString( bytes );
					log( string.Format( "AXIS1 IP:{0} PORT:{1} RECV:{2}", MainFrm.IP_Axis1, MainFrm.PORT_Axis1, str ) );

					if( bytes.Count() != 20 )
						continue;

					if( bytes[ 0 ] != 0x02 )
						continue;

					if( bytes[ 19 ] != 0x03 )
						continue;

					d[ 0 ] = convert_byte_to_val( bytes[ 3 ], bytes[ 4 ] );
					d[ 1 ] = convert_byte_to_val( bytes[ 5 ], bytes[ 6 ] );
					d[ 2 ] = convert_byte_to_val( bytes[ 7 ], bytes[ 8 ] );
					d[ 3 ] = convert_byte_to_val( bytes[ 9 ], bytes[ 10 ] );

					bwGraphRefresh1.ReportProgress( 0, d );
				}
				catch( Exception ex )
				{
					Console.WriteLine( ex.Message );
					log( string.Format( "AXIS1 IP:{0} PORT:{1} Exception:{2}", MainFrm.IP_Axis1, MainFrm.PORT_Axis1, ex.Message ) );
				}
			}
		}

		private void BwGraphRefresh1_RunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e )
		{
			try
			{
				save_data( eAxis.Axis1, ref times1, ref g1_1, ref g1_2, ref g1_3, ref g1_4 );
			}
			catch( Exception )
			{

			}
		}







		private void BwGraphRefresh2_ProgressChanged( object sender, ProgressChangedEventArgs e )
		{
			try
			{
				var v = ( List<double> )e.UserState;

				ucGraph2_1.add_value( v[ 0 ] ); g2_1.Add( v[ 0 ] );
				ucGraph2_2.add_value( v[ 1 ] ); g2_2.Add( v[ 1 ] );
				ucGraph2_3.add_value( v[ 2 ] ); g2_3.Add( v[ 2 ] );
				ucGraph2_4.add_value( v[ 3 ] ); g2_4.Add( v[ 3 ] );

				ucGraph2_1.set_min( g2_1.Min() ); ucGraph2_1.set_max( g2_1.Max() ); ucGraph2_1.set_ave( g2_1.Average() );
				ucGraph2_2.set_min( g2_2.Min() ); ucGraph2_2.set_max( g2_2.Max() ); ucGraph2_2.set_ave( g2_2.Average() );
				ucGraph2_3.set_min( g2_3.Min() ); ucGraph2_3.set_max( g2_3.Max() ); ucGraph2_3.set_ave( g2_3.Average() );
				ucGraph2_4.set_min( g2_4.Min() ); ucGraph2_4.set_max( g2_4.Max() ); ucGraph2_4.set_ave( g2_4.Average() );

				times2.Add( DateTime.Now );
			}
			catch( Exception )
			{

			}
			
		}

		private void BwGraphRefresh2_DoWork( object sender, DoWorkEventArgs e )
		{
			if( simul != true )
			{
				IPEndPoint epRemote = new IPEndPoint( IPAddress.Parse( MainFrm.IP_Axis2 ), MainFrm.PORT_Axis2 );
				tcp2 = new TcpClient();
				tcp2.Connect( epRemote );

				byte[] SendBytes = { 0x02, 0x14, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x17, 0x03 };
				tcp2.Client.Send( SendBytes );

				string str = BitConverter.ToString( SendBytes );
				log( string.Format( "AXIS2 IP:{0} PORT:{1} SEND:{2}", MainFrm.IP_Axis2, MainFrm.PORT_Axis2, str ) );
			}

			while( true )
			{
				if( bwGraphRefresh2.CancellationPending )
					break;

				try
				{
					List<double> d = new List<double>() { 0, 0, 0, 0 };
					System.Threading.Thread.Sleep( 1 );

					// 양수 byte[] bytes = { 0x02, 0x14, 0x81, 0x02, 0x14, 0x02, 0x13, 0x02, 0x11, 0x02, 0x12, 0x00, 0xDF, 0x02, 0xE2, 0x01, 0x00, 0x00, 0xAD, 0x03 };
					// 음수 byte[] bytes = { 0x02, 0x14, 0x81, 0x80, 0x64, 0x02, 0x13, 0x02, 0x11, 0x02, 0x12, 0x00, 0xDF, 0x02, 0xE2, 0x01, 0x00, 0x00, 0xAD, 0x03 };
					byte[] bytes = { 0x02, 0x14, 0x81, 0x80, 0x64, 0x02, 0x13, 0x02, 0x11, 0x02, 0x12, 0x00, 0xDF, 0x02, 0xE2, 0x01, 0x00, 0x00, 0xAD, 0x03 };

					if( simul )
					{
						System.Threading.Thread.Sleep( 100 );

						Random rand = new Random();

						bytes[ 3 ] = ( byte )rand.Next( -128, 127 );
						bytes[ 4 ] = ( byte )rand.Next( -128, 127 );
						bytes[ 5 ] = ( byte )rand.Next( -128, 127 );
						bytes[ 6 ] = ( byte )rand.Next( -128, 127 );
						bytes[ 7 ] = ( byte )rand.Next( -128, 127 );
						bytes[ 8 ] = ( byte )rand.Next( -128, 127 );
						bytes[ 9 ] = ( byte )rand.Next( -128, 127 );
						bytes[ 10 ] = ( byte )rand.Next( -128, 127 );
					}
					else
					{
						tcp2.Client.Receive( bytes );
					}

					string str = BitConverter.ToString( bytes );
					log( string.Format( "AXIS2 IP:{0} PORT:{1} RECV:{2}", MainFrm.IP_Axis2, MainFrm.PORT_Axis2, str ) );

					if( bytes.Count() != 20 )
						continue;

					if( bytes[ 0 ] != 0x02 )
						continue;

					if( bytes[ 19 ] != 0x03 )
						continue;

					d[ 0 ] = convert_byte_to_val( bytes[ 3 ], bytes[ 4 ] );
					d[ 1 ] = convert_byte_to_val( bytes[ 5 ], bytes[ 6 ] );
					d[ 2 ] = convert_byte_to_val( bytes[ 7 ], bytes[ 8 ] );
					d[ 3 ] = convert_byte_to_val( bytes[ 9 ], bytes[ 10 ] );

					bwGraphRefresh2.ReportProgress( 0, d );
				}
				catch( Exception ex )
				{
					Console.WriteLine( ex.Message );
					log( string.Format( "AXIS2 IP:{0} PORT:{1} Exception:{2}", MainFrm.IP_Axis2, MainFrm.PORT_Axis2, ex.Message ) );
				}
			}
		}

		private void BwGraphRefresh2_RunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e )
		{
			try
			{
				save_data( eAxis.Axis2, ref times2, ref g2_1, ref g2_2, ref g2_3, ref g2_4 );
			}
			catch( Exception )
			{

			}
		}


	}
}
