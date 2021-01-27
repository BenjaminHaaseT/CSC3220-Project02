using System;
namespace Project02
{
    public abstract class Appliance
    {
        protected string make;
        protected ApplianceState state;

        public Appliance(string make)
        {
            this.make = make;
        }

        public virtual string Description()
        {
            string description = string.Empty;
            description += "I'm a " + make + " appliance";
            description += Environment.NewLine;
            description += "My state is " + state;
            description += Environment.NewLine;
            return description;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
    }
}
