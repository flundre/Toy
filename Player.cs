using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy
{
    class Player
    {
        string Name { get; set; }
        int Score { get; set; }
        public Player(string n, int s)
        {
            Name = n;
            Score = s;
        }
    }
}
