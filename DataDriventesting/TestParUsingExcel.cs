using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectEg.Utilities;

namespace TestProjectEg.DataDriventesting
{
    internal class TestParUsingExcel: TestProjectEg.Utilities.ExcelRead
    {
        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + ":" + password);

        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            var columns = new List<string> { "username", "password" };
            return ExcelRead.GetTestDataFromExcel("C:\\Users\\vardh\\source\\repos\\TestProjectEg\\TestProjectEg\\testdata.xlsx", "sheet1", columns);
        }
    }
}
