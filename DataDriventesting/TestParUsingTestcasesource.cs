using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectEg.DataDriventesting
{
    internal class TestParUsingTestcasesource
    {
        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + ":" + password);

        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("ad.com", "admin123");
            yield return new TestCaseData("ad0.com", "ad");
            yield return new TestCaseData("adm.com", "ghhjm");
            yield return new TestCaseData("admm.com", "gdfhhhjm");
        }
    }
}
