using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace QuizCraft.ViewModels.Question
{
	public class QuestionViewModel : BaseViewModel
	{
		private QuestionData _questionData;
		private static int QuestionNumber = 1;
		
		public int MaxQuestions { get; private set; }
		
		public QuestionData QuestionData
		{
			get => _questionData;
			set => SetProperty(ref _questionData, value);
		}

		public QuestionViewModel()
		{
			MaxQuestions = 5;
			Title = $"Question {QuestionNumber}/{MaxQuestions}";
			
			QuestionData = new QuestionData
			{
				Question = $"Question {QuestionNumber}/{MaxQuestions}",
				Answers = new ObservableCollection<string> {"a", "b", "c", "d"},
				GoodAnswer = "c",
				ImagePath = "minecraft.png",
				
				Remark = "remarque",
				RemarkColor = Color.Red,
				DisplayRemark = false,
				Stars = 4
			};
		}

		public bool ValidateAnswer(string answer)
		{
			if(answer != QuestionData.GoodAnswer)
				return false;

			return true;
		}

		public void WrongAnswer()
		{
			QuestionData.Remark = "Ce n'est pas la bonne réponse, réessaye !";
			QuestionData.RemarkColor = Color.Red;
			QuestionData.DisplayRemark = true;
		}
		
		public void CorrectAnswer()
		{
			QuestionData.Remark = "Félicitations, tu as trouvé la bonne réponse !";
			QuestionData.RemarkColor = Color.Green;
			QuestionData.DisplayRemark = true;
			QuestionNumber++;
		}
	}
}