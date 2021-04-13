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
        private static List<Snake> _snakes = new List<Snake>() { new Snake(14, 7) };

        public TestsBase()
        {
            board = new Board(_snakes);
        }

        public void Dispose()
        {
        }
    }
}
