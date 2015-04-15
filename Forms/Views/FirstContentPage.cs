using System;

using Xamarin.Forms;

namespace XFdemo
{
	public class FirstContentPage : ContentPage //UI in code
	{
		public FirstContentPage ()
		{
			Title = "First page";

			BackgroundColor = Color.Blue;

			var labelMcc = new Label {
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				Text = "Clockwork is the best",
				TextColor = Color.White
			};

			var buttonToNavigate = new Button {
				Text = "Open second page",
				BackgroundColor = Color.White,
				TextColor = Color.Black
			};

			buttonToNavigate.Clicked += async (object sender, EventArgs e) => 
			{
				await Navigation.PushAsync (new SecondContentPage());
			};

			Content = new StackLayout {
				Children = {
					labelMcc, buttonToNavigate
				}
			};
		}
	}
}