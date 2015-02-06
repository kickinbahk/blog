using System;

namespace Commentsandformattingstrings
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Let's demo formatting strings. Press enter to begin...");
			Console.ReadLine ();
			Console.Clear (); //this clears our console from what was written previously

			DemoSubstitutionStrings (); //Method: this will cause the program to jump down to the method code then return to run next method
			LeftAlign ();
			RightAlign ();
			FormatNumericalData ();
			StringDotFormat ();
		}

		static void DemoSubstitutionStrings ()
		{
			Console.WriteLine ("Substitution strings are easier to read than concatenation");
			Console.WriteLine ("----------------------------------------------------------");

			//get some data
			Console.Write ("What is your name? ");
			string userName = Console.ReadLine ();

			Console.Write ("What is your favorite color? ");
			string favoriteColor = Console.ReadLine ();

			/*substitution strings are in curly braces, they always start with 0
			 * Each substitution string is replaced by the values following the string */

			Console.WriteLine ("Hello {0}!  Your favorite color is {1}. \nI am a big fan of the name {0}.\n", 
				userName, favoriteColor);
			//"0" refers to the first data after the comma (userName), "1" refers to next 
			//Computers count from 0  

			//We can pass literals or variables
			Console.WriteLine("My favorite number is {0}.", 7); //can pass a literal (7) in to a substitution string 

			Console.WriteLine("\nPress enter to continue...");
			Console.ReadLine();
			Console.Clear();
		}

		static void LeftAlign()
		{
			Console.WriteLine ("Put a comma and a negative number to left align. ex: {0,-15}");
			Console.WriteLine ("------------------------------------------------------------");

			string lineOutputFormat = "{0,-15} {1,-2} {2,-5}";
			Console.WriteLine (lineOutputFormat, "John Doe", "OH", "44113");
			Console.WriteLine(lineOutputFormat, "Jane Doe", "NY", "12065");
			Console.WriteLine(lineOutputFormat, "Cheech Marin", "CA", "90210");

			Console.WriteLine("\nPress enter to continue...");
			Console.ReadLine ();
			Console.Clear ();
		}

		static void RightAlign()
		{
			Console.WriteLine("Put a comma and a positive number to right align. ex: {1,9}");
			Console.WriteLine("-----------------------------------------------------------");

			/* We can store things in a format for later
			 * we can use the : and a format code to do things like currency format
			 * */

			string lineOutputFormat = "{0,-15} {1,9:C}"; //":C" Is a format code for currency format installed on my computer 
			Console.WriteLine(lineOutputFormat, "A12345678", 5302.32);
			Console.WriteLine (lineOutputFormat, "A392848293", 27.32);
			Console.WriteLine(lineOutputFormat, "A20859329", 1232706.00);//this one oferflows becuase the maximum size of data is bigger

			Console.WriteLine("\nPress enter to continue...");
			Console.ReadLine();
			Console.Clear();
		}

		static void FormatNumericalData()
		{
			//List of standard number format codes
			//http://msdn.microsoft.com/en-us/library/dwhawy9k(v=vs.110.aspx

			Console.WriteLine("The value 12345 in various formats: \n");
			Console.WriteLine("c format: {0:c}", 12345); //currency format
			Console.WriteLine("d9 format: {0:d9}", 12345); //said character length must be 9  
			Console.WriteLine("f3 format: {0:f3}", 12345); //said three decimal places must exist
			Console.WriteLine ("n format: {0:n}", 12345); //number format, two decimal and commas

			Console.WriteLine("\n");

			//Notice that upper ot lowercasing for hex
			//determines if letters are upper or lowercase. 

			Console.WriteLine ("E format: {0:E}", 12345); //exponetial format
			Console.WriteLine("e format: {0:e}", 12345);

			Console.WriteLine("For hex we will use 99999 to get some letters.");
			Console.WriteLine("X format: {0:X}", 99999); //hex format
			Console.WriteLine("x format: {0:x}", 99999);

			Console.WriteLine("\nPress enter to continue..");
			Console.ReadLine();
			Console.Clear();
		}

		static void StringDotFormat()	
		{
			//string.Format() allows for substitution strings as well. 
			//It returns a string we can store for later

			string totalLine = string.Format("Total: {0:C}", 25.39);

			Console.Write (totalLine);

			Console.WriteLine("\nPress enter to continue...");
			Console.ReadLine ();
			Console.Clear (); 


		}


	}
}
