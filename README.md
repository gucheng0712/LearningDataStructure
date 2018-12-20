# LearningDataStructure

## [List](https://github.com/gucheng0712/LearningDataStructure/tree/master/DataStructureStudy/001-List)
The Structure of Sequence List and Linked List

## [Stack](https://github.com/gucheng0712/LearningDataStructure/tree/master/DataStructureStudy/002-Stack)
The Structure of Sequence Stack and Linked Stack


## [Queue](https://github.com/gucheng0712/LearningDataStructure/tree/master/DataStructureStudy/003-Queue)
The Structure of Sequence Stack and Linked Stack


## [String](https://github.com/gucheng0712/LearningDataStructure/tree/master/DataStructureStudy/004-String)
The Structure of String Class


## [InsertSort](https://github.com/gucheng0712/LearningDataStructure/tree/master/DataStructureStudy/005-InsertSort)
Insert sort is a simple sorting algorithm. The principle is to scan the unsorted data from back to front in the sorted sequence, find the corresponding position and insert.
In the process of backward scanning, the sorted elements need to be moved backward step by step repeatedly to provide insertion space for the latest elements.

Time Complexity:

* Average: O (n ^ 2)
* Best: O(n)
* Worst: O (n ^ 2)
    
    
## [SelectSort](https://github.com/gucheng0712/LearningDataStructure/tree/master/DataStructureStudy/006-SelectSort)
Selection sort is a simple sorting algorithm.
It works as follows:
    First, find the smallest (large) element in the unsorted sequence, store it at the beginning of the sorted sequence, then continue to find the smallest (large) element from the remaining unsorted elements, and then put it at the end of the sorted sequence. and so on until all the elements are sorted.
    
Time Complexity:

* O (n ^ 2)


## [QuickSort](https://github.com/gucheng0712/LearningDataStructure/tree/master/DataStructureStudy/007-QuickSort)
QuickSort used a strategy called ***Divide & Conquer***. 
The basic principle of Divide&Conquer is to decompose the problem into servial smaller sub-problems with similar structure to the original problem. Solve these subproblems recursively, and then combine the solutions of these subproblems into the solutions of the original problem.

Divide & Conquer can be used to divide quicksort into 3 steps:

1. Select an Element as the "pivot" int the data set.
2. All elements less than the "pivot" are moved to the left of the "pivot"; All elements larger than the "pivot" are moved to the right of the "pivot".
3. For the left and right subsets of "pivot", repeat step 1 and step 2 until only one element is left in all subsets.

Time Complexity:

* Average: O (nlogn)
* Best: O (nlogn)
* Worst: O (n ^ 2)


## [MergeSort](https://github.com/gucheng0712/LearningDataStructure/tree/master/DataStructureStudy/008-MergeSort)
Merge-Sort is an effective sorting algorithm established on merge operations. This algorithm is a typical application of Divide & Conquer.
The Principle of the Merge-Sort is to merge the ordered subsequences to get a completely ordered sequence.
Firstly, make each sub-sequence orderly, and then make the sub-sequence segments orderly

Time Complexity:

* Average: O (nlogn)
* Best: O (nlogn)
* Worst: O (nlogn)

## [HeapSort](https://github.com/gucheng0712/LearningDataStructure/tree/master/DataStructureStudy/017-BinaryHeap)
Heap-Sort is a kind of Selection sort method. It is not Stabled. Mainly used for forming and processing priority queues.

The Principle of the Heap Sort is think the sorting array as the sequential storage structure of a complete binary tree, and the internal relationship between parent nodes and child nodes in the complete binary tree is utilized to select the record with the largest or smallest keyword in the current disordered area.

Time Complexity:
* Average:O(nlog2n)
* Best: O(nlog2n)
* Wirst O(nlog2n)


## [BinaryTree](https://github.com/gucheng0712/LearningDataStructure/tree/master/DataStructureStudy/014-BinaryTree)
A Binary Tree is a finite set of n nodes, which can be an empty set (called an empty binary tree), or a root node and a binary tree of two disjoint nodes, called the left subtree of the root node and the right subtree respectively.

Binary tree traversal refers to starting from the root node, in some order to access all nodes in the binary tree, so that each node is accessed once.
Include:
1.  Preorder Traversal (前序遍历)      ( node - left - right ) 
2.  Inorder Traversal (中序遍历)        ( left - node - right ) 
3. PostOrder Traversal (后序遍历)    ( left - right - node ) 
4. LevelOrder Traversal(存序遍历)    从树的第一层开始，从上到下逐层遍历，在同一层中，从左到右对结点 逐个访问输出.

Binary sort tree, also known as binary search tree. It's either an empty tree, or a binary tree with the following properties.
If its left subtree is not empty, the value of all nodes in the left subtree is less than the value of the root structure;
If its right subtree is not empty, the value of all nodes on the right alphanter is greater than the value of its root node;
Its left and right subtrees are also binary sort trees

