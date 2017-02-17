using Xunit;
using RepeatCounterApp.Objects;
using System;
using System.Collections.Generic;

namespace RepeatCounterApp
{
    public class RepeatCounterTest
    {
        [Fact]
        public void CountRepeats_lettersDontMatch_True()
        {
            //arrange
            RepeatCounter testObject = new RepeatCounter();
            //act
            int answer =  testObject.CountRepeats("z","y");
            //assert
            Assert.Equal(answer, 0);
        }

        [Fact]
        public void CountRepeats_LettersMatch_True()
        {
            //arrange
            RepeatCounter testObject = new RepeatCounter();
            //act
            int answer =  testObject.CountRepeats("z","z");
            //assert
            Assert.Equal(answer, 1);
        }

        [Fact]
        public void CountRepeats_wordMatch_True()
        {
            //arrange
            RepeatCounter testObject = new RepeatCounter();
            //act
            int answer =  testObject.CountRepeats("zoo","zoo");
            //assert
            Assert.Equal(answer, 1);
        }



    }
}
