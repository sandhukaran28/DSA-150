# DSA-150: Data Structures & Algorithms Problem Set

A comprehensive collection of **150+ Data Structures and Algorithms problems** implemented in **C#**, organized by topic for systematic interview preparation and algorithmic mastery.

## 📋 Table of Contents

- [Overview](#overview)
- [Directory Structure](#directory-structure)
- [Topics Covered](#topics-covered)
- [Problem Breakdown by Category](#problem-breakdown-by-category)
- [Getting Started](#getting-started)
- [How to Use This Repository](#how-to-use-this-repository)
- [Problem Categories](#problem-categories)
- [Complexity Analysis](#complexity-analysis)
- [Contributing](#contributing)

---

## 🎯 Overview

This repository contains a curated collection of LeetCode-style problems and classic DSA challenges, all solved in C#. It's designed to help with:

- **Technical Interview Preparation** - Companies like FAANG (Meta, Apple, Amazon, Netflix, Google)
- **Algorithm Mastery** - Deep understanding of core algorithmic patterns
- **Data Structure Proficiency** - Implementation and usage of fundamental data structures
- **Coding Practice** - Consistent problem-solving across diverse topics

**Total Problems**: 150+  
**Language**: C#  
**Difficulty Levels**: Easy, Medium, Hard

---

## 📁 Directory Structure

```
DSA-150/
├── Arrays & Hashing/           (24 problems)
├── Binary Search/              (12 problems)
├── DP/                         (8 problems)
├── Graphs/                     (Empty - ready for contribution)
├── Hashmap & hashset/          (7 problems)
├── Linked List/                (14 problems)
├── Miscellaneous/              (4 problems)
├── Recursion & BackTracking/   (13 problems)
├── Revision/                   (In progress)
├── Sliding Window/             (10 problems)
├── Stacks/                     (7 problems)
├── Strings/                    (11 problems)
├── trees/                      (14 problems)
├── Two Pointers/               (7 problems)
└── README.md                   (This file)
```

---

## 🔥 Topics Covered

### 1. **Arrays & Hashing** (24 problems)
Fundamental array manipulations and hash table implementations.

**Key Problems:**
- `Two_Sum.cs` - Classic two-pointer/hash table problem
- `Contains_Duplicate.cs` - Duplicate detection using sets
- `Product_Of_Array_Except_Self.cs` - Array manipulation without division
- `Top_K_Frequent_Elements.cs` - Heap/sorting problems
- `Longest_Consecutive_Sequence.cs` - Optimal sequencing with hashing
- `Valid_Sudoko.cs` - Constraint satisfaction
- `Group_Anagrams.cs` - String grouping
- `Three_Sum.cs` - Multi-pointer technique
- `Best_Time_To_Buy_&_Sell_Stocks.cs` - Transaction optimization
- `First_Missing_Positive.cs` - In-place array manipulation

**Concepts**: Hash Maps, Hash Sets, Two Pointers, Prefix Sums, Arrays

---

### 2. **Binary Search** (12 problems)
Efficient searching in sorted data structures.

**Key Problems:**
- `Binary_Search.cs` - Classic binary search
- `Find_Peak_Element.cs` - Peak finding in unsorted arrays
- `Find_Min_in_rotated_sorted_array.cs` - Rotation handling
- `Koko_Eating_Bananas.cs` - Binary search on answer
- `Median_Of_Sorted_Arrays.cs` - Advanced binary search
- `Search_2D_Array.cs` - 2D matrix searching
- `Guess_Number_Higher_Or_Lower.cs` - Interactive search
- `Time_Based_Key_Value_Store.cs` - Timestamped data search

**Concepts**: Binary Search, Search Space Optimization, Monotonic Properties

---

### 3. **Dynamic Programming** (8 problems)
Optimization through memoization and tabulation.

**Key Problems:**
- `Climbing_Stairs.cs` - Classic DP base case
- `House_Robber.cs` - Linear DP
- `House_Robber_II.cs` - Circular constraint handling
- `Longest_Palindrone.cs` - String palindrome detection
- `decode_ways.cs` - Counting interpretations
- `Maximum_Product_Subarray.cs` - State tracking with constraints
- `Min_Cost_Climbing_Stairs.cs` - Cost optimization
- `Palindrone Substrings.cs` - Substring enumeration

**Concepts**: Memoization, Tabulation, State Transitions, Optimization

---

### 4. **Graphs** (Currently Empty)
Ready for graph algorithm implementations including BFS, DFS, Dijkstra's, etc.

---

### 5. **Hashmap & Hashset** (7 problems)
Hash-based data structure applications.

**Key Problems:**
- `Group_Anagrams.cs` - Character frequency mapping
- `Happy_Number.cs` - Cycle detection
- `Isomorphic_Strings.cs` - Pattern matching
- `Ransom_Note.cs` - Character availability checking
- `Top_K_Frequent_Elements.cs` - Frequency-based problems
- `Valid_Sudoko.cs` - Constraint validation

**Concepts**: Hash Maps, Hash Sets, Collision Handling, Frequency Analysis

---

### 6. **Linked List** (14 problems)
Pointer manipulation and list traversal.

**Key Problems:**
- `Reverse_Linked_List.cs` - Basic reversal
- `Merge_Two_Sorted_Linked_List.cs` - List merging
- `Linked_List_Cycle.cs` - Cycle detection (Floyd's algorithm)
- `Linked_List_Cycle_II.cs` - Cycle origin detection
- `Remove_nth_node_from_end_of_list.cs` - Two-pass traversal
- `Middle_of_linked_list.cs` - Slow-fast pointer
- `Add_Two_Numbers.cs` - List arithmetic
- `Palindrone_Linked_List.cs` - Palindrome checking
- `Copy_Linked_List_With_Random_Pointer.cs` - Deep copy with extra pointers
- `Intersection_of_two_linked_list.cs` - Intersection detection
- `Reorder_Linked_List.cs` - List restructuring
- `Revere_Nodes_in_k_group.cs` - K-group reversal

**Concepts**: Pointers, Two-Pointer Technique, Fast-Slow Pointers, List Manipulation

---

### 7. **Miscellaneous** (4 problems)
Standalone problems that don't fit standard categories.

**Problems:**
- `Find_the Difference.cs` - Character difference finding
- `Find_Unique_Character_in_string.cs` - Uniqueness detection
- `Majority_element.cs` - Majority element (Boyer-Moore voting)
- `Reverse_Vowels_Of_string.cs` - String manipulation

---

### 8. **Recursion & BackTracking** (13 problems)
Recursive problem solving with constraint satisfaction.

**Key Problems:**
- `Combination_Sum.cs` - Unlimited combination selection
- `Combination_Sum_II.cs` - Limited combination selection
- `Permutations.cs` - All permutation generation
- `Subsets.cs` - All subset generation
- `Subsets_II.cs` - Subset generation with duplicates
- `N_Queens.cs` - Classic NxN queens placement
- `Palindrone_Partitioning.cs` - Palindrome splitting
- `Word_Search.cs` - Grid word search
- `Sudoko_Solver.cs` - Constraint satisfaction problem
- `Letter_Combination_Of_Phone_number.cs` - Digit-to-letter mapping
- `Generate parenthesis.cs` - Valid parenthesis generation
- `Fibonacci.cs` - Recursive sequence
- `Climbing_Stairs.cs` - Alternative recursive approach

**Concepts**: Backtracking, Recursion, State Space Exploration, Pruning

---

### 9. **Sliding Window** (10 problems)
Efficient subarray/substring problems using the sliding window technique.

**Key Problems:**
- `Longest_Substring_Without_Repeating_Characters.cs` - Character window
- `Minimum_Window_Substring.cs` - Pattern window
- `Permutation_in_a_string.cs` - Substring permutation
- `Longest_Repeating_Charcter_Replacement.cs` - Character replacement
- `Maximun_Avg_Subarray_1.cs` - Average subarray
- `Maximum_Subarray.cs` - Subarray sum (Kadane's algorithm)
- `Minimim_Size_Subarray_Sum.cs` - Minimum length subarray
- `Sliding_Window_Maximum.cs` - Window maximum tracking
- `Best_Time_to_Buy_and_Sell_Stock.cs` - Transaction optimization
- (Duplicate in Arrays & Hashing)

**Concepts**: Sliding Window, Two Pointers, Window Contraction/Expansion

---

### 10. **Stacks** (7 problems)
LIFO data structure applications.

**Key Problems:**
- `Valid_Parenthesis.cs` - Bracket matching
- `Min_Stack.cs` - Stack with minimum tracking
- `Evaluate_Reverse_polish_notation.cs` - RPN expression evaluation
- `Generate_Parenthesis.cs` - Valid parenthesis generation
- `Car_Fleet.cs` - Fleet merging simulation
- `Daily Temperatures.cs` - Temperature span calculation
- `Implement_Queue.Using_Stack.cs` - Queue implementation with stacks

**Concepts**: Stack Data Structure, LIFO, Monotonic Stacks

---

### 11. **Strings** (11 problems)
String manipulation and pattern matching.

**Key Problems:**
- `Isomorphic_Strings.cs` - Character mapping
- `Palindrone_Partitioning.cs` - Palindrome splitting
- `Valid_Anagram.cs` - Anagram validation
- `Additive_Number.cs` - Additive number validation
- `Palindrone_Subsequences.cs` - Palindrome subsequences
- `Longest_Happy_String.cs` - Happy string generation
- `Different ways to Add paranthesis.cs` - Expression evaluation
- `Minimum Remove to Make Valid Parentheses.cs` - Parenthesis removal
- `Number_of_wonderful_strings.cs` - Wonderful string counting
- `Split_Two_Strings_To_Make_Palindrone.cs` - String splitting
- `Strings_Equivalent.cs` - String equivalence checking

**Concepts**: String Manipulation, Pattern Matching, Character Analysis

---

### 12. **Trees** (14 problems)
Binary tree and binary search tree problems.

**Key Problems:**
- `Invert_Binary_Tree.cs` - Tree inversion
- `Maximum_Depth_Of_Binary_Tree.cs` - Tree height
- `Same_Tree.cs` - Tree equality
- `Subtree_Of_Another_Tree.cs` - Subtree matching
- `Balanced_Binary_Tree.cs` - Balance checking
- `Diameter_Of_Binary_Tree.cs` - Longest path
- `Valid_Binary_Search_Tree.cs` - BST validation
- `Kth_Small_Int_BST.cs` - K-th smallest in BST
- `LCS_in_Binary_Tree.cs` - Lowest common ancestor
- `Construct_Binary_tree_From_Inorder_&_preorder_traversal.cs` - Tree reconstruction
- `Binary_Tree_Level_Order_Traversal.cs` - BFS traversal
- `Binary_Tree_Right_Side_View.cs` - Right view traversal
- `Count_Good_Nodes_in_Binary_Tree.cs` - Node counting with conditions
- `Path_Sum.cs` - Path sum verification

**Concepts**: Tree Traversal, DFS, BFS, Tree Construction, BST Properties

---

### 13. **Two Pointers** (7 problems)
Efficient pointer manipulation techniques.

**Key Problems:**
- `Two_Sum.cs` - Sorted array two-sum
- `Three_Sum.cs` - Three-sum problem
- `Container_With_Most_Water.cs` - Maximum container area
- `Trapping_Water.cs` - Water trapping calculation
- `Valid_Palindrone.cs` - Palindrome validation with special characters
- `Reverse_String.cs` - String reversal
- `Remove_Nth_Node_from_last.cs` - List node removal

**Concepts**: Two Pointers, Pointer Convergence, Array Partitioning

---

## 📊 Problem Breakdown by Category

| Category | Count | Difficulty | Focus |
|----------|-------|-----------|-------|
| Arrays & Hashing | 24 | Mixed | Foundation |
| Binary Search | 12 | Medium | Optimization |
| DP | 8 | Medium-Hard | Optimization |
| Graphs | 0 | - | (Coming Soon) |
| Hashmap & Hashset | 7 | Easy-Medium | Data Structures |
| Linked List | 14 | Medium | Pointers |
| Miscellaneous | 4 | Easy-Medium | Utility |
| Recursion & BackTracking | 13 | Medium-Hard | Algorithms |
| Revision | - | - | Review |
| Sliding Window | 10 | Medium | Optimization |
| Stacks | 7 | Easy-Medium | Data Structures |
| Strings | 11 | Medium | Manipulation |
| Trees | 14 | Medium-Hard | Data Structures |
| Two Pointers | 7 | Easy-Medium | Techniques |
| **TOTAL** | **142+** | - | - |

---

## 🚀 Getting Started

### Prerequisites
- **.NET Framework** (4.7.2+) or **.NET Core** (3.1+)
- **C# Compiler** (included with Visual Studio or .NET SDK)
- **Visual Studio Code** or **Visual Studio** IDE (recommended)

### Setup

1. **Clone the Repository**
   ```bash
   git clone https://github.com/sandhukaran28/DSA-150.git
   cd DSA-150
   ```

2. **Open in Visual Studio Code**
   ```bash
   code .
   ```

3. **Or Open in Visual Studio**
   - Open Visual Studio
   - File → Open Folder → Select `DSA-150`

### Compilation & Execution

**Using .NET CLI:**
```bash
# Navigate to a specific problem directory
cd "Arrays & Hashing"

# Compile a specific problem
csc Two_Sum.cs

# Run the compiled program
.\Two_Sum.exe
```

**Using Visual Studio:**
- Open the `.cs` file
- Press `Ctrl+F5` to run without debugging

---

## 💡 How to Use This Repository

### 1. **Sequential Learning Path**
Start with foundational concepts and progress to advanced topics:
```
Start Here:
1. Arrays & Hashing
2. Two Pointers
3. Hashmap & Hashset
4. Strings
5. Stacks
6. Linked List
7. Sliding Window
8. Binary Search
9. Trees
10. Recursion & BackTracking
11. DP
12. Graphs (Coming Soon)
```

### 2. **Topic-Based Study**
Focus on specific areas:
- **Want to master arrays?** → Study the `Arrays & Hashing` folder
- **Need binary search?** → Focus on `Binary Search` folder
- **Studying for interviews?** → Practice all folders systematically

### 3. **Difficulty-Based Progression**
- **Easy**: Start with simple problems to understand patterns
- **Medium**: Consolidate your understanding with real problems
- **Hard**: Challenge yourself and learn advanced techniques

### 4. **Review & Revision**
- Use the `Revision` folder to review previously learned concepts
- Practice similar problems from different categories

---

## 📝 Problem Categories & Patterns

### Pattern-Based Organization

**Optimization Problems:**
- Binary Search
- Sliding Window
- DP
- Two Pointers

**Search & Traversal:**
- Trees
- Graphs (Coming)
- Recursion & BackTracking

**Data Structure Manipulation:**
- Linked List
- Strings
- Arrays

**Constraint Satisfaction:**
- Recursion & BackTracking
- Stacks
- Strings

---

## ⏱️ Complexity Analysis Guide

### Time Complexities Encountered

| Complexity | Examples | Optimal Use |
|-----------|----------|------------|
| O(1) | Hash lookup, Stack pop | Direct access |
| O(log n) | Binary search, Balanced BST | Sorted data |
| O(n) | Linear search, Array traversal | Single pass |
| O(n log n) | Merge sort, Sort + search | Sorting required |
| O(n²) | Bubble sort, Nested loops | Small datasets |
| O(2ⁿ) | Permutations, Subsets | Exponential growth |
| O(n!) | All permutations | Factorially expensive |

### Space Complexities

| Complexity | Examples | Use Case |
|-----------|----------|----------|
| O(1) | In-place algorithms | Memory-constrained |
| O(log n) | Recursion depth | Binary search trees |
| O(n) | Hash maps, Arrays | Typical approach |
| O(n²) | 2D DP arrays | Dynamic programming |

---

## 🔧 Key Algorithmic Techniques

### 1. **Two Pointers**
- Converging pointers from ends
- Used in: Arrays, Linked Lists, Strings

### 2. **Sliding Window**
- Moving window of fixed/variable size
- Used in: Strings, Subarrays, Substrings

### 3. **Fast & Slow Pointers**
- Detecting cycles, finding midpoint
- Used in: Linked Lists, Arrays

### 4. **Binary Search**
- Search in sorted data
- Variations: Search for value, first occurrence, last occurrence

### 5. **Backtracking**
- Explore all possibilities with constraint checking
- Used in: Permutations, Combinations, Subsets, NP-complete

### 6. **Dynamic Programming**
- Memoization & Tabulation
- Used in: Optimization problems, Counting problems

### 7. **Prefix Sum / Suffix Sum**
- Precompute aggregates
- Used in: Range queries, Product calculations

### 8. **Monotonic Structures**
- Stacks for maintaining order
- Used in: Temperature problems, Stock problems

---

## 📈 Interview Preparation Guide

### Recommended Study Schedule

**Week 1-2: Fundamentals**
- Arrays & Hashing (Complete)
- Two Pointers (Complete)
- Strings (Complete)

**Week 3: Data Structures**
- Hashmap & Hashset (Complete)
- Stacks (Complete)
- Linked List (Chapters 1-7)

**Week 4: Advanced Data Structures**
- Linked List (Complete)
- Trees (Complete)

**Week 5-6: Algorithms**
- Sliding Window (Complete)
- Binary Search (Complete)
- Recursion & BackTracking (Complete)

**Week 7-8: Optimization**
- DP (Complete)
- Graphs (When added)
- Mixed problem solving

**Week 9-10: Mock Interviews & Revision**
- Practice full problem sets under time constraints
- Review weak areas

---

## ✅ Best Practices

1. **Understand Before Coding**
   - Read problem carefully
   - Identify patterns and techniques
   - Plan approach before writing code

2. **Test Thoroughly**
   - Test with base cases (empty, single element)
   - Test with edge cases (duplicates, negatives, zero)
   - Test with large inputs (performance)

3. **Optimize Iteratively**
   - Brute force first for understanding
   - Then optimize for time
   - Then optimize for space

4. **Document Your Approach**
   - Add comments explaining logic
   - Note time and space complexity
   - Document edge cases handled

5. **Practice Consistently**
   - Daily: 1-2 problems (30-45 min)
   - Weekly: Review and repeat previous topics
   - Monthly: Full mock interviews

---

## 🎓 Learning Resources

### Recommended External Resources
- **LeetCode**: https://leetcode.com (Problem source)
- **NeetCode**: https://neetcode.io (Video explanations)
- **GeeksforGeeks**: https://www.geeksforgeeks.org (Tutorials)
- **InterviewBit**: https://www.interviewbit.com (Interview prep)
- **GitHub**: Search for "[language]-solutions" for multiple approaches

### C# Specific
- **Official C# Docs**: https://docs.microsoft.com/en-us/dotnet/csharp/
- **LeetCode C# Solutions**: Filter solutions by C# language

---

## 📚 Problem Difficulty Reference

### Easy (Foundation Building)
- Two Sum (warm-up)
- Contains Duplicate
- Valid Anagram
- Reverse String
- Palindrome Validation (basic)

### Medium (Core Interview Questions)
- Product of Array Except Self
- Group Anagrams
- Longest Substring Without Repeating Characters
- Merge Sorted Arrays
- House Robber
- Palindrome Partitioning

### Hard (Advanced Mastery)
- First Missing Positive
- Median of Two Sorted Arrays
- LCS in Binary Tree
- Sudoku Solver
- N-Queens
- Word Search with constraints

---

## 🤝 Contributing

### How to Contribute

1. **Add Solutions**: Contribute solutions for empty categories (Graphs)
2. **Optimize**: Provide better solutions with improved complexity
3. **Document**: Add problem explanations and approach guides
4. **Fix Issues**: Report and fix bugs or typos
5. **Add Tests**: Create unit tests for solutions

### Contribution Guidelines
- Follow C# coding standards
- Add XML documentation comments
- Include complexity analysis in comments
- Test before submitting
- Reference problem sources (LeetCode, HackerRank, etc.)

### Example Contribution Format
```csharp
/// <summary>
/// Solves [Problem Name] in O(n log n) time and O(n) space
/// 
/// Approach:
/// - [Step 1]
/// - [Step 2]
/// 
/// Time: O(n log n)
/// Space: O(n)
/// 
/// Problem: https://leetcode.com/problems/[problem-url]
/// </summary>
public class Solution {
    public int YourMethod(int[] nums) {
        // Implementation
    }
}
```

---

## 📞 Contact & Support

- **Repository**: https://github.com/sandhukaran28/DSA-150
- **Issues**: Report bugs and request features via GitHub Issues
- **Discussions**: Engage with the community for problem solving tips

---

## 📜 License

This repository is provided for educational purposes. All solutions are original implementations unless otherwise noted.

---

## 🎉 Acknowledgments

This repository is inspired by:
- LeetCode's problem categories
- NeetCode's curated problem lists
- Industry best practices for technical interviews

---

## 📊 Repository Statistics

- **Total Problems**: 142+
- **Implementation Language**: C#
- **Categories**: 14
- **Difficulty Levels**: Easy, Medium, Hard
- **Last Updated**: [Current Date]
- **Status**: Active & Growing

---

## 🚀 Quick Start Commands

```bash
# View all categories
dir

# View problems in a category
dir "Arrays & Hashing"

# Compile and run a solution
cd "Arrays & Hashing"
csc Two_Sum.cs && Two_Sum.exe

# Search for a specific problem
Get-ChildItem -Recurse -Filter "*Two_Sum*"
```

---

## ⭐ Don't Forget To

- ⭐ **Star this repository** if you found it helpful
- 🔔 **Watch for updates** when new problems are added
- 🤝 **Contribute** solutions or improvements
- 📢 **Share** with others preparing for technical interviews

---

**Happy Coding! 🎯**

*Remember: Consistent practice beats occasional intensity. Aim for daily problem-solving rather than marathon sessions.*

