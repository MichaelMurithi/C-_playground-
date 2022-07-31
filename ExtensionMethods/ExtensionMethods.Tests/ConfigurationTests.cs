using System.Linq;
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

        [Test]
        public void AddStandardProviders()
        {
            var builder = new ConfigurationBuilder();
            var config = builder.AddStandardProviders().Build();
            Assert.AreEqual(4, config.Providers.Count());
            Assert.IsTrue(config.IsLoaded());
        }
    }
}
