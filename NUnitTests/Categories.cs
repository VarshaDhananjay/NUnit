using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectEg.NUnitTests
{
    [Allure.NUnit.AllureNUnit]
    internal class Categories
    {
        [Test, Order(1), Category("Regression")]
        public void userreg()
        {
            Console.WriteLine("User registration completed");
        }
        [Test, Order(2)]
        public void login()
        {
            Console.WriteLine("User is logged in");
        }
        [Test, Order(3), Category("Sanity")]
        public void products()
        {
            Console.WriteLine("User selects the product");
        }
        [Test, Order(4),Category("Regression")]
        public void addtocart()
        {
            Console.WriteLine("The products are added to the cart");
        }
    }
}
