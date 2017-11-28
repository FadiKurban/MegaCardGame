using Microsoft.VisualStudio.TestTools.UnitTesting;
using MCGv4.Classes.Frigther;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGv4.Classes.Frigther.Tests
{
    [TestClass()]
    public class CharacterTests
    {
        [TestMethod()]
        public void AttackCharTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CharacterTest()
        {
            //Arrange
            Game_Controller vTest = new Game_Controller();
            //Act
            vTest.ClassChoice('W');
            //Assert  
            Assert.AreEqual(40, vTest.player.Hp);
            Assert.AreEqual(10, vTest.player.BaseDamage);
        }
    }
}