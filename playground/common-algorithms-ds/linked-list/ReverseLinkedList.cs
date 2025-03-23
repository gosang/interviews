// Problem: Reverse a singly linked list.

// Brute Force Solution
// The brute force approach collects all nodes into a list, then rebuilds the linked list in reverse order by updating the next pointers. We first traverse the list to store nodes, then iterate through the list backwards to set each node’s next pointer to the previous node. This is inefficient because it requires extra space and two passes over the list, though it’s conceptually simple.
// Time Complexity: O(n) - Two passes: one to collect nodes, one to rebuild.
// Space Complexity: O(n) - List stores all n nodes.

public class BruteForceReverseLinkedList{
    public ListNode ReverseListBruteForce(ListNode head) {
        if (head == null) return null;
        List<ListNode> nodes = new List<ListNode>();
        ListNode current = head;
        while (current != null) {
            nodes.Add(current);
            current = current.next;
        }
        
        for (int i = nodes.Count - 1; i > 0; i--) {
            nodes[i].next = nodes[i - 1];
        }
        nodes[0].next = null;
        return nodes[nodes.Count - 1];
    }
}


// Divide-and-Conquer Solution
// Split the list, reverse each half, and connect them. Less efficient due to list traversal.
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

// Optimal Solution (Iterative reversal with three pointers)

// The optimal solution reverses the list in-place using three pointers: prev, current, and next. We iterate through the list once, reversing each node’s next pointer to point to the previous node. prev becomes the new head at the end. This is efficient because it uses constant space and only one pass, directly manipulating the links without storing nodes separately.
// Time Complexity: O(n) - Single pass through the list.
// Space Complexity: O(1) - Only three pointers, regardless of list size.

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

// Example usage
// ListNode head = new ListNode(1, new ListNode(2, new ListNode(3)));
// ListNode reversed = new OptimalReverseLinkedList().ReverseList(head); // Output: 3->2->1