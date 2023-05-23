using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy
{
    class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public string Difficulty { get; set; }
        public DateTime time { get; set; }
        public Player(string n)
        {
            Name = n;
        }
    }
}
