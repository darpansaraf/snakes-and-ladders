using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders.Tests
{
    public class TestsBase : IDisposable
    {
        
        protected SnakesAndLaddersBoard snakesAndLaddersBoard;
        public TestsBase()
        {
            snakesAndLaddersBoard = new SnakesAndLaddersBoard();
        }

        public void Dispose()
        {
        }
    }
}
