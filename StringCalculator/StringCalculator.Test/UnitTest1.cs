using System.ComponentModel;

namespace StringCalculator.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmptyStringTest()
        {
            string striing = "";

            Add add = new Add();

            int res = add.Addition(striing);
            Assert.AreEqual(0, res);
        }
    }
}