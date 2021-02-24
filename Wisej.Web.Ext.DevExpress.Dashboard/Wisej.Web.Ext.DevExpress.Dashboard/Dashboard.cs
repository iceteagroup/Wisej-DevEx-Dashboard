using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.Web;
using System;
using System.ComponentModel;
using Wisej.Web.Ext.AspNetControl;

namespace Wisej.Web.Ext.DevExpress.Dashboard
{
	/// <summary>
	/// Represents a wrapped <see cref="ASPxDashboard"/> for Wisej.
	/// </summary>
	public class Dashboard : AspNetWrapper<ASPxDashboard>
	{
		public Dashboard()
		{
			InitializeComponent();
		}

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// Dashboard
			// 
			this.Name = "Dashboard";
			this.Size = new System.Drawing.Size(450, 376);
			this.Text = "Dashboard";
			this.ResumeLayout(false);

		}

		#endregion

		#region Properties

		public DashboardControlClientSideEvents ClientSideEvents
		{
			get
			{
				return 
					this._clientSideEvents 
						= this._clientSideEvents 
							?? new DashboardControlClientSideEvents();
			}
		}
		private DashboardControlClientSideEvents _clientSideEvents;

		/// <summary>
		/// Gets or sets the ASPxDashboard's client programmatic identifier.
		/// </summary>
		public string ClientInstanceName 
		{ 
			get
			{
				return this._clientInstanceName;
			}
			set
			{
				if (this._clientInstanceName != value)
				{
					this._clientInstanceName = value;
				}
			}
		}
		private string _clientInstanceName;

		/// <summary>
		/// Gets or sets whether an end-user can create new dashboards in the ASPxDashboard.
		/// </summary>
		public bool AllowCreateNewDashboard 
		{
			get
			{
				return this._allowCreateNewDashboard;
			}
			set
			{
				if (this._allowCreateNewDashboard != value)
				{
					this._allowCreateNewDashboard = value;
					Update();
				}
			}
		}
		private bool _allowCreateNewDashboard;

		/// <summary>
		/// Gets or sets whether an end user can create a JSON data source with a new data connection.
		/// </summary>
		public bool AllowCreateNewJsonConnection
		{
			get
			{
				return this._allowCreateNewJsonConnection;
			}
			set
			{
				if (this._allowCreateNewJsonConnection != value)
				{
					this._allowCreateNewJsonConnection = value;
					Update();
				}
			}
		}
		private bool _allowCreateNewJsonConnection;

		/// <summary>
		/// Gets or sets whether to executes SQL queries on the server side.
		/// </summary>
		public bool AllowExecutingCustomSql
		{
			get
			{
				return this._allowExecutingCustomSql;
			}
			set
			{
				if (this._allowExecutingCustomSql != value)
				{
					this._allowExecutingCustomSql = value;
					Update();
				}
			}
		}
		private bool _allowExecutingCustomSql;

		/// <summary>
		/// Gets or sets whether the entire dashboard can be exported by end-users.
		/// </summary>
		public bool AllowExportDashboard
		{
			get
			{
				return this._allowExportDashboard;
			}
			set
			{
				if (this._allowExportDashboard != value)
				{
					this._allowExportDashboard = value;
					Update();
				}
			}
		}
		private bool _allowExportDashboard;

		public bool AllowExportDashboardItems
		{
			get
			{
				return this._allowExportDashboardItems;
			}
			set
			{
				if (this._allowExportDashboardItems != value)
				{
					this._allowExportDashboardItems = value;
					Update();
				}
			}
		}
		private bool _allowExportDashboardItems;

		public bool AllowInspectAggregatedData
		{
			get
			{
				return this._allowInspectAggregatedData;
			}
			set
			{
				if (this._allowInspectAggregatedData != value)
				{
					this._allowInspectAggregatedData = value;
					Update();
				}
			}
		}
		private bool _allowInspectAggregatedData;

		#endregion

		#region Initialization

		protected override void OnInit(EventArgs e)
		{
			base.OnInit(e);

			var dashboard = this.WrappedControl;

			// register events.
			AssignClientSideEvents();
			dashboard.DataLoading += this.dashboard_DataLoading;
			dashboard.CustomDataCallback += this.dashboard_CustomDataCallback;

			// assign properties.
			dashboard.ClientInstanceName = this.ClientInstanceName;
			dashboard.AllowCreateNewDashboard = this.AllowCreateNewDashboard;

			// invoke methods.
			dashboard.SetDashboardStorage(this._dashboardStorage);
			dashboard.SetDataSourceStorage(this._dataSourceStorage);
		}

		/// <summary>
		/// Uses reflection to assign all the client-side events.
		/// </summary>
		private void AssignClientSideEvents()
		{
			var dashboardClientSideEvents = this.WrappedControl.ClientSideEvents;
			var properties = TypeDescriptor.GetProperties(this.ClientSideEvents);
			foreach (PropertyDescriptor p in properties)
			{
				p.SetValue(dashboardClientSideEvents, p.GetValue(this.ClientSideEvents));
			}
		}

		#endregion

		#region Methods

		public void SetDataSourceStorage(IDataSourceStorage dataSourceStorage)
		{
			this._dataSourceStorage = dataSourceStorage;
			Update();
		}
		private IDataSourceStorage _dataSourceStorage;

		public void SetDashboardStorage(IDashboardStorage dashboardStorage)
		{
			this._dashboardStorage = dashboardStorage;
			Update();
		}
		private IDashboardStorage _dashboardStorage;

		#endregion

		#region Events

		public event CustomDataCallbackEventHandler CustomDataCallback;

		private void dashboard_CustomDataCallback(object sender, global::DevExpress.Web.CustomDataCallbackEventArgs e)
		{
			if (CustomDataCallback != null)
			{
				Application.Update(this, () =>
				{
					CustomDataCallback(sender, e);
				});
			}
		}

		/// <summary>
		/// Allows you to provide data for the DevExpress.DashboardCommon.DashboardObjectDataSource.
		/// </summary>
		public event DataLoadingWebEventHandler DataLoading;

		void dashboard_DataLoading(object sender, DataLoadingWebEventArgs e)
		{
			if (DataLoading != null)
			{
				Application.Update(this, () =>
				{
					DataLoading(sender, e);
				});
			}
		}

		#endregion
	}
}
