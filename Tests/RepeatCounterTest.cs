using Xunit;
using RepeatCounterApp.Objects;
using System;
using System.Collections.Generic;

namespace RepeatCounterApp
{
    public class RepeatCounterTest
    {
        [Fact]
        public void InsideWord_WordContainsLetter_True()
        {
            //arrange
            RepeatCounter testObject = new RepeatCounter();
            //act
            int answer =  testObject.CountRepeats("z","y");
            //assert
            Assert.Equal(answer, 0);
        }


    }
}
