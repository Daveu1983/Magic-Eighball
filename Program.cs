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
		private string Answer;
		public void getAnswer(){
			Random r = new Random();
			int ran = r.Next(1,20);
			if (ran == 1) {
				Answer = "It is certain";
			}
			if (ran == 2) {
				Answer = "It is decidely so";
			}
			if (ran == 3) {
				Answer = "Without a doubt";
			}
			if (ran == 4) {
				Answer = "Yes definately";
			}
			if (ran == 5) {
				Answer = "You may rely on it";
			}
			if (ran == 6) {
				Answer = "As I see it, yes";
			}
			if (ran == 7) {
				Answer = "Most likely";
			}
			if (ran == 8) {
				Answer = "Outlook good";
			}
			if (ran == 9) {
				Answer = "Yes";
			}
			if (ran == 10) {
				Answer = "Signs point to yes";
			}
			if (ran == 11) {
				Answer = "Reply hazy try again";
			}
			if (ran == 12) {
				Answer = "Ask again later";
			}
			if (ran == 13) {
				Answer = "Better not tell you now";
			}
			if (ran == 14) {
				Answer = "Cannot predict now";
			}
			if (ran == 15) {
				Answer = "Concentrate and ask again";
			}
			if (ran == 16) {
				Answer = "Don't count on it";
			}
			if (ran == 17) {
				Answer = "My reply is no";
			}
			if (ran == 18) {
				Answer = "My sources say no";
			}
			if (ran == 19) {
				Answer = "Outlook not so good";
			}
			if (ran == 20) {
				Answer = "Very doubtful";
			}
			Console.WriteLine("\n{0}", Answer);
		}
	}
}
