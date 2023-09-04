using ASSIGNMENT_3.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_3.Tests
{
    [TestClass]
    public class CheckOutStepTwo : CheckOut
    {

        CheckOut checkouttwo = new CheckOut();
        CheckOutStepTwoPage checkOutStepTwo = new CheckOutStepTwoPage();

        [TestMethod]
        public void Finish_Shopping()
        {
            checkouttwo.ContinueCheckOut();
            checkOutStepTwo.Print_AddtoCart_Item_Names();
            checkOutStepTwo.Click_Finish_Btn();
            Assert.AreEqual("https://www.saucedemo.com/checkout-complete.html", driver.Url);
        }

        

        [TestMethod]
        public void Cancel_Order()
        {
            checkouttwo.ContinueCheckOut();
            checkOutStepTwo.Cancel_CheckoutSteptwo();
            Assert.IsTrue(driver.Url.Equals("https://www.saucedemo.com/inventory.html"));
            Console.WriteLine("Order Cancelled");

        }
    }
}
