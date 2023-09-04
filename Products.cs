using ASSIGNMENT_3.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_3.Tests
{
    [TestClass]
    public class Products : ProductsPage
    {
        ProductsPage product = new ProductsPage();
        AddToCartPage addToCart = new AddToCartPage();

        [TestMethod]
        public void AddProducts()
        {
            product.Product_1();

            product.Product_2();

            product.Product_3();

            product.Product_4();

            string expectedUrl = "https://www.saucedemo.com/inventory.html";

            string actualUrl = driver.Url;

            Assert.AreEqual(expectedUrl, actualUrl, "URL assertion Passed.");

            // Print a message
            Console.WriteLine("Products added successfully in cart: Expected URL: '{0}', Actual URL: '{1}'", expectedUrl, actualUrl);

            product.ClickAddtoCart();

            Assert.AreNotEqual("https://www.saucedemo.com/inventory.html", driver.Url);
        }




        /*[TestMethod]
        public void RemoveProducts()
        {
            product.Product_5();

            product.Product_6();

            product.Product_7();

            product.Product_8();

            string expectedUrl = "https://www.saucedemo.com/inventory.html";

            string actualUrl = driver.Url;

            Assert.AreEqual(expectedUrl, actualUrl, "URL assertion Passed.");

            // Print a message
            Console.WriteLine("URL Assertion Passed: Expected URL: '{0}', Actual URL: '{1}'", expectedUrl, actualUrl);

        }*/

    }
}
