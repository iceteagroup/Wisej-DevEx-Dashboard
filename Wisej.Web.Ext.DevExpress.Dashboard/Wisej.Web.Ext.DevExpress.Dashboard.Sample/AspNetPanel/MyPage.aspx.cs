using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using System;

namespace Wisej.Web.Ext.DevExpress.Dashboard.Sample
{
	public partial class MyDXDashboard : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			#region #DashboardStorage

			// Register the dashboards.
			DashboardFileStorage dashboardFileStorage = new DashboardFileStorage("~/App_Data/Dashboards");
			MyDXDashboard1.SetDashboardStorage(dashboardFileStorage);

			#endregion #DashboardStorage

			#region #DataSourceStorage

			// register the data source.
			var dataSourceStorage = CreateDataSourceStorage();
			MyDXDashboard1.SetDataSourceStorage(dataSourceStorage);

			#endregion #DataSourceStorage
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void MyDXDashboard1_DataLoading(object sender, DataLoadingWebEventArgs e)
		{
			if (e.DataSourceName == "Object Data Source")
			{
				e.Data = SalesPersonData.CreateData();
			}
		}
	}
}