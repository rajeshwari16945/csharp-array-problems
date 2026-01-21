using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class EnergyResetSegment
    {
        public static long MaxEnergySegment(int[] energy)
        {
            long currentEnergy = 0;
            long maxEnergy = 0;

            foreach (int e in energy)
            {
                currentEnergy += e;

                if (currentEnergy < 0)
                {
                    currentEnergy = 0; // reset segment
                }

                if (currentEnergy > maxEnergy)
                {
                    maxEnergy = currentEnergy;
                }
            }

            return maxEnergy;
        }
    }
}
