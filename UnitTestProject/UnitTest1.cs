using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolApp;

namespace UnitTestProject
{
	[TestClass]
	public class AddNumstTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			var testInstance = new AddNums();
			var testResult = testInstance.AddTwo(9, 5);
			Assert.AreEqual(14, testResult, "I expect 9 + 5 to be 14");
		}
	}
}
