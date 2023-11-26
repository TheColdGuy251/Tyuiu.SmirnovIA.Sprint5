using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.SmirnovIA.Sprint5.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V18.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
