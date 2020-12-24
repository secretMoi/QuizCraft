using System.Collections.Generic;

namespace QuizCraft.Models
{
	public class QuestionModel
	{
		public string Question { get; set; }
		public List<string> Answers { get; set; }
		public string GoodAnswer { get; set; }
		public string ImagePath { get; set; }
	}
}