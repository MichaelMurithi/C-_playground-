using System;

using System.Collections.Generic;
using System.Text;

namespace SchoolApp
{
	class School
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }

		public string Zip { get; set; }

		public string State { get; set; }

		public string PhoneNumber { get; set; }


		private string _twitterAddress;

		public string TwitterAddress
		{
			get { return _twitterAddress; } //On get, the twitter address is automatically returned
			set
			{
				if (value.StartsWith("@")) //A valid address should start with @
				{
					_twitterAddress = value;
				}
				else
				{
					throw new Exception("The twitter address must begin with @");
				}
			}
		}

		// Function bodied expressions
		public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;
		public static int AverageThreeScores(int a, int b, int c)
		{
			var result = (a + b + c) / 3;
			return result;
		}

		//Methods overiding
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine(Name);
			sb.AppendLine(Address);
			sb.AppendLine(City);
			sb.Append(", ");
			sb.Append("  ");

			return sb.ToString();
		}

	}
}

