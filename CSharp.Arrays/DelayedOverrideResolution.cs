using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class DelayedOverrideResolution
    {
        public static List<int> ResolveCommits(int[] ops)
        {
            HashSet<int> active = new HashSet<int>();

            HashSet<int> disabled = new HashSet<int>();

            int currentMax = int.MinValue;

            List<int> finalized = new List<int>();

            foreach (int op in ops)
            {
                if (op > 0) 
                {
                    active.Add(op);
                    disabled.Remove(op);
                    currentMax = Math.Max(currentMax, op);
                }
                else if (op < 0) 
                {
                    int feature = -op;
                    if (active.Contains(feature))
                    {
                        disabled.Add(feature);
                    }
                }
                else 
                {
                    int best = int.MinValue;
                    foreach (int f in active)
                    {
                        if (!disabled.Contains(f) && f > best)
                        {
                            best = f;
                        }
                    }

                    if (best != int.MinValue)
                    {
                        finalized.Add(best);
                        active.Remove(best);
                        disabled.Remove(best);

                        if (best == currentMax)
                        {
                            currentMax = int.MinValue;
                            foreach (int f in active)
                            {
                                if (!disabled.Contains(f))
                                    currentMax = Math.Max(currentMax, f);
                            }
                        }
                    }
                }
            }

            return finalized;
        }
    }
}
