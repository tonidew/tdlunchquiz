﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunchQuiz;


namespace LunchQuizTests
{
    [TestClass]
    public class MenuItemTests
    {

        [TestMethod]
        public void MenuItemEnsureICanCreateInstance()
        {
            MenuItem milkshake = new MenuItem();
            Assert.IsNotNull(milkshake);
        }

        [TestMethod]
        public void MenuItemHasName()
        {
            MenuItem milkshake = new MenuItem();
            milkshake.Name = "milkshake";
            Assert.AreEqual("milkshake", milkshake.Name);
        }

        [TestMethod]
        public void MenuItemHasPrice()
        {
            MenuItem milkshake = new MenuItem();
            milkshake.Price = 3.00;
            Assert.AreEqual(3.00, milkshake.Price);
        }

        [TestMethod]
        public void MenuItemHasDescription()
        {
            MenuItem milkshake = new MenuItem();
            milkshake.Description = "yummy and delicious";
            Assert.AreEqual("yummy and delicious", milkshake.Description);
        }
    }
}
