using data_structures_and_algorithms;
using System.Collections;
using System.Collections.Generic;
using static data_structures_and_algorithms.Program;

namespace TestReserve
{

    public class UnitTest1
    {
        [Theory]
        [InlineData( "(dfdfdfdf)", true)]
        [InlineData("(dfdfdfdf)}", false)]
        [InlineData("{(dfdfdfdf)", false)]
        [InlineData("(dfdfdfdf}", false)]
        [InlineData("{dfdfdfdf)", false)]
        [InlineData("dfdfdfdf)(", false)]
        [InlineData("{dfdfdfdf}", true)]
        [InlineData("[dfdfdfdf]", true)]
        public void brackets(string teststring,bool expected)
        {
            

            // Act
            bool result = BracketsBalanced(teststring);

            // Assert
            Assert.Equal(expected, result);
        }
   
      
    }
}










