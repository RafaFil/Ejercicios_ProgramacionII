using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Dwarf gimli = new Dwarf("Gimli");
            IElemento item = new Axe();
            gimli.AddElemento(item);
            item = new Shield();
            gimli.AddElemento(item);
            int attackExpected = 25;
            int defenseExpected = 25;
            Assert.AreEqual(gimli.AttackValue,attackExpected);
            Assert.AreEqual(gimli.DefenseValue,defenseExpected);
        }
        public void TestAtk()
        {
            Dwarf gimli = new Dwarf("Gimli");
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;
            gimli.ReceiveAttack(gandalf);
            int HealthExpected = 0;
            Assert.AreEqual(gimli.Health,HealthExpected);
        }
    }
}