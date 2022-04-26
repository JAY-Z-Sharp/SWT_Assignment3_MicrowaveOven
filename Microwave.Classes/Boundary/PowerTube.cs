using System;
using Microwave.Classes.Interfaces;

namespace Microwave.Classes.Boundary
{
    public class PowerTube : IPowerTube
    {
        private IOutput myOutput;

        private bool IsOn = false;

        public enum PowerSupplyEnum {
            watt1000 = 1000,
            watt800 = 800,
            watt700 = 700,
            watt500 = 500
        }

        public PowerSupplyEnum PowerSupply { get;}

        public PowerTube(IOutput output, PowerSupplyEnum powerSupply)
        {
            myOutput = output;
            PowerSupply = powerSupply;
            
        }

        public int GetMaxPower()
        {
            return (int)PowerSupply;
        }

        public void TurnOn(int power)
        {
            if (power < 1 || ((int)PowerSupply) < power)
            {
                throw new ArgumentOutOfRangeException("power", power, "Must be between 1 and" + PowerSupply.ToString() + "(incl.)");
            }

            if (IsOn)
            {
                throw new ApplicationException("PowerTube.TurnOn: is already on");
            }

            myOutput.OutputLine($"PowerTube works with {power}");
            IsOn = true;
        }

        public void TurnOff()
        {
            if (IsOn)
            {
                myOutput.OutputLine($"PowerTube turned off");
            }

            IsOn = false;
        }
    }
}