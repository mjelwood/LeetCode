public class Solution {
    public int SumOfUnique(int[] nums) {
        int sum = 0;
        Dictionary<int,int> countOfElements = new Dictionary<int,int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            int curKey = nums[i];
            
            if(countOfElements.ContainsKey(curKey))
            {
                countOfElements[curKey]++;
            }
            else
            {
                countOfElements.Add(curKey, 1);    
            }
            
        }
        
        foreach(KeyValuePair<int,int> item in countOfElements)
        {
            if(item.Value == 1)
                sum += item.Key;
        }
            
        return sum;
    }
}