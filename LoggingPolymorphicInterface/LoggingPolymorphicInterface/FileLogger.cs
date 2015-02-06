using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggingPolymorphicInterface
{
	public class FileLogger : ILogger 
	{
		#region ILogger implementation

		public void WriteToLog (string message)
		{
			var fileWriter = file.AppendText("log.txt");
			fileWriter.WriteLine (message);
			fileWriter.Close ();
		}

		#endregion


	}
}

