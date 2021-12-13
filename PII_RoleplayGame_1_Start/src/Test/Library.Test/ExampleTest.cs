using NUnit.Framework;

namespace Program
{

    [TestFixture]
    public class ExampleTest
    {

        [Test]
        public void TestNombre()    //Testea los nombres
        {
            Wizard Saruman = new Wizard("Saruman",5,5,5);
            string expectedW = "Saruman";
            Assert.AreEqual(expectedW, Saruman.Nombre);
            Elves Zirael = new Elves("Zirael",1,1,1);
            string expectedElv = "Zirael";
            Assert.AreEqual(expectedElv,Zirael.Name);
            Enano Tyron = new Enano("Tyron",1,1,1);
            string expectedEn = "Tyron";
            Assert.AreEqual(expectedEn, Tyron.Nombre);
        }
        [Test]
        public void ObtenerTotales()    //Verifica se agregen correctamente y se sumen a los totales de defensa
        {
            Wizard Guts = new Wizard("Guts",5,0,0);
            Elemento DragonSlayer = new Elemento("Dragonslayer","Espada",0,500);
            Elemento Berserker = new  Elemento("Armadura de Berserker","Armadura",1000,0);
            Guts.EquiparItem(DragonSlayer);
            Guts.EquiparItem(Berserker);
            int expectedAtk = 500;
            int expectedDef = 1000;
            Assert.AreEqual(expectedAtk,Guts.TotalAtaque());
            Assert.AreEqual(expectedDef, Guts.TotalDefensa());
        }
        [Test]
        public void MetodosPuntuales()  //metodos puntuales perteneciente a diferentes clases
        {
            Wizard Saruman = new Wizard("Saruman",5,5,5);
            Saruman.AprenderMagia();
            int expectedMag= 6;
            Assert.AreEqual(expectedMag, Saruman.Magia);
            Saruman.Salud=0;
            Saruman.Curarse();
            int expectedSalud = 5;
            Assert.AreEqual(expectedSalud,Saruman.Salud);
        }
        [Test]
        public void TestSantiago()
        {
            Wizard Kakashi = new Wizard("Kakashi", 40,2,10);
            string expectedk = "Kakashi";
            Assert.AreEqual(expectedk, Kakashi.Nombre);
            int expectedS = 40;
            Assert.AreEqual(expectedS, Kakashi.Salud);
            int expectedD = 2;
            Assert.AreEqual(expectedD, Kakashi.Defensa);
            int expectedM = 10;
            Assert.AreEqual(expectedM, Kakashi.Magia);

        }
    }


}
