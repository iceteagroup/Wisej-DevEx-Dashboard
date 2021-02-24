
using System;
using Wisej.Web.Ext.DevExpress.Dashboard.Sample.AspNetControl;
using Wisej.Web.Ext.DevExpress.Dashboard.Sample.AspNetPanel;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExpress.Dashboard.Sample
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void Page1_Load(object sender, EventArgs e)
		{
			var w1 = new Window1();
			w1.Show();

			var w2 = new Window2();
			w2.Show();
		}
	}
}
