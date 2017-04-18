using Xamarin.Forms;

namespace XFdemo
{
	public partial class ThirdContentPage : ContentPage //UI in XAML - MVVM
	{
		public ThirdContentPage ()
		{
			InitializeComponent ();

			BindingContext = new ThirdViewModel ();
		}
	}
}