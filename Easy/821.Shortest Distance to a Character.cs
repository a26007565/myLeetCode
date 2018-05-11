public class Solution {
    public int[] ShortestToChar (string S, char C) {
        var stringLength = S.Length;
        IList<int> result = new List<int> ();
        for (int i = 0; i < stringLength; i++) {
            // reverse
            var charArray = S.ToCharArray (0, i > 0 ? i + 1 : i);
            Array.Reverse (charArray);
            var leftFinded = new string (charArray).IndexOf (C);
            var shortest = leftFinded;

            var RightString = S.Substring (i, stringLength - i);
            var RightFinded = RightString.IndexOf (C);
            shortest = shortest > 0 ? RightFinded > 0 ? Math.Min (shortest, RightFinded) : leftFinded : RightFinded;
            result.Add (shortest);
        }
        return result.ToArray ();
    }
}