using DevExpress.DashboardWeb;
using DevExpress.Web;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Wisej.Web.Ext.AspNetControl;

namespace Wisej.Web.Ext.DevExpress.Dashboard
{
	/// <summary>
	/// Represents a wrapped <see cref="ASPxDashboard"/> for Wisej.
	/// </summary>
	[ToolboxItem(true)]
	[ToolboxBitmap(typeof(Dashboard), "DevExtreme.bmp")]
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

		/// <summary>
		/// Allows you to hide specific dashboard items when exporting the entire dashboard.
		/// </summary>
		public event BeforeExportDocumentWebEventHandler BeforeExportDocument;

		private void dashboard_BeforeExportDocument(object sender, BeforeExportDocumentWebEventArgs e)
		{
			if (BeforeExportDocument != null)
			{
				Application.Update(this, () =>
				{
					BeforeExportDocument(sender, e);
				});
			}
		}

		/// <summary>
		/// Allows you to customize connection settings before the ASPxDashboard connects to a data store (database, OLAP cube, etc.).
		/// </summary>
		public event ConfigureDataConnectionWebEventHandler ConfigureDataConnection;

		private void dashboard_ConfigureDataConnection(object sender, ConfigureDataConnectionWebEventArgs e)
		{
			if (ConfigureDataConnection != null)
			{
				Application.Update(this, () =>
				{
					ConfigureDataConnection(sender, e);
				});
			}
		}

		/// <summary>
		/// Allows overriding the default behavior when current connection parameters do not allow connecting to a data store.
		/// </summary>
		public event ConnectionErrorWebEventHandler ConnectionError;

		private void dashboard_ConnectionError(object sender, ConnectionErrorWebEventArgs e)
		{
			if (ConnectionError != null)
			{
				Application.Update(this, () =>
				{
					ConnectionError(sender, e);
				});
			}
		}

		/// <summary>
		/// Allows you to set a time interval that specifies how frequently the Web Dashboard should refill its in-memory cache when a user sends a data request.
		/// </summary>
		public event ConfigureDataReloadingTimeoutWebEventHandler ConfigureDataReloadingTimeout;

		private void dashboard_ConfigureDataReloadingTimeout(object sender, ConfigureDataReloadingTimeoutWebEventArgs e)
		{
			if (ConfigureDataReloadingTimeout != null)
			{
				Application.Update(this, () =>
				{
					ConfigureDataReloadingTimeout(sender, e);
				});
			}
		}

		/// <summary>
		/// Allows you to configure how the dashboard item's client data is calculated.
		/// </summary>
		public event ConfigureItemDataCalculationWebEventHandler ConfigureItemDataCalculation;

		private void dashboard_ConfigureItemDataCalculation(object sender, ConfigureItemDataCalculationWebEventArgs e)
		{
			if (ConfigureItemDataCalculation != null)
			{
				Application.Update(this, () =>
				{
					ConfigureItemDataCalculation(sender, e);
				});
			}
		}

		/// <summary>
		/// Allows you to specify the initial dashboard state when loading a dashboard.
		/// </summary>
		public event SetInitialDashboardStateEventHandler SetInitialDashboardState;

		private void dashboard_SetInitialDashboardState(object sender, SetInitialDashboardStateEventArgs e)
		{
			if (SetInitialDashboardState != null)
			{
				Application.Update(this, () =>
				{
					SetInitialDashboardState(sender, e);
				});
			}
		}

		/// <summary>
		/// Allows you to customize the exported document.
		/// </summary>
		public event CustomizeExportDocumentWebEventHandler CustomizeExportDocument;

		private void dashboard_CustomizeExportDocument(object sender, CustomizeExportDocumentWebEventArgs e)
		{
			if (CustomizeExportDocument != null)
			{
				Application.Update(this, () =>
				{
					CustomizeExportDocument(sender, e);
				});
			}
		}

		/// <summary>
		/// Allows you to include WHERE clauses into DashboardSqlDataSource queries.
		/// </summary>
		public event CustomFilterExpressionWebEventHandler CustomFilterExpression;

		private void dashboard_CustomFilterExpression(object sender, CustomFilterExpressionWebEventArgs e)
		{
			if (CustomFilterExpression != null)
			{
				Application.Update(this, () =>
				{
					CustomFilterExpression(sender, e);
				});
			}
		}

		/// <summary>
		/// Enables you to supply any server data that can then be parsed on the client.
		/// </summary>
		public event CustomJSPropertiesEventHandler CustomJSProperties;

		private void dashboard_CustomJSProperties(object sender, CustomJSPropertiesEventArgs e)
		{
			if (CustomJSProperties != null)
			{
				Application.Update(this, () =>
				{
					CustomJSProperties(sender, e);
				});
			}
		}

