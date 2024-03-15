public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int length = nums.Length;
    int[] answer = new int[length];

    // answer[i] contains the product of all the numbers to the left of i
    answer[0] = 1;
    for (int i = 1; i < length; i++) {
        answer[i] = nums[i - 1] * answer[i - 1];
    }

    // R contains the product of all the numbers to the right of i
    int R = 1;
    for (int i = length - 1; i >= 0; i--) {
        // For the index 'i', answer[i] contains the product of all the numbers to the left and R contains the product of all the numbers to the right. The product of answer[i] and R gives the product of all numbers except the number at the index 'i'
        answer[i] = answer[i] * R;
        R *= nums[i];
    }

    return answer;
    }
}