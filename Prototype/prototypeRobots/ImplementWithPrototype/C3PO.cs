using Prototype.prototypeRobots.ImplementWithPrototype.Abstract;

namespace Prototype.prototypeRobots.ImplementWithPrototype
{
    public class C3PO : IRobot
    {
        public string Number { get; set; }
        public bool GoldPlating { get; set; }

        public C3PO(string number, bool goldPlating)
        {
            Number = number;
            GoldPlating = goldPlating;
        }

        public IRobot Clone()
        {
            return new C3PO(Number, GoldPlating);
        }
    }
}
