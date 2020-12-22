using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.prototypeRobots.ImplementWithoutPrototype
{
    public class ArtooDetooWP
    {
        public string Number { get; set; }

        public ArtooDetooWP(string number)
        {
            Number = number;
        }

        public override string ToString()
        {
            return Number;
        }
    }
}