		/// <summary>
		/// Occurs before data is loaded from the data store and allows you to change parameter values before they are passed to a data query.
		/// </summary>
		public event CustomParametersWebEventHandler CustomParameters;

		private void dashboard_CustomParameters(object sender, CustomParametersWebEventArgs e)
		{
			if (CustomParameters != null)
			{
				Application.Update(this, () =>
				{
					CustomParameters(sender, e);
				});
			}
		}

		/// <summary>
		/// Allows you to load a dashboard at runtime.
		/// </summary>
		public event DashboardLoadingWebEventHandler DashboardLoading;

		private void dashboard_DashboardLoading(object sender, DashboardLoadingWebEventArgs e)
		{
			if (DashboardLoading != null)
			{
				Application.Update(this, () =>
				{
					DashboardLoading(sender, e);
				});
			}
		}

		/// <summary>
		/// Allows you to save a dashboard at runtime.
		/// </summary>
		public event DashboardSavingWebEventHandler DashboardSaving;

		private void dashboard_DashboardSaving(object sender, DashboardSavingWebEventArgs e)
		{
			if (DashboardSaving != null)
			{
				Application.Update(this, () =>
				{
					DashboardSaving(sender, e);
				});
			}
		}

		/// <summary>
		/// Allows you to add a new dashboard to the dashboard storage at runtime.
		/// </summary>
		public event DashboardAddingWebEventHandler DashboardAdding;

		private void dashboard_DashboardAdding(object sender, DashboardAddingWebEventArgs e)
		{
			if (DashboardAdding != null)
			{
				Application.Update(this, () =>
				{
					DashboardAdding(sender, e);
				});
			}
		}

		/// <summary>
		/// Provides the capability to substitute the default palette containing colors used to paint dashboard item elements.
		/// </summary>
		public event CustomPaletteWebEventHandler CustomPalette;

		private void dashboard_CustomPalette(object sender, CustomPaletteWebEventArgs e)
		{
			if (CustomPalette != null)
			{
				Application.Update(this, () =>
				{
					CustomPalette(sender, e);
				});
			}
		}

		/// <summary>
		/// Allows you to customize the exported document.
		/// </summary>
		public event CustomExportWebEventHandler CustomExport;

		private void dashboard_CustomExport(object sender, CustomExportWebEventArgs e)
		{
			if (CustomExport != null)
			{
				Application.Update(this, () =>
				{
					CustomExport(sender, e);
				});
			}
		}

		#endregion

		#region Properties

		/// <summary>
		/// Specifies options that allow you to configure the Web Dashboard's back-end.
		/// </summary>
		public DashboardBackendOptions BackendOptions
		{ 
			get
			{
				return
					this._backendOptions
						= this._backendOptions
							?? new DashboardBackendOptions();
			}
		}
		private DashboardBackendOptions _backendOptions;

		/// <summary>
		/// Uses reflection to assign the backend options.
		/// </summary>
		private void AssignBackendOptions(ASPxDashboard dashboard)
		{
			var backendOptions = dashboard.BackendOptions;
			var properties = TypeDescriptor.GetProperties(this.BackendOptions);
			foreach (PropertyDescriptor p in properties)
			{
				p.SetValue(backendOptions, p.GetValue(this.BackendOptions));
			}
		}

		/// <summary>
		/// Gets an object that lists the client-side events specific to the ASPxDashboard control.
		/// </summary>
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
		/// Uses reflection to assign the client-side events.
		/// </summary>
		private void AssignClientSideEvents(ASPxDashboard dashboard)
		{
			var dashboardClientSideEvents = dashboard.ClientSideEvents;
			var properties = TypeDescriptor.GetProperties(this.ClientSideEvents);
			foreach (PropertyDescriptor p in properties)
			{
				p.SetValue(dashboardClientSideEvents, p.GetValue(this.ClientSideEvents));
			}
		}

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

		/// <summary>
		/// Gets or sets whether the dashboard items can be exported by end-users.
		/// </summary>
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

		/// <summary>
		/// Gets or sets whether to display aggregated data in the Data Inspector.
		/// </summary>
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

		/// <summary>
		/// Gets or sets whether to display raw data in the Data Inspector.
		/// </summary>
		public bool AllowInspectRawData 
		{ 
			get
			{
				return this._allowInspectRawData;
			}
			set
			{
				if (this._allowInspectRawData != value)
				{
					this._allowInspectRawData = value;
					Update();
				}
			}
		}
		private bool _allowInspectRawData;

		/// <summary>
		/// Gets or sets whether end users can maximize dashboard items.
		/// </summary>
		public bool AllowMaximizeItems 
		{
			get
			{
				return this._allowMaximizeItems;
			}
			set
			{ 
				if (this._allowMaximizeItems != value)
				{
					this._allowMaximizeItems = value;
					Update();
				}
			}
		}
		private bool _allowMaximizeItems;

