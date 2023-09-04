using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_3.Pages
{
    public class OrderCompletePage : CheckOutStepTwoPage
    {
        #region Locators
        
        By OrderCompletionMsg = By.ClassName("complete-header");
       By SuccessMsg = By.ClassName("complete-text");
        By BackHomeBtn = By.Id("back-to-products");
        By options = By.Id("react-burger-menu-btn");
        By logout = By.Id("logout_sidebar_link");


        #endregion

        #region Methods

        public void PrintOrderCompletionMsg()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement Title = wait.Until(ExpectedConditions.ElementIsVisible(OrderCompletionMsg));
            string pageTitle = Title.Text;
            Assert.AreEqual("Thank you for your order!", pageTitle);
            Console.WriteLine(pageTitle);

            IWebElement Success_Msg = wait.Until(ExpectedConditions.ElementIsVisible(SuccessMsg));
            string Order_Placed = Success_Msg.Text;
            Assert.AreEqual("Your order has been dispatched, and will arrive just as fast as the pony can get there!", Order_Placed);
            Console.WriteLine(Order_Placed);
            Thread.Sleep(2000);

        }
        public void GoToBackHomeBtn()

        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            wait.Until(ExpectedConditions.ElementToBeClickable(BackHomeBtn)).Click();
            

        }



        public void LogOut()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));

            IWebElement ClickNavBarBtn = wait.Until(ExpectedConditions.ElementIsVisible(options));
            ClickNavBarBtn.Click();
            Thread.Sleep(3000);
            Console.WriteLine("Session LogOut");
            IWebElement ClicklogoutBtn = wait.Until(ExpectedConditions.ElementIsVisible(logout));
            ClicklogoutBtn.Click();
            Thread.Sleep(3000);

        }
        #endregion
    }
}
