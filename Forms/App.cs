using Xamarin.Forms;

namespace XFdemo
{
	public class App : Application
	{
		public App ()
		{
			var navigationPage = new NavigationPage (new FirstContentPage ());

			MainPage = navigationPage;
		}

		protected override void OnStart ()
		{
			//Handle when your app starts
		}

		protected override void OnSleep ()
		{
			//Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			//Handle when your app resumes
		}
	}
}