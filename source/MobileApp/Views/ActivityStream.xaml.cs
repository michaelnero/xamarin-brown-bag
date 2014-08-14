using System;
using System.Collections.Generic;
using Xamarin.Forms;
using MobileApp.ViewModels;

namespace MobileApp.Views
{
	public partial class ActivityStream : ContentPage
	{
		public ActivityStream ()
		{
			InitializeComponent ();
		}

		protected override async void OnAppearing ()
		{
			this.IsBusy = true;
			await ((ActivityStreamViewModel)this.BindingContext).Initialize ();
			this.IsBusy = false;
		}
	}
}