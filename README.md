# Interviews

## Data Structures

### Linked List

- A Linked List is a linear data structure consisting of a sequence of elements, called nodes. Each node contains:
  - Data: The actual value stored in the node.
  - Reference (or Pointer): A link to the next node in the sequence.
    This structure allows for efficient insertion and removal of elements but does not support random access.

#### Types of Linked Lists

- Singly Linked List:
  - Each node points to the next node in the sequence.
  - The last node's pointer references null, indicating the end of the list.
- Doubly Linked List:
  - Each node contains two pointers:
    - One pointing to the previous node.
    - One pointing to the next node.
  - The first node’s previous pointer and the last node’s next pointer reference null.
- Circular Linked List:
  - Each node points to the next node in the sequence.
  - The last node points back to the first node, forming a continuous circular structure.
- Time Complexity
  - Access: (O(n))
  - Search: (O(n))
  - Insert: (O(1))
  - Remove: (O(1))
- Space Complexity
  | Type | Space Complexity |
  | -------------------- | ---------------- |
  | Singly Linked List | O(n) |
  | Doubly Linked List | O(n) |
  | Circular Linked List | O(n) |

  - The space complexity is O(n) for all types of linked lists, where n is the number of nodes, because each node requires memory to store:
    - The data (value).
    - One or two pointers, depending on the type of linked list.

### Stack

- A Stack is a linear data structure that follows the Last In, First Out (LIFO) principle. This means the element that is added most recently to the stack is the first one to be removed.
- Key Operations:
  - Push: Adds an element to the top of the stack.
  - Pop: Removes the element from the top of the stack.
  - Peek (or Top): Retrieves the element at the top of the stack without removing it (optional, but commonly supported).
- Stacks are widely used in programming for tasks like backtracking, function call management, and expression evaluation.
- Characteristics of a Stack
  - LIFO Structure: The last element added is always the first to be removed.
  - Dynamic: The size of the stack can grow or shrink as needed (depending on implementation).
  - Typically implemented using arrays or linked lists.
- Time Complexity:
  - Access: O(n)
  - Search: O(n)
  - Insert: O(1)
  - Remove: O(1)
    Explanation:
  - Access/Search: Requires traversing the stack, resulting in O(n).
  - Insert/Remove: These operations occur at the top of the stack and take constant time, O(1).
- Space Complexity
  | Type | Space Complexity |
  | -------------------- | ---------------- |
  | Array-based Stack | O(n) |
  | Linked list-based Stack | O(n) |

  - Array-Based Stack:
    - Requires memory to store the elements in a contiguous block.
    - If the stack dynamically resizes, additional space may be temporarily required during resizing.
  - Linked list-based Stack
    - Each node requires extra memory for storing pointers (or references), leading to slightly higher space usage compared to an array-based stack.

### Queue

- A Queue is a linear data structure that follows the First In, First Out (FIFO) principle. This means that the element added earliest to the queue is the first one to be removed, much like a line of people waiting to be served.
- Key Operations:
  - Enqueue: Adds an element to the end (rear) of the queue.
  - Dequeue: Removes an element from the front of the queue.
  - Peek (or Front): Retrieves the element at the front of the queue without removing it (optional but commonly supported).
- Characteristics of a Queue
  - FIFO Structure: The first element added is always the first to be removed.
  - Dynamic Size: The size of the queue can grow or shrink dynamically based on operations (if implemented with dynamic structures like linked lists).
  - Used extensively in scenarios such as task scheduling, breadth-first search algorithms, and buffer management.
- Time Complexity:
  | Type | Time Complexity |
  | -------------------- | ---------------- |
  | Access | O(n) |
  | Search | O(n) |
  | Insert | O(1) |
  | Remove | O(1) |
  - Access/Search: Traversing the queue is required, resulting in O(n).
  - Insert/Remove: These operations occur at the rear or front of the queue, which take constant time, O(1).
- Space Complexity
  | Type | Time Complexity |
  | -------------------- | ---------------- |
  | Array-based Queue | O(n) |
  | Linked list-based Queue | O(n) |
  - Array-Based Queue
    - Requires memory for storing elements in a contiguous block.
    - May require additional memory during resizing (if dynamic arrays are used).
  - Linked list-based Queue
    - Each node requires memory for data and a pointer/reference, leading to slightly higher space usage.

### Tree

- A Tree is a type of data structure or graph that adheres to the following properties:
  - It is connected, meaning there is a path between any two nodes.
  - It is acyclic, meaning it contains no closed loops or cycles.
  - It is an undirected graph, where edges between nodes do not have a direction.
