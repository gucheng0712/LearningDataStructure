using System;
namespace List
{
    public class SequenceList<T> : IMyList<T>
    {
        private T[] data; // 用来存储数据
        private int count = 0;


        public SequenceList(int size) // Size 是最大容量
        {
            data = new T[size];
            count = 0;
        }

        // 这里的this(10)指的是当你在别的地方创建这个SequenceList的时候如果不设置这个list的容量
        // 系统就会默认设置为一个容量为10 的SequenceList
        public SequenceList() : this(10) // 默认构造函数容量为10
        {

        }

        public T this[int index] => GetElement(index);

        //添加方法
        public void Add(T item)
        {
            if (count == data.Length)
            {
                Console.WriteLine("current sequence list is full");
            }
            else
            {
                data[count] = item;
                count++;
            }
        }

        public void Clear()
        {
            count = 0;
        }

        public int GetLength()
        {
            return count;
        }

        public T Delete(int index)
        {
            for (int i = index + 1; i < count; i++)
            {
                data[i - 1] = data[i];
            }
            count--;
            return data[index];

        }

        public T GetElement(int index)
        {
            if (index >= 0 && index <= count - 1)
            {
                return data[index];
            }
            else
            {
                Console.WriteLine("No this Index");
                return default(T);
            }
        }

        public void Insert(T item, int index)
        {
            for (int i = count - 1; i >= index; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = item;
            count++;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public int Location(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
