namespace Workout;


//Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val; this.next = next;
    }
}
public class Solution {
    public ListNode ReverseEvenLengthGroups(ListNode head) {
        // Prev -> (head -> ... -> tail) -> next -> ...
        ListNode dummy = new ListNode(0, head);
        ListNode prev = dummy;
        ListNode tail = head;
        ListNode next = head.next;
        int groupLength = 1;

        while (next != null) {
            if ((groupLength & 1) == 1) {
                prev.next = head;
                prev = tail;
            } else {
                tail.next = null;
                prev.next = reverse(head);
                // Prev -> (tail -> ... -> head) -> next -> ...
                head.next = next;
                prev = head;
            }
            
            head = next;
            (ListNode, int) res = getTailAndLength(head, groupLength + 1);
            tail = res.Item1;
            next = tail.next;
            groupLength = res.Item2;
        }

        return dummy.next;
    }

    private (ListNode, int) getTailAndLength(ListNode head, int groupLength) {
        int length = 1;
        ListNode tail = head;
        while (length < groupLength && tail.next != null) {
            tail = tail.next;
            ++length;
        }
        return (tail, length);
    }

    ListNode reverse(ListNode head) {
        ListNode prev = null;
        while (head != null) {
            ListNode next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }
        return prev;
    }
}