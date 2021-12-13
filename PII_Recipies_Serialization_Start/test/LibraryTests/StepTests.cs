using NUnit.Framework;
using Recipies;

namespace LibraryTests
{
    public class StepTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SerializeStepTest()
        {
            string productDescription = "Test Product";
            double unitCost = 9.99;
            string productJson = $@"{{""Description"":""{productDescription}"",""UnitCost"":{unitCost}}}";

            string equipmentDescription = "Test Equipment";
            double hourlyCost = 99.99;
            string equipmentJson = $@"{{""Description"":""{equipmentDescription}"",""HourlyCost"":{hourlyCost}}}";

            double quantity = 999.99;
            int time = 10;

            string expected = $@"{{""Input"":{productJson},""Quantity"":{quantity},""Time"":{time},""Equipment"":{equipmentJson}}}";

            Product product = new Product(productDescription, unitCost);
            Equipment equipment = new Equipment(equipmentDescription, hourlyCost);
            IJsonConvertible step = new Step(product, quantity, equipment, time);
            string actual = step.ConvertToJson();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DeserializeStepTest()
        {
            string productDescription = "Test Product";
            double unitCost = 9.99;
            string productJson = $@"{{""Description"":""{productDescription}"",""UnitCost"":{unitCost}}}";

            string equipmentDescription = "Test Equipment";
            double hourlyCost = 99.99;
            string equipmentJson = $@"{{""Description"":""{equipmentDescription}"",""HourlyCost"":{hourlyCost}}}";

            double quantity = 999.99;
            int time = 10;

            string json = $@"{{""Input"":{productJson},""Quantity"":{quantity},""Time"":{time},""Equipment"":{equipmentJson}}}";

            Step step = new Step(json);


            Assert.AreEqual(step.Input.Description, productDescription);
            Assert.AreEqual(step.Quantity, quantity);
            Assert.AreEqual(step.Equipment.Description, equipmentDescription);
            Assert.AreEqual(step.Time, time);
        }
    }
}