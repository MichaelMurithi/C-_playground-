using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp
{
	public class FlowControl
	{
		// Compound logic with logical OR
		public string PrimaryOrSecondaryCompound(string color)
		{
			if(color.ToLower() == "red" || color.ToLower() == "blue" || color.ToLower() == "yellow")
			{
				return "primary";
			}
			else
			{
				return "Secondary";
			}
		}
		//Switch statements
		public string SecondaryOrPrimary(string color)
		{
			var result = "";
			switch (color.ToLower())
			{
				case "red":
					result = "Primary";
					break;
				case "blue":
					result = "Primary";
					break;
				default:
					result = "Secondary";
					break;
			}
			return result;
		}

		//Nested if
		public string PrimaryOrSecondary(string color)
		{
			string result = "";
			if(color.ToLower() == "red")
			{
				result = "Primary";
			}else if(color.ToLower() == "blue")
			{
				result = "Primary";
			}
			else if (color.ToLower() == "yellow")
			{
				result = "Primary";

			} else
			{
				result = "Secondary";
			}
			return result;
		}

		//Without conditionals
		public bool IsYourFavoriteColorYellow(string color)
		{
			return color.ToLower() == "yellow";
		}
		//Control flow using ternary operators
		public bool IsYourFavoriteColorGreen(string color)
		{
			return (color.ToLower() == "green") ? true : false;
		}

		//Control flow using simple if...statements
		public bool IsFavoriteColorRed(string color)
		{
			if (color.ToLower() == "red") return true;
			else return false;
		}
		//Control flow using normal if..statements
		public bool IsFavoriteColorBlue(string color)
		{
			if (color.ToLower() == "blue")
			{
				return true;
			}else
			{
				return false;
			}
		}
	}
}
