using System;

namespace StopwatchDemo
{
	public class Stopwatch
	{
		private DateTime _startTime;

		public void Start ()
		{
			_startTime = DateTime.Now;
		}

		public void Stop()
		{
			TimeSpan elapsed = DateTime.Now - _startTime;

			Console.WriteLine ("The elapsed time is : {0}s {1}ms", elapsed.Seconds, elapsed.Milliseconds);
		}
	}
}

