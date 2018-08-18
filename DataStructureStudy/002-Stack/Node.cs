using System;
namespace Stack
{
    public class Node<T>
    {
        private T data;
        private Node<T> next;

        public Node()
        {
            data = default(T);
            next = null;
        }
        public Node(T _data)
        {
            data = _data;
            next = null;
        }
        public Node(Node<T> _next)
        {
            data = default(T);
            next = _next;
        }
        public Node(T _data, Node<T> _next)
        {
            data = _data;
            next = _next;
        }

        public T Data { get { return data; } set { data = value; } }
        public Node<T> Next { get { return next; } set { next = value; } }
    }
}
