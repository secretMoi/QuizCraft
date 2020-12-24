using System;
using System.Collections.ObjectModel;
using System.Linq;
using QuizCraft.Data;
using QuizCraft.Models;
using Xamarin.Forms;

namespace QuizCraft.ViewModels.Question
{
	public class QuestionViewModel : BaseViewModel
	{
		private QuestionData _questionData;
		private static int _questionNumber = 1;
		private static QuestionsList _questionsList;
		
		public int MaxQuestions { get; private set; }
		
		public QuestionData QuestionData
		{
			get => _questionData;
			set => SetProperty(ref _questionData, value);
		}

		public QuestionViewModel()
		{
			if (_questionsList == null)
				_questionsList = new QuestionsList();
			
			MaxQuestions = 5;
			Title = $"Question {_questionNumber}/{MaxQuestions}";

			QuestionModel questionModel = ChooseRandomQuestion();
			SuppressQuestionByName(questionModel.Question);
			
			QuestionData = new QuestionData
			{
				Question = questionModel.Question,
				Answers = new ObservableCollection<string>(questionModel.Answers),
				GoodAnswer = questionModel.GoodAnswer,
				ImagePath = questionModel.ImagePath,
				
				RemarkColor = Color.Red,
				DisplayRemark = false,
				Stars = 4
			};
		}

		public bool QuestionsAvailable()
		{
			return _questionsList.Questions.Count > 0;
		}

		private QuestionModel ChooseRandomQuestion()
		{
			int choosenQuestion = new Random().Next(0, _questionsList.Questions.Count);

			return _questionsList.Questions[choosenQuestion];
		}

		private void SuppressQuestionByName(string name)
		{
			_questionsList.Questions.Remove(
				_questionsList.Questions.FirstOrDefault(question => question.Question == name)
			);
		}

		public bool ValidateAnswer(string answer)
		{
			return answer == QuestionData.GoodAnswer;
		}

		public void WrongAnswer()
		{
			QuestionData.Remark = "Ce n'est pas la bonne réponse, réessaye !";
			QuestionData.RemarkColor = Color.Red;
			QuestionData.DisplayRemark = true;
			QuestionData.Stars -= 1;
		}
		
		public void CorrectAnswer()
		{
			QuestionData.Remark = "Félicitations, tu as trouvé la bonne réponse !";
			QuestionData.RemarkColor = Color.Green;
			QuestionData.DisplayRemark = true;
			_questionNumber++;
		}
	}
}