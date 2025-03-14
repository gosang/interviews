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

- A graph is an ordered pair G = (V, E), consisting of:
  - V: A set of vertices (or nodes).
  - E: A set of edges (or arcs), where each edge is a 2-element subset of 𝑉 . An edge connects two vertices, forming an unordered pair of those vertices. Graphs are widely used to represent relationships or connections in various systems.
- Types of Graphs
  - **Undirected Graph**: In an undirected graph, the adjacency relation is symmetric. This means that if there is an edge from node 𝑢 to node 𝑣(𝑢↔𝑣), there is also an edge from node 𝑣 to node 𝑢 (𝑣 ↔ 𝑢). Essentially, the edges have no direction. Example: A social network where friendships are mutual.
  - **Directed Graph (Digraph)**: In a directed graph, the adjacency relation is asymmetric. This means that if there is an edge from node 𝑢 to node 𝑣(𝑢→𝑣), it does not necessarily imply that there is an edge from node 𝑣 to node 𝑢 (𝑣→𝑢). The edges have a specific direction. Example: A web graph where hyperlinks point from one webpage to another.
- Time and Space Complexity of Graphs:
  The complexities of graphs depend on how the graph is represented:

  - Adjacency Matrix Representation
    - **Time Complexity**
      - Checking if an edge exists: O(1).
      - Adding or removing an edge: O(1).
      - Iterating through all edges: O(V^2), where 𝑉 is the number of vertices.
    - **Space Complexity**: O(V^2), as it requires a matrix of size 𝑉×𝑉.
  - Adjacency List Representation
    - **Time Complexity**
      - Checking if an edge exists: O(V) in the worst case (if all edges for a vertex need to be searched).
      - Adding an edge: O(1).
      - Iterating through all edges: O(V + E), where 𝐸 is the number of edges.
    - **Space Complexity**: O(V + E), as it stores a list for each vertex containing its adjacent vertices.

- Applications:
  - Social Networks (Representing connections between individuals (e.g., friendships, followers)), Web Graphs (Visualizing the structure of the World Wide Web (e.g., pages linked by hyperlinks)), Recommendation systems (Identifying relationships between users and items to provide personalized recommendations), Network analysis (Modeling and analyzing complex networks (e.g., transportation systems, communication networks)).

## Algorithms

### Sorting

#### Quicksort

Quicksort is a widely used divide-and-conquer sorting algorithm that is known for its efficiency in handling large datasets. It works by partitioning the array into smaller subarrays based on a pivot element and recursively sorting the subarrays.

- Stable: No (The relative order of equal elements may not be preserved in the original implementation).
- In-place: Yes (Requires only O(log(n)) additional memory for the recursion stack).
- Time Complexity:
  - Best Case: O(nlog(n)): Occurs when the pivot divides the array into two nearly equal halves at every step.
  - Worst Case: O(n^2): Happens when the pivot is the smallest or largest element, resulting in highly unbalanced partitions (e.g., for already sorted or reverse-sorted arrays).
  - Average Case: O(nlog(n)): On average, the pivot provides reasonably balanced partitions, leading to logarithmic recursive steps.
- Space Complexity:
  - O(log(n)): Quicksort is in-place and only requires additional memory for the recursion stack, making it memory-efficient compared to other divide-and-conquer algorithms like Merge Sort.

#### Mergesort

Mergesort is is a divide-and-conquer algorithm that recursively splits an array into two halves, sorts each half, and then merges the two sorted halves to produce the final sorted array. It is particularly efficient for large datasets and guarantees stable sorting.

- Stable: Yes (Equal elements retain their relative order).
- In-place: No (Additional memory is required for merging, making it less space-efficient than Quicksort).
- Time Complexity:
  - **Best Case: O(nlog(n))**: Even in the best case, the array is divided and merged recursively, maintaining logarithmic depth with linear merging.
  - **Worst Case: O(nlog(n))**: Mergesort performs the same operations regardless of the input order, making it consistent in time complexity.
  - **Average Case: O(nlog(n))**: Mergesort performs the same operations regardless of the input order, making it consistent in time complexity.
- Space Complexity:
  - **O(n)**: Mergesort requires additional memory for temporary arrays during the merging step, making its space usage proportional to the input size.

#### Bucket Sort

Bucket Sort is a sorting algorithm that distributes the elements of an array into a predefined number of buckets. Each bucket contains a range of values, and elements within the same range are grouped together. Once distributed, the elements in each bucket are sorted individually, either using another sorting algorithm (e.g., Insertion Sort) or by recursively applying Bucket Sort. Finally, the contents of the buckets are concatenated to produce the sorted array.

- Stable: Depends on the sorting method used within the buckets (Insertion Sort preserves stability).
- In-place: No (Additional memory is required for buckets).
- Time Complexity:
  - **Best Case: Ω(n + k)**: Occurs when the data is evenly distributed across buckets, and each bucket contains only a few elements, leading to minimal overhead in sorting individual buckets.
  - **Worst Case: O(n^2)**: Happens when all elements land in the same bucket, essentially reducing Bucket Sort to a less efficient sorting algorithm like Insertion Sort.
  - **Average Case:Θ(n + k)**: With reasonably uniform distribution, the sorting process across buckets scales efficiently.
- Space Complexity:
  - **O(n + k)**: Additional space is required for the buckets and temporary storage during the sorting process.

#### Radix Sort

Radix Sort is a non-comparative sorting algorithm that processes the elements of an array by their individual digits or components. Similar to Bucket Sort, it distributes elements into buckets; however, it differs by repeatedly redistributing the elements (or "re-bucketing") based on each digit or positional value, starting from the least significant digit (LSD) to the most significant digit (MSD), or vice versa. The sorted order is achieved after completing all positional passes.

- Stable: Yes (Preserves the relative order of equal elements).
- In-place: No (Requires additional memory for buckets).
- Time Complexity:
  - **Best Case: Ω(nk)**: Occurs when the distribution and re-bucketing are highly efficient across 𝑘 passes.
  - **Worst Case: O(nk)**: Even in the worst case, Radix Sort performs a fixed number of operations per element per digit, making it consistent.
  - **Average Case: Θ(nk)**: The runtime remains predictable, as every element is processed 𝑘 times.
- Space Complexity:
  - **O(n + b)**: Radix Sort requires additional space for 𝑏, the number of buckets (usually equal to the base of the numbering system, e.g., 10 for decimal).

### Graph Algorithms

#### Depth First Search (DFS)

Depth First Search (DFS) is a fundamental graph traversal algorithm. It systematically explores a graph by starting at a source vertex and going as far as possible along one path (branch) before backtracking to explore other paths. This approach uses a stack either explicitly or implicitly (via recursion) to manage visited vertices and ensure proper backtracking.

- DFS traverses each vertex and edge exactly once during the search.
- It can be applied to both directed and undirected graphs.
- DFS is particularly useful for problems requiring exploration of all paths, such as finding connected components, detecting cycles, and solving puzzles (e.g., mazes).

Time Complexity

- O(|V| + |E|), where:
  - ∣𝑉∣: Number of vertices in the graph.
  - ∣𝐸∣: Number of edges in the graph. DFS processes all vertices and edges, making its runtime proportional to the size of the graph.

Space Complexity

- O(|V|) for the recursion stack or explicit stack, in the worst case (e.g., a path-like graph with maximum depth).

Common applications include Topological Sorting (Used to order tasks, such as scheduling jobs, resolving package dependencies, or ordering instructions in compilers),
Strongly Connected Components detection (Find SCCs in directed graphs using Tarjan's or Kosaraju's algorithm, useful in analyzing networks),
Pathfinding and Navigation (for pathfinding in games or mapping out routes (e.g., solving word ladders or navigating virtual worlds)).

#### Breadth First Search (BFS)

Breadth First Search (BFS) is a fundamental graph traversal algorithm. It explores all neighboring nodes of a vertex before progressing to the next level of neighbors. BFS uses a queue to systematically visit nodes level by level, ensuring that all vertices at the current depth are explored before moving deeper into the graph.

- BFS guarantees finding the shortest path (in terms of the number of edges) in an unweighted graph.
- It is applicable to both directed and undirected graphs.
- BFS is an iterative algorithm, relying on a queue to manage visited nodes.

- Time Complexity

  - O(|V| + |E|), where:
    - ∣𝑉∣: Number of vertices in the graph.
    - ∣𝐸∣: NNumber of edges. BFS processes each vertex and edge exactly once, resulting in a runtime proportional to the size of the graph.

- Space Complexity
  - O(|V|) for storing the queue and the visited set (or array), as they must hold all vertices in the worst case.

Common applications include Shortest Path in Unweighted Graphs (Find the minimum number of edges required to reach a target vertex),
Level Order Traversal (BFS is used for traversing trees level by level), Solving Puzzles (Used in games and puzzles to explore all possible states (e.g., sliding puzzles, word ladders)).

#### Topological Sort

Topological Sort is a linear ordering of the nodes (or vertices) of a directed acyclic graph (DAG) such that for every directed edge from node
𝑢 to node 𝑣(𝑢→𝑣), node 𝑢 appears before node 𝑣 in the ordering. It is used to represent dependencies between tasks, making it ideal for scheduling problems.

- Can only be performed on a directed acyclic graph (DAG).
- If a graph contains cycles, topological sorting is not possible.
- Multiple valid topological orderings may exist for a single graph.
- Time Complexity

  - O(|V| + |E|), where:
    - ∣𝑉∣: Number of vertices in the graph.
    - ∣𝐸∣: Number of edges in the graph. The algorithm visits each vertex and processes all its outgoing edges, resulting in linear complexity.

- Space Complexity

  - O(|V|): Space is required for auxiliary data structures like the in-degree array (or visited set) and the stack or queue.

- Common Algorithms
  - **Kahn's Algorithm (Using in-degrees and a queue)**: Iteratively removes vertices with no incoming edges and reduces the in-degree of their neighbors.
  - **DFS-Based Algorithm**: Uses a recursive DFS to traverse the graph and pushes vertices onto a stack when their neighbors are fully explored.

Applications of Topological Sort include Task Scheduling (determine the order in which tasks with dependencies (e.g., jobs, courses) should be executed),
Precedence Problems (solve problems where certain tasks or actions must be performed before others),
Project Management (represent activities in a project and ensure the order of execution respects dependencies)

### Dijkstra's Algorithm

Dijkstra's Algorithm is a widely used graph algorithm for finding the shortest path from a source vertex to all other vertices in a graph. It works with weighted graphs where edge weights represent distances or costs, provided all edge weights are non-negative.
The algorithm uses a greedy approach, selecting the shortest known distance at each step to ensure efficient pathfinding.

- Finds the shortest paths from a single source vertex to all other vertices.
- Assumes all edge weights are non-negative (does not work with negative weights).
- Guarantees the shortest path for all vertices in the graph if executed to completion

- Time Complexity
  The time complexity depends on the data structures used:

  - Naive Implementation (using arrays):
    - O(|V|²), where ∣𝑉∣ is the number of vertices.
    - This occurs when finding the minimum distance vertex at each step requires scanning the entire list of vertices.
  - Optimized Implementation (using a priority queue, e.g., a binary heap):
    - O((|V| + |E|) \log |V|), where ∣𝐸∣ is the number of edges.
    - The priority queue ensures efficient updates and retrieval of the next closest vertex.

- Space Complexity

  - O(|V| + |E|): Space is required to store the graph (adjacency list) and additional data structures such as the distance array and the priority queue.

- Steps of the Algorithm
- Initialization:
  - Set the distance to the source vertex as 0 and to all other vertices as infinity.
  - Initialize a priority queue to track vertices with the shortest known distances.
- Relaxation:
  - Iteratively extract the vertex with the smallest distance from the priority queue.
  - Update the distances of its neighboring vertices if a shorter path is found.
- Termination:
  - The algorithm terminates when all vertices have been processed, resulting in the shortest paths from the source to all other vertices.

Applications include Network Routing(Find the shortest path in communication and transportation networks),
Mapping and Navigation(Used in GPS systems to find the shortest route between locations),
Resource Optimization(Solve problems in logistics, such as determining the fastest delivery routes).

### Bellman-Ford Algorithm

The Bellman-Ford Algorithm is a graph algorithm used to compute the shortest paths from a single source vertex to all other vertices in a weighted graph. Unlike Dijkstra's Algorithm, Bellman-Ford is more versatile as it can handle graphs with negative edge weights. Additionally, it is capable of detecting negative weight cycles, making it a powerful tool for solving more complex graph problems.

