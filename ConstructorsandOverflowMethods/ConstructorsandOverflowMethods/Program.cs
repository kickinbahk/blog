using System;

namespace ConstructorsandOverflowMethods
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Rectangle r = new Rectangle();
			//Console.WriteLine ("Area: {0}", r.GetArea());

			//Rectangle r2 = new Rectangle (5, 10);

			//Console.WriteLine ("Area: {0}", r2.GetArea()); 

			Calculator c = new Calculator ();

			Console.WriteLine ("{0}", c.Add (1, 2));
			Console.WriteLine ("{0}", c.Add (1, 2, 3));


		}
	}
}