- In the context of computer science and graph theory, a tree is widely used to represent hierarchical relationships or structures.
- Key Features of a Tree
  - Root Node: The topmost node in the tree, where traversal begins.
  - Child Nodes: Nodes directly connected to a node when moving away from the root.
  - Parent Node: A node connected to one or more child nodes.
  - Leaf Nodes: Nodes with no children (terminal nodes).
  - Edge: A connection between two nodes.
  - Height of Tree: The length of the longest path from the root to any leaf node.
  - Depth of Node: The distance (number of edges) from the root to the node.

### Binary Tree

- A binary tree is a type of tree data structure in which each node can have at most two children, commonly referred to as the left child and right child.
- Types of Binary Trees
  - **Full Tree**: A tree in which every node has either 0 or 2 children, without exception.
  - **Perfect Binary Tree**: A tree in which all interior nodes have exactly two children, and all the leaf nodes are at the same depth.
  - **Complete Tree**: A binary tree in which every level, except possibly the last one, is completely filled. Additionally, all nodes in the last level are as far to the left as possible.

### Binary Search Tree (BST)

- A binary search tree, often referred to as a BST, is a specialized binary tree data structure. It maintains the following property:

  - The value of each node must be greater than or equal to the values stored in its left subtree.
  - The value of each node must be less than or equal to the values stored in its right subtree.

- Time Complexity:
  - Access: O(log(n))
  - Search: O(log(n))
  - Insert: O(log(n))
  - Remove: O(log(n))
- Space Complexity
  - Space Complexity: O(n), where n is the number of nodes in the tree. This is due to the storage required to maintain all the nodes in the tree.
  - Auxiliary Space: O(h), where h is the height of the tree, representing the memory required for the recursion stack during operations like traversal.

### Trie (Prefix Tree or Radix Tree)

- A trie is a tree-like data structure used to store a dynamic set or associative array where the keys are typically strings. Unlike many other data structures, the nodes in a trie do not store the keys directly. Instead, the position of a node within the trie defines the key it is associated with. Each edge between nodes represents a character, and traversing the tree spells out the keys.
- Some applications

  - **Autocomplete**: Tries are used in search engines and text editors to provide word suggestions based on prefixes.
  - **Spell Checking**: Tries can quickly verify if a word exists in a dictionary.
  - **IP Routing**: Tries are used in networking to store routing information.

- Time Complexity:
  - Insertion: O(m), where m is the length of the key being inserted. This is because each character of the key needs to be processed.
  - Search: O(m), where m is the length of the key being searched. The search operation also involves traversing the trie one character at a time.
  - Deletion: O(m), as it requires searching for the key first, which takes O(m), and then performing cleanup operations.
- Space Complexity:
  - Space Complexity: O(n \* m), where n is the number of keys stored in the trie, and m is the average length of the keys. This accounts for storing all characters in the trie nodes.
  - Auxiliary Space: Additional space may be required for recursive calls during operations like traversal, but this is generally proportional to the height of the trie.

### Fenwick Tree (Binary Indexed Tree - BIT)

- A Fenwick tree, also known as a binary indexed tree (BIT), is a data structure that provides efficient methods for updating and querying prefix sums in an array. While it is conceptually a tree, it is implemented using a flat array for simplicity and efficiency.
- Applications
  - Cumulative Frequency Tables: Fenwick trees are used to maintain and update cumulative frequencies in statistical datasets efficiently.
  - Range Sum Queries: They are widely used in competitive programming and other fields to answer range sum queries efficiently.
  - Dynamic Arrays: Useful for handling dynamic prefix sums, allowing quick updates and queries without rebuilding the data structure.
- **Time Complexity**:
  - Range Sum Query: O(log(n)), where n is the size of the array. This is achieved by traversing the binary representation of indices.
  - Update Operation: O(log(n)), as updates propagate through relevant nodes in the tree.
- **Space Complexity**:
- Space Complexity: O(n), where n is the size of the array. This accounts for the storage of the array-based implementation of the Fenwick tree.
- Auxiliary Space: Minimal additional space is required for operations, aside from the input array.

### Segment Tree

- A Segment Tree is a versatile tree data structure used to store information about intervals or segments of data. It supports efficient querying and updating of aggregated values over a range of indices in an array. This makes it particularly useful for range-based queries and modifications.
- Key Features:
  - A Segment Tree divides the array into segments and builds a binary tree structure, where each node represents a specific segment of the array.
  - It allows for efficient processing of range-based queries and updates in logarithmic time.
  - Common operations include finding the sum, minimum, maximum, or greatest common divisor (GCD) over a given range.