		/// <summary>
		/// Gets or sets whether an end-user can open existing dashboards in the ASPxDashboard.
		/// </summary>
		public bool AllowOpenDashboard 
		{ 
			get
			{
				return this._allowOpenDashboard;
			}
			set
			{
				if (this._allowOpenDashboard != value)
				{
					this._allowOpenDashboard = value;
					Update();
				}
			}
		}
		private bool _allowOpenDashboard;

		/// <summary>
		/// Gets or sets the name of the color theme to be applied to the control.
		/// </summary>
		public string ColorScheme 
		{ 
			get
			{
				return this._colorScheme;
			}
			set
			{
				if (this._colorScheme != value)
				{
					this._colorScheme = value;
					Update();
				}
			}
		}
		private string _colorScheme = "";

		/// <summary>
		/// Gets or sets the path to a folder used to keep dashboards.
		/// </summary>
		public string DashboardStorageFolder
		{
			get
			{
				return this._dashboardStorageFolder;
			}
			set
			{
				if (this._dashboardStorageFolder != value)
				{
					this._dashboardStorageFolder = value;
					Update();
				}
			}
		}
		private string _dashboardStorageFolder = "";

		/// <summary>
		/// Gets or sets the path to the XML definition of a dashboard to be loaded to ASPxDashboard.
		/// </summary>
		public string DashboardXmlPath 
		{ 
			get
			{
				return this._dashboardXmlPath;
			}
			set
			{
				if (this._dashboardXmlPath != value)
				{
					this._dashboardXmlPath = value;
					Update();
				}
			}
		}
		private string _dashboardXmlPath = "";

