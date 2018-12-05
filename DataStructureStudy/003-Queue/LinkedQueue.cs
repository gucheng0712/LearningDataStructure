using System;
namespace Queue
{
    public class LinkedQueue<T> : IQueue<T>
    {
        Node<T> front; // 头节点
        Node<T> rear;   // 尾节点

        public int Count { get; private set; }

        public LinkedQueue()
        {
            front = rear = null;
            Count = 0;
        }


        public void Clear()
        {
            front = rear = null;
            Count = 0;
        }

        public int GetLength() { return Count; }

        public bool IsEmpty() { return Count == 0; }

        public T Peek() { return (Count != 0) ? front.Data : default(T); }

        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (Count == 0) // 如果队列中没有元素,队首和队尾都是一个新的节点
            {
                front = newNode;
                rear = newNode;
                Count = 1;
            }
            else
            {
                rear.Next = newNode;
                newNode = rear;
                Count++;
            }
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                Console.WriteLine("队列为空无法出队");
                return default(T);
            }
            else if (Count == 1) //如果 队列元素总数为1, 那么就归零
            {
                T temp = front.Data;
                front = rear = null;
                Count = 0;
                return temp;
            }
            else // 如果 队列元素总数大于1, 那么 队首就是队首的下一个元素
            {
                T temp = front.Data;
                front = front.Next;
                Count--;
                return temp;
            }
        }



    }
}
