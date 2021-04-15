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

		private void btnSave_Click( object sender, EventArgs e )
		{
			System.Console.WriteLine( tbAxis1ServerIP );
			System.Console.WriteLine( tbAxis1ServerPORT );

			int port = Convert.ToInt32( tbAxis1ServerPORT.Text );
		}
	}
}
