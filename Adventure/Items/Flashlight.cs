using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items
{
    public class Flashlight : BaseItem
    {
        public override string Name => "Flashlight";

        public override string Description => "a Flashlight. Helps with the dark, at least you can see something now." +
            " Gives a false feeling of safety.";
    }
}
