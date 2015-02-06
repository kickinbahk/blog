using System;

namespace FieldsandProperties
{
	public class Rectangle
	{
		public int Width { get; set; }
		public int Height { get; set; }

		public int Area
		{
			get 
			{
				return Width * Height;
			}
		}
	}
}

