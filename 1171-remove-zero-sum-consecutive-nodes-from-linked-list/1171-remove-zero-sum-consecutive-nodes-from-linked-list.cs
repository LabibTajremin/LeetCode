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
    public ListNode RemoveZeroSumSublists(ListNode head) {
        
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        Dictionary<int, ListNode> map = new Dictionary<int, ListNode>();
        int prefixSum = 0;
        ListNode current = dummy;

        while (current != null) {
            prefixSum += current.val;
            if (map.ContainsKey(prefixSum)) {
                current = map[prefixSum].next;
                int sum = prefixSum + current.val;
                while (sum != prefixSum) {
                    map.Remove(sum);
                    current = current.next;
                    sum += current.val;
                }
                map[prefixSum].next = current.next;
            } else {
                map[prefixSum] = current;
            }
            current = current.next;
        }

        return dummy.next;
    }
}