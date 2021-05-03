using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp
{
	public class ProgrammingLoops
	{
		public List<Dictionary<string,int>> StudentMarks = new List<Dictionary<string,int>>();

        //foeach loop in C#
		public int ForEachLoop()
		{
			var sum = 0;
			var numbers = new List<int> { 1, 4, 5, 6, 7, 8, 9 };
			foreach(var number in numbers)
			{
				sum += number;
			}
            return sum;
		}

		//For loops in C#
		public int SumEven()
		{
			var sum = 0;
			for (var i = 0; i < 100; i++)
			{
				if (i % 2 == 0)
				{
					sum = sum + 1;
				}
			}
			return sum;
		}
	}
}
