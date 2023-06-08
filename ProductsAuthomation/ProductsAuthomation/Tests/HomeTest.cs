using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ViteReactTS.Pages;

namespace ViteReactTS.Tests
{
    [TestClass]
    public class HomeTest : BaseTest
    {
        [TestMethod]
        public void Home()
        {
            //f
            HomePage Home = new HomePage(driver);
        }
    }
}