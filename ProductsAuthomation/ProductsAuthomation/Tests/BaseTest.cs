using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace ViteReactTS
{
    [TestClass]
    public class BaseTest

    {
        public ChromeDriver driver { get; set; }

        [TestInitialize]
        public void InitTest()
        {
            driver = new ChromeDriver(@"C:\QA\ViteReactTS\ViteReactTS\ViteReactTS\ViteReactTS\chromedriver\chromedriver.exe");
            driver.Navigate().GoToUrl(Pages.BasePage.ViteReactST_URL);
            driver.Manage().Window.Maximize();
        }
        [TestCleanup]
        public void FinishTest()
        {
            driver.Quit();
        }
    }
}