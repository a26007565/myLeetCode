/*
 * [136] Single Number
 *
 * https://leetcode.com/problems/single-number/description/
 *
 * algorithms
 * Easy (55.72%)
 * Total Accepted:    307.1K
 * Total Submissions: 549.8K
 * Testcase Example:  '[2,2,1]'
 *
 * Given a non-empty array of integers, every element appears twice except for
 * one. Find that single one.
 * 
 * Note:
 * 
 * Your algorithm should have a linear runtime complexity. Could you implement
 * it without using extra memory?
 * 
 * Example 1:
 * 
 * 
 * Input: [2,2,1]
 * Output: 1
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: [4,1,2,1,2]
 * Output: 4
 * 
 * 
 */
//   ✔ Accepted
//   ✔ 16/16 cases passed (112 ms)
//   ✔ Your runtime beats 96.12 % of csharp submissions

public class Solution {
    public int SingleNumber(int[] nums) {
        // return nums.AsEnumerable()
        //     .GroupBy(i => i)
        //     .Where(g => g.Count() == 1)
        //     .Select(g => g.Key).First();
        var count = nums.Length;
        var result = nums[0];
        if (count == 1) {
            return result;
        }
        for (int i = count - 1; i > 0; i --) {
            result ^= nums[i];
        }
        return result;
    }
}
