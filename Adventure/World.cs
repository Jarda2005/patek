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

        public string Intro { get; } = @"You are contained in the depths of the Undead Asylum in the eternal darkness.
There's no hope of returning from this damned hell. Until now. A corpse of a dead Hollow dropped from above,
carrying a key from your cell. Lucky coincidence? Who knows. Now it's time to leave this place.";
    }
}
