using NUnit.Framework;
using RoleplayGame;


namespace Test.Library
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestPjs()
        {
            DarkArcher maton = new DarkArcher("Maton");
            const string expected = "maton";
            Assert.AreEqual(expected, maton.Name);
        }

        [Test]
        public void TestPjs1()
        {
            HeroeKnight markus = new HeroeKnight("Markus");
            DarkWizard dario = new DarkWizard("Dario"); 
            
            Assert.AreEqual(markus, dario);
        }
    }
}