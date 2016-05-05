using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunchQuiz;

namespace LunchQuizTests
{
    [TestClass]
    public class FineDiningTests
    {
        [TestMethod]
        public void FineDiningCanCreateInstance()
        {
            FineDining fancys = new FineDining();
            Assert.IsNotNull(fancys);
        }
        [TestMethod]
        public void FineDiningCanSetNumberofSeatsAtBar()
        {
            FineDining fancys = new FineDining();
            fancys.NumberofSeatsAtBar = 12;
            Assert.AreEqual(12, fancys.NumberofSeatsAtBar);
        }
        [TestMethod]
        public void FineDiningCanCalculateCapacity()
        //expand upon base.capacity()
        {
            FineDining fancys = new FineDining();
            fancys.NumberofSeatsAtBar = 12;
            fancys.Numberof4PersonTables = 6;
            fancys.Numberof2PersonTables = 8;
            Assert.AreEqual(52, fancys.capacity());
        }
    }
}
