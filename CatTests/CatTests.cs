using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cats;

namespace CatTests
{
    [TestClass]
    public class CatTests
    {
        HouseCat keyboardCat;
        [TestInitialize]
        public void CreateHouseCatObject()
        {
            keyboardCat = new HouseCat("Keyboard Cat", 7);
        }

        [TestMethod]
        public void InheritsBaseInFirstConstructor()
        {
            Assert.AreEqual(7, keyboardCat.Weight, 0.001);
        }   

        [TestMethod]
        public void InheritsDefaultCatInSecondConstructor()
        {
            keyboardCat = new HouseCat("Keyboard Cat");
            Assert.AreEqual(13.0, keyboardCat.Weight, 0.001);
        }

        [TestMethod]
        public void IsNotInitiallyTired()
        {
            keyboardCat = new HouseCat("Keyboard Cat");
            Assert.IsFalse(keyboardCat.Hungry);
            Assert.IsFalse(keyboardCat.Tired);
            keyboardCat.Eat();
            Assert.IsTrue(keyboardCat.Tired);
        }
    }
}
