using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
	class Teacher : Person
	{
		
		public string Subject { get; set; }

		public override float ComputeGradeAverage()
		{
			//TODO: Fix the Implementation Later
			return 4.0f;
		}
	}
}
