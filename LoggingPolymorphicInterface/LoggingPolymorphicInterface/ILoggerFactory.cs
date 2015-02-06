using System;

namespace LoggingPolymorphicInterface
{
	static class ILoggerFactory
	{
		private static ILogger _myLogger;

		public static ILogger GetLogger()
		{
			if (_myLogger == null) 
			{

			}

			return _myLogger;
		}
	}
}

