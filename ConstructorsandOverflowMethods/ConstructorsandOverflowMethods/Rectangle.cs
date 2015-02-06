using System;

namespace ConstructorsandOverflowMethods
{
	public class Rectangle
	{
		private int length;
		private int width;

		public Rectangle()
		{
			Console.WriteLine ("We are in the Rectangle's constructor");
			length = 0;
			width = 0;
		}

		public Rectangle(int sideA, int sideB)
		{
			Console.WriteLine ("This is the constructor that takes two values");
			length = sideA;
			width = sideB;
		}

		public int GetArea ()
		{
			return length * width;
		}

	}
}

