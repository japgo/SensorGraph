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
	public partial class ucGraph : UserControl
	{
		public ucGraph()
		{
			InitializeComponent();
		}

		public void add_value( double _val )
		{
			
		}

		private void ucGraph_Load( object sender, EventArgs e )
		{
			graph.Series.Add( "Value" );
		}
	}
}
