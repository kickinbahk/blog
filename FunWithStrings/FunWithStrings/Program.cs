using System;

namespace FunWithStrings
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			StringsAreImmutable ();
			ComparingStrings ();
			StringsHaveLengthsAndIndexes ();
			CasingAndWhiteSpace ();
			UsefulCharacterMethods ();
			EditingStrings ();
			SplitandJoin ();
		}

		static void StringsAreImmutable()
		{
			string s1 = "Hello";

			s1.ToUpper ();
			Console.WriteLine ("s1: {0}", s1);

			s1 = s1.ToUpper ();
			Console.WriteLine ("s1: {0}", s1);
		}
		static void ComparingStrings()
		{
			string s1 = "hi";
			string s2 = "HI";

			if (s1 != s2)
			{
				Console.WriteLine("It is not equal");
			}

			if (s1.Equals(s2, StringComparison.CurrentCultureIgnoreCase))
			{
				Console.WriteLine("s1 is equal to s2");
			}
		}
		static void StringsHaveLengthsAndIndexes()
		{
			string name = "Josiah";

			Console.WriteLine ("First Letter: {0}", name [0]);

			for (int i = name.Length - 1; i >= 0; i--) 
			{
				Console.Write ("{0}", name[i]);
			}
			
			Console.WriteLine();
			Console.WriteLine("Everything at or after position 1: {0}", name.Substring(1));
			Console.WriteLine("The Last two characters : {0}", name.Substring(name.Length-2,2));

		}
		static void CasingAndWhiteSpace()
		{
			string s1 = "";

			Console.WriteLine("Does the string have any data? {0}", string.IsNullOrEmpty(s1));

			s1 = "AbCdEfG";
			Console.WriteLine("{0} ToUpper: {1}  ToLower: {2}", s1, s1.ToUpper(), s1.ToLower());

		}
		static void UsefulCharacterMethods()
		{
			char c1 = 'a';

			Console.WriteLine ("The character: {0}", c1);
			Console.WriteLine ("IsDigit: {0}", char.IsDigit (c1));
			Console.WriteLine ("IsLetter: {0}", char.IsLetter (c1));
			Console.WriteLine ("IsLetterOrDigit: {0}", char.IsLetterOrDigit (c1));
			Console.WriteLine ("IsLower: {0}", char.IsLower (c1));
			Console.WriteLine ("IsUpper: {0}", char.IsUpper (c1));
			Console.WriteLine ("IsPunctuation: {0}", char.IsPunctuation (c1));
			Console.WriteLine ("IsWhiteSpace: {0}", char.IsWhiteSpace (c1));
		}
		static void EditingStrings()
		{
			string s1 = "    Got Extra Space?     ";
			s1 = s1.Trim ();

			Console.WriteLine (s1);

			s1 = s1.Replace ("Got", "Have");
			Console.WriteLine (s1);
		}
		static void SplitandJoin ()
		{
			string s1 = "This is a sentence";

			string [] words = s1.Split(' ');

			foreach (string word in words)
			{
				Console.WriteLine (word);
			}

			string s2 = string.Join (",", words);
			Console.WriteLine (s2); 
		}

	}
}
