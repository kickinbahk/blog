﻿using System;

namespace FlipACoin
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int coin;
			string userGuess;
			Random rng = new Random ();

			//Ask your question
			Console.Write ("Enter your guess...Heads or Tails: ");
			userGuess = Console.ReadLine ();

			//Get a random number for filp

			coin = rng.Next (0, 2);

			if (coin == 0 && userGuess == "Tails" || userGuess == "tails") {
				Console.WriteLine ("You Win!!! Tails never fails!");
			
			} else if (coin == 1 && userGuess == "Heads" || userGuess == "heads") {
				Console.WriteLine ("You Win!!! Heads or you're dead!");

			} else if (coin == 0 && userGuess == "Tails" || userGuess == "tails") {
					Console.WriteLine ("You lose...It seems you are the butt of the joke...");

			} else if (coin == 1 && userGuess == "Heads" || userGuess == "heads") {
					Console.Write ("Did you even try?...You lost...obviously!");
				} else {
				Console.WriteLine ("The response you gave is invalid.");

			}

		 



			Console.WriteLine ("Press enter to continue...");
			Console.ReadLine ();
			Console.Clear ();

		}
	}
}
