using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace MobileApp.ViewModels
{
	public abstract class ViewModelBase : INotifyPropertyChanged
	{
		protected ViewModelBase ()
		{
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged (string name)
		{
			var handler = this.PropertyChanged;
			if (null != handler) {
				handler (this, new PropertyChangedEventArgs (name));
			}
		}

		protected void SetPropertyValue<T> (string name, T value, ref T field)
		{
			if (EqualityComparer<T>.Default.Equals (value, field)) {
				return;
			}

			field = value;
			this.OnPropertyChanged (name);
		}
	}
}