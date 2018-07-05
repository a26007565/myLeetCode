/*
 * [7] Reverse Integer
 *
 * https://leetcode.com/problems/reverse-integer/description/
 *
 * algorithms
 * Easy (24.38%)
 * Total Accepted:    434.6K
 * Total Submissions: 1.8M
 * Testcase Example:  '123'
 *
 * Given a 32-bit signed integer, reverse digits of an integer.
 * 
 * Example 1:
 * 
 * 
 * Input: 123
 * Output: 321
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: -123
 * Output: -321
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: 120
 * Output: 21
 * 
 * 
 * Note:
 * Assume we are dealing with an environment which could only store integers
 * within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of
 * this problem, assume that your function returns 0 when the reversed integer
 * overflows.
 * 
 */

//  ✔ Accepted
//  ✔ 1032/1032 cases passed (48 ms)
//  ✔ Your runtime beats 78.64 % of csharp submissions
public class Solution {
    public int Reverse (int x) {
        try {
            var chars = Math.Abs (x).ToString ().ToCharArray ();
            Array.Reverse (chars);
            var result = Convert.ToInt32 (new string (chars));
            return x < 0 ? result * -1 : result;
        } catch {
            return 0;
        }
    }
}