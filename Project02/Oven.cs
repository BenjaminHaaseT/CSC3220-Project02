using System;
namespace Project02
{
    public class Oven : Appliance
    {
        public Oven(string make) : base(make)
        {
        }

        public override void TurnOn()
        {
            this.state = ApplianceState.on;
            Console.WriteLine(this.make + " is now " + this.state + ".");
            Console.WriteLine("ZiiiiingDiiiing!");
        }

        public override void TurnOff()
        {
            this.state = ApplianceState.off;
            Console.WriteLine(this.make + " is now " + this.state + ".");
            Console.WriteLine("Verrrrrmding");
        }
    }
}
