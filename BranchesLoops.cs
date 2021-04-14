using System;
using System.Collections.Generic;
using System.Text;

namespace PreworkBootcamp
{
    public class BranchesLoops
    {
		public static BranchesLoops branchesLoops = new BranchesLoops();

		//if
		public bool IFTest(int l, int m, int n)
		{
			bool test;
			if ((l + m + n > 10) || (l == m))
			{
				test = true;
			}
			else
			{
				test = false;
			}
			return test;
		}


		//while
		public int WhileTest()
		{


			int counter = 0;
			while (counter < 10)
			{
				Console.WriteLine($"The counter is {counter}");
				counter++;
				Console.WriteLine();
			}

			return counter;
		}

		//task

		public int Task()
		{
			int sum = 0;
			for (int number = 1; number < 21; number++)
			{
				if (number % 3 == 0)
				{
					sum = sum + number;
				}
			}
		
			Console.WriteLine($"This is the sum of all integers 1 through 20 that are divisible by 3:  {sum}");
			Console.WriteLine();
			return sum;
		}
	}
}
