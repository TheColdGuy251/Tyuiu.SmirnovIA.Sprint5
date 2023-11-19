using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.SmirnovIA.Sprint5.Task0.V17.Lib;

namespace Tyuiu.SmirnovIA.Sprint5.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\tyuiu projects\Tyuiu.SmirnovIA.Sprint5\Tyuiu.SmirnovIA.Sprint5.Task0.V17\bin\Debug\OutPutFileTask0.txt";
            
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
