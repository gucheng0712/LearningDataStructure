using System;
namespace Queue
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T _data)
        {
            Data = _data;
        }

    }
}
