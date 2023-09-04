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
    public class CheckOutPage : AddToCartPage
    {
        #region Locators
        By FirstName = By.Id("first-name");
        By LastName = By.XPath("//*[@id=\"last-name\"]");
        By PostalCode = By.CssSelector("#postal-code");
        By CancleBtn = By.CssSelector("#cancel");
        By ContinueBtn = By.Id("continue");
        /*By RemoveProd1 = By.XPath("//*[@id=\"remove-sauce-labs-backpack\"]");*/

        #endregion

        #region Methods


        public void Enter_First_Name(String First_Name)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement firstNameField = wait.Until(ExpectedConditions.ElementToBeClickable(FirstName));
            firstNameField.SendKeys(First_Name);
            Thread.Sleep(2000);
        }

        public void Enter_Last_Name(String Last_Name)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement lastNameField = wait.Until(ExpectedConditions.ElementToBeClickable(LastName));
            lastNameField.SendKeys(Last_Name);
            Thread.Sleep(2000);
        }

        public void Enter_Postal_Code(int Postal_Code)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement postalCodeField = wait.Until(ExpectedConditions.ElementToBeClickable(PostalCode));
            postalCodeField.SendKeys(Postal_Code.ToString());
            Thread.Sleep(2000);
        }
        public void Continue_Checkout()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));           
            IWebElement Cont = wait.Until(ExpectedConditions.ElementToBeClickable(ContinueBtn));
          /* IWebElement Title = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("title")));
            string pageTitle = Title.Text;
            Assert.AreEqual(pageTitle, "Checkout: Your Information");*/
            Cont.Click();
            Thread.Sleep(5000);
        }

        public void Cancel_Checkout()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));            
            IWebElement Cancle_Btn = wait.Until(ExpectedConditions.ElementToBeClickable(CancleBtn));
            Cancle_Btn.Click();
            Thread.Sleep(5000);
        }

        #endregion
    }
}
