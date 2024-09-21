# Data Structures

## Linked List

A Linked List is a linear data structure consisting of a sequence of elements, called nodes. Each node contains data and a reference (or pointer) to the next node in the sequence. This structure allows for efficient insertion and removal of elements.

### Types of Linked Lists

- Singly Linked List:
  - Each node points to the next node in the sequence.
  - The last node points to null, indicating the end of the list.
- Doubly Linked List:
  - Each node contains two pointers: one pointing to the previous node and one to the next node.
  - The first node’s previous pointer and the last node’s next pointer both point to null.
- Circular Linked List:
  - Each node points to the next node in the sequence.
  - The last node points back to the first node, forming a circular structure.

### Time Complexity

- Access: (O(n))
- Search: (O(n))
- Insert: (O(1))
- Remove: (O(1))

## Stack

- A Stack is a collection of elements, with two principle operations: push, which adds to the collection, and pop, which removes the most recently added element
- Last in, first out data structure (LIFO): the most recently added object is the first to be removed

### Time Complexity:

- Access: O(n)
- Search: O(n)
- Insert: O(1)
- Remove: O(1)
