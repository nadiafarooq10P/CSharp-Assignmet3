using ASSIGNMENT_3.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_3.Tests
{
    [TestClass]
    public class AddToCart:Products
    {
       
        AddToCartPage addToCart = new AddToCartPage();
        Products product = new Products();

        [TestMethod]
        public void Continue_Shopping()
        {
            product.AddProducts();
            addToCart.ContinueShopping();
            Assert.IsTrue(driver.Url.Equals("https://www.saucedemo.com/inventory.html"));

        }
        [TestMethod]
        public void Check_out()
        {
            product.AddProducts();
            addToCart.CheckOut();
            Assert.AreEqual("https://www.saucedemo.com/checkout-step-one.html", driver.Url);
        }

    }
}
