using NUnit.Framework;
using Recipies;

namespace LibraryTests
{
    public class ProductTests
    {
    [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SerializeProductTest()
        {
            string description = "Test Product";
            double unitCost = 9.99;
            string expected = $@"{{""Description"":""{description}"",""UnitCost"":{unitCost}}}";

            IJsonConvertible Product = new Product(description, unitCost);
            string actual = Product.ConvertToJson();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DeserializeProductTest()
        {
            string description = "Test Product";
            double unitCost = 9.99;
            string json = $@"{{""Description"":""{description}"",""UnitCost"":{unitCost}}}";

            Product Product = new Product(json);

            Assert.AreEqual(description, Product.Description);
            Assert.AreEqual(unitCost, Product.UnitCost);
        }
    }
}