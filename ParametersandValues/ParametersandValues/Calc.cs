﻿using System;

namespace ParametersandValues
{
	public class SimpleCalculator
	{
		public int Square (int x)
		{
			return x * x;
		}

		public int AddTwoNumbers (int x, int y)
		{
			return x + y;
		}

		public int FindMaxOfThree(int a, int b, int c)
		{
			if (a >= b && a >= c)
				return a;
			else if (b >= a && b >= c)
				return b;
			else
				return c;
		}
	}
}

