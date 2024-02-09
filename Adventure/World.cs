using Adventure.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class World
    {
        public List<BaseRoom> rooms = new();
        public BaseRoom CurrentRoom { get; private set; }

        public World() 
        {
            var lobby = new Lobby();
            var corridor = new Corridor();

            lobby.RegisterNeighbour(corridor);


            rooms.AddRange(new BaseRoom[] { lobby, corridor });

            CurrentRoom = rooms[0];
        }

        public string Intro { get; } = @"While collecting scrap for The Company, one of your crewmates went missing inside the facility.
It's your best friend, so you went there without second thought. But time is ticking and you should be back until 
midnight, or you will be left behind and die from lack of oxygen! As you approach the facility,
it sends shivers down your spine. There are a lot of monsters beyond human comprehension 
and they are eager to kill on you sight. You hope that your colleague is alright as you open the door to the facility.";
    }
}
