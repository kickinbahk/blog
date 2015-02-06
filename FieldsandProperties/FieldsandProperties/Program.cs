using System;

namespace FieldsandProperties
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Rectangle aRectangleObject = new Rectangle ();

			aRectangleObject.Height = 10;
			aRectangleObject.Width = 5;

			Console.WriteLine ("Area = {0}", aRectangleObject.Area);

	
		}
	}
}
