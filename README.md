# Interviews

## Data Structures

### Linked List

A Linked List is a linear data structure consisting of a sequence of elements, called nodes. Each node contains data and a reference (or pointer) to the next node in the sequence. This structure allows for efficient insertion and removal of elements.

#### Types of Linked Lists

- Singly Linked List:
  - Each node points to the next node in the sequence.
  - The last node points to null, indicating the end of the list.
- Doubly Linked List:
  - Each node contains two pointers: one pointing to the previous node and one to the next node.
  - The first node’s previous pointer and the last node’s next pointer both point to null.
- Circular Linked List:
  - Each node points to the next node in the sequence.
  - The last node points back to the first node, forming a circular structure.

#### Time Complexity

- Access: (O(n))
- Search: (O(n))
- Insert: (O(1))
- Remove: (O(1))

### Stack

- A Stack is a collection of elements, with two principle operations: push, which adds to the collection, and pop, which removes the most recently added element
- Last in, first out data structure (LIFO): the most recently added object is the first to be removed

#### Time Complexity:

- Access: O(n)
- Search: O(n)
- Insert: O(1)
- Remove: O(1)

### Queue

- A Queue is a collection of elements, supporting two principle operations: enqueue, which inserts an element into the queue, and dequeue, which removes an element from the queue
- First in, first out data structure (FIFO): the oldest added object is the first to be removed

#### Time Complexity:

- Access: O(n)
- Search: O(n)
- Insert: O(1)
- Remove: O(1)

### Tree

- A Tree is an undirected, connected, acyclic graph

### Binary Tree

- A Binary Tree is a tree data structure in which each node has at most two children, which are referred to as the left child and right child
- _Full Tree_: a tree in which every node has either 0 or 2 children
- _Perfect Binary Tree_: a binary tree in which all interior nodes have two children and all leave have the same depth
- _Complete Tree_: a binary tree in which every level except possibly the last is full and all nodes in the last level are as far left as possible
