using ASSIGNMENT_3.Pages;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_3.Tests
{
    [TestClass]
    public class CheckOut : AddToCart
    {
        CheckOutPage checkout = new CheckOutPage();
        AddToCart add_to_cart = new AddToCart();

        [TestMethod]
        public void ContinueCheckOut()
        {
            add_to_cart.Check_out();

            checkout.Enter_First_Name("Nadia");
            checkout.Enter_Last_Name("Khan");
            checkout.Enter_Postal_Code(75850);
           
            /*IWebElement Title = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("title")));
            string pageTitle = Title.Text;
            Assert.AreEqual(pageTitle, "Checkout: Your Information");
            Console.WriteLine("Last Step To Checkout -> " + pageTitle);*/
     
            
            checkout.Continue_Checkout();
            Assert.AreNotEqual("https://www.saucedemo.com/checkout-step-one.html", driver.Url);

        }
        [TestMethod]
        public void Cancel_Btn()
        {
            add_to_cart.Check_out();
            checkout.Enter_First_Name("Nadia");
            checkout.Enter_Last_Name("Khan");
            checkout.Enter_Postal_Code(75850);
            checkout.Cancel_Checkout();
            Assert.IsTrue(driver.Url.Equals("https://www.saucedemo.com/cart.html"));

        }

    }

}
