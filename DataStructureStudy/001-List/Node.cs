using System;
using System.Collections.Generic;
namespace List
{
    public class Node<T> //  单链表的节点
    {
        public T Data { get; set; } // 存储数据
        public Node<T> Next { get; set; } // 指针, 永爱指向下一个元素


        public Node()
        {
            Data = default(T);
            Next = null;
        }

        public Node(T value)
        {
            Data = value;
            Next = null;
        }

        public Node(Node<T> _next) { Next = _next; }


        public Node(T value, Node<T> _next)
        {
            Data = value;
            Next = _next;
        }
    }
}
