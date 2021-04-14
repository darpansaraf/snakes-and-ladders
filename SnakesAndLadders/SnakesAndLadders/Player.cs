using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    public class Player
    {
        public Player(string name, int position)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Position = position;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public int Position { get; set; }
    }
}
