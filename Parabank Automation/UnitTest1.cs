using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

using System;
using System.Security.Policy;

using Parabank_Automation.Framework.Pages;

namespace Parabank_Automation
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver driver;


        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the WebDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
            Thread.Sleep(1000);

            var homePageElements = new HomePageElements(driver);
            
            homePageElements.AboutUsButton.c





            /*IWebElement solutionsElem = driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']//li[@class='Solutions']"));
            IWebElement aboutUsElem = driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']/li[2]/a"));
            IWebElement servicesElem = driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']/li[3]/a"));
            IWebElement productsElem = driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']//a[@href='http://www.parasoft.com/jsp/products.jsp']"));
            IWebElement locationsElem = driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']//a[@href='http://www.parasoft.com/jsp/pr/contacts.jsp']"));
            IWebElement adminPageElem = driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']/li[6]/a"));

            Actions actions = new Actions(driver);
            actions.Click(solutionsElem).Perform();
            Thread.Sleep(1000);
            actions.Click(aboutUsElem).Perform();
            Thread.Sleep(2000);
            actions.Click(servicesElem).Perform();
            Thread.Sleep(2000);
*/

            Thread.Sleep(5000);


        }


        [TestCleanup]
        public void MyTestCleanup()
        {
            driver.Quit();
        }

    }
}
