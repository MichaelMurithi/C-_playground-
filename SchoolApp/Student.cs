using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
	public class Student : Person
	{
		public enum GradeLevels { Freshman, Sophomore, Juniour, Senior}
		public GradeLevels GradeLevel { get; set; }

		public override float ComputeGradeAverage()
		{
			return 4.0f;
		}
		public override string SendMessage(string message)
		{
			return base.SendMessage(message);
		}
	}
}
