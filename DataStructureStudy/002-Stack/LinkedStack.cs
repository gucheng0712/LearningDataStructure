using System;
namespace Stack
{
    // no need to preset the size of the stack
    public class LinkedStack<T> : IStack<T>
    {
        Node<T> top = new Node<T>();  // 栈顶元素节点
        private int count = 0; // 栈元素个数

        public int Count => count;

        public int GetLength()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Clear()
        {
            count = 0;
            top = null;
        }

        public void Push(T item)
        {
            // 把新添加的元素作为栈顶元素节点
            Node<T> newNode = new Node<T>(item);
            newNode.Next = top;
            top = newNode;
            count++;

        }

        public T Pop()
        {
            // 取的栈顶元素, 然后删除
            T data = top.Data;
            top = top.Next;
            count--;
            return data;
        }

        public T Peek()
        {
            return top.Data;
        }
    }
}
