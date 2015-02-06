using System;

namespace FoxProject
{
	class MainClass
	{
		public static void Main (string[] args)

		{
			Fox quickType = new Fox ();

			quickType.WriteFox ();
			Console.WriteLine(quickType.Number(6, 7));

		}
	}
}
