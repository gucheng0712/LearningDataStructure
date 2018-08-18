using System;
namespace Queue
{
    public class LinkedQueue<T> : IQueue<T>
    {
        Node<T> front; // 头节点
        Node<T> rear;   // 尾节点
        int count; // 表示元素个数
        public LinkedQueue()
        {
            front = rear = null;
            count = 0;
        }

        public int Count => count;

        public void Clear()
        {
            front = rear = null;
            count = 0;
        }



        public int GetLength()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (count == 0) // 如果队列中没有元素,队首和队尾都是一个新的节点
            {
                front = newNode;
                rear = newNode;
                count = 1;
            }
            else
            {
                rear.Next = newNode;
                newNode = rear;
                count++;
            }
        }

        public T Dequeue()
        {
            if (count == 0)
            {
                Console.WriteLine("队列为空无法出队");
                return default(T);
            }
            else if (count == 1) //如果 队列元素总数为1, 那么就归零
            {
                T temp = front.Data;
                front = rear = null;
                count = 0;
                return temp;
            }
            else // 如果 队列元素总数大于1, 那么 队首就是队首的下一个元素
            {
                T temp = front.Data;
                front = front.Next;
                count--;
                return temp;

            }
        }

        public T Peek()
        {
            if (count != 0)
            {
                return front.Data;
            }
            else
            {
                return default(T);
            }
        }


    }
}
