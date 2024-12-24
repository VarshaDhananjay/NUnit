using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectEg.NUnitTests
{
    internal class SetUpTeardown
    {
        [SetUp]
        public void launchbrowser()
        {
            Console.WriteLine("Launching the browser");
        }
        
        [TearDown]
        public void closebrowser()
        {
            Console.WriteLine("Closing the browser");
        }
        [Test, Order(1)]
        public void userreg()
        {
            Console.WriteLine("User registration completed");
        }
        [Test, Order(2)]
        public void login()
        {
            Console.WriteLine("User is logged in");
        }
        [Test, Order(3)]
        public void products()
        {
            Console.WriteLine("User selects the product");
        }
    }
}
