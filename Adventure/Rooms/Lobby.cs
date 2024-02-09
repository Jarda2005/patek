using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public class Lobby : BaseRoom
    {
        public override string Description => "a lobby inside the facility, the room is almost dark, because the lights on the ceiling are barely functioning";

        public override string Name => "Lobby";
    }
}
