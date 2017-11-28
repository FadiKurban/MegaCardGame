using Microsoft.VisualStudio.TestTools.UnitTesting;
using MCGv4.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGv4.Classes.Tests
{
    [TestClass()]
    public class Game_ControllerTests
    {
        [TestMethod()]
        public void ClassChoiceTest()
        {
            //Arrange
            Game_Controller vTest = new Game_Controller();
            //Act
            vTest.ClassChoice('W');
            //Assert  
            Assert.AreEqual('W', vTest.player);
        }

        [TestMethod()]
        public void AttackCallTest()
        {
            Game_Controller vTest = new Game_Controller();
            vTest.ClassChoice('W');

            vTest.AttackCall('N');

            
        }
    }
}