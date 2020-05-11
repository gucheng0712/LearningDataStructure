using System;
namespace List
{
    /// <summary>
    /// Linked list 是线性表中的另外一种存储结构-- Linked Storage, 这样的表叫 Linked List
    /// Linked List 是由节点组成的, 不要求逻辑上响铃的元素在物理存储位置上也相邻, 是无序的
    /// 
    /// 优点: 在插入和删除元素时不需要移动数据元素
    /// 缺点: 不便于查找, 因为是无序的, 不能通过 Index 来查找.
    /// </summary>
    public class LinkedList<T> : IMyList<T>
    {
        Node<T> head;

        public LinkedList() { head = null; }

        // 通过Index得到元素
        public T this[int index] => GetElement(index);

        // 通过Index得到元素
        public T GetElement(int index)
        {
            Node<T> temp = head;
            for (int i = 1; i <= index; i++)
            {
                temp = temp.Next;
            }
            return temp.Data;
        }

        //添加一个元素
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

        // 清空 Linked List
        public void Clear() { head = null; }

        // 删除指定索引的元素
        public T Delete(int index) // 和插入原理类似
        {
            T data = default(T);

            // 如果 要插入的index 是 0, 那么需要返回的数据就是 Node 的 头结点, 然后头节点就是头节点的Next节点
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

        // 得到LinkedList 的长度
        public int GetLength()
        {
            if (head == null) return 0; // 如果头结点是Null, 那直接返回长度为0

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

        // 插入元素到指定的Index
        public void Insert(T item, int index)
        {
            Node<T> newNode = new Node<T>(item);
            if (index == 0) // 如果插入到头节点,这个newNode 就是头结点, 把头结点向后移
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

                // 把上一个 Node 的指针指向 newNode
                preNode.Next = newNode;
                // 把 newNode 的指针指向目前的 Node
                newNode.Next = curNode;
            }
        }

        // 判断是否为空
        public bool IsEmpty() { return head == null; }

        // 通过值得到索引
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
