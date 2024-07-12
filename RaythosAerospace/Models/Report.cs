using System;
namespace RaythosAerospace.Models
{
	public class Report
	{
		public Report()
		{
		}
		public int ReportId { get; set; }
		public string ReportType { get; set; }
		public DateTime GeneratedDate { get; set; }
		public string Data { get; set; }

    }
}

