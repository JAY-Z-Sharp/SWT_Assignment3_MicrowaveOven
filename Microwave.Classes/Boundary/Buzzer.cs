using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microwave.Classes.Interfaces;

namespace Microwave.Classes.Boundary
{
    public class Buzzer : IBuzzer
    {
        private IOutput myOutput;
        public Buzzer(IOutput output)
        {
            myOutput = output;
        }
        public void BuzzerSoundTimeElapsed()
        {
            myOutput.OutputLine("Beep -- Beep -- Beep");
        }
    }
}
