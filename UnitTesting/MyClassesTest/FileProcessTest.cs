using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExist()
        {
            FileProcess fp = new();
            bool doesFileExist;

            doesFileExist = fp.FileExists(@"C:\Windows\Regedit.exe");
                
            Assert.IsTrue(doesFileExist);
        }

        [TestMethod]
        public void FileNameDoesNotExist()
        {
            FileProcess fp = new();
            bool doesFileExist;

            doesFileExist = fp.FileExists(@"C:\Windows\DontExist.exe");

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
