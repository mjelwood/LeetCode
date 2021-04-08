public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int countFound = 0;
        
        for(int j = 0; jewels.Length > j; j++)
        {
            for(int s = 0; stones.Length > s; s++)
            {
                if(jewels[j] == stones[s])
                    countFound++;
            }
        }
        
        return countFound;
    }
}