using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KarpenkoNA.Sprint7.Project.V4.Lib;

using System.IO;

namespace Tyuiu.KarpenkoNA.Sprint7.Project.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\duplo\source\repos\Tyuiu.KarpenkoNA.Sprint7\Tyuiu.KarpenkoNA.Sprint7.Project.V4\bin\Debug\OutPutFileProject.xlsx";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