- Some applications
  - Database Management: Used to optimize range-based queries and updates, such as calculating sums or counts across specified fields in large datasets.
  - Financial Analysis: Applied in stock market data analysis for efficient range queries, such as calculating moving averages or aggregating data over specific time intervals.
  - Geographical Information Systems (GIS): Used to process spatial data, such as querying elevation ranges or aggregated weather data for specific regions.
- **Time Complexity**:
  - Range Query: O(log(n)), where n is the number of elements in the array. This is achieved by selectively traversing only relevant branches of the tree.
  - Update Operation: O(log(n)), as updates propagate through the tree to maintain the consistency of affected segments.
- **Space Complexity**:
  - Space Complexity: O(n), for storing the array representation of the tree, where n is the size of the input array.
  - Auxiliary Space: O(log(n)), required for the recursion stack during operations.

### Heap

- A heap is a specialized tree-based data structure that satisfies the heap property. This property ensures that for any given node 𝐴 and its child node
  𝐵, the value (or key) of node 𝐴 is ordered relative to the value of node 𝐵:
  - In a max-heap, the value of each parent node is greater than or equal to the values of its child nodes.
  - In a min-heap, the value of each parent node is less than or equal to the values of its child nodes.
- Heaps are commonly implemented using arrays to efficiently represent the tree structure.
- Applications
  - **Priority Queues**: Heaps are widely used to implement priority queues, where elements are processed in order of their priority (e.g., highest or lowest).
  - **Heap Sort**: A comparison-based sorting algorithm that leverages the heap structure to sort elements efficiently in O(n log(n)) time.
  - **Graph Algorithms**: Heaps are essential in algorithms like Dijkstra’s shortest path and Prim’s Minimum Spanning Tree, as they enable efficient retrieval of the next node to process.
- Time Complexity
  - Access Max/Min: O(1), as the maximum (or minimum) element is always at the root of the heap.
  - Insert: O(log(n)), due to the process of restoring the heap property (heapification) after insertion.
  - Remove Max/Min: O(log(n)), as removing the root requires re-establishing the heap property.
- Space Complexity
  - Space Complexity: O(n), where n is the number of elements stored in the heap.
  - Auxiliary Space: O(1), since heaps are typically implemented in place using arrays.

### Hashing

- Hashing: Hashing is a technique used to map data of arbitrary size to fixed-size values, known as hash values, hash codes, or simply hashes. It plays a critical role in data structures and algorithms, providing efficient data organization and retrieval. A collision occurs when two keys produce the same hash value.
- Hash Maps: A Hash Map (or hash table) is a data structure that stores key-value pairs. It uses a hash function to compute an index (or hash code) into an array of buckets or slots, where the desired value can be found. The key advantage of hash maps is their ability to provide fast data retrieval, typically in constant time (O(1)).
- Common methods to handle collisions:
  - Separate Chaining: This technique resolves collisions by storing multiple entries that hash to the same index in a linked list. Each bucket in the hash table points to a linked list containing all entries that share the same hash code. It is simple and effective, particularly when collisions are rare.
  - Open Addressing: In this method, all elements are stored within the hash table itself. When a collision occurs, the algorithm searches for the next available slot in the array to store the new entry. Techniques like linear probing, quadratic probing, or double hashing are used for this purpose. Open addressing minimizes memory usage and works well when the table has low occupancy.
- Applications: Password Authentication (Securely hashing passwords to enhance security), Data Storage and Retrieval (Enabling quick access to large datasets), Caching (Storing frequently accessed data for faster retrieval), Cryptography (Ensuring data integrity and security through hash functions)
- **Time Complexity**
  - **Search, Insert, and Delete (Average Case)**: O(1), thanks to uniform distribution by the hash function.
  - **Search, Insert, and Delete (Worst Case)**: O(n), which occurs when all keys hash to the same index, resulting in a single chain or full probing.
  - **Separate Chaining**
    - (Average Case): O(1) for insertions, deletions, and lookups.
    - (Worst Case): O(n), where all entries collide and form a single linked list.
  - **Open Addressing**
    - (Average Case): O(1) for insertions, deletions, and lookups.
    - (Worst Case): O(n), when searching through a long probe sequence.
- **Space Complexity**
  - O(n), where 𝑛 is the number of key-value pairs stored in the hash map.
  - **Separate Chaining**: O(n + m), where 𝑛 is the number of keys and 𝑚 is the size of the table.
  - **Open Addressing**: O(m), where 𝑚 is the size of the table.

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
