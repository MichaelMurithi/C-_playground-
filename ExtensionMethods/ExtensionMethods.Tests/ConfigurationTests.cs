using ExtensionMethods.Library;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace ExtensionMethods.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            IConfiguration config = null;

            Assert.IsFalse(config.IsLoaded());
        }
    }
}
