using System;
using System.Collections.Generic;
using System.Data;

namespace Wisej.Web.Ext.DevExpress.Dashboard.Sample
{
	public class SalesPersonData
	{
		public string SalesPerson { get; set; }
		public int Quantity { get; set; }

		public static DataTable CreateDataWithDataTable()
		{
			List<SalesPersonData> data = new List<SalesPersonData>();
			string[] salesPersons = {
								"Andrew Fuller",
								"Michael Suyama",
								"Robert King",
								"Nancy Davolio",
								"Margaret Peacock",
								"Laura Callahan",
								"Steven Buchanan",
								"Janet Leverling"
							};

			var dataTable = new DataTable("SalesInfo");

			dataTable.Columns.Add(new DataColumn("SalesPerson", typeof(string)));
			dataTable.Columns.Add(new DataColumn("Quantity", typeof(int)));

			var random = new Random();
			for (int i = 0; i < 100; i++)
			{
				var salesPerson = salesPersons[random.Next(0, salesPersons.Length)];
				var quantity = random.Next(0, 100);
				dataTable.Rows.Add(salesPerson, quantity);
			}

			return dataTable;
		}
	}
}