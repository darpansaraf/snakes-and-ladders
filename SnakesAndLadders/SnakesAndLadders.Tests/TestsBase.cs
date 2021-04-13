using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SnakesAndLadders.Tests
{
    [ExcludeFromCodeCoverage]
    public class TestsBase : IDisposable
    {
        protected Board board;

        public TestsBase()
        {
            board = new Board();
        }

        public void Dispose()
        {
        }
    }
}
