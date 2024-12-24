using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectEg.NUnitTests
{
    [TestFixture, Description("This is sanity test suite"), Category("Sanity")]
    internal class TestFixtureEg
    {
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
        [Ignore("Defect ID 12345")]
        public void products()
        {
            Console.WriteLine("User selects the product");
        }
    }
}
