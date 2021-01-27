using System;
namespace Project02
{
    public class DishWasher : Appliance
    {
        public DishWasher(string make) : base(make)
        {     
        
        }

        public override void TurnOn()
        {
            this.state = ApplianceState.on;
            Console.WriteLine(this.make + " is now " + this.state + ".");
            Console.WriteLine("Scrub, Scrub");
        }

        public override void TurnOff()
        {
            this.state = ApplianceState.off;
            Console.WriteLine(this.make + " is now " + this.state + ".");
         
        }
    }
}
