using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сards
{
    class Player
    {
        public string Name { get; set; }
        public CardSet Cards { get; set; }
        public Player(string name)
        {
            Name = name;

        }
    }
}
