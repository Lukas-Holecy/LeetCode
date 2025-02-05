/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var existingValues = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            var diff = target - num;
            if (existingValues.ContainsKey(diff))
            {
                return new int[] { existingValues[diff], i };
            }
            if (!existingValues.ContainsKey(num))
            {
                existingValues.Add(num, i);
            }
        }

        return new int[] { };
    }
}
// @lc code=end

