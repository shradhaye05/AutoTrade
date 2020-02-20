using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewApp.Base;
using NewApp.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support;


namespace AutoTraderTest
{
    [TestClass]
    public class AutoUnitTest1:Base
    {

        string url = "https://www.autotrader.com/";

        public void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
        {

            switch (browserType)
            {
                case BrowserType.InterntExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;


            }
        }


        [TestMethod]
        public void TestMethod1()
        {

            
           
            OpenBrowser(BrowserType.Chrome);
            DriverContext.Driver.Manage().Window.Maximize();
            DriverContext.Browser.GoToUrl(url);
            DriverContext.Driver.FindElement(By.XPath("//*[@id='mountNode']/div/div[1]/div/div/div/div[1]/div/div[2]/div/div/div/div/div/div/div[1]/div[2]/span/span/div[1]/div[1]/span")).Click();
            DriverContext.Driver.FindElement(By.XPath("//*[@id='mountNode']/div/div[1]/div/div/div/div[1]/div/div[2]/div/div/div/div/div/div/div[1]/div[2]/span/span/div[2]/div/span")).Click();
            DriverContext.Driver.FindElement(By.XPath("//*[@id='mountNode']/div/div[1]/div/div/div/div[1]/div/div[2]/div/div/div/div/div/div/div[1]/div[2]/span/span/div[3]/div/a")).Click();
            DriverContext.Driver.FindElement(By.Id("search")).Click();

            //IWebElement dropdown = DriverContext.Driver.FindElement(By.Id("makeCodeListPlaceHolder"));
            //if (dropdown.Text.Contains("BMW"))
            //{
            //    string s1 = "Value is present";
            //}
            //else
            //{
            //    string s2 = "value is not present";
            //}

            //IWebElement dropdown1 = DriverContext.Driver.FindElement(By.Id("modelCodeListPlaceHolder"));
            DriverContext.Driver.Quit();




        }
    }
}
