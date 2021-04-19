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

		public void set_title( string _title )
		{
			lbTitle.Text = _title;
		}

		public void set_min( double _val )
		{
			lbMin.Text = _val.ToString( "0.000" );
		}

		public void set_max( double _val )
		{
			lbMax.Text = _val.ToString( "0.000" );
		}

		public void set_ave( double _val )
		{
			lbAve.Text = _val.ToString( "0.000" );
		}

		public void add_value( double _val )
		{
			lbReal.Text = _val.ToString( "0.000" );

			graph.Series[ 0 ].Points.Add( _val );
			
			if( graph.Series[ 0 ].Points.Count() > 50 )
			{
				graph.Series[ 0 ].Points.RemoveAt( 0 );
			}
		}

		private void ucGraph_Load( object sender, EventArgs e )
		{
			graph.Series.Add( "Value" );
		}
	}
}
