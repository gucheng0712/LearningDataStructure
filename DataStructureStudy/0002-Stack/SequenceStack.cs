using System;
namespace Stack
{
    public class SequenceStack<T> : IStack<T>
    {
        T[] data;
        int top;

        // array implement stack needs preset the size of the stack
        public SequenceStack(int size)
        {
            data = new T[size];
            top = -1; // 表示没有指向任何的元素
        }
        public SequenceStack() : this(10) { }

        public int Count => top + 1;

        public void Clear() { top = -1; }

        public int GetLength() { return Count; }

        public bool IsEmpty() { return Count == 0; }

        public T Peek() { return data[top]; }

        public void Push(T item) { data[++top] = item; }

        public T Pop()
        {
            T temp = data[top];
            top--;
            return temp;
        }
    }
}
