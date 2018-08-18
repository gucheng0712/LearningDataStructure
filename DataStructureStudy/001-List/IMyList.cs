using System;
namespace List
{
    interface IMyList<T>
    {
        int GetLength();
        void Clear();
        bool IsEmpty();
        void Add(T item);
        void Insert(T item, int index);
        T Delete(int index);
        T this[int index] { get; }
        T GetElement(int index);
        int Location(T value);

    }
}
