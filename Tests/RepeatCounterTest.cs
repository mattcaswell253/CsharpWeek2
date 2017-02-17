using Xunit;
using RepeatCounterApp.Objects;
using System;
using System.Collections.Generic;

namespace RepeatCounterApp
{
    public class RepeatCounterTest
    {
        [Fact]
        public void CountRepeats_WordContainsLetter_True()
        {
            //arrange
            RepeatCounter testObject = new RepeatCounter("smooth", "s");
            //act
            bool count =  testObject.InsideWord();
            //assert
            Assert.Equal(count, true );
        }
    }
}
