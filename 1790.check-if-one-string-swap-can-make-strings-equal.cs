/*
 * @lc app=leetcode id=1790 lang=csharp
 *
 * [1790] Check if One String Swap Can Make Strings Equal
 */

// @lc code=start
public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        if (s1 == s2)
        {
            return true;
        }

        var diffs = GetDiffs(s1, s2);
        if (diffs.Count == 2 && diffs[0] == new string(diffs[1].Reverse().ToArray()))
        {
            return true;
        }

        return false;
    }

    private List<string> GetDiffs(string s1, string s2)
    {
        var result = new List<string>();

        for (var i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                result.Add($"{s1[i]}{s2[i]}");
            }
        }

        return result;
    }
}
// @lc code=end

