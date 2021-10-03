using NUnit.Framework;
using RoleplayGame;


namespace Test.Library
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestPjsEncuentro()
        {
            DarkArcher maton = new DarkArcher("Maton");
            DarkDwarf tronco = new DarkDwarf("Tronco");
            DarkWizard tirador = new DarkWizard("Tirador");
            Encuentros testEnc = new Encuentros();
            testEnc.AddEnemigo(maton);
            testEnc.AddEnemigo(tronco);
            testEnc.AddEnemigo(tirador); 
            testEnc.DoEncounters();
            
            string expected = $"{testEnc.ToString()}";
            
            Assert.AreEqual(expected, testEnc.ToString() );
        }

        [Test]
        public void TestPjs1()
        {
            HeroeKnight markus = new HeroeKnight("Markus");
            Character dario = new DarkWizard("Dario"); 
            dario = markus;
            Assert.AreEqual(markus, dario);
        }
    }
}