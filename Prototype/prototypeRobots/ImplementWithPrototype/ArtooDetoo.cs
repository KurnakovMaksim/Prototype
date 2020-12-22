using Prototype.prototypeRobots.ImplementWithPrototype.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.prototypeRobots.ImplementWithPrototype
{
    public class ArtooDetoo : IRobot
    {
        public string Number { get; set; }

        public ArtooDetoo(string number)
        {
            Number = number;
        }

        public IRobot Clone()
        {
            return new ArtooDetoo(Number);
        }
    }
}
