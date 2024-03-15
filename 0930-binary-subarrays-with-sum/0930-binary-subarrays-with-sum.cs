public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {
         
        Dictionary<int, int> prefixSumCount = new Dictionary<int, int>();
        int currentSum = 0;
        int count = 0;

        // Initialize with 0 to handle subarrays starting from index 0
        prefixSumCount[0] = 1;

        foreach (int num in nums)
        {
            currentSum += num;

            // Check if there exists a previous prefix sum such that currentSum - prevSum == goal
            if (prefixSumCount.ContainsKey(currentSum - goal))
                count += prefixSumCount[currentSum - goal];

            // Update the prefix sum count
            if (prefixSumCount.ContainsKey(currentSum))
                prefixSumCount[currentSum]++;
            else
                prefixSumCount[currentSum] = 1;
        }

        return count;
    }
}