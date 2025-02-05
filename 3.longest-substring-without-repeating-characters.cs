/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start

using System.Collections.Generic;
public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        var length = 0;
        while (s.Length > length)
        {
            var (newLength, offset) = LengthOfLongestSubstringFromStart(s);
            length = Math.Max(length, newLength);
            s = s.Substring(offset);
        }

        return length;
    }

    public (int, int) LengthOfLongestSubstringFromStart(string s) 
    {
        var previousIndices = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (previousIndices.ContainsKey(c))
            {
                return (previousIndices.Count, previousIndices[c] + 1);
            }
            
            previousIndices.Add(c, i);
        }

        return (previousIndices.Count, s.Length);
    }
}
// @lc code=end

