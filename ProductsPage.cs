using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using ASSIGNMENT_3.Tests;

namespace ASSIGNMENT_3.Pages
{
    public class ProductsPage : BaseClass
    {
        #region Locators
        By Product1 = By.XPath("//*[@id=\"add-to-cart-sauce-labs-backpack\"]");
        By Product2 = By.Id("add-to-cart-sauce-labs-bike-light");
        By Product3 = By.Id("add-to-cart-sauce-labs-bolt-t-shirt");
        By Product4 = By.Id("add-to-cart-sauce-labs-fleece-jacket");
      

        
        By Product5 = By.Id("remove-sauce-labs-backpack");
        By Product6 = By.Id("remove-sauce-labs-bike-light");
        By Product7 = By.Id("remove-sauce-labs-bolt-t-shirt");
        By Product8 = By.Id("remove-sauce-labs-fleece-jacket");

        By ClickAddToCart = By.XPath("//*[@id=\"shopping_cart_container\"]/a");
        #endregion

        #region Methods
        public void Product_1()
        {

            // Wait for Product1 to be clickable and then click it
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement P1 = wait.Until(ExpectedConditions.ElementToBeClickable(Product1));
            P1.Click();
        }

        public void Product_2()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement P2 = wait.Until(ExpectedConditions.ElementToBeClickable(Product2));
            P2.Click();
        }

        public void Product_3()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement P3 = wait.Until(ExpectedConditions.ElementToBeClickable(Product3));
            P3.Click();
        }

        public void Product_4()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5000));
            IWebElement P4 = wait.Until(ExpectedConditions.ElementToBeClickable(Product4));
            P4.Click();
            Thread.Sleep(5000);
        }
       

       
        public void Product_5()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5000));
            IWebElement P5 = wait.Until(ExpectedConditions.ElementToBeClickable(Product5));
            P5.Click();

        }

        public void Product_6()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5000));
            IWebElement P6 = wait.Until(ExpectedConditions.ElementToBeClickable(Product6));
            P6.Click();
            Thread.Sleep(5000);

        }

        public void Product_7()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5000));
            IWebElement P7 = wait.Until(ExpectedConditions.ElementToBeClickable(Product7));
            P7.Click();
          
        }

        public void Product_8()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5000));
            IWebElement P8 = wait.Until(ExpectedConditions.ElementToBeClickable(Product8));
            P8.Click();
            Thread.Sleep(5000);
        }

        public void ClickAddtoCart()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5000));
            // Wait for Product1 to be clickable and then click it
            IWebElement AddTo_Cart_Btn = wait.Until(ExpectedConditions.ElementToBeClickable(ClickAddToCart));
            AddTo_Cart_Btn.Click();
            Thread.Sleep(5000);
        }


        #endregion

    }
}
