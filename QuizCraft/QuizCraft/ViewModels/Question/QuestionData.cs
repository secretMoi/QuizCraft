using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace QuizCraft.ViewModels.Question
{
	public class QuestionData : BaseViewModel
	{
		public ObservableCollection<string> Answers { get; set; }
		private string _goodAnswer;
		
		private string _question;
		private string _imagePath;
		private int _stars;

		private bool _displayRemark;
		private string _remark;
		private Color _remarkColor;

		private int _score;
		
		public string GoodAnswer
		{
			get => _goodAnswer;
			set => SetProperty(ref _goodAnswer, value);
		}
		
		public int Score
		{
			get => _score;
			set => SetProperty(ref _score, value);
		}

		public bool DisplayRemark
		{
			get => _displayRemark;
			set => SetProperty(ref _displayRemark, value);
		}

		public string Remark
		{
			get => _remark;
			set => SetProperty(ref _remark, value);
		}

		public Color RemarkColor
		{
			get => _remarkColor;
			set => SetProperty(ref _remarkColor, value);
		}

		public string Question
		{
			get => _question;
			set => SetProperty(ref _question, value);
		}

		public string ImagePath
		{
			get => _imagePath;
			set => SetProperty(ref _imagePath, value);
		}

		public int Stars
		{
			get => _stars;
			set => SetProperty(ref _stars, value);
		}
	}
}