using System;
namespace Queue
{
    public class SequenceQueue<T> : IQueue<T>
    {
        private T[] data;
        private int count;  //表示当前有多少个元素
        private int front; //对首 = 对首的元素index - 1
        private int rear;  //对尾 = 对尾元素index

        public SequenceQueue(int size)
        {
            data = new T[size];
            count = 0;
            front = -1;
            rear = -1;
        }
        public SequenceQueue() : this(10)
        {

        }


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
            front = rear = -1;
        }

        public void Enqueue(T item)
        {
            // 首先要检查队列是否满
            if (count == data.Length)
            {
                Console.WriteLine("队列已满,不可以再添加新的数据");
            }
            else//如果队列并没有满
            {
                //如果队尾在data数组的末尾,则形成循环,把末尾的队列放到队首
                if (rear == data.Length - 1) // 
                {
                    data[0] = item;
                    rear = 0;
                    count++;
                }
                else// 如果不是在末尾,则直接把enqueue的对象加到队尾的后面一个
                {
                    data[++rear] = item;
                    count++;
                }
            }
        }

        public T Dequeue()
        {
            // 首先检查队列数是否大于0
            if (count > 0)
            {
                T temp = data[++front]; // ++队首后赋值给temp来输出
                count--;
                return temp;
            }
            else
            {
                Console.WriteLine("队列为空,无法取得队首的数据");
                return default(T);
            }
        }



        public T Peek()
        {
            if (count > 0)
            {
                T temp = data[front + 1]; // 不需要变动count或者队首的index 直接输出
                return temp;
            }
            else
            {
                Console.WriteLine("队列为空,无法取得队首的数据");
                return default(T);
            }
        }
    }
}
