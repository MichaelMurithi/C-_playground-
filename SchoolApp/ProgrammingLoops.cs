using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp
{
	class ProgrammingLoops
	{
		public List<Dictionary<string,int>> StudentMarks = new List<Dictionary<string,int>>();


		//For loops in C#
		public int SumEvn()
		{
			var sum = 0;
			for (var i = 0; i < 100; i++)
			{
				if (i % 2 == 0);
					sum = sum + 1;
			}
			return sum;
		}
	}
}
