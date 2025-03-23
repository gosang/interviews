// Problem: Reverse a singly linked list.
// Divide-and-Conquer Solution
// Explanation: Split the list, reverse each half, and connect them. Less efficient due to list traversal.
// Time Complexity: O(n log n), Space Complexity: O(log n)


public class DivideConquerReverseLinkedList {
    public ListNode ReverseListDivideConquer(ListNode head) {
        if (head == null || head.next == null) return head;
        return ReverseHelper(head).Item1;
    }
    
    private (ListNode, ListNode) ReverseHelper(ListNode head) {
        if (head.next == null) return (head, head);
        
        ListNode slow = head, fast = head, prev = null;
        while (fast != null && fast.next != null) {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        prev.next = null;
        
        var (leftHead, leftTail) = ReverseHelper(head);
        var (rightHead, rightTail) = ReverseHelper(slow);
        rightTail.next = leftHead;
        return (rightHead, leftTail);
    }
}

// Optimal Solution
// Explanation: Iterative reversal with three pointers.
// Time Complexity: O(n), Space Complexity: O(1)

public class OptimalReverseLinkedList {
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null, current = head;
        while (current != null) {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        return prev;
    }
}