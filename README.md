# Interviews

## Data Structures

### Linked List

- A Linked List is a linear data structure consisting of a sequence of elements, called nodes. Each node contains data and a reference (or pointer) to the next node in the sequence. This structure allows for efficient insertion and removal of elements.
- Types of Linked Lists
  - Singly Linked List:
    - Each node points to the next node in the sequence.
    - The last node points to null, indicating the end of the list.
  - Doubly Linked List:
    - Each node contains two pointers: one pointing to the previous node and one to the next node.
    - The first node’s previous pointer and the last node’s next pointer both point to null.
  - Circular Linked List:
    - Each node points to the next node in the sequence.
    - The last node points back to the first node, forming a circular structure.
- Time Complexity
  - Access: (O(n))
  - Search: (O(n))
  - Insert: (O(1))
  - Remove: (O(1))

### Stack

- A Stack is a collection of elements, with two principle operations: push, which adds to the collection, and pop, which removes the most recently added element
- Last in, first out data structure (LIFO): the most recently added object is the first to be removed
- Time Complexity:
  - Access: O(n)
  - Search: O(n)
  - Insert: O(1)
  - Remove: O(1)

### Queue

- A Queue is a collection of elements, supporting two principle operations: enqueue, which inserts an element into the queue, and dequeue, which removes an element from the queue
- First in, first out data structure (FIFO): the oldest added object is the first to be removed
- Time Complexity:
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

- Time Complexity:
  - Access: O(log(n))
  - Search: O(log(n))
  - Insert: O(log(n))
  - Remove: O(log(n))

### Trie

- A trie, also known as a prefix tree or radix tree, is a type of search tree used to store a dynamic set or associative array where the keys are typically strings. Unlike other data structures, nodes in a trie do not store the keys themselves. Instead, a node’s position within the trie determines the key it is associated with.
- Applications

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

### Segment Tree

- A Segment tree, is a tree data structure for storing intervals, or segments. It allows querying which of the stored segments contain a given point
- **Time Complexity**:
  - Range Query: O(log(n))
  - Update: O(log(n))

### Heap

- A heap is a specialized tree-based data structure that satisfies the heap property. This property ensures that for any given node (A) and its child node (B), the key (value) of node (A) is ordered with respect to the key of node (B). This ordering applies consistently throughout the entire heap.
- Applications
  - **Priority Queues**: Heaps are commonly used to implement priority queues, where elements are processed based on their priority.
  - **Heap Sort**: This sorting algorithm leverages the heap structure to sort elements efficiently.
  - **Graph Algorithms**: Heaps are used in algorithms like Dijkstra’s shortest path algorithm to efficiently manage and retrieve the next node to process.
- **Time Complexity**:
  - Access Max / Min: O(1)
  - Insert: O(log(n))
  - Remove Max / Min: O(log(n))

### Hashing

- Hashing is a technique used to map data of arbitrary size to fixed-size values, known as hash values, hash codes, or simply hashes. When two keys produce the same hash value, a collision occurs.
- Hash Maps: A Hash Map (or hash table) is a data structure that stores key-value pairs. It uses a hash function to compute an index (or hash code) into an array of buckets or slots, from which the desired value can be found. The primary advantage of hash maps is their ability to provide fast data retrieval, typically in constant time, (O(1)).
- Common methods to handle collisions:
  - Separate Chaining: a collision resolution technique used in hash maps. When two keys hash to the same index, separate chaining stores these keys in a linked list at that index. This way, each bucket in the hash table points to a linked list of entries that share the same hash code. This method is simple and effective, especially when the number of collisions is low.
  - Open Addressing: is another collision resolution method where, instead of using linked lists, all elements are stored within the hash table itself. When a collision occurs, the algorithm searches for the next available slot in the array (using techniques like linear probing, quadratic probing, or double hashing) to store the new entry. This approach minimizes memory usage and can be faster for lookups when the table is not too full
- Applications: Password Authentication, Data Storage and Retrieval, Caching, Cryptography

### Graph

- A graph is an ordered pair ( G = (V, E) ) consisting of a set ( V ) of vertices (or nodes) and a set ( E ) of edges (or arcs), where each edge is a 2-element subset of ( V ). In other words, an edge connects two vertices, forming an unordered pair of those vertices.
  - **Undirected Graph**: In an undirected graph, the adjacency relation is symmetric. This means if there is an edge from node ( u ) to node ( v ) (( u \rightarrow v )), there is also an edge from node ( v ) to node ( u ) (( v \rightarrow u )).
  - **Directed Graph**: In a directed graph, the adjacency relation is not symmetric. Thus, if there is an edge from node ( u ) to node ( v ) (( u \rightarrow v )), it does not necessarily imply that there is an edge from node ( v ) to node ( u ) (( v \rightarrow u )).
  - Applications:
    - Social Networks, Web Graphs, Recommendation systems, Network analysis.

## Algorithms

### Sorting

#### Quicksort

- Stable: No
- Time Complexity:
  - Best Case: O(nlog(n))
  - Worst Case: O(n^2)
  - Average Case: O(nlog(n))

#### Mergesort

- Mergesort is also a divide and conquer algorithm. It continuously divides an array into two halves, recurses on both the left subarray and right subarray and then merges the two sorted halves.
- Stable: Yes
- Time Complexity:
  - Best Case: O(nlog(n))
  - Worst Case: O(nlog(n))
  - Average Case: O(nlog(n))

#### Bucket Sort

- Bucket Sort is a sorting algorithm that works by distributing the elements of an array into a number of buckets. Each bucket is then sorted individually, either using a different sorting algorithm, or by recursively applying the bucket sorting algorithm
- Time Complexity:
  - Best Case: Ω(n + k)
  - Worst Case: O(n^2)
  - Average Case:Θ(n + k)

#### Radix Sort

- Radix Sort is a sorting algorithm that like bucket sort, distributes elements of an array into a number of buckets. However, radix sort differs from bucket sort by 're-bucketing' the array after the initial pass as opposed to sorting each bucket and merging
- Time Complexity:
  - Best Case: Ω(nk)
  - Worst Case: O(nk)
  - Average Case: Θ(nk)
