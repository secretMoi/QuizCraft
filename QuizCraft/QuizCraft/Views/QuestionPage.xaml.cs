﻿using System;
using QuizCraft.ViewModels.Question;
using SkiaRate;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuizCraft.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuestionPage : ContentPage
	{
		private readonly QuestionViewModel _viewModel = new QuestionViewModel();
		private bool _questionFinished = false;
		
		public QuestionPage()
		{
			InitializeComponent();
			
			BindingContext = _viewModel;
			Rate.Path = PathConstants.Heart;
		}

		private async void Button_OnClicked(object sender, EventArgs e)
		{
			if (!_questionFinished)
			{
				var answer = CurrentResponse.SelectedItem as string;
				_questionFinished = _viewModel.ValidateAnswer(answer);

				if (!_questionFinished)
				{
					Rate.Value -= 1;
					_viewModel.WrongAnswer();
				}
				else
				{
					_viewModel.CorrectAnswer();
					ButtonValider.Text = "Question suivante";
				}
			}
			else
			{
				await Navigation.PushAsync(new QuestionPage());
				Navigation.RemovePage(this);
			}
		}
	}
}