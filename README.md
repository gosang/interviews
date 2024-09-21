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
- **Full Tree**: a tree in which every node has either 0 or 2 children
- **Perfect Binary Tree**: a binary tree in which all interior nodes have two children and all leave have the same depth
- **Complete Tree**: a binary tree in which every level except possibly the last is full and all nodes in the last level are as far left as possible

### Binary Search Tree

- A binary search tree, sometimes called BST, is a type of binary tree which maintains the property that the value in each node must be greater than or equal to any value stored in the left sub-tree, and less than or equal to any value stored in the right sub-tree

#### Time Complexity:

- Access: O(log(n))
- Search: O(log(n))
- Insert: O(log(n))
- Remove: O(log(n))

### Trie

- A trie, also known as a prefix tree or radix tree, is a type of search tree used to store a dynamic set or associative array where the keys are typically strings. Unlike other data structures, nodes in a trie do not store the keys themselves. Instead, a node’s position within the trie determines the key it is associated with.

Example: consider storing the words “cat”, “car”, and “dog” in a trie:
(root)
/ | \
 c d o
/ \ \ \
 a a o g
/ \ \
 t r g

#### Applications

- **Autocomplete**: Tries are used in search engines and text editors to provide word suggestions based on prefixes.
- **Spell Checking**: Tries can quickly verify if a word exists in a dictionary.
- **IP Routing**: Tries are used in networking to store routing information.

### Fenwick Tree

- A Fenwick tree, also known as a binary indexed tree (BIT), is a data structure that provides efficient methods for updating and querying prefix sums in an array. Although it is conceptually a tree, it is implemented using an array.
- Applications
  - Cumulative Frequency Tables: Fenwick trees are used to maintain cumulative frequencies in statistical data.
  - Range Sum Queries: They are efficient for answering range sum queries in competitive programming and other applications.
- **Time Complexity**:
  - Range Sum: O(log(n))
  - Update: O(log(n))
