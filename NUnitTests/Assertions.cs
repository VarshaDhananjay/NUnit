using System;
using NUnit.Framework;

namespace TestProjectEg.NUnitTests
{
    [Allure.NUnit.AllureNUnit]
    internal class Assertions
    {
        [Test]
        public void AssertionsEg()
        {
            // String assertions
            string actual = "Google";
            string expected = "yahoo";

            // Comparison assertions
            Assert.AreNotEqual(actual, expected);  // Pass
            Assert.AreNotSame(actual, expected);  // Pass
            Assert.That(actual, Is.Not.EqualTo(expected)); // Pass

            // String constraints
            Assert.That(actual, Does.Contain("goo").IgnoreCase); // Pass
            Assert.IsNotNull(actual); // Pass

            // Collection constraints
            int[] array = new int[] { 1, 4, 3, 8, 5, 6 };

            Assert.NotNull(array); // Pass
            Assert.That(array, Is.All.GreaterThan(0)); // Pass
            Assert.That(array, Is.Not.Empty); // Pass

            // Check if the array is unordered
            Assert.That(array, Is.Not.Ordered); // Pass

            // Sorted array check
            int[] sortedArray = new int[] { 1, 2, 3, 4, 5, 6 };
            Assert.That(sortedArray, Is.Ordered.Ascending); // Pass

            // Numeric assertions
            int age = 17;

            // Assert with a meaningful message
            Assert.That(age, Is.LessThan(18), "User is not eligible for voting");
        }
    }
}
