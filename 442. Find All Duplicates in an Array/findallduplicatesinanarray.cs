public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        HashSet<int> dupList = new HashSet<int>();
        HashSet<int> actualDups = new HashSet<int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            var exists = dupList.Add(nums[i]);   
            
            if(!exists)
            {
                actualDups.Add(nums[i]);
            }
        }
        return actualDups.ToList();
    }
}