using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuizCraft.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
		}

		private async void Button_OnClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new QuestionPage());
		}
	}
}