using System;

namespace GuessingGame
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int playerGuess;
			string playerInput;
			bool isNumberGuessed = false;
			int theAnswer;

			Random rng = new Random ();
			theAnswer = rng.Next (1, 20);
			int numberOfGuesses;
			numberOfGuesses = 0;

			do 
			{
				Console.Write("Enter your guess (1-20): ");
				playerInput = Console.ReadLine();

				if (int.TryParse(playerInput, out playerGuess))
					{				
						if (playerGuess == theAnswer)
							{
								numberOfGuesses = numberOfGuesses+1;
								Console.Clear();
								Console.WriteLine ("You got it!");
								isNumberGuessed = true;
								Console.WriteLine ("It took you {0} guesses.", numberOfGuesses);
							}
						else if (playerGuess > theAnswer && playerGuess <= 20)
							{
								numberOfGuesses = numberOfGuesses+1;
								Console.WriteLine("Too high!");
							}
						else if (playerGuess < theAnswer)
							{
								numberOfGuesses = numberOfGuesses+1;
								Console.WriteLine("Too low!");
							}
						else if (playerGuess >= 21)
							{
								Console.WriteLine ("The number {0} is invalid. \nPlease pick a number between 1 and 20.", playerGuess);
								Console.WriteLine("Press any key to try again...");
								Console.Read();
								Console.Clear();
							}
					}
				else
					{
						Console.WriteLine ("Not a number. Please enter a number (1-20). Hit any key to continue...");
						Console.Read();
						Console.Clear();
					}
			} while (!isNumberGuessed);
		}
	}
}