		/// <summary>
		/// Gets or sets a value that indicates whether a web control is enabled, allowing it to respond to end-user interactions. Inherited from ASPxWebControl.
		/// </summary>
		public new bool Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				if (this._enabled != value)
				{
					this._enabled = value;
					Update();
				}
			}
		}
		private bool _enabled = true;

		public bool EnableCustomSql
		{
			get
			{
				return this._enableCustomSql;
			}
			set
			{
				if (this._enableCustomSql != value)
				{
					this._enableCustomSql = value;
					Update();
				}
			}
		}
		private bool _enableCustomSql = false;

		/// <summary>
		/// Gets or sets whether to allow users to create the JSON data source in the Dashboard Data Source Wizard.
		/// </summary>
		public bool EnableJsonDataSource
		{
			get
			{
				return this._enableJsonDataSource;
			}
			set
			{
				if (this._enableJsonDataSource != value)
				{
					this._enableJsonDataSource = value;
					Update();
				}
			}
		}
		private bool _enableJsonDataSource = true;

		/// <summary>
		/// Gets or sets whether to allow users to create the OLAP data source in the Dashboard Data Source Wizard.
		/// </summary>
		public bool EnableOlapDataSource
		{
			get
			{
				return this._enableOlapDataSource;
			}
			set
			{
				if (this._enableOlapDataSource != value)
				{
					this._enableOlapDataSource = value;
					Update();
				}
			}
		}
		private bool _enableOlapDataSource = true;

		/// <summary>
		/// Gets or sets whether to allow users to create the SQL data source in the Dashboard Data Source Wizard.
		/// </summary>
		public bool EnableSqlDataSource
		{
			get
			{
				return this._enableSqlDataSource;
			}
			set
			{
				if (this._enableSqlDataSource != value)
				{
					this._enableSqlDataSource = value;
					Update();
				}
			}
		}
		private bool _enableSqlDataSource = true;

		public MobileLayoutMode MobileLayoutEnabled
		{
			get
			{
				return this._mobileLayoutEnabled;
			}
			set
			{
				if (this._mobileLayoutEnabled != value)
				{
					this._mobileLayoutEnabled = value;
					Update();
				}
			}
		}
		private MobileLayoutMode _mobileLayoutEnabled = MobileLayoutMode.Auto;

		#endregion

		#region Methods

		/// <summary>
		/// Copies any nonblank elements of the specified style to the Web control, overwriting
		///     any existing style elements of the control. This method is primarily used by
		///     control developers.
		/// </summary>
		/// <param name="s">A System.Web.UI.WebControls.Style that represents the style to be copied.</param>
		public void ApplyStyle(Style s)
		{
			this._s = s;
			Update();
		}
		private Style _s;

		/// <summary>
		/// Loads a dashboard from a string containing a dashboard XML definition.
		/// </summary>
		/// <remarks>Note that the OpenDashboard method can be used only on the initial page loading (in the Page_Load event handler).</remarks>
		/// <param name="xml">A System.String value that specifies a dashboard XML definition.</param>
		public void OpenDashboard(string xml)
		{
			this.WrappedControl.OpenDashboard(xml);
		}

		/// <summary>
		/// Loads a dashboard from a document containing a dashboard XML definition.
		/// </summary>
		/// <remarks>Note that the OpenDashboard method can be used only on the initial page loading (in the Page_Load event handler).</remarks>
		/// <param name="document">A System.Xml.Linq.XDocument object that is a document 
		/// containing a dashboard xml definition.</param>
		public void OpenDashboard(XDocument document)
		{
			this.WrappedControl.OpenDashboard(document);
		}

		/// <summary>
		/// Specifies a data source storage for the Web Dashboard.
		/// </summary>
		/// <param name="dataSourceStorage">An object implementing the DevExpress.DashboardWeb.IDataSourceStorage interface
		/// that is a storage of the dashboard data sources.</param>
		public void SetDataSourceStorage(IDataSourceStorage dataSourceStorage)
		{
			this._dataSourceStorage = dataSourceStorage;
			Update();
		}
		private IDataSourceStorage _dataSourceStorage;

		/// <summary>
		/// Specifies a custom storage of dashboards for the Web Dashboard.
		/// </summary>
		/// <param name="dashboardStorage">An object implementing the DevExpress.DashboardWeb.IDashboardStorage
		/// interface that is the custom storage of dashboards.</param>
		public void SetDashboardStorage(IDashboardStorage dashboardStorage)
		{
			this._dashboardStorage = dashboardStorage;
			Update();
		}
		private IDashboardStorage _dashboardStorage;

		#endregion

		#region Initialization

		protected override void OnInit(EventArgs e)
		{
			base.OnInit(e);

			var dashboard = this.WrappedControl;

			// assign properties.
			AssignBackendOptions(dashboard);
			dashboard.Enabled = this.Enabled;
			dashboard.BackColor = this.BackColor;
			dashboard.ColorScheme = this.ColorScheme;
			dashboard.EnableCustomSql = this.EnableCustomSql;
			dashboard.DashboardXmlPath = this.DashboardXmlPath;
			dashboard.AllowMaximizeItems = this.AllowMaximizeItems;
			dashboard.AllowOpenDashboard = this.AllowOpenDashboard;
			dashboard.ClientInstanceName = this.ClientInstanceName;
			dashboard.MobileLayoutEnabled = this.MobileLayoutEnabled;
			dashboard.AllowInspectRawData = this.AllowInspectRawData;
			dashboard.EnableSqlDataSource = this.EnableSqlDataSource;
			dashboard.EnableSqlDataSource = this.EnableSqlDataSource;
			dashboard.EnableJsonDataSource = this.EnableJsonDataSource;
			dashboard.EnableOlapDataSource = this.EnableOlapDataSource;
			dashboard.AllowExportDashboard = this.AllowExportDashboard;
			dashboard.DashboardStorageFolder = this.DashboardStorageFolder;
			dashboard.AllowCreateNewDashboard = this.AllowCreateNewDashboard;
			dashboard.AllowExecutingCustomSql = this.AllowExecutingCustomSql;
			dashboard.AllowExportDashboardItems = this.AllowExportDashboardItems;
			dashboard.AllowInspectAggregatedData = this.AllowInspectAggregatedData;
			dashboard.AllowCreateNewJsonConnection = this.AllowCreateNewJsonConnection;

			// register events.
			AssignClientSideEvents(dashboard);
			dashboard.DataLoading += this.dashboard_DataLoading;
			dashboard.CustomExport += this.dashboard_CustomExport;
			dashboard.CustomPalette += this.dashboard_CustomPalette;
			dashboard.DashboardAdding += this.dashboard_DashboardAdding;
			dashboard.DashboardSaving += this.dashboard_DashboardSaving;
			dashboard.ConnectionError += this.dashboard_ConnectionError;
			dashboard.DashboardLoading += this.dashboard_DashboardLoading;
			dashboard.CustomParameters += this.dashboard_CustomParameters;
			dashboard.CustomDataCallback += this.dashboard_CustomDataCallback;
			dashboard.CustomJSProperties += this.dashboard_CustomJSProperties;
			dashboard.BeforeExportDocument += this.dashboard_BeforeExportDocument;
			dashboard.CustomFilterExpression += this.dashboard_CustomFilterExpression;
			dashboard.ConfigureDataConnection += this.dashboard_ConfigureDataConnection;
			dashboard.CustomizeExportDocument += this.dashboard_CustomizeExportDocument;
			dashboard.SetInitialDashboardState += this.dashboard_SetInitialDashboardState;
			dashboard.ConfigureItemDataCalculation += this.dashboard_ConfigureItemDataCalculation;
			dashboard.ConfigureDataReloadingTimeout += this.dashboard_ConfigureDataReloadingTimeout;
		}

		#endregion

	}
}
