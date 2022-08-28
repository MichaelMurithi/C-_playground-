using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest : TestBase
    {
     
        private const string BAD_FILE_NAME = @"C:\Windows\DontExist.exe";

        [TestMethod]
        public void FileNameDoesExist()
        {
            FileProcess fp = new();
            bool doesFileExist;

            SetGoodFileName();
            if (!string.IsNullOrEmpty(_GoodFileName))
            {
                //Create the 'Good' file
                File.AppendAllText(_GoodFileName, "Some Text");
            }

            TestContext.WriteLine($@"Checking if {_GoodFileName} exists");

            doesFileExist = fp.FileExists(_GoodFileName);

            //Delete file
            if (File.Exists(_GoodFileName))
            {
                File.Delete(_GoodFileName);
            }
            
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
