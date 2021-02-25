
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.Web;
using System;

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
			// Register the dashboards.
			DashboardFileStorage dashboardFileStorage = new DashboardFileStorage("~/App_Data/Dashboards");
			this.dashboard1.SetDashboardStorage(dashboardFileStorage);

			// give the wrapped control a unique name.
			this.dashboard1.ClientInstanceName = "dashboard1";

			// register the data source.
			var dataSourceStorage = CreateDataSourceStorage();
			this.dashboard1.SetDataSourceStorage(dataSourceStorage);

			// register events.
			this.dashboard1.DataLoading += Dashboard1_DataLoading;
			this.dashboard1.CustomDataCallback += Dashboard1_CustomDataCallback;
			this.dashboard1.ClientSideEvents.ItemClick = @"
				function(sender, e) {
					dashboard1.PerformDataCallback(e.ItemName); 
				}";

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
	}
}
