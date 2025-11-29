public class IncreasingSubsequencePartition
{
    public static int MinIncreasingSubsequences(int[] arr)
    {
        List<int> piles = new List<int>();

        foreach (int x in arr)
        {
            int left = 0, right = piles.Count - 1;
            int pos = piles.Count;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (piles[mid] < x)
                {
                    pos = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            if (pos == piles.Count)
                piles.Add(x);
            else
                piles[pos] = x;
        }

        return piles.Count;
    }
}
