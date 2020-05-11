using System;
namespace Stack
{
    public interface IStack<T>
    {
        int Count { get; }

        int GetLength();

        bool IsEmpty();

        void Clear();

        void Push(T item);

        T Pop();

        T Peek();

    }
}
