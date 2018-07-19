using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdPartyTools;

namespace ThirdPartyToolsTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void GetFileDetails_ValidVersion_Test()
        {
            //Arrange
            Program prog = new Program();
            FileInfo fileInfo = new FileInfo();
            string[] args = new string[] { "-v" };

            //Act
            fileInfo = prog.GetFileDetails(args);

            //Assert
            Assert.AreNotEqual(0, fileInfo.Version);
        }

        [TestMethod]
        public void GetFileDetails_ValidVersionAndSize_Test()
        {
            //Arrange
            Program prog = new Program();
            FileInfo fileInfo = new FileInfo();
            string[] args = new string[] { "-v", "-size" };

            //Act
            fileInfo = prog.GetFileDetails(args);

            //Assert
            Assert.AreNotEqual(0, fileInfo.Version);
            Assert.AreNotEqual(0, fileInfo.Size);
        }

        [TestMethod]
        public void GetFileDetails_InvalidInputs_Test()
        {
            //Arrange
            Program prog = new Program();
            FileInfo fileInfo = new FileInfo();
            //Swaaping input params order such that we should not get any output
            string[] args = new string[] { "-size", "-v" };

            //Act
            fileInfo = prog.GetFileDetails(args);

            //Assert
            Assert.AreEqual(0, fileInfo.Version);
            Assert.AreEqual(0, fileInfo.Size);
        }
    }
}
