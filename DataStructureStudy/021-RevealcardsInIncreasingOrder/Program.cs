/*
In a deck of cards, every card has a unique integer. You can order the deck in any order you want.

Initially, all the cards start face down (unrevealed) in one deck.

Now, you do the following steps repeatedly, until all cards are revealed:

Take the top card of the deck, reveal it, and take it out of the deck.
If there are still cards in the deck, put the next top card of the deck at the bottom of the deck.
If there are still unrevealed cards, go back to step 1. Otherwise, stop.
Return an ordering of the deck that would reveal the cards in increasing order.

The first entry in the answer is considered to be the top of the deck.

Example 1:
    Input: [17,13,11,2,3,5,7]
    Output: [2,13,3,11,5,17,7]
    Explanation: 
    We get the deck in the order [17,13,11,2,3,5,7] (this order doesn't matter), and reorder it.
    After reordering, the deck starts as [2,13,3,11,5,17,7], where 2 is the top of the deck.
    We reveal 2, and move 13 to the bottom.  The deck is now [3,11,5,17,7,13].
    We reveal 3, and move 11 to the bottom.  The deck is now [5,17,7,13,11].
    We reveal 5, and move 17 to the bottom.  The deck is now [7,13,11,17].
    We reveal 7, and move 13 to the bottom.  The deck is now [11,17,13].
    We reveal 11, and move 17 to the bottom.  The deck is now [13,17].
    We reveal 13, and move 17 to the bottom.  The deck is now [17].
    We reveal 17.
    Since all the cards revealed are in increasing order, the answer is correct.

Note:
    1 <= A.length <= 1000
    1 <= A[i] <= 10^6
    A[i] != A[j] for all i != j
    
这道题对我来说是有点难的，刚开始看懂题目之后完全没有任何思路。经过google一番，看了别人一个解题思路。这个思路的核心是映射关系。

这个题目可以简化为以下描述：给定一个序列，经过一个操作算法，变为另一个序列，已知操作算法和结果序列，求原序列。

如果我们知道每个元素的初始位置，那么就很容易摆回原来的样子了。
所以我们需要将元素与原来的位置进行绑定。
如何绑定？很简单，我们模拟这个跟随过程，我们将原来的位置也看成一个序列进行相同的算法操作，这样元素原来的位置也就跟着走了。
然后我们根据每个元素的位置，将其放回原来的位置就得到了原序列。
*/

using System;
using System.Collections.Generic;

namespace RevealcardsInIncreasingOrder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] input = { 17, 13, 11, 2, 3, 5, 7 };
            int[] output = DeckRevealedIncreasing(input);
            foreach (var o in output)
            {
                Console.Write(o + " ");
            }
        }

        public static int[] DeckRevealedIncreasing(int[] deck)
        {
            int len = deck.Length;
            int[] map = new int[len]; // 用于映射索引的数组
            int[] res = new int[len]; // 结果

            Queue<int> queue = new Queue<int>(); //用队列来模拟抓牌放牌过程

            // 给队列添加索引
            for (int i = 0; i < deck.Length; i++)
                queue.Enqueue(i);


            int index = 0; // 用于映射的索引
            for (int i = 0; queue.Count > 0; i++)
            {
                if (i % 2 == 0)
                    map[index++] = queue.Dequeue();
                else
                    queue.Enqueue(queue.Dequeue());
            }

            Array.Sort(deck); // 排序deck数组
            for (int i = 0; i < len; i++)
            {
                res[map[i]] = deck[i];
            }
            return res;
        }
    }
}
