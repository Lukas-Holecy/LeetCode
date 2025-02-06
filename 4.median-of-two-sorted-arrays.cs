/*
 * @lc app=leetcode id=4 lang=csharp
 *
 * [4] Median of Two Sorted Arrays
 */

// @lc code=start
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var i = 0;
        var j = 0;

        var merged = new int[nums1.Length + nums2.Length];
        while(i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] < nums2[j])
            {
                merged[i + j] = nums1[i];
                i++;
            }
            else
            {
                merged[i + j] = nums2[j];
                j++;
            }
        }

        for (var k = i; k < nums1.Length; k++)
        {
            merged[j + k] = nums1[k];
        }

        for (var k = j; k < nums2.Length; k++)
        {
            merged[i + k] = nums2[k];
        }

        var length = merged.Length;
        if (length % 2 == 0)
        {
            return (merged[length / 2] + merged[length / 2 - 1]) / 2.0;
        }
        else
        {
            return merged[length / 2];
        }
    }
}
// @lc code=end

