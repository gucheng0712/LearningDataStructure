using System;
namespace List
{
    /// <summary>
    /// Sequence List 是在计算机内存中以数组的形式保存的线性表，是指用一组地址连续的存储单元依次存储数据元素的线性结构。
    /// 
    /// 优点: 容易查找,可以直接通过索引来得到所需要的元素.
    /// 缺点: 在对 Sequence List 进行插入和删除的时候,需要通过移动数据元素来实现,影响运行效率
    /// 
    /// 与之特性相反的数据结构是 LinkedList
    /// </summary>

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
        public SequenceList() : this(10) { } // 默认构造函数容量为10

        // 得到这个元素
        public T this[int index] => GetElement(index);

        //添加一个元素
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

        // 清除所有元素
        public void Clear() { count = 0; }

        // 得到顺序表的长度
        public int GetLength() { return count; }

        // 判断顺序表是否是空的
        public bool IsEmpty() { return count == 0; }

        // 删除指定Index
        public T Delete(int index)
        {
            for (int i = index + 1; i < count; i++)
            {
                data[i - 1] = data[i];
            }
            count--;
            return data[index];

        }

        // 得到指定Index的元素
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


        // 在指定位置插入元素
        public void Insert(T item, int index)
        {
            for (int i = count - 1; i >= index; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = item;
            count++;
        }

        // 通过元素的值, 得到元素的索引
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
