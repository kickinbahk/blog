using System;

namespace AdvancedMethodsAndClasses
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			PrintSum (2, 2, 2);
			PrintSum (1, 2, 3, 4, 5, 6, 7);
			PrintSum ();

			string name, gender;

			GetData (out name, out gender);
			int age = GetAge ();

			Console.WriteLine ("Name: {0}, Gender: {1}, Age: {2}", name, gender, age);


		}

		static void PrintSum(params int[] numbers)
		{
			int sum = 0;

			foreach (int number in numbers) 
			{
				sum += number;
			}

			Console.WriteLine ("The sum is {0}", sum);

		}

		static void GetData(out string name, out string gender)
		{
			Console.Write ("Enter your name: ");
			name = Console.ReadLine ();

			Console.Write ("Enter your gender: ");
			gender = Console.ReadLine ();
		}

		static int GetAge()
		{
			bool valid = false;
			int number = 0;

			while (!valid) 
			{
				Console.Write ("Enter your age: ");
				if(int.TryParse(Console.ReadLine(), out number))
				{
					valid = true;
				}
				else
				{
					Console.WriteLine("That is not an integer.");
				}

			}
			return number;
		}
	}
}
