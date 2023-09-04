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
    public class CheckOutStepTwoPage : CheckOutPage
    {
        #region Locators
       By SecondProduct = By.Id("item_0_title_link");
       By FirstProduct = By.Id("item_4_title_link");
       By ThirdProduct = By.Id("item_1_title_link");
       By FourthProduct = By.Id("item_5_title_link");
        By FinishBtn = By.Id("finish");
        By CancleBtn2 = By.XPath("//*[@id=\"cancel\"]");
        


        #endregion

        #region Methods

       public void Print_AddtoCart_Item_Names()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement FirstItem = wait.Until(ExpectedConditions.ElementIsVisible(FirstProduct));
            string firstProductText = FirstItem.Text;
            Console.WriteLine("1st Product :" + firstProductText);


            IWebElement SecondItem = wait.Until(ExpectedConditions.ElementIsVisible(SecondProduct));
            string secondProductText = SecondItem.Text;
            Console.WriteLine("2nd Product :" + secondProductText);
            Thread.Sleep(5000);

           IWebElement ThirdItem = driver.FindElement(ThirdProduct);
            string thirdProductText = ThirdItem.Text;
            Console.WriteLine("3rd Product : " + thirdProductText);


            IWebElement FourthItem = driver.FindElement(FourthProduct);
            string fourthProductText = FourthItem.Text;
            Console.WriteLine("4th Product : " + fourthProductText);

        }
        
        public void Click_Finish_Btn()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement Finish_Btn = wait.Until(ExpectedConditions.ElementToBeClickable(FinishBtn));
            Finish_Btn.Click();
            Thread.Sleep(5000);


        }


        public void Cancel_CheckoutSteptwo()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Wait for Product1 to be clickable and then click it
            IWebElement Cancle_CheckoutSteptwoBtn = wait.Until(ExpectedConditions.ElementToBeClickable(CancleBtn2));
            Cancle_CheckoutSteptwoBtn.Click();
            Thread.Sleep(5000);
        }

        #endregion
    }
}
