using System;

namespace CreatingandManipulatingArrays
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//SingleDimensionArrayCreation ();
			//AutoInitializingArrays ();
			//ArraysandMethods ();
			ArrayClassMethods ();

		}

		 static void SingleDimensionArrayCreation()
		{	
			Console.WriteLine ("Create a single dimension array");
			int[] numbers = new int[3];
			numbers [0] = 100;
			numbers [1] = 200;
			numbers [2] = 300;

			for (int i = 0; i < numbers.Length; i++)
			Console.WriteLine (numbers [i]);
				
		}

		static void AutoInitializingArrays()
		{
			Console.WriteLine ("=> Array Initialize");

			string[] stringArray = new string[] { "one", "two", "three" };
			Console.WriteLine ("stringArray has {0} elements", stringArray.Length);

			bool[] boolArray = { false, false, true, };
			Console.WriteLine ("boolArray has {0} elements", boolArray.Length);

			int[] intArray = new int[4] { 20, 22, 23, 0 };
			Console.WriteLine ("intArray has {0} elements", intArray.Length);

			Console.WriteLine ("Hit any key to continue...");
		}

		static void ArraysandMethods()
		{
			Console.WriteLine ("=> Arrays as params and return values.");

			int[] ages = { 20, 22, 23, 0 };
			PrintArrayElements (ages);

			int [] numbers = GetNumbersArray();
			PrintArrayElements(numbers);

			Console.WriteLine("\nPress enter to continue...");
		}

		static void PrintArrayElements(int[] numbers)
		{
			for (int i = 0; i < numbers.Length; i++)
				Console.WriteLine("Item {0} is {1}", i, numbers[i]);
		}

		static int[] GetNumbersArray()
		{
			int[] numbers = { 1, 2, 3, 4, 5 }; 
			return numbers; 
		}

		static void ArrayClassMethods()
		{
			string[] vowels = { "a", "e", "i", "o", "u", };

			for (int i = 0; i < vowels.Length; ++i) 
			{
				Console.Write (vowels [i]);
			}
			Console.WriteLine ();

			Console.Write ("Reversed: ");
			Array.Reverse (vowels);

			for (int i = 0; i < vowels.Length; i++) 
			{
				Console.Write (vowels [i]);
			}
			Console.WriteLine ();

			Console.WriteLine ("The alphabet has {0} vowels", vowels.Length);
		}
	}
}
