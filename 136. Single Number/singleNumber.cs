public class Solution {
    public int SingleNumber(int[] nums) {
     
        Dictionary<int, int> currentCountOfKeys = new Dictionary<int, int>();
        int onlyAppearsOnce = 0;
        
        for(int i = 0; i < nums.Length; i++)
        {
            int curKey = nums[i];
            if(currentCountOfKeys.ContainsKey(curKey))
            {
                currentCountOfKeys[curKey]++;
            }
            else
            {
                currentCountOfKeys.Add(curKey, 1);    
            }
        }
        
        foreach(KeyValuePair<int,int> item in currentCountOfKeys)
        {
            if(item.Value == 1)
            {
                onlyAppearsOnce = item.Key;
            }
        }
        
        return onlyAppearsOnce;
    }
}