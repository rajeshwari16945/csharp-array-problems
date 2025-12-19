using System;

class MemoryLeakSimulation
{
    public static int CountLeakIncidents(int[] memory)
    {
        if (memory == null || memory.Length == 0)
            return 0;

        int leak = memory[0];
        int maxLeakSoFar = leak;
        int incidents = 1; 

        for (int i = 1; i < memory.Length; i++)
        {
            if (memory[i] > leak)
                leak = memory[i];
            else
                leak = memory[i];

            if (leak > maxLeakSoFar)
            {
                incidents++;
                maxLeakSoFar = leak;
            }
        }

        return incidents;
    }

}
