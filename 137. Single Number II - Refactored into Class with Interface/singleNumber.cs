public interface ISingleNumberHelper
{
    int SingleNumber(int[]nums );
}

public class SingleNumberHelper: ISingleNumberHelper
{
    public int SingleNumber(int[] nums) {
     
        Dictionary<int, int> currentCountOfKeys = new Dictionary<int, int>();
        currentCountOfKeys = GetCountOfKeyValuesFromNumberArray(nums, currentCountOfKeys);
        return returnSingleValue(currentCountOfKeys);
    }

    internal Dictionary<int, int> GetCountOfKeyValuesFromNumberArray(int[] nums, Dictionary<int,int> currentCountOfKeys)
    {
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
        
        return currentCountOfKeys;
    }
    
    internal int returnSingleValue(Dictionary<int,int> currentCountOfKeys)
    {
        int onlyAppearsOnce = 0;
        foreach(KeyValuePair<int,int> item in currentCountOfKeys)
        {
            if(item.Value == 1)
            {
                onlyAppearsOnce = item.Key;
                break;
            }
        }
        return onlyAppearsOnce;
    }
}

public class Solution {
    public int SingleNumber(int[] nums) {
        SingleNumberHelper testHelper = new SingleNumberHelper();
        
        return testHelper.SingleNumber(nums);
    }   
}