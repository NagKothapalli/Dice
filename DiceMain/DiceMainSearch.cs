using System;
using System.Configuration;
using System.Security.Policy;
using Dice.DicePages;
using Dice.DiceUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Dice
{
    [TestClass]
    public class UnitTest1
    {
        private static IWebDriver driver = TestSetUp.BringMyDriver();
        DiceHomePage myDiceHomePage = new DiceHomePage(driver);

        [TestInitialize]
        public void LaunchApplication()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["AppURL"]);
            
        }
        [TestMethod]
        public void DiceMainSearch()
        {
            XLUtility.WriteCellValue("BooleanSearch",0,1,"MyNewColum");
            myDiceHomePage.DiceSearch("Java","WA");
        }

        [TestMethod]
        public void DiceBooleanSearch()
        {
            myDiceHomePage.BooleanSearch();
           // myDiceHomePage.CaptureTheSearchResultsCount();
        }
    }
}
