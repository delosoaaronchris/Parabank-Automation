using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parabank_Automation.Framework.Pages
{
    class HomePageElements
    {
        private IWebDriver _driver;

        public HomePageElements(IWebDriver driver)
        {
            _driver = driver;
        }

/*        public IWebDriver SolutionElement
        {
            get
            {
                return _driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']//li[@class='Solutions']"));
           
            }
        }*/
        public IWebDriver AboutUsButton
        {
            get
            {
                return _driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']/li[2]/a"));

            }
        }



        /*
                IWebElement solutionsElem = _driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']//li[@class='Solutions']"));
                IWebElement aboutUsElem = driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']/li[2]/a"));
                IWebElement servicesElem = driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']/li[3]/a"));
                IWebElement productsElem = driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']//a[@href='http://www.parasoft.com/jsp/products.jsp']"));
                IWebElement locationsElem = driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']//a[@href='http://www.parasoft.com/jsp/pr/contacts.jsp']"));
                IWebElement adminPageElem = driver.FindElement(By.XPath("//div[@id='headerPanel']/ul[@class='leftmenu']/li[6]/a"));
        */
    }
}
