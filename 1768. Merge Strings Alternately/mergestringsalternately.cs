public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int minLength = Math.Min(word1.Length, word2.Length);
        int extraLetters = 0;
        string remainingData = "";
        StringBuilder sb = new StringBuilder();
        
        if(word1.Length > word2.Length)
        {
            extraLetters = word1.Length - word2.Length;
            remainingData = word1.Substring(minLength, extraLetters);
        }
        else if(word2.Length > word1.Length)
        {
            extraLetters = word2.Length - word1.Length;
            remainingData = word2.Substring(minLength, extraLetters);
        }
        
        for(int i = 0; i < minLength; i++)
        {
           sb.Append(word1.Substring(i,1));
           sb.Append(word2.Substring(i,1));
        }
        
        sb.Append(remainingData);
        
        return sb.ToString();
    }
}