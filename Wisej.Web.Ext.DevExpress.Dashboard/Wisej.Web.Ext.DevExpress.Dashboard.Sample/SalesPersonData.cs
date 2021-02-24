using System;
using System.Collections.Generic;

namespace Wisej.Web.Ext.DevExpress.Dashboard.Sample
{
	public class SalesPersonData
	{
		public string SalesPerson { get; set; }
		public int Quantity { get; set; }

		public static List<SalesPersonData> CreateData()
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

			var random = new Random();
			for (int i = 0; i < 100; i++)
			{
				SalesPersonData record = new SalesPersonData();
				record.SalesPerson = salesPersons[random.Next(0, salesPersons.Length)];
				record.Quantity = random.Next(0, 100);
				data.Add(record);
			}
			return data;
		}
	}
}