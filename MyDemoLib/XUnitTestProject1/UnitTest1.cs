using MyDemoLib;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class DeepThoughtTest
    {
        [Fact]
        public void TestTheAnswerOfTheUniverse()
        {
            int expected = 42;
            DeepThought dt = new DeepThought();
            int actual = dt.TheAnswerOfTheUniverse();
            Assert.Equal(expected, actual);
        }
    }
}
