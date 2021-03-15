
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.Web;
using System;
using System.IO;
using System.Web.UI;

namespace Wisej.Web.Ext.DevExpress.Dashboard.Sample
{
	public partial class Page1 : Page
	{
		private string dashboardXML { get; set; }

		public Page1()
		{
			InitializeComponent();
		}

		private void Page1_Load(object sender, EventArgs e)
		{
			// give the wrapped control a unique name.
			this.dashboard1.ClientInstanceName = "dashboard1";

			// register the data source.
			var dataSourceStorage = CreateDataSourceStorage();
			this.dashboard1.SetDataSourceStorage(dataSourceStorage);

			this.dashboard1.AllowInspectRawData = true;
			this.dashboard1.AllowInspectAggregatedData = true;

			// register events.
			this.dashboard1.Load += Dashboard1_Load;
			this.dashboard1.DataLoading += Dashboard1_DataLoading;
			this.dashboard1.CustomDataCallback += Dashboard1_CustomDataCallback;
			this.dashboard1.ClientSideEvents.BeforeRender = @"
				function(sender) {
					// configure dxGrid startup.
					var control = sender.GetDashboardControl();
					control.unregisterExtension('data-inspector');
					control.registerExtension(new DevExpress.Dashboard.DataInspectorExtension(control, {
						allowInspectAggregatedData: true,
						allowInspectRawData: true,
						onGridInitialized: function (args) {
							args.component.option({
								export: { enabled: true }
							})
						}
					}));
				}";
			this.dashboard1.ClientSideEvents.ItemClick = @"
				function(sender, e) {
					dashboard1.PerformDataCallback(e.ItemName); 
				}";
		}

		private void Dashboard1_Load(object sender, EventArgs e)
		{
			// OpenDashboard() can only be called in the ASPxDashboard's Load event.
			if (!String.IsNullOrEmpty(this.dashboardXML))
				this.dashboard1.OpenDashboard(this.dashboardXML);
		}

		private void Dashboard1_CustomDataCallback(object sender, CustomDataCallbackEventArgs e)
		{
			AlertBox.Show(e.Parameter);
		}

		/// <summary>
		/// Registers the object data source with the dashboard.
		/// </summary>
		/// <returns>The storage of the dashboard data source.</returns>
		public DataSourceInMemoryStorage CreateDataSourceStorage()
		{
			DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();

			DashboardObjectDataSource objDataSource = new DashboardObjectDataSource("Object Data Source");
			objDataSource.DataSource = typeof(SalesPersonData);
			dataSourceStorage.RegisterDataSource("objectDataSource1", objDataSource.SaveToXml());

			return dataSourceStorage;
		}

		private void Dashboard1_DataLoading(object sender, DataLoadingWebEventArgs e)
		{
			// Fires when data source is requested and not found locally within the wrapped dashboard.
			if (e.DataSourceName == "Object Data Source")
				e.Data = SalesPersonData.CreateDataWithDataTable();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var path = Application.MapPath("App_Data/dashboard1.xml");
			this.dashboardXML = File.ReadAllText(Application.MapPath(path));
			this.dashboard1.Update();

			// alternate option.
			// this.dashboard1.DashboardXmlPath = path;
		}

		private void dashboard1_Init(object sender, EventArgs e)
		{
			// register DashboardClient.js
			this.dashboard1.ScriptManager.Scripts.Add(new ScriptReference("DashboardClient.js"));
		}
	}
}
