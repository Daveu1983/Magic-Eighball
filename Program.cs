using System;

namespace MagicEight
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string option;
			string question;
			Console.WriteLine ("Ask the 8 ball a question");
			question = Console.ReadLine ();
			Console.WriteLine ("enter \"answer\" \n ");
			option = Console.ReadLine();
			if (option == "answer")
			{
				AnswerQuestion Ans = new AnswerQuestion();
				Ans.getAnswer ();
			}
			else
			{
				Console.WriteLine("You did not enter answer \n");
			}

		}
	}

	class AnswerQuestion
	{
		private string[] Answer = {"It is certain","It is decidely so","Without a doubt", "Yes definately",
			"You may rely on it", "As I see it, yes", "Most likely", "Outlook good", "Yes", "Signs point to yes",
			"Reply hazy try again", "Ask again later", "Better not tell you now", "Cannot predict now",
			"Concentrate and ask again", "Don't count on it", "My reply is no", "My sources say no", 
			"Outlook not so good", "Very doubtful"};
		public void getAnswer(){ 
			Random r = new Random();
			int answerLength = Answer.Length;
			int ran = r.Next(1, answerLength);
			Console.WriteLine("\n{0}", Answer[ran]);
		}
	}
}
