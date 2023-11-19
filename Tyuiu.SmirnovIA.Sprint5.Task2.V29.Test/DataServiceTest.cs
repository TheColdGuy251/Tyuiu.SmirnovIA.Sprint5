using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SmirnovIA.Sprint5.Task2.V29.Lib;

namespace Tyuiu.SmirnovIA.Sprint5.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\tyuiu projects\Tyuiu.SmirnovIA.Sprint5\Tyuiu.SmirnovIA.Sprint5.Task2.V29\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
