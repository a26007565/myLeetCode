/*
 * [58] Length of Last Word
 *
 * https://leetcode.com/problems/length-of-last-word/description/
 *
 * algorithms
 * Easy (32.09%)
 * Total Accepted:    199.9K
 * Total Submissions: 623K
 * Testcase Example:  '"Hello World"'
 *
 * Given a string s consists of upper/lower-case alphabets and empty space
 * characters ' ', return the length of last word in the string.
 * 
 * If the last word does not exist, return 0.
 * 
 * Note: A word is defined as a character sequence consists of non-space
 * characters only.
 * 
 * Example:
 * 
 * Input: "Hello World"
 * Output: 5
 * 
 * 
 */
//   √ Accepted
//   √ 59/59 cases passed (756 ms)
//   √ Your runtime beats 0 % of csharp submissions
public class Solution {
    private static string pattern = @"(?<word>\S+)$";

    public int LengthOfLastWord(string s) {
        var result = System.Text.RegularExpressions.Regex.Match(s.TrimEnd(), pattern).Groups["word"].Value;
        return result.Length;
    }
}