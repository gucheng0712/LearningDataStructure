using System;
using System.Collections.Generic;
namespace List
{
    public class Node<T> //  单链表的节点
    {
        private T data;
        private Node<T> next; // 用于指向下一个元素
        public T Data { get { return data; } set { data = value; } }
        public Node<T> Next { get { return next; } set { next = value; } }


        public Node()
        {
            data = default(T);
            next = null;
        }

        public Node(T value)
        {
            data = value;
            next = null;
        }
        public Node(Node<T> _next)
        {
            next = _next;
        }
        public Node(T value, Node<T> _next)
        {
            data = value;
            next = _next;
        }
    }
}
