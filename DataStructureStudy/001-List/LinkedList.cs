using System;
namespace List
{
    public class LinkedList<T> : IMyList<T>
    {
        private Node<T> head;

        public LinkedList()
        {
            head = null;
        }

        public T this[int index] => GetElement(index);

        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item); // 根据新的数据创建一个新的节点
            if (head == null) // 如果头结点为空, 那么这个新的节点就是头节点
            {
                head = newNode;
            }
            else //  把新的节点放到链表的尾部
            {
                // 访问链表的尾节点
                Node<T> temp = head;
                while (true)
                {
                    if (temp.Next != null) // 如果这个temp的后一个节点不是null, 那么就一直赋值给后一个节点的后一个节点
                    {
                        temp = temp.Next;
                    }
                    else // 如果这个temp的后一个节点是null, 那么表示这个temp就在最后一个节点了, 要跳出死循环
                    {
                        break;
                    }
                }
                temp.Next = newNode;// 把新节点加到末尾

            }

        }

        public void Clear()
        {
            head = null;
        }

        public T Delete(int index) // 和插入原理类似
        {
            T data = default(T);
            if (index == 0)
            {
                data = head.Data;
                head = head.Next;
            }
            else
            {
                Node<T> temp = head;
                for (int i = 1; i < index; i++)
                {
                    temp = temp.Next;
                }
                Node<T> preNode = temp;
                Node<T> curNode = temp.Next;
                data = curNode.Data;
                Node<T> nextNode = curNode.Next;
                preNode.Next = nextNode;
            }
            return data;
        }

        public T GetElement(int index)
        {
            Node<T> temp = head;
            for (int i = 1; i <= index; i++)
            {
                temp = temp.Next;
            }
            return temp.Data;
        }

        public int GetLength()
        {
            if (head == null) return 0;
            Node<T> temp = head;
            int count = 1;
            while (true)
            {
                if (temp.Next != null)
                {
                    count++;
                    temp = temp.Next;
                }
                else
                {
                    break;
                }
            }
            return count;
        }

        public void Insert(T item, int index)
        {
            Node<T> newNode = new Node<T>(item);
            if (index == 0) // 如果插入到头节点
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                for (int i = 1; i < index; i++) //新建一个head的temp索引,把到索引位置的node 向后移动一位
                {
                    temp = temp.Next;
                }
                Node<T> curNode = temp.Next; // 然后当前index的node 则是temp node 的下一个node
                Node<T> preNode = temp; // 上一个index 的node,则是temp node

                // 上一个node的下一个node就是要新插入的newNode
                preNode.Next = newNode;
                // 新插入的node的下一个node 就是当前索引的Node
                newNode.Next = curNode;
            }
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public int Location(T value)
        {
            if (head == null) //如果头结点为空
            {
                return -1;
            }
            else
            {
                Node<T> temp = head;
                int index = 0;
                while (true)
                {
                    if (temp.Data.Equals(value))
                    {
                        return index;
                    }
                    else
                    {
                        if (temp.Next != null)
                        {
                            temp = temp.Next;
                            index++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                return -1;
            }
        }
    }
}
