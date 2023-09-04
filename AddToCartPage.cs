using ASSIGNMENT_3.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_3.Pages
{
    public class AddToCartPage : ProductsPage
    {
        #region Locators
        By ContinueShoppingBtn = By.Id("continue-shopping");
        By CheckOutBtn = By.XPath("//*[@id=\"checkout\"]");
        /*By RemoveProd1 = By.XPath("//*[@id=\"remove-sauce-labs-backpack\"]");*/

        #endregion

        #region Methods

        public void ContinueShopping()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement Cont_Shopping = wait.Until(ExpectedConditions.ElementToBeClickable(ContinueShoppingBtn));
            Cont_Shopping.Click();
            Thread.Sleep(5000);
        }

        public void CheckOut()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement Check_Out = wait.Until(ExpectedConditions.ElementToBeClickable(CheckOutBtn));
            Check_Out.Click();
            Thread.Sleep(5000);
        }


        #endregion

    }


}
