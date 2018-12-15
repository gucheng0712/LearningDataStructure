using System;
namespace BinaryTree
{
    public class Node
    {
        public int Data { get; set; }

        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public Node Parent { get; set; }

        public Node() { }
        public Node(int item)
        {
            this.Data = item;
        }
    }
}