Characteristics:
1. Easy sorting
2. Easy to find
3. easy to insert and delete


## [FindLargestSubArray](https://github.com/gucheng0712/LearningDataStructure/tree/master/DataStructureStudy/009-FindLargestSubArray)
Find the largest sub array in a array:

1. Violent Method
2. Divide & Conquer Method



## [EncodingAndDecoding](https://github.com/gucheng0712/LearningDataStructure/tree/master/DataStructureStudy/010-EncodeAndDecode)

Question: Design the encode and decode methods. There is no restriction on how your encode/decode algorithm should work. You just need to ensure that a string can be encoded to a a code and the code can be decoded to the original URL.


## [MaxStack](https://github.com/gucheng0712/LearningDataStructure/tree/master/DataStructureStudy/011-MaxStack)
    
Question: Design a max stack that supports push, pop, peek, peekMax and popMax.

1. push(x) -- Push element x onto stack.
2. pop() -- Remove the element on top of the stack and return it.
3. peek() -- Get the element on the top.
4. peekMax() -- Retrieve the maximum element in the stack.
5. popMax() -- Retrieve the maximum element in the stack, and remove it. If you find more than one maximum elements, only remove the top-most one.


## [Unique Morse Code Words](https://github.com/gucheng0712/LearningDataStructure/tree/master/DataStructureStudy/012-UniqueMorseCodeWords)

Question: International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows: "a" maps to ".-", "b" maps to "-...", "c" maps to "-.-.", and so on.

For convenience, the full table for the 26 letters of the English alphabet is given below:
[".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",
".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]


Now, given a list of words, each word can be written as a concatenation of the Morse code of each letter.  For example, "cba" can be written as "-.-..--...", (which is the concatenation "-.-." + "-..." + ".-").  We'll call such a concatenation, the transformation of a word. Return the number of different transformations among all words we have.

Example:
* Input: words = ["gin", "zen", "gig", "msg"]
* Output: 2
* Explanation: 
* The transformation of each word is:
1. "gin" -> "--...-."
2. "zen" -> "--...-."
3. "gig" -> "--...--."
4. "msg" -> "--...--."

There are 2 different transformations, "--...-." and "--...--.".

Note:
* The length of words will be at most 100.
* Each words[i] will have length in range [1, 12].
* words[i] will only consist of lowercase letters.



## [UniqueEmailAddresses](https://github.com/gucheng0712/LearningDataStructure/tree/master/DataStructureStudy/013-UniqueEmailAddresses)

Question: Every email consists of a local name and a domain name, separated by the @ sign. For example, in alice@leetcode.com, alice is the local name, and leetcode.com is the domain name. Besides lowercase letters, these emails may contain '.'s or '+'s.

If you add periods ('.') between some characters in the local name part of an email address, mail sent there will be forwarded to the same address without dots in the local name.   For example, "alice.z@leetcode.com" and "alicez@leetcode.com" forward to the same email address.  (Note that this rule does not apply for domain names.)

If you add a plus ('+') in the local name, everything after the first plus sign will be ignored. This allows certain emails to be filtered, for example m.y+name@email.com will be forwarded to my@email.com. (Again, this rule does not apply for domain names.)
It is possible to use both of these rules at the same time.

Given a list of emails, we send one email to each address in the list.  How many different addresses actually receive mails? 

Example 1:

* Input: ["test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"]
* Output: 2
* Explanation: "testemail@leetcode.com" and "testemail@lee.tcode.com" actually receive mails


Note:

* 1 <= emails[i].length <= 100
* 1 <= emails.length <= 100
* Each emails[i] contains exactly one '@' character.


## [HammingDistance](https://github.com/gucheng0712/LearningDataStructure/tree/master/DataStructureStudy/015-HammingDistance)
Question: The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
Given two integers x and y, calculate the Hamming distance.

Note:
* 0 ≤ x, y < 231.

Example:
* Input: x = 1, y = 4
* Output: 2
* Explanation:
* 1   (0 0 0 1)
* 4   (0 1 0 0)
* ↑   ↑

The above arrows point to positions where the corresponding bits are different.


## [RangeSumOfBST](https://github.com/gucheng0712/LearningDataStructure/tree/master/DataStructureStudy/016-RangeSumOfBST)
Given the root node of a binary search tree, return the sum of values of all nodes with value between L and R (inclusive).
The binary search tree is guaranteed to have unique values.

Example 1:
* Input: root = [10,5,15,3,7,null,18], L = 7, R = 15
* Output: 32

Example 2:
* Input: root = [10,5,15,3,7,13,18,1,null,6], L = 6, R = 10
* Output: 23
