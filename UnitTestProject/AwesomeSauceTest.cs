using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolApp;

namespace SchoolTest
{
	[TestClass]
	public class AwesomeSauceTest
	{
		[TestMethod]
		public void TestInstantiation()
		{

			var testInstance = new AwesomeSauce();
			testInstance.Sauces.Add("Mukimo");
			testInstance.Sauces.Add("Njahi");
			testInstance.Sauces.Add("Njenga");

			//expect to pass
			Assert.IsTrue(testInstance.IsSauceAwesome("Mukimo"));

			//expect false
			Assert.IsFalse(testInstance.IsSauceAwesome("Njahi"));
		}
		[TestMethod]
		public void TestToString()
		{
			var testInstance = new SimpleArray();
			Assert.IsTrue(testInstance.ToString().StartsWith("There are"));
		}
	}
}

