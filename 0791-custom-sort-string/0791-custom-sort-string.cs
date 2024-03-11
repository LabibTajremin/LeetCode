public class Solution {
   public string CustomSortString(string order, string s) {
         // Dictionary to store character frequencies
        Dictionary<char, int> charFreq = new Dictionary<char, int>();

        // Count characters in s
        foreach (char c in s) {
            if (charFreq.ContainsKey(c))
                charFreq[c]++;
            else
                charFreq[c] = 1;
        }

        // Construct the sorted string
        string sortedS = "";
        foreach (char c in order) {
            if (charFreq.ContainsKey(c)) {
                sortedS += new String(c, charFreq[c]);
                charFreq.Remove(c); // Remove the processed character
            }
        }

        // Append remaining characters
        foreach (var kvp in charFreq) {
            sortedS += new String(kvp.Key, kvp.Value);
        }

        return sortedS;
    }
}