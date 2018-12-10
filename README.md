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
