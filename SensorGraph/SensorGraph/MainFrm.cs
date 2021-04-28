using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SensorGraph
{
	public partial class MainFrm : Form
	{
		private ucMainView ucMainView = new ucMainView();
		private ucSetupView ucSetupView = new ucSetupView();

		public static string IP_Axis1 = "";
		public static int PORT_Axis1 = 0;

		public static string IP_Axis2 = "";
		public static int PORT_Axis2 = 0;

		public static int interval_msec = 100;

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
			lbVersion.Text = "v" + typeof( MainFrm ).Assembly.GetName().Version.ToString();
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

		private void lbClock_DoubleClick( object sender, EventArgs e )
		{
			if( Control.ModifierKeys == ( Keys.Control ) )
			{
				if( lbClock.BackColor == Color.Red )
				{
					lbClock.BackColor = Color.White;
				}
				else
				{
					lbClock.BackColor = Color.Red;
				}

				ucMainView.set_simul( lbClock.BackColor == Color.Red ? true : false );
			}
		}
	}
}
