using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MobileApp
{
	public static class FakeDataProvider
	{
		public static async Task<TimeEntry[]> GetFakeData ()
		{
			await Task.Delay (3000);

			var entries = Newtonsoft.Json.JsonConvert.DeserializeObject<TimeEntry[]> (json);
			return entries;
		}

		private static readonly string json = "[{\"hours\":\"01:00\",\"isWorkDay\":false,\"totalHours\":0,\"totalMinutes\":60,\"taskID\":7298,\"taskName\":\"Maintenance T\\u0026M - Aug\",\"descriminator\":\"time\",\"insertTimestamp\":\"\\/Date(1407151446847)\\/\",\"entryID\":75174,\"description\":\"\",\"projectName\":\"Web Evolution - Support\",\"clientName\":\"McCoy\\u0027s\"},{\"hours\":\"00:30\",\"isWorkDay\":false,\"totalHours\":0,\"totalMinutes\":30,\"taskID\":7299,\"taskName\":\"Iteration Zero- Setup\",\"descriminator\":\"time\",\"insertTimestamp\":\"\\/Date(1407151477957)\\/\",\"entryID\":75175,\"description\":\"\",\"projectName\":\"Ed-Fi ETL Upgrade Proof of Concept\",\"clientName\":\"Michael and Susan Dell Foundation\"},{\"hours\":\"06:30\",\"isWorkDay\":false,\"totalHours\":0,\"totalMinutes\":390,\"taskID\":7136,\"taskName\":\"Xamarin Ramp-up (Anne)\",\"descriminator\":\"time\",\"insertTimestamp\":\"\\/Date(1407228679567)\\/\",\"entryID\":75259,\"description\":\"\",\"projectName\":\"Directed Training\",\"clientName\":\"- Company\"},{\"hours\":\"08:00\",\"isWorkDay\":false,\"totalHours\":0,\"totalMinutes\":480,\"taskID\":7299,\"taskName\":\"Iteration Zero- Setup\",\"descriminator\":\"time\",\"insertTimestamp\":\"\\/Date(1407243054903)\\/\",\"entryID\":75292,\"description\":\"\",\"projectName\":\"Ed-Fi ETL Upgrade Proof of Concept\",\"clientName\":\"Michael and Susan Dell Foundation\"},{\"hours\":\"08:00\",\"isWorkDay\":false,\"totalHours\":0,\"totalMinutes\":480,\"taskID\":6772,\"taskName\":\"Sick Time\",\"descriminator\":\"time\",\"insertTimestamp\":\"\\/Date(1407411529237)\\/\",\"entryID\":75485,\"description\":\"\",\"projectName\":\"Personal Time\",\"clientName\":\"- Employees\"},{\"hours\":\"08:00\",\"isWorkDay\":false,\"totalHours\":0,\"totalMinutes\":480,\"taskID\":6772,\"taskName\":\"Sick Time\",\"descriminator\":\"time\",\"insertTimestamp\":\"\\/Date(1407411538337)\\/\",\"entryID\":75486,\"description\":\"\",\"projectName\":\"Personal Time\",\"clientName\":\"- Employees\"},{\"hours\":\"01:00\",\"isWorkDay\":false,\"totalHours\":0,\"totalMinutes\":60,\"taskID\":3464,\"taskName\":\"Mandatory Meetings\",\"descriminator\":\"time\",\"insertTimestamp\":\"\\/Date(1407750496167)\\/\",\"entryID\":75740,\"description\":\"\",\"projectName\":\"- Assigned\",\"clientName\":\"- Company\"},{\"hours\":\"07:00\",\"isWorkDay\":false,\"totalHours\":0,\"totalMinutes\":420,\"taskID\":7299,\"taskName\":\"Iteration Zero- Setup\",\"descriminator\":\"time\",\"insertTimestamp\":\"\\/Date(1407750523127)\\/\",\"entryID\":75741,\"description\":\"\",\"projectName\":\"Ed-Fi ETL Upgrade Proof of Concept\",\"clientName\":\"Michael and Susan Dell Foundation\"}]";
	}

	public class TimeEntry
	{
		public string hours { get; set; }

		public int taskID { get; set; }

		public string taskName { get; set; }

		public DateTime insertTimestamp { get; set; }
	}
}