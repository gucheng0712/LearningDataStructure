using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOfPlates
{
    public class Node<T>
    {
        private T data;
        private Node<T> above;
        private Node<T> below;

        public Node()
        {
            data = default(T);
            above = null;
        }
        public Node(T _data)
        {
            data = _data;
            above = null;
        }
        public Node(Node<T> _next)
        {
            data = default(T);
            above = _next;
        }
        public Node(T _data, Node<T> _next)
        {
            data = _data;
            above = _next;
        }

        public T Data { get { return data; } set { data = value; } }
        public Node<T> Above { get { return above; } set { above = value; } }
        public Node<T> Below { get { return below; } set { below = value; } }
    }
}
