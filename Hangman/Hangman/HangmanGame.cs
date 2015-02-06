using System;
using System.Linq;

namespace Hangman
{
	public class HangmanGame
	{
		private bool _keepPlaying;
		private int _guessesLeft;
		private string _answer;
		private int _lettersFound;

		private string[] _guessedLetters;
		private int _guessedLettersIndex;

		private string[] _wordDisplay;

		public void Play()
		{
			SetUp();
			while (_keepPlaying)
			{
				PromptUser();
			}

			DisplayResult ();
		}

		private void PromptUser()
		{
			bool validInput = false;
			while (!validInput)
			{
				DisplayPuzzle();
				Console.Write("\nGuess a letter or the whole word: ");
				validInput = ParseInput(Console.ReadLine().ToUpper());
				Console.Clear ();
			}

		
		}

		private bool ParseInput(string input)
		{
			if (input.Length > 1)
			{
				if (input == _answer)
				{
					_keepPlaying = false;
					return true;
						
				}
				Console.Clear ();
				Console.WriteLine ("Wrong Answer!");
				_guessesLeft--;
				Console.WriteLine ("Press enter to continue...");
				Console.ReadLine ();
			}
			else
			{
				if (_guessedLetters.Contains(input))
				{
					Console.Clear ();
					Console.WriteLine ("You already guessed {0}", input);
					Console.WriteLine ("Press enter to continue...");
					Console.ReadLine ();
					return false;
				}

				bool foundLetterAtLeastOnce = false;
				for (int i = 0; i < _answer.Length; i++) 
				{
					if (input == _answer [i].ToString ())
					{
						foundLetterAtLeastOnce = true;
						_lettersFound++;
						_wordDisplay [i] = input;
					}
				}
				if (foundLetterAtLeastOnce) 
				{	
					Console.Clear ();
					Console.WriteLine ("That was a good guess!");
					Console.WriteLine ("Press enter to continue...");
					Console.ReadLine ();
					if (_lettersFound == _answer.Length) 
					{
						_keepPlaying = false;
				
					}
				}
				else 
				{
					Console.Clear ();
					Console.WriteLine ("That letter was not found!");
					_guessesLeft--;
					Console.WriteLine ("Press enter to continue...");
					Console.ReadLine ();
				}

			}

				_guessedLetters [_guessedLettersIndex] = input;
				_guessedLettersIndex++;

				if (_guessesLeft == 0)
				{
					_keepPlaying = false;
				}
				return true;
				

			}

		private void DisplayResult()
		{
			if (_guessesLeft > 0) 
				{
					Console.WriteLine ("You guessed the word: {0}!", _answer);
				} 

			else 
				{
					Console.Clear ();
					Console.WriteLine ("You lose! The word was {0}", _answer);
				}

		}

		private void DisplayPuzzle()
		{ 
			Console.WriteLine ("\nPuzzle: ");
			for (int i = 0; i < _wordDisplay.Length; i++)
			{
				Console.Write("{0} ", _wordDisplay[i]);
			}

			Console.WriteLine("\n\nYou have {0} guesses left.", _guessesLeft);

		} 

		private void SetUp()
		{
		_guessesLeft = 5;
		_keepPlaying = true;
		_guessedLetters = new string[26];
		_guessedLettersIndex = 0;

		GetWordFromPlayer ();
		CreateWordDisplay ();
		}
			
		private void CreateWordDisplay()
		{
			_wordDisplay = new string[_answer.Length];
			for (int i = 0; i < _wordDisplay.Length; i++)
			{
				_wordDisplay[i] = "_";
			}
		}

		private void GetWordFromPlayer()
		{
			Console.Write("Enter the word your opponent will try to guess (make sure they aren't looking!): ");

			_answer = Console.ReadLine().ToUpper();
			Console.Clear();
		}
	

	}

}

