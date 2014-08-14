using System;
using Xamarin.Forms;
using MobileApp.Views;

namespace MobileApp
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new NavigationPage (new ActivityStream ());
		}
	}
}