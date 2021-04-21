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
	public partial class ucSetupView : UserControl
	{
		public ucSetupView()
		{
			InitializeComponent();
		}

		private void set_ip_port()
		{
			MainFrm.IP_Axis1 = tbAxis1ServerIP.Text;
			MainFrm.PORT_Axis1 = Convert.ToInt32( tbAxis1ServerPORT.Text );

			MainFrm.IP_Axis2 = tbAxis2ServerIP.Text;
			MainFrm.PORT_Axis2 = Convert.ToInt32( tbAxis2ServerPORT.Text );
		}

		private void btnSave_Click( object sender, EventArgs e )
		{
			try
			{
				set_ip_port();

				IniFile ini = new IniFile();
				ini[ "Axis1" ][ "IP" ] = tbAxis1ServerIP.Text;
				ini[ "Axis1" ][ "PORT" ] = tbAxis1ServerPORT.Text;
				ini[ "Axis2" ][ "IP" ] = tbAxis2ServerIP.Text;
				ini[ "Axis2" ][ "PORT" ] = tbAxis2ServerPORT.Text;

				string filename = string.Format( "{0}\\setup.ini", System.IO.Directory.GetCurrentDirectory() );
				ini.Save( filename );
			}
			catch( Exception ex )
			{
				MessageBox.Show( ex.Message );
			}
		}

		private void ucSetupView_Load( object sender, EventArgs e )
		{
			IniFile ini = new IniFile();
			string filename = string.Format( "{0}\\setup.ini", System.IO.Directory.GetCurrentDirectory() );
			try
			{
				ini.Load( filename );

				tbAxis1ServerIP.Text = ini[ "Axis1" ][ "IP" ].ToString();
				tbAxis1ServerPORT.Text = ini[ "Axis1" ][ "PORT" ].ToString();
				tbAxis2ServerIP.Text = ini[ "Axis2" ][ "IP" ].ToString();
				tbAxis2ServerPORT.Text = ini[ "Axis2" ][ "PORT" ].ToString();

				set_ip_port();
			}
			catch( Exception )
			{
				ini.Save( filename );
			}
		}
	}
}
