using System;

namespace ConstructorsandOverflowMethods
{
	public class Calculator
	{
		public int Add (int a, int b)
		{
			return a + b;
		}

		public int Add (int a, int b, int c) //signature needs to be the different if the name and type is the same
		{
			return a + b + c;
		}

		public decimal Add (decimal a, decimal b) //if the name and type is different, the signature can be the same 
		{
			return a + b;
		}
	}
}

