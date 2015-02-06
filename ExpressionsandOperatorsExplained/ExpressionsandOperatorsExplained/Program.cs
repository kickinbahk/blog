using System;

namespace ExpressionsandOperatorsExplained
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DemonstrateLiterals ();
			DemonstrateEscapeCharacters ();
			DemonstrateArithmetic ();
			DemonstrateEqualityComparisons ();
			DemonstrateConditionalOperators ();
			DemonstrateAssignmentOperators ();
		}

		static void DemonstrateLiterals()
		{
			Console.WriteLine ("Some examples of literals");
			Console.WriteLine ("-------------------------");
			Console.WriteLine ("{0}", 10);
			Console.WriteLine ("{0}", 3.14);
			Console.WriteLine ("{0}", 3.14F);
			Console.WriteLine ("{0}", 3.14M);
			Console.WriteLine ("{0}", true);
			Console.WriteLine ("{0}", "a");
			Console.WriteLine ("{0}", "Hi!");

			Console.WriteLine ();
			Console.WriteLine ("Press any key to continue...");
			Console.ReadLine ();
			Console.Clear ();
		}

		static void DemonstrateEscapeCharacters()
		{
			Console.WriteLine ("Escape Characters");
			Console.WriteLine ("-----------------");
			Console.WriteLine ("She Said \"Hello\"");
			Console.WriteLine ("c:\\windows is normally where the Windows folder is."); 
			Console.WriteLine ("Let's print 3 blank lines after this. \n\n\n");

			Console.WriteLine (@"
The @ symbol can let me 
write out text 
		exactly
				as
					I 
						want
");
			Console.WriteLine (@"The @ symbol also makes backslashes literal. 
c:\mydirectory\subdirectory\filename.txt");

			Console.WriteLine ();
			Console.WriteLine ("Press any key to continue...");
			Console.ReadLine ();
			Console.Clear ();
		}

		static void DemonstrateArithmetic()
		{
			Console.WriteLine("Arithmetic Operators");
			Console.WriteLine ("---------------------");

			int x = 21, y = 5;

			decimal a = 21M, b = 5M;

			Console.WriteLine("First some integer math, given x = 21 and y = 5: ");
			Console.WriteLine("x + y = {0}", x + y);
			Console.WriteLine("x - y = {0}", x - y);
			Console.WriteLine("x * y = {0}", x * y);
			Console.WriteLine("x / y = {0}", x / y);
			Console.WriteLine("x % y = {0}", x % y);

			Console.WriteLine();
			Console.WriteLine("Press any key to continue...");
			Console.ReadLine();

			Console.WriteLine ();
			Console.WriteLine ("Now some fractional math, given that a = 21.0 and b = 5.0:");
			Console.WriteLine ("a + b = {0}", a + b);
			Console.WriteLine ("a - b = {0}", a - b);
			Console.WriteLine ("a * b = {0}", a * b);
			Console.WriteLine ("a / b = {0}", a / b);
			Console.WriteLine ("a % b = {0}", a % b);

			Console.WriteLine ();
			Console.WriteLine ("Press any key to continue...");
			Console.ReadLine ();
			Console.Clear ();
		}

		static void DemonstrateEqualityComparisons()
		{
			Console.WriteLine ("Equality Operators");
			Console.WriteLine ("----------------------\n");

			int x = 21, y = 5, z = 5;

			Console.WriteLine ("Given that x = 21, y = 5, and z = 5: ");
			Console.WriteLine("x < y? {0}", x < y);
			Console.WriteLine("y < z? {0}", y < z);
			Console.WriteLine("z >= y? {0}", z >= y);
			Console.WriteLine("z <= x? {0}", z <= x);
			Console.WriteLine("z == y? {0}", z ==y);
			Console.WriteLine("x != z? {0}", x != z);

			Console.WriteLine ();
			Console.WriteLine ("Press any key to continue...");
			Console.ReadLine();
			Console.Clear();
		}

		static void DemonstrateConditionalOperators()
		{
			Console.WriteLine ("Conditional Operators");
			Console.WriteLine("-----------------------\n");

			int x = 21, y = 5, z = 5;
			int a = 0; //cant divide by zero

			Console.WriteLine("Given x = 21, y = 5, z = 5, and a = 0: ");
			Console.WriteLine("x > y && x > z? {0}", x > y && x > z);
			Console.WriteLine("x < y || y == z? {0}", x < y || y == z);
			Console.WriteLine("(x != z && x < y) || a == 0? {0}", (x != z && x < y) || a == 0);
			Console.WriteLine("!(x > z)? {0}", !(x > z));

			// because the first part of the && is false, the second part wont be run
			// so we don't get an error
			Console.WriteLine("x < z && x / a > 0? {0}", x < z && x / a > 0);

			Console.WriteLine();
			Console.WriteLine("Press any key to continue...");
			Console.ReadLine();
			Console.Clear();
		}

		static void DemonstrateAssignmentOperators()
		{
			Console.WriteLine ("Assignment Operators");
			Console.WriteLine("-------------------------\n");

			int x = 1;
			Console.WriteLine ("Given x = 1");

			Console.WriteLine ("x++ : {0}", x++);
			Console.WriteLine ("x is now {0}", x);

			Console.WriteLine ("++x : {0}", ++x);
			Console.WriteLine ("x is now {0}", x);

			x += 1;
			Console.WriteLine("x += 1 : {0}", x); 

			x *= 2;
			Console.WriteLine("x *= 2 : {0}", x);

			x -= 1;
			Console.WriteLine ("x -= 1 : {0}", x);

			x /= 3;
			Console.WriteLine ("x /= 3 : {0}", x);

			Console.WriteLine ();
			Console.WriteLine ("Press any key to continue...");
			Console.ReadLine ();
			Console.Clear ();
		}


	}
}
