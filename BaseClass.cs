using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;
using static System.Collections.Specialized.BitVector32;

namespace ASSIGNMENT_3
{
    [TestClass]
    public class BaseClass
    {

        public static IWebDriver? driver;
        public WebDriverWait wait;
        By username = By.Id("user-name");
        By password = By.Id("password");

        // Initialize Driver

        [TestInitialize]
        public void WebdriverInitialization1()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.FindElement(username).SendKeys("standard_user");
            driver.FindElement(password).SendKeys("secret_sauce");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(2000);
            Assert.AreEqual("https://www.saucedemo.com/inventory.html", driver.Url);
        }

        //ClosingBrowser
        [TestCleanup]
        public void ClosingBrowser2(){
            driver.Close();
}
    }
}

