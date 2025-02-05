/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        var value = (l1?.val ?? 0) + (l2?.val ?? 0);  
        var carry = value / 10;
        var result = new ListNode()
        {
            val = value % 10,
            next = null
        };

        var first = result;

        while (l1?.next != null || l2?.next != null || carry > 0)
        {
            l1 = l1?.next;
            l2 = l2?.next;
            var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            var next = new ListNode()
            {
                val = sum % 10,
                next = null
            };

            carry = sum / 10;
            result.next = next;
            result = next;
        }
        
        return  first;
    }
}
// @lc code=end

