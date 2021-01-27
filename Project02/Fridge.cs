using System;
namespace Project02
{
    public class Fridge : Appliance
    {
        public Fridge(string make) : base(make)
        {
        }

        public override void TurnOn()
        {
            this.state = ApplianceState.on;
            Console.WriteLine(this.make + " is now " + this.state + ".");
            Console.WriteLine("Rumble Rumble, vrooooooom.");
        }

        public override void TurnOff()
        {
            this.state = ApplianceState.off;
            Console.WriteLine(this.make + " is now " + this.state + ".");
            Console.WriteLine("Rumble Rumble, oomhf");
        }

    }
}
