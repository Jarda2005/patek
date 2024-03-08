using Adventure.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public class Lobby : BaseRoom
    {
        public override string Name => "Lobby";

        public override string Description => "a lobby outside the cell, the room is almost dark, because the lights from the torches are" +
            " giving a little light.";
        public Lobby()
        {
            Items.Add(new BrokenSwordHilt());
        }
    }
}
