/// <summary>
/// Los test se encargarn de ver si la herencia es aplicada correctamente, creando 
/// instancias para cada clase que hereda de personajes (Se crearan 2 clases heroes y
/// una clase villano).
/// </summary>

using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class Tests
    {
        [Test]
        public void TestArcher()
        {
            Archer p = new Archer("Gilgamesh");
            string expectedName = "Gilgamesh";
            Assert.AreEqual(expectedName,p.Name);
            int expectedATK = 15;
            Assert.AreEqual(expectedATK,p.AttackValue);
            int expectedDEF = 18;
            Assert.AreEqual(expectedDEF, p.DefenseValue);
            p.ReceiveAttack(100);
            int expectedHealth = 18;
            Assert.AreEqual(expectedHealth,p.Health);
            p.Cure();
            int expectedCure = 100;
            Assert.AreEqual(expectedCure, p.Health);
        }
        [Test]
        public void TestWizard()
        {
            Wizard p = new Wizard("Gandalf");
            string expectedName = "Gandalf";
            Assert.AreEqual(expectedName,p.Name);
            int expectedATK = 100;
            Assert.AreEqual(expectedATK,p.AttackValue);
            int expectedDEF = 100;
            Assert.AreEqual(expectedDEF, p.DefenseValue);
            p.ReceiveAttack(200);
            int expectedHealth = 0;
            Assert.AreEqual(expectedHealth,p.Health);
            p.Cure();
            int expectedCure = 100;
            Assert.AreEqual(expectedCure, p.Health);
        }
        [Test]
        public void Testlieutenant()
        {
            DemonLieutenant p = new DemonLieutenant("Astaroth",5);
            string expectedName = "Astaroth";
            Assert.AreEqual(expectedName,p.Name);
            int expectedVP = 5;
            Assert.AreEqual(expectedVP,p.VP);
            int expectedATK = 1000;
            Assert.AreEqual(expectedATK,p.AttackValue);
            int expectedDEF = 50;
            Assert.AreEqual(expectedDEF, p.DefenseValue);
            p.ReceiveAttack(200);
            int expectedHealth = 0;
            Assert.AreEqual(expectedHealth,p.Health);
            p.Cure();
            int expectedCure = 100;
            Assert.AreEqual(expectedCure, p.Health);
        }
        [Test]
        public void TestVP()
        {
            Sombras sombraGenerica = new Sombras("Generica",1);
            Knight saber = new Knight("Saber");
            int expectedVP=0;
            Assert.AreEqual(expectedVP,saber.VP);
            int expectedVPgained = 1;
            saber.AñiadirVP(sombraGenerica);
            Assert.AreEqual(expectedVPgained, saber.VP);
        }
    }
}