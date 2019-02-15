using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crawl.Models;

namespace UnitTests.Models
{
    [TestFixture]
    public class CharaterUnitTests
    {
        [Test]
        public void Character_ScaleLevel_Level_0_Should_Fail()
        {
            //arrange
            var Hit = 10;  //set Hit so SetForcedRandomNumbers will work
            var Fixed = 1;  //Fixed die roll value
            var level = 0;  //level to scale to

            //force random number to = Fixed
            Crawl.Models.GameGlobals.SetForcedRandomNumbers(Fixed, Hit);

            //create a character
            var test = new Character();
            //Expected value is default test Level = 1
            var Expected = test.Level;

            //Act
            test.ScaleLevel(level);  //call ScaleLevel
            var Actual = test.GetHealthMax();  //Check for correct Max Health

            //reset
            Crawl.Models.GameGlobals.ToggleRandomState(); //unfix random numbers

            //assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);

        }

        [Test]
        public void Character_ScaleLevel_Level_Neg1_Should_Fail()
        {
            // Arrange    
            var Hit = 10;  //set Hit so SetForcedRandomNumbers will work
            var Fixed = 1;  //Fixed die roll value
            var level = -1;  //level to scale to                             

            //force random number to = Fixed
            Crawl.Models.GameGlobals.SetForcedRandomNumbers(Fixed, Hit);

            //create a character
            var test = new Character();
            //Expected value is default test Level = 1
            var Expected = test.Level;
            
            // Act
            test.ScaleLevel(level);  //call ScaleLevel
            var Actual = test.GetHealthMax();  //Check for correct Max Health

            //reset 
            Crawl.Models.GameGlobals.ToggleRandomState(); //unfix random numbers

            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void Character_ScaleLevel_Same_Level_Should_Fail()
        {
            // Arrange    
            var Hit = 10;  //set Hit so SetForcedRandomNumbers will work
            var Fixed = 1;  //Fixed die roll value

            //force random number to = Fixed
            Crawl.Models.GameGlobals.SetForcedRandomNumbers(Fixed, Hit);
            
            //create a character
            var test = new Character();
            var level = test.Level;  //level to scale to
            //Expected value is default test Level = 1
            var Expected = test.Level;

            //act
            test.ScaleLevel(level);  //call ScaleLevel
            var Actual = test.GetHealthMax();  //Check for correct Max Health

            //reset 
            Crawl.Models.GameGlobals.ToggleRandomState(); //unfix random numbers

            // assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void Character_ScaleLevel_Lower_Level_Should_Fail()
        {
            //arrange    
            var Hit = 10;  //set Hit so SetForcedRandomNumbers will work
            var Fixed = 1;  //Fixed die roll value

            //force random number to = Fixed
            Crawl.Models.GameGlobals.SetForcedRandomNumbers(Fixed, Hit);

            //create a character
            var test = new Character(); 
            var level = test.Level - 1;  //level to scale to
            //Expected value is default test Level = 1
            var Expected = test.Level;

            //act
            test.ScaleLevel(level);  //call ScaleLevel
            var Actual = test.GetHealthMax();  //Check for correct Max Health

            //reset 
            Crawl.Models.GameGlobals.ToggleRandomState(); //unfix random numbers

            //assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }
 
        [Test]
        public void Character_ScaleLevel_Level_21_Should_Fail()
        {
            // Arrange   
            var Hit = 10;  //set Hit so SetForcedRandomNumbers will work  
            var Fixed = 1;  //Fixed die roll value
            var level = 21;  //level to scale to

            //force random number to = Fixed
            Crawl.Models.GameGlobals.SetForcedRandomNumbers(Fixed, Hit);

            //create a character
            var test = new Character();  
            //Expected value is default test Level = 1
            var Expected = test.Level;  

            // Act
            test.ScaleLevel(level);  //call ScaleLevel
            var Actual = test.GetHealthMax(); //Check for correct Max Health

            //reset 
            Crawl.Models.GameGlobals.ToggleRandomState(); //unfix random numbers

            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void Character_ScaleLevel_Level_2_Fixed_5_Max_Health_Should_Equal_10()
        {
            //Arrange
            var Hit = 10;  //set Hit so SetForcedRandomNumbers will work
            var Fixed = 5;  //Fixed die roll value
            var level = 2;  //level to scale to
            var Expected = 10; //Expected value

            //force random number to = Fixed
            Crawl.Models.GameGlobals.SetForcedRandomNumbers(Fixed, Hit);

            //create a character
            var test = new Character();

            //Act
            test.ScaleLevel(level);  //call ScaleLevel
            var Actual = test.GetHealthMax();  //Check for correct Max Health

            //Reset
            Crawl.Models.GameGlobals.ToggleRandomState(); //unfix random numbers

            // assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void Character_ScaleLevel_Level_5_Fixed_5_Max_Health_Should_Equal_25()
        {
            // arrange
            var Hit = 10;  //set Hit so SetForcedRandomNumbers will work
            var Fixed = 5;  //Fixed die roll value
            var level = 5;  //level to scale to
            var Expected = 25; //Expected value

            //force random number to = Fixed
            Crawl.Models.GameGlobals.SetForcedRandomNumbers(Fixed, Hit);

            //create a character
            var test = new Character();

            //Act
            test.ScaleLevel(level);  //call ScaleLevel
            var Actual = test.GetHealthMax();  //Check for correct Max Health

            //reset
            Crawl.Models.GameGlobals.ToggleRandomState(); //unfix random numbers

            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

    }
}
