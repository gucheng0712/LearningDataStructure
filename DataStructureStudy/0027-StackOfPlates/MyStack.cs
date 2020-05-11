using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOfPlates
{
    class MyStack
    {
        int capacity;
        public Node<int> top;
        public Node<int> bottom;
        public int size = 0;

        public MyStack(int capacity) { this.capacity = capacity; }

        public bool IsFull()
        {
            return size == capacity;
        }

        public void Join(Node<int> above, Node<int> below)
        {
            if (below != null) below.Above = above;
            if (above != null) above.Below = below;
        }

        public bool Push(int item)
        {
            if (size >= capacity) return false;
            size++;
            Node<int> n = new Node<int>(item);
            if (size == 1) bottom = n; // assign the buttom if size is only 1
            Join(n, top);
            top = n;
            return true;
        }

        public int Pop()
        {
            Node<int> t = top;
            top = top.Below;
            size--;
            return t.Data;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int RemoveBottom()
        {
            Node<int> b = bottom;
            bottom = bottom.Above;
            if (bottom != null)
            {
                bottom.Below = null;
            }
            size--;
            return b.Data;
        }
    }
}
