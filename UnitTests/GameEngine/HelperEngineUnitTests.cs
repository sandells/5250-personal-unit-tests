using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crawl.Models;

namespace UnitTests.GameEngine
{
    [TestFixture]
    public class HelperEngineUnitTests
    {
        [Test]
        public void RollDice_Roll_1_Dice_10_Should_Pass()
        {
            // Arrange
            var Roll = 1; //Dice to roll
            var Dice = 10; //Die sides
            var Expected = 1; //Expected result
            var RollResult = 1; //fixed result of die roll
            var Hit = 1; //so setforcedrandomnumbers will work

            //fix random numbers
            Crawl.Models.GameGlobals.SetForcedRandomNumbers(RollResult, Hit);

            // Act
            //call RollDice
            var Actual = Crawl.GameEngine.HelperEngine.RollDice(Roll, Dice);

            //reset
            //unfix random numbers
            Crawl.Models.GameGlobals.ToggleRandomState();

            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }
        
        [Test]
        public void RollDice_Roll_2_Dice_10_Should_Pass()
        {
            //arrange
            var Roll = 2; //Dice to roll
            var Dice = 10; //Die sides
            var Expected = 2; //Expected result
            var RollResult = 1; //fixed result of die roll
            var Hit = 1; //so setforcedrandomnumbers will work

            //fix random numbers
            Crawl.Models.GameGlobals.SetForcedRandomNumbers(RollResult, Hit);

            //act
            //call RollDice
            var Actual = Crawl.GameEngine.HelperEngine.RollDice(Roll, Dice);

            //reset
            //unfix random numbers
            Crawl.Models.GameGlobals.ToggleRandomState();

            //assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }
        
        [Test]
        public void RollDice_Roll_0_Dice_10_Should_Fail()
        {
            // Arrange
            var Roll = 0; //Dice to roll
            var Dice = 10; //Die sides
            var Expected = 0; //Expected result

            // Act
            //call RollDice
            var Actual = Crawl.GameEngine.HelperEngine.RollDice(Roll, Dice);

            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }
        
        [Test]
        public void RollDice_Roll_Neg1_Dice_10_Should_Fail()
        {
            //arrange
            var Roll = -1; //Dice to roll
            var Dice = 10; //Die sides
            var Expected = 0; //Expected result

            //act
            //call RollDice
            var Actual = Crawl.GameEngine.HelperEngine.RollDice(Roll, Dice);

            //assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }
        
        [Test]
        public void RollDice_Roll_1_Dice_Neg1_Should_Fail()
        {
            // Arrange
            var Roll = 1; //Dice to roll
            var Dice = -1; //Die sides
            var Expected = 0; //Expected result

            // Act
            //call RollDice
            var Actual = Crawl.GameEngine.HelperEngine.RollDice(Roll, Dice);

            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }
        
        [Test]
        public void RollDice_Roll_1_Dice_Zero_Should_Fail()
        {
            //arrange
            var Roll = 1; //Dice to roll
            var Dice = 0; //Die sides
            var Expected = 0; //Expected result

            //act
            //call RollDice
            var Actual = Crawl.GameEngine.HelperEngine.RollDice(Roll, Dice);

            //assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }
        
        [Test]
        public void RollDice_Roll_1_Dice_10_Fixed_5_Should_Return_5()
        {
            // Arrange
            var Roll = 1; //Dice to roll
            var Dice = 10; //Die sides
            var Fixed = 5; //fixed result of die roll
            var Hit = 10; //so setforcedrandomnumbers will work
            var Expected = 5; //Expected result

            //fix random numbers
            Crawl.Models.GameGlobals.SetForcedRandomNumbers(Fixed,Hit);

            // Act
            //call RollDice
            var Actual = Crawl.GameEngine.HelperEngine.RollDice(Roll, Dice);

            //reset - MUST CLEAN UP BEFORE ASSERT
            //unfix random numbers
            Crawl.Models.GameGlobals.ToggleRandomState();

            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }
        
        [Test]
        public void RollDice_Roll_3_Dice_10_Fixed_5_Should_Return_15()
        {
            //arrange
            var Roll = 3; //Dice to roll
            var Dice = 10; //Die sides
            var Fixed = 5; //fixed result of die roll
            var Hit = 10; //so setforcedrandomnumbers will work
            var Expected = 15; //Expected result

            //fix random numbers
            Crawl.Models.GameGlobals.SetForcedRandomNumbers(Fixed, Hit);

            //act
            //call RollDice
            var Actual = Crawl.GameEngine.HelperEngine.RollDice(Roll, Dice);

            //reset
            //unfix random numbers
            Crawl.Models.GameGlobals.ToggleRandomState();

            //assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }
        
    }
}
