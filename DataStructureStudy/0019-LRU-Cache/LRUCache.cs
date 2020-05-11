using System;
using System.Collections.Generic;
using System.Text;

namespace LRU_Cache
{
    public class LRUCache
    {
        class Node
        {
            public int key;
            public int val;

            public Node next;
            public Node prev;
        }

        // 虚拟的头节点
        Node head;
        //虚拟的尾节点
        Node tail;

        //缓存字典
        Dictionary<int, Node> cache = new Dictionary<int, Node>();

        int size;
        int capacity;

        // 初始化
        public LRUCache(int capacity)
        {
            this.size = 0;
            this.capacity = capacity;
            head = new Node();
            tail = new Node();
            head.next = tail;
            tail.prev = head;
        }

        // 根据key得到value， 然后把这个节点移动到虚拟头节点的后面
        public int Get(int key)
        {
            Node node = GetCacheValue(key);
            if (node == null)
                return -1;

            MoveToFirst(node);
            return node.val;
        }

        // 添加一个新的缓存，并判断容量，如果超出了容量，那么就把虚拟尾节点的prev一处
        public void Put(int key, int value)
        {
            Node node = null;
            cache.TryGetValue(key, out node);

            if (node == null)
            {
                Node newNode = new Node();
                newNode.key = key;
                newNode.val = value;
                cache.Add(key, newNode);
                AddNode(newNode);
                size++;
                if (size > capacity)
                {
                    //pop tail
                    Node tail = PopLast();
                    cache.Remove(tail.key);
                    size--;
                }
            }
            else
            {
                node.val = value;
                MoveToFirst(node);
            }
        }

        Node GetCacheValue(int key)
        {
            Node node = null;
            cache.TryGetValue(key, out node);
            return node;
        }

        void MoveToFirst(Node node)
        {
            RemoveNode(node);
            AddNode(node);
        }

        //Pop the current tail.
        Node PopLast()
        {
            Node node = tail.prev;
            RemoveNode(node);

            return node;
        }

        // Always add the new node right after head.
        void AddNode(Node node)
        {
            node.prev = head;
            node.next = head.next;

            head.next.prev = node;
            head.next = node;
        }

        void RemoveNode(Node node)
        {
            Node prev = node.prev;
            Node next = node.next;
            prev.next = next;
            next.prev = prev;
        }


    }

}