- Works with weighted directed and undirected graphs.
- Can handle negative edge weights (unlike Dijkstra's Algorithm).
- Detects the presence of negative weight cycles (if a vertex's distance can still be reduced after ∣𝑉∣−1 iterations, a negative weight cycle exists).

Algorithm Steps

- Initialization:
  - Set the distance to the source vertex as 0 and to all other vertices as infinity (∞).
- Relaxation:
  - Iterate ∣𝑉∣−1 times (where ∣𝑉∣ is the number of vertices), relaxing all edges. This means updating the distance of neighboring vertices if a shorter path is found via the current edge.
- Negative Cycle Check:
  - Perform one additional iteration to check for negative weight cycles. If any distance can still be reduced, the graph contains a negative cycle.

Time Complexity

- Best Case: O(|E|): Occurs when the graph is sparse and no relaxation is needed after the initial few edges.
- Worst Case: O(|V| |E|): Happens when the algorithm performs ∣𝑉∣−1 iterations of relaxation over all edges in a dense graph.

Space Complexity

- O(|V|): Space is required to store distances and predecessors for all vertices.

Applications include Shortest Path in Graphs with Negative Weights(Useful in network routing and financial models),
Negative Weight Cycle Detection(Applied in system analysis to identify issues, such as arbitrage opportunities in currency exchange),
Logistics and Planning(Solves problems where edge weights represent costs that can be negative (e.g., profit margins or loss reduction)),
Currency Arbitrage Detection(Identify profitable opportunities in foreign exchange markets)

### Floyd-Warshall Algorithm

The Floyd-Warshall Algorithm is a dynamic programming algorithm used to find the shortest paths between all pairs of nodes in a weighted graph. It works with graphs that have positive or negative edge weights, as long as there are no negative weight cycles. The algorithm is particularly useful for dense graphs and produces a matrix that represents the shortest path distances between every pair of vertices.

- Finds the shortest path between all pairs of nodes in a single execution.
- Handles graphs with negative edge weights but not negative weight cycles.
- The algorithm uses a matrix-based approach to iteratively improve estimates of shortest path distances.

Algorithm Steps

- Initialization
  - Create a distance matrix where 𝑑𝑖𝑠𝑡[𝑖][𝑗] represents the shortest distance from vertex 𝑖 to vertex 𝑗.
  - Set 𝑑𝑖𝑠𝑡[𝑖][𝑗] = 0 for all vertices 𝑖, as the distance from a node to itself is zero.
  - Initialize 𝑑𝑖𝑠𝑡[𝑖][𝑗] with the weight of the edge between 𝑖 and 𝑗 (or ∞ if no edge exists).
- Dynamic Programming
  - Use each vertex 𝑘 as an intermediate point and update the distance matrix.
  - Update 𝑑𝑖𝑠𝑡[𝑖][𝑗] as:
    - 𝑑𝑖𝑠𝑡[𝑖][𝑗] = min(𝑑𝑖𝑠𝑡[𝑖][𝑗], 𝑑𝑖𝑠𝑡[𝑖][k] + 𝑑𝑖𝑠𝑡[k][𝑗])
      This ensures the algorithm considers paths passing through 𝑘, improving the shortest path estimates.
- Result
  - After ∣𝑉∣ iterations (where ∣𝑉∣ is the number of vertices), the distance matrix contains the shortest path lengths for all pairs of nodes.

Time Complexity

- Best Case: O(|V|³)
- Worst Case: O(|V|³)
- Average Case: O(|V|³) The cubic complexity arises from three nested loops over the vertices, making the algorithm most efficient for dense graphs or smaller input sizes.

Space Complexity

- O(|V|²): Space is required to store the distance matrix.

Applications include All-Pairs Shortest Path (Efficiently compute shortest path distances in road networks, communication networks, or any system modeled as a graph),
Detecting Negative Weight Cycles(A graph has a negative weight cycle if, after completing the algorithm, 𝑑𝑖𝑠𝑡[𝑖][𝑗] < 0 for any vertex 𝑖),
Routing in Networks(Determine optimal routes in communication or transportation networks).

### Prim's Algorithm

Prim's Algorithm is a greedy algorithm used to find the Minimum Spanning Tree (MST) of a weighted undirected graph. The MST is a subset of the graph’s edges that connects all vertices with the minimum possible total edge weight, ensuring there are no cycles.

- Starts with a single vertex and grows the spanning tree one edge at a time by choosing the smallest available edge that connects a vertex in the tree to a vertex outside the tree.
- Uses a priority queue or simple arrays to select the minimum weight edge efficiently.
- Guarantees the MST for connected and undirected graphs.

Algorithm Steps

- Initialization:
  - Choose an arbitrary starting vertex and initialize it as part of the MST.
  - Assign infinite weights (or large values) to all other vertices initially, representing their distance from the MST.
- Edge Selection:
  - Repeatedly select the smallest weight edge that connects a vertex in the MST to a vertex outside the MST.
  - Add the selected edge and its associated vertex to the MST.
- Update Weights:
  - Update the weights of all vertices outside the MST based on their distance to the newly added vertex.
- Repeat:
  - Continue until all vertices are included in the MST.

Time Complexity
The time complexity depends on the data structure used:

- Naive Implementation (using arrays):
  - O(|V|²), where ∣𝑉∣ is the number of vertices.
  - This occurs because selecting the minimum weight edge at each step requires scanning all vertices.
- Optimized Implementation (using a binary heap or priority queue):
  - O((|V| + |E|) \log |V|), where ∣𝐸∣ is the number of edges.
  - This optimization significantly improves performance for sparse graphs.

Space Complexity

- O(|V| + |E|): Space is required for storing the graph (in an adjacency list) and auxiliary data structures like the priority queue.

Applications include Network Design(Design efficient communication or transportation networks (e.g., laying cables or constructing roads)),
Circuit Design(Optimize connections in electrical circuits),
Clustering Problems(Used in data analysis to group similar objects),
Navigation Systems(Minimize costs in creating maps or routes).

### Kruskal's Algorithm

Kruskal's Algorithm is a greedy algorithm used to find the Minimum Spanning Tree (MST) of a graph. It operates by sorting all edges in the graph based on their weights and iteratively adding edges to the MST, ensuring no cycles are formed. Unlike Prim's Algorithm, Kruskal's does not require the graph to be connected, as it can construct a minimum spanning forest for disconnected graphs.

- Works on weighted, undirected graphs.
- Can handle both connected and disconnected graphs (creates a minimum spanning forest for disconnected graphs).
- Uses the concept of union-find (disjoint set data structure) to efficiently detect and prevent cycles.

Algorithm Steps

- Sort Edges by Weight:
  - Begin by sorting all edges in ascending order of their weights.
- Initialize Forest:
  - Treat each vertex as an independent tree (i.e., the MST starts with ∣𝑉∣ single-node trees).
- Edge Selection:
  - Iterate through the sorted edges. For each edge, check if adding it to the MST would form a cycle using the union-find data structure.
  - If no cycle is formed, add the edge to the MST.
- Repeat Until MST is Formed:
  - Continue adding edges until the MST contains ∣𝑉∣−1 edges (for a connected graph).

Time Complexity

- Sorting Edges
  - Sorting all edges takes O(|E| log |E|)
  - Since ∣𝐸∣≤∣𝑉∣2, this can also be written as O(|E| log |V|).
- Union-Find Operations
  - For ∣𝐸∣ edges, performing union and find operations takes approximately O(|E| \alpha(|V|)), where 𝛼(∣𝑉∣) is the inverse Ackermann function (almost constant).
- Overall Complexity
  - The dominant term is the sorting step, so the total time complexity is O(|E| log |V|).

Space Complexity

- O(|V| + |E|): Space is required to store the graph and the union-find data structure.

Applications include Network Design(Optimize cost for constructing communication, transportation, or electrical networks),
Clustering(Used in hierarchical clustering algorithms to group similar items),
Approximation Algorithms(Applied in problems requiring the construction of low-cost networks),
Forest Construction(Handles disconnected graphs effectively by creating a minimum spanning forest),

### Greedy Algorithms

Greedy Algorithms are a class of algorithms that make a series of locally optimal choices at each step, with the intention of ultimately arriving at a globally optimal solution. While this approach is simple and often efficient, it works only for certain types of problems.

For a problem to be solved effectively using a Greedy Algorithm, it must satisfy two key properties:

- **Optimal Substructure**: The problem exhibits an optimal substructure when the optimal solution to the entire problem can be constructed from the optimal solutions to its subproblems.
- **Greedy Choice Property**: The problem has the greedy property if a globally optimal solution can be reached by making a series of locally optimal choices, without the need to revisit or reconsider prior decisions.

**Example - Coin Change Problem**

The problem: Given a target amount 𝑉(in cents) and a list of 𝑛 coin denominations, represented as coinValue [𝑖](where 𝑖 ∈ [ 0, 𝑛 − 1 ]), determine the minimum number of coins needed to make up the amount 𝑉. Assume an unlimited supply of coins of each denomination.

For this example, the available coin denominations are: Penny: 1 cent, Nickel: 5 cents, Dime: 10 cents and Quarter: 25 cents.

Let’s solve the problem using the Greedy Algorithm, which repeatedly selects the largest coin denomination less than or equal to the remaining amount
𝑉. Subtract the value of the selected coin from 𝑉 and continue until 𝑉 = 0.

Assume 𝑉 = 93 cents:

- Initial amount: 𝑉 = 93 cents, Coins used: 0.
  - Select the largest coin less than or equal to 93 : Quarter (25 cents).
  - Subtract 25 from 93.
  - 𝑉 = 93 − 25 = 68. Coins used: 1.
- 𝑉 = 43 cents, Coins used: 2. 𝑉 = 68 − 25 = 43
- 𝑉 = 18 cents, Coins used: 3. 𝑉 = 43 − 25 = 18
- 𝑉 = 8 cents, Coins used: 4. 𝑉 = 18 − 10 = 8
- 𝑉 = 3 cents, Coins used: 5. 𝑉 = 8 − 5 = 3
- 𝑉 = 2 cents, Coins used: 6. 𝑉 = 3 − 1 = 2
- 𝑉 = 1 cents, Coins used: 7. 𝑉 = 2 − 1 = 1
- 𝑉 = 0 cents, Coins used: 8. 𝑉 = 1 − 1 = 0
  Using the Greedy Algorithm, the target amount 𝑉 = 93 can be represented using a total of 8 coins which is optimal.

**Time Complexity**
The time complexity of a greedy algorithm is typically determined by:

- Sorting: Many greedy problems require sorting elements first (e.g., sorting activities by finish time or items by value-to-weight ratio), which has a time complexity of
  𝑂(𝑛log⁡𝑛), where 𝑛 is the number of elements.
- Iterations: After sorting, the algorithm usually iterates through the input (e.g., selecting activities or coins). This step typically takes 𝑂(𝑛).

Thus, the overall time complexity for most greedy algorithms is: 𝑂(𝑛log⁡𝑛)(dominated by the sorting step).

For cases where sorting is not required, the complexity might just be 𝑂(𝑛), depending on the nature of the problem.

**Space Complexity**
The space complexity of a greedy algorithm is generally: 𝑂(1) (constant space) if the algorithm operates in-place without requiring additional data structures. However, if the algorithm involves using auxiliary data structures (e.g., arrays, heaps, or lists), the space complexity might increase to:

- 𝑂(𝑛) for storing input data or intermediate results.

**Example Complexities**:

- Activity Selection Problem: 𝑂(𝑛log𝑛) time (due to sorting) and 𝑂(1) space.
- Huffman Encoding: 𝑂(𝑛log⁡𝑛) time (using a priority queue) and 𝑂(𝑛) space.
- Dijkstra’s Algorithm: 𝑂((𝑉 - 𝐸 ) log ⁡ 𝑉) time (with a priority queue) and 𝑂 (𝑉 - 𝐸 ) space, where 𝑉 is the number of vertices and 𝐸 is the number of edges.

Applications include:

- Scheduling Problems
  - Job Scheduling: to schedule tasks on machines or processors to minimize completion time or maximize resource utilization.
  - Activity Selection: Selecting the maximum number of non-overlapping activities from a given set, such as optimizing conference room usage.
- Pathfinding and Graph Problems
  - Dijkstra's Algorithm: A greedy approach is used to find the shortest path from a source node to all other nodes in a weighted graph, useful in GPS navigation systems and routing.
- Resource Allocation
  - Fractional Knapsack Problem: Determines the maximum value of items that can fit into a knapsack by greedily selecting items with the highest value-to-weight ratio, often applied in financial planning and supply chain optimization.
- Optimization Problems
  - Coin Change Problem: Greedy strategies are applied to determine the minimum number of coins needed for a specific amount, often used in automated cash registers.
  - Interval Covering Problems: Such as selecting minimum intervals to cover a certain range, useful in broadcasting and signal allocation.
- Real-Time Systems
  - Task Assignment: Allocating tasks in real-time systems to minimize delay or maximize throughput, such as in operating systems or load balancing on servers.
- Dynamic Pricing
  - In e-commerce and airline ticket pricing, greedy methods optimize revenue by continuously adjusting prices based on demand and inventory levels.

### Bitmasking

Bitmasking is a powerful technique used to manipulate data at the bit level. By operating directly on binary representations, bitmasks enable faster computations and reduce memory usage, making them ideal for solving problems efficiently.

Here are some common bitmasking operations:

- Test the 𝑘-th Bit Check if the 𝑘-th bit is set (1): s & (1 << k)
- Set the 𝑘-th Bit Turn on (set to 1) the 𝑘-th bit: s |= (1 << k)
- Turn Off the 𝑘-th Bit Turn off (set to 0) the 𝑘-th bit: s &= ~(1 << k)
- Toggle the 𝑘-th Bit Flip the state of the 𝑘-th bit (1 becomes 0, and vice versa): s ^= (1 << k)
- Multiply by 2𝑛 Left shift by 𝑛 bits (equivalent to multiplying by 2𝑛): s << n
- Divide by 2𝑛 Right shift by 𝑛 bits (equivalent to dividing by 2𝑛): s >> n
- Intersection of Two Sets Retain only the common bits between two numbers: s & t
- Union of Two Sets Combine the set bits from two numbers: s | t
- Set Subtraction Remove all bits in 𝑡 from 𝑠: s & ~t
- Extract the Lowest Set Bit Isolate the rightmost bit that is set (1): s & (-s)
- Extract the Lowest Unset Bit Identify the first unset (0) bit from the right: ~s & (s + 1)
- Swap Two Values Without a Temporary Variable Swap two integers 𝑥 and 𝑦 using XOR: x ^= y; y ^= x; x ^= y;

### Runtime Analysis

Analyzing the runtime of algorithms helps us understand their efficiency as input sizes grow. Various notations are used to describe the asymptotic behavior of algorithms:

- **Big O Notation (O)**

  - Big O describes the upper bound of an algorithm’s runtime.
    - It characterizes the worst-case scenario, providing the maximum time an algorithm may take as input size increases.
  - Illustration:
    - Imagine you're delivering packages, and there's unexpected traffic on the route. Big O gives the maximum time it might take for you to complete your deliveries.
    - Example: If sorting an array takes 𝑂(𝑛log𝑛), this means at most 𝑛log𝑛 operations are required, regardless of the specific input arrangement.

- **Little O Notation (o)**

  - Little O also describes an upper bound for an algorithm, but it is not asymptotically tight (i.e., it's an approximation of how the runtime grows).
    - This means it provides a looser constraint compared to Big O.
  - Illustration:
    - You're running a race against time but know you’ll finish faster than an opponent's slowest estimate. Little O tells you the opponent’s slowest runtime without being precise about your actual runtime.
    - Example: If the runtime of an algorithm is 𝑜(𝑛2), it grows slower than 𝑛2 for large input sizes, but it's not as tightly bound.

- **Big Ω (Omega) Notation (Ω)**

  - Big Ω provides an asymptotic lower bound on an algorithm’s runtime.
    - It describes the best-case scenario or the minimum time an algorithm will take for large inputs.
  - Illustration:
    - You're cooking a meal, and some steps (e.g., boiling water) are unavoidable. Big Ω gives the minimum time it will take to complete cooking, no matter how efficiently you handle the other tasks.
    - Example: If searching an unsorted array takes Ω(𝑛), you must inspect at least 𝑛 elements, even in the best case.

- **Little ω (Omega) Notation (ω)**

  - Little ω also provides a lower bound, but it is not asymptotically tight.
    - It represents a looser lower bound compared to Big Ω.
  - Illustration:
    - Think of it as a running track where you know you'll cover more distance than the first lane but aren't sure how far exactly.
    - Example: If an algorithm's runtime is 𝜔(𝑛), it grows faster than 𝑛 for large inputs, but the bound is not precise.

- **Theta (Θ) Notation (Θ)**
  - Theta notation provides a tight bound on an algorithm's runtime.
  - It "sandwiches" the runtime between an upper bound and a lower bound, ensuring both are asymptotically equal for sufficiently large input sizes.
  - Illustration:
    - Imagine a bus schedule that specifies a journey will take between 45 and 60 minutes. Theta guarantees the travel time will stay within this range.
    - Example: If an algorithm has a runtime of Θ(𝑛2), the number of operations is proportional to 𝑛2, both in the best and worst cases.
