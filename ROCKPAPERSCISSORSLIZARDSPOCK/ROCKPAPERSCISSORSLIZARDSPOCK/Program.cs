using System;

namespace ROCKPAPERSCISSORSLIZARDSPOCK

{
	class Program
	{
		public static void Main (string[] args)
		{

	
			Console.Write ("Welcome!\n\n\n"); //Simple welcome 



			Console.WriteLine ("Shall We Play a Game? (Yes or No) "); //game initiallizer

			string userResponse; //holds user response

			userResponse = Console.ReadLine (); //reads users response and places it in userResponse
			Console.Clear ();

			//When users says yes game is initiallize
			if (userResponse == "Yes" || userResponse == "yes") { //lists rules for the game
				Console.Write (@"I know! Let's play rock, paper, scissors, lizard, spock! 
			
		The rules of rock-paper-scissors-lizard-Spock are:

			Scissors cuts Paper
			Paper covers Rock
			Rock crushes Lizard
			Lizard poisons Spock
			Spock smashes Scissors
			Scissors decapitates Lizard
			Lizard eats Paper
			Paper disproves Spock
			Spock vaporizes Rock
			And. As it alaways has, 
			Rock crushes Scissors


Press any key to continue...");
				Console.Read ();
				Console.Clear ();


				Start: // this will allow us to repeat the code if we tie

				Console.Write ("Please choose: Rock, Paper, Scissors, Lizard, or Spock: "); //second prompt

				Random rng = new Random (); //random number generator

				string gameItem; //storage for the users choice

				gameItem = Console.ReadLine (); //interpets the user input
				Console.Clear ();

				int choice;

				choice = rng.Next (0, 5); //sets 4 random numbers

				//----------------------------------------------------------
				//Here is the Scissors if statements

				if (gameItem == "Scissors" || gameItem == "scissors") {

					gameItem = "Scissors";

					if (choice == 0) {
						string compChoice = Convert.ToString (choice);
						compChoice = "Rock";

						Console.WriteLine ("I chose {0}. My {0} crushes your {1}. You lose.", compChoice, gameItem);
						Console.WriteLine ("Thank you for playing!");

					} else if (choice == 1) {
						string compChoice = Convert.ToString (choice);
						compChoice = "Paper";

						Console.WriteLine ("I chose {0}. Your {1} cuts my {0}. You win!", compChoice, gameItem);
						Console.WriteLine ("Thank you for playing!");

					} else if (choice == 2) {
						string compChoice = Convert.ToString (choice);
						compChoice = "Spock";

						Console.WriteLine ("I chose {0}. {0} smashes your {1}. You lose.", compChoice, gameItem);
						Console.WriteLine ("Thank you for playing!");

					} else if (choice == 3) {
						string compChoice = Convert.ToString (choice);
						compChoice = "Lizard";

						Console.WriteLine ("I chose {0}. Your {1} decapitates my {0}. You win!", compChoice, gameItem);
						Console.WriteLine ("Thank you for playing!");

					} else if (choice == 4) {
						string compChoice = Convert.ToString (choice);
						compChoice = "Scissors";
						Console.Write ("I chose {0}. You are a worthy adversary! Shall we play again? ", compChoice);

						string playAgain;

						playAgain = Console.ReadLine ();

						if (playAgain == "Yes" || playAgain == "yes") {
							Console.Clear ();
							goto Start;

						} else {
							Console.WriteLine ("Thank you for playing! \nGoodbye!");

						}
					}

				} 
				//--------------------------------------------------------------------------------------------------
				//Here are the Paper if statements

				else if (gameItem == "Paper" || gameItem == "paper") {

					if (choice == 1) {
						string compChoice = Convert.ToString (choice);
						compChoice = "Paper";

						Console.WriteLine ("I chose {0}. You are a worthy adversary! Shall we play again? ", compChoice);

						string playAgain;

						playAgain = Console.ReadLine ();

						if (playAgain == "Yes" || playAgain == "yes") {
							Console.Clear ();
							goto Start;

						} else {
							Console.WriteLine ("Thank you for playing! \nGoodbye!");
						}
					} else if (choice == 0) {
						string compChoice = Convert.ToString (choice);
						compChoice = "Rock";

						Console.WriteLine ("I chose {0}. Your {1} covers my {0}. You win!", compChoice, gameItem);
						Console.WriteLine ("Thank you for playing!");

					} else if (choice == 2) {
						string compChoice = Convert.ToString (choice);
						compChoice = "Spock";

						Console.WriteLine ("I chose {0}. Your {1} disproves {0}. You win!", compChoice, gameItem);
						Console.WriteLine ("Thank you for playing!");

					} else if (choice == 3) {
						string compChoice = Convert.ToString (choice);
						compChoice = "Lizard";

						Console.WriteLine ("I chose {0}. My {0} eats {1}. You lost!", compChoice, gameItem);
						Console.WriteLine ("Thank you for playing!");
					
					} else if (choice == 4) {
						string compChoice = Convert.ToString (choice);
						compChoice = "Scissors";

						Console.WriteLine ("I chose {0}. My {0} cuts {1}. You lost!", compChoice, gameItem);
						Console.WriteLine ("Thank you for playing!");
					} 
				}
				//--------------------------------------------------------------
				// Here are the Rock if statements

				else if (gameItem == "Rock" || gameItem == "rock") {

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
							Console.WriteLine ("I chose Paper. My paper beats your rock. \nYou have won!!!");
							Console.WriteLine ("Thank you for playing!");

						} else if (gameItem == "Lizard" || gameItem == "lizard") {

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
								Console.WriteLine ("I chose Paper. My paper beats your rock. \nYou have won!!!");
								Console.WriteLine ("Thank you for playing!");

							} else {
								Console.Beep ();
								Console.WriteLine (@"I am sorry, I do not recognize your input ""{0}"". 
Please try again later...", gameItem);
							}




						} else if (userResponse == "No" || userResponse == "no") {

							Console.Write ("Maybe next time then...\nGoodbye!");
						} else {
							Console.Beep ();
							Console.WriteLine ("I am sorry, I do not recognize your input. \nPlease try again later...");
						}

					}
				}
			}
		}
}