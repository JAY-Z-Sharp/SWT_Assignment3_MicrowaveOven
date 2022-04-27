using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Microwave.Classes.Interfaces
{

    

    public interface IPowerTube
    {
        public enum PowerSupplyEnum
        {
            watt1000 = 1000,
            watt800 = 800,
            watt700 = 700,
            watt500 = 500

        }

        void TurnOn(int power);

        void TurnOff();

        int GetMaxPower();

    }
}
