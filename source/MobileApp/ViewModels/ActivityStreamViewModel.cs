using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
	public class ActivityStreamViewModel : ViewModelBase
	{
		private readonly ObservableCollection<TimeEntry> timeEntries = new ObservableCollection<TimeEntry> ();

		public ObservableCollection<TimeEntry> TimeEntries {
			get { return this.timeEntries; }
		}

		public async Task Initialize ()
		{
			var fakeData = await FakeDataProvider.GetFakeData ();
			foreach (var item in fakeData) {
				this.timeEntries.Add (item);
			}
		}
	}
}