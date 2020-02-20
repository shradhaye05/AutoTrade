using System;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewApp.Base;
using NewAppTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using NewApp.Helpers;

namespace NewAppTest
{
    [TestClass]
    public class UnitTest1:Base
    {

        string url = "http://automationpractice.com/index.php";

        public void OpenBrowser(BrowserType browserType=BrowserType.Chrome)
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
            //  _driver = new InternetExplorerDriver();
            //DriverContext.Driver = new ChromeDriver();
            //DriverContext.Driver.Navigate().GoToUrl(url);


          //  OpenBrowser(BrowserType.Chrome);
           // DriverContext.Browser.GoToUrl(url);

            // LoginPage page = new LoginPage();
            // page.ClickLoginLink();
            // page.Login("shradhaye@gmail.com", "Test1234");


            // //CurrentPage = page.CLickOrderHistroyr();
            // // CurrentPage.ClickFirstelement

            // CurrentPage = page.ClickOrderHistory();
            // ((OrderHistoryPage)CurrentPage).ClickFirstElement();

            //// OrderHistoryPage orderpage = new OrderHistoryPage();
            // //orderpage.ClickFirstElement();


            //login page
            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().ClickLoginLink();
            CurrentPage.As<LoginPage>().Login("shradhaye@gmail.com", "Test1234");
            //employee page 
           CurrentPage=  CurrentPage.As<LoginPage>().ClickOrderHistory();

           // CurrentPage.As<OrderHistoryPage>().ClickFirstElement();


            
        }

        [TestMethod]
        public void TableOperation()
        {

            OpenBrowser(BrowserType.Chrome);
           //DriverContext.Driver.Manage().Window.Maximize();
            DriverContext.Browser.GoToUrl(url);
           

            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().ClickLoginLink();
            CurrentPage.As<LoginPage>().Login("shradhaye@gmail.com", "Test1234");
            //employee page 
            CurrentPage = CurrentPage.As<LoginPage>().ClickOrderHistory();

            var table = CurrentPage.As<OrderHistoryPage>().GetOrderList();
            //var table = CurrentPage.As<OrderHistoryPage>().ClickFirstElement();

            HtmlTableHelpers.ReadTable(table);
            HtmlTableHelpers.PerformActionOnCell("0", "Order reference","GPAJWOBEI", "GPAJWOBEI");
            DriverContext.Driver.Quit();


        }

        //*[@id="order-list"]/tbody/tr[1]/td[7]/a[1]



        //public void Login()
        //{
        //    //old code
        //    ////_driver.FindElement(By.LinkText("Sign in")).Click();
        //    //_driver.FindElement(By.XPath("//a[@href='http://automationpractice.com/index.php?controller=my-account']")).Click();
        //    ////username
        //   // DriverContext.Driver.FindElement(By.Id("email")).SendKeys("shradhaye@gmail.com");
        //   // DriverContext.Driver.FindElement(By.Id("passwd")).SendKeys("Test1234");

        //    //click login
        //   // DriverContext.Driver.FindElement(By.Id("SubmitLogin")).Submit();


        //}

    }
}
