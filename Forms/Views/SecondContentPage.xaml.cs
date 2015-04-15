using System;

using Xamarin.Forms;

namespace XFdemo
{
	public partial class SecondContentPage : ContentPage //UI in XAML - bindings
	{
		public SecondContentPage ()
		{
			InitializeComponent ();
		}

		public async void OnButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new ThirdContentPage());
		}
	}
}