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
    public class OrderComplete : OrderCompletePage
    {

        CheckOutStepTwo checkOutStepTwo = new CheckOutStepTwo();
        OrderCompletePage orderCompletePage = new OrderCompletePage();

        [TestMethod]
        public void Order_Completion_Msg()
        {
            checkOutStepTwo.Finish_Shopping();
            orderCompletePage.PrintOrderCompletionMsg();
            orderCompletePage.GoToBackHomeBtn();
            Assert.AreEqual("https://www.saucedemo.com/inventory.html", driver.Url);
            orderCompletePage.LogOut();


        }
    }
}
