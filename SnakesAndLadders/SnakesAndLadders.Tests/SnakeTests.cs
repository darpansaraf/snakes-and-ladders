using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace SnakesAndLadders.Tests
{
    [ExcludeFromCodeCoverage]
    public class SnakeTests
    {
        [Fact]
        public void Test_InvalidSnakePositionsShouldThrowExceptionWhileCreatingSnake()
        {
            int start = 36, end = 45;

            Assert.Throws<ArgumentException>(() => new Snake(start, end));
        }

        [Fact]
        public void Test_InvalidSnakeStartPositionsShouldThrowExceptionWhileCreatingSnake()
        {
            int start = 45, end = -1;

            Assert.Throws<ArgumentException>(() => new Snake(start, end));
        }

        [Fact]
        public void Test_InvalidSnakeEndPositionsShouldThrowExceptionWhileCreatingSnake()
        {
            int start = 100, end = 34;

            Assert.Throws<ArgumentException>(() => new Snake(start, end));
        }
    }
}
