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


## [Unique Morse Code Words]()

International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows: "a" maps to ".-", "b" maps to "-...", "c" maps to "-.-.", and so on.

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



## [UniqueEmailAddresses]()

Every email consists of a local name and a domain name, separated by the @ sign. For example, in alice@leetcode.com, alice is the local name, and leetcode.com is the domain name. Besides lowercase letters, these emails may contain '.'s or '+'s.

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
