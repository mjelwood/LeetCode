public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        List<int> sortedArray = new List<int>();

        int yArea = n;
        for (int x = 0; x < n; x++)
        {
            sortedArray.Add(nums[x]);
            sortedArray.Add(nums[yArea]);
            yArea++;
        }

        return sortedArray.ToArray();
    }
}