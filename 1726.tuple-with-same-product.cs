/*
 * @lc app=leetcode id=1726 lang=csharp
 *
 * [1726] Tuple with Same Product
 */

// @lc code=start
public class Solution {    
    public int TupleSameProduct(int[] nums) {
        var pockets = new Dictionary<int, List<(int, int)>>();

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                var product = nums[i] * nums[j];
                if (!pockets.ContainsKey(product))
                {
                    pockets[product] = new List<(int, int)>();
                }
                pockets[product].Add((nums[i], nums[j]));
            }
        }

        int result = 0;
        foreach (var key in pockets.Keys)
        {
            var count = pockets[key].Count;
            if (count > 1)
            {
                result += (count * (count - 1)) * 4;
            }
        }

        return result;
    }

    static int Factorial(int num)
    {
        if (num == 0 || num == 1) return 1;
        int result = 1;
        for (int i = 2; i <= num; i++)
            result *= i;
        return result;
    }
}
// @lc code=end

