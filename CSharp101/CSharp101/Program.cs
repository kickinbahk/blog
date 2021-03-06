﻿using System; 

namespace CSharp101
{
	class Program
	{
		public static void Main (string[] args)
		{
			#region Greeting
			Console.WriteLine ("Hello!");
			Console.WriteLine (@"Tell me your name: 
(Please type in your name and press the ""Enter"" key when done) ");
			string name;

			name = Console.ReadLine ();
			Console.Clear ();
			Console.Write ("Welcome {0}! \n\n\nPress any key to continue...", name);

			Console.Read ();
			Console.Clear ();

			Console.WriteLine ("Shall We Play a Game? (Yes or No) ");

			string userResponse;

			userResponse = Console.ReadLine ();
			Console.Clear ();


			if (userResponse == "Yes" || userResponse == "yes") {
				Console.Write ("You are going down! \n\n\nPress any key to continue...");
				Console.Read ();
				Console.Clear ();
			
				#endregion

				Start:

				Console.Write ("Please choose: Rock, Paper, or Scissors\n");

				Random rng = new Random ();

				string gameItem;

				gameItem = Console.ReadLine ();
				Console.Clear ();

				int choice;

				choice = rng.Next (0, 3);

				if (gameItem == "Scissors" || gameItem == "scissors") {

					if (choice == 0) {
						Console.WriteLine ("I chose Rock. My rock beats your scissors. \nYou have lost!!!");
						Console.WriteLine ("Thank you for playing!");
					} else if (choice == 1) {
						Console.WriteLine ("I chose Paper. Your scissors beats my paper. \nYou have won!!!");
						Console.WriteLine ("Thank you for playing!");
					} else if (choice == 2) {
						Console.Write ("I chose Scissors. We have tied. You are a worthy adversary! Shall we play again? ");

						string playAgain;

						playAgain = Console.ReadLine ();

						if (playAgain == "Yes" || playAgain == "yes") {
							Console.Clear ();
							goto Start;
						} else {
							Console.WriteLine("Thank you for playing! \nGoodbye!");
								
						}
					}

				} else if (gameItem == "Paper" || gameItem == "paper") {

					if (choice == 1) {
						Console.WriteLine ("I chose Paper. We have tied. You are a worthy adversary! \nShall we play again?");

						string playAgain;

						playAgain = Console.ReadLine ();

						if (playAgain == "Yes" || playAgain == "yes") {
							Console.Clear ();
							goto Start;

						} else {
							Console.WriteLine ("Thank you for playing! \nGoodbye!");
						}
					} else if (choice == 0) {
						Console.WriteLine ("I chose Rock. Your paper beats my rock. \nYou have won!!!");
						Console.WriteLine ("Thank you for playing!");
					} else if (choice == 2) {
						Console.WriteLine ("I chose Scissors. My scissors beats your paper. \nYou have lost!!!");
						Console.WriteLine ("Thank you for playing!");
					}

				} else if (gameItem == "Rock" || gameItem == "rock") {

					if (choice == 2) {
						Console.WriteLine ("I chose Scissors. Your rock beats my scissors. \nYou have won!!!");
						Console.WriteLine ("Thank you for playing!");
					} else if (choice == 0) {
						Console.WriteLine ("I chose Rock. We have tied. You are a worthy adversary! \nShall we play again?");

						string playAgain;

						playAgain = Console.ReadLine ();

						if (playAgain == "Yes" || playAgain == "yes") {
							Console.Clear ();
							goto Start;

						} else {
							Console.WriteLine ("Thank you for playing! \nGoodbye!");
						}
					} else if (choice == 1) {
						Console.WriteLine ("I chose Paper. My paper beats your rock. \nYou have lost!!!");
						Console.WriteLine ("Thank you for playing!");

					}

				} else {
					Console.Beep ();
					Console.WriteLine(@"I am sorry, I do not recognize your input ""{0}"". 
Please try again later...", gameItem);
				}


							

			} else if (userResponse == "No" || userResponse == "no") {

				Console.Write ("Maybe next time then...\nGoodbye!");
			}

			else {
				Console.Beep ();
				Console.WriteLine("I am sorry, I do not recognize your input. \nPlease try again later...");
			}
				


	
		}
	}
}
