using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.prototypeRobots.ImplementWithPrototype.Abstract
{
    public interface IRobot
    {
        public string Number { get; set; }
        IRobot Clone();
    }
}
