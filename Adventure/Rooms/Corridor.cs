using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public class Corridor : BaseRoom
    {
        public override string Name => "Corridor";

        public override string Description => "a dark and empty corridor. You hear something in distance, " +
            "maybe just an unlucky soul devoured by some beast.";
    }
}
