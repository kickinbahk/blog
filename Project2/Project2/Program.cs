using System;

namespace Project2
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter the first number: ");

			string userInput = Console.ReadLine ();
			int number1 = int.Parse (userInput);

			Console.Write ("Enter the second number: ");


			userInput = Console.ReadLine ();


			//parse is hard converting the sting input from our useer to an integer
			int number2 = int.Parse (userInput);

			int sum = number1 + number2;

			Console.WriteLine ("The sum is: " + (number1 + number2));
		}
	}
}
