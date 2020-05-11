using System;
namespace BinaryTree
{
    public class SequenceBinaryTree<T>
    {
        T[] data;
        int count;

        public SequenceBinaryTree(int capacity)// 这个参数是当前二叉树的容量
        {
            data = new T[capacity];
        }

        public void Add(T item)
        {
            if (count >= data.Length) return;// 限制容量

            data[count] = item;
            count++;
        }

        public void PreorderTraversal()
        {
            PreorderTraversal(0);
        }

        // 前序遍历
        void PreorderTraversal(int index)
        {
            if (index >= count) return;

            // 得到需要遍历的节点的编号
            int number = index + 1;
            if (data[index].Equals(-1)) return; // 当这个数为空的话, 返回
            Console.Write(data[index] + " ");

            int leftNumber = number * 2; // 得到左节点的编号
            int rightNumber = number * 2 + 1; // 得到右节点的编号

            PreorderTraversal(leftNumber - 1);// 递归 左节点
            PreorderTraversal(rightNumber - 1);// 递归 右节点
        }

        public void InorderTraversal()
        {
            InorderTraversal(0);
        }
        // 中序遍历
        void InorderTraversal(int index)
        {
            if (index >= count) return;

            // 得到需要遍历的节点的编号
            int number = index + 1;
            if (data[index].Equals(-1)) return; // 当这个数为空的话, 返回
            // 得到左节点的编号
            int leftNumber = number * 2;

            int rightNumber = number * 2 + 1;

            InorderTraversal(leftNumber - 1);
            Console.Write(data[index] + " ");
            InorderTraversal(rightNumber - 1);
        }

        public void PostorderTraversal()
        {
            PostorderTraversal(0);
        }

        // 后序遍历
        void PostorderTraversal(int index)
        {
            if (index >= count) return;

            // 得到需要遍历的节点的编号
            int number = index + 1;
            if (data[index].Equals(-1)) return;// 当这个数为空的话, 返回
            // 得到左节点的编号
            int leftNumber = number * 2;

            int rightNumber = number * 2 + 1;

            InorderTraversal(leftNumber - 1);
            InorderTraversal(rightNumber - 1);
            Console.Write(data[index] + " ");
        }

        // 层序遍历
        public void LevelOrderTraversal()
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(-1)) continue;// 当这个数为空的话, 掉过这一个index 继续遍历
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
