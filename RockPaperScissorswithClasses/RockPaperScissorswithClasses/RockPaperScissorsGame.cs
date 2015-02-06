using System;

namespace RockPaperScissorswithClasses
{
	public class RockPaperScissorsGame
	{
		private Random rng;
		private int wins;
		private int losses;
		private int ties;


		public RockPaperScissorsGame ()
		{
			rng = new Random ();
		}

		public void Play()
		{
			string usersChoice;
			usersChoice = PromptUser ();

			while (usersChoice != "Q") 
			{
				string computerChoice = GetComputerChoice ();
				DetermineWinner (usersChoice, computerChoice);
				PrintScore ();
				Console.WriteLine ("Press enter to continue...");
				Console.ReadLine ();
				Console.Clear();
				usersChoice = PromptUser ();

			}
			if (usersChoice == "Q")
				Console.WriteLine();
				Console.WriteLine ("Have a good day! Here is the final score:");
				PrintScore ();
		}

		private void PrintScore ()
		{
			Console.WriteLine ();
			Console.WriteLine ("Wins\tLosses\tTies", wins);
			Console.WriteLine("{0}\t{1}\t{2}", wins, losses, ties);
			Console.WriteLine ();

		}

		private void DetermineWinner (string usersChoice, string computerChoice)
		{
			if (usersChoice == computerChoice)
			{
				ties++;
				Console.WriteLine("You both picked {0}, you tied", ConvertChoiceToWord(usersChoice));
			}
			else if (usersChoice == "R" && computerChoice == "S" || usersChoice == "S" && computerChoice == "P" || usersChoice == "P" && computerChoice == "R")
			{
				wins++;
				Console.WriteLine("You picked {0} and the computer picked {1}, you win!", ConvertChoiceToWord(usersChoice), ConvertChoiceToWord(computerChoice));
			}
			else
			{
				losses++;
				Console.WriteLine("You picked {0} and the computer picked {1}, you lose!", ConvertChoiceToWord(usersChoice), ConvertChoiceToWord(computerChoice));
			}

		}

		private string ConvertChoiceToWord(string choice)
		{
			if (choice == "R")
				return "Rock";
			else if (choice == "S")
				return "Scissors";
			else
				return "Paper";

		}

		string GetComputerChoice ()
		{
			int choice = rng.Next (1, 4);

			if (choice == 1)
				return "R";
			else if (choice == 2)
				return "P";
			else
				return "S";	
			
		}
	
		private string PromptUser ()
		{
			while (true) {
				Console.Write ("Enter your choice: (R)ock, (P)aper, (S)cissors, or (Q): ");
				string choice = Console.ReadLine ();

				if (choice == "R" || choice == "P" || choice == "S" || choice == "Q") 
				{
					return choice;

				} 

				else 
				{
					Console.WriteLine ();
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine ("That was not a valid choice");
					Console.WriteLine ();
					Console.ForegroundColor = ConsoleColor.Black;
					Console.WriteLine ("Press enter to try again...");
					Console.ReadLine ();
					Console.Clear();
				}
			}
		}
	}
}

