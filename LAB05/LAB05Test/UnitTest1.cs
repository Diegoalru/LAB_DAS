using LAB05.App_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LAB05Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FormatIdAndNameWithEmptyReturnsNull()
        {
            StudentC studen = new StudentC(new MyFake());

            string formatter = studen.FormatNameAndID("", 1);

            Assert.IsNull(formatter);
        }

        class MyFake : IFormatIdAndName
        {
            override 
        }

    }
}
