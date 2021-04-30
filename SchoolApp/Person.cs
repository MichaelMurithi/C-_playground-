using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
	//The Person class is abstract to prevent it from being instantiated directly
	public abstract class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }

		public abstract float ComputeGradeAverage();

	}
}
