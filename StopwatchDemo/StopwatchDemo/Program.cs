using System;

namespace StopwatchDemo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Press enter to start the timer");
			Console.ReadLine ();
			Console.Clear ();

			Stopwatch watch = new Stopwatch ();
			watch.Start ();

			Console.Write ("Press enter to stop the timer. ");
			Console.ReadLine ();
			watch.Stop ();
		}
	}
}
