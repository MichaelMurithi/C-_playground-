using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest
    {
        private const string BAD_FILE_NAME = @"C:\Windows\DontExist.exe";

        #nullable disable
        public TestContext TestContext { get; set; }
        #nullable enable

        [TestMethod]
        public void FileNameDoesExist()
        {
            FileProcess fp = new();
            bool doesFileExist;

            TestContext.WriteLine(@"Checking if C:\Windows\Regedit.exe exists");
            doesFileExist = fp.FileExists(@"C:\Windows\Regedit.exe");
                
            Assert.IsTrue(doesFileExist);
        }

        [TestMethod]
        public void FileNameDoesNotExist()
        {
            FileProcess fp = new();
            bool doesFileExist;

            TestContext.WriteLine($@"Checking if {BAD_FILE_NAME} exists");
            doesFileExist = fp.FileExists(BAD_FILE_NAME);

            Assert.IsFalse(doesFileExist);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_UsingAttribute()
        {
            FileProcess fp = new();

            fp.FileExists("");
        }

        [TestMethod]
        public void FileNameNullOrEmpty_UsingTryCatch()
        {
            FileProcess fp = new();

            try
            {
                TestContext.WriteLine(@"Checking if a null file name exists");
                fp.FileExists("");
            }
            catch (ArgumentNullException)
            {
                return;
            }

            Assert.Fail("Call to FileExists() did NOT throw an ArgumentNullException");
        }
    }
}
