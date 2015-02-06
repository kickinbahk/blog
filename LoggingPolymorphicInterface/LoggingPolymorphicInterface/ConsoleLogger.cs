using System;

namespace LoggingPolymorphicInterface
{
	public class ConsoleLogger : ILogger 
	{
		#region ILogger implementation

		public void WriteToLog (string message)
		{
			Console.WriteLine (message);
		}

		#endregion


	}
}

