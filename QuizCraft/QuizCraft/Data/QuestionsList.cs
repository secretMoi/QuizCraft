using System.Collections.Generic;
using QuizCraft.Models;

namespace QuizCraft.Data
{
	public class QuestionsList
	{
		public List<QuestionModel> Questions { get; private set; }
		
		public QuestionsList()
		{
			Questions = GenerateQuestions();
		}

		public List<QuestionModel> GenerateQuestions()
		{
			return new List<QuestionModel>
			{
				new QuestionModel
				{
					Question = "Combien y a-t-il de modes de jeu ?",
					Answers = new List<string>
					{
						"5", "2", "7", "4"
					},
					GoodAnswer = "4",
					ImagePath = "minecraft.png"
				},
				
				new QuestionModel
				{
					Question = "L'enderman peut se tp à maximum combien de cases ?",
					Answers = new List<string>
					{
						"6", "12", "18", "24"
					},
					GoodAnswer = "24",
					ImagePath = "minecraft.png"
				},
				
				new QuestionModel
				{
					Question = "Quel le nom de cet entité ?",
					Answers = new List<string>
					{
						"Herobrine", "Notch", "jeb", "Jeb..."
					},
					GoodAnswer = "Herobrine",
					ImagePath = "minecraft.png"
				}
			};
		} 
	}
}