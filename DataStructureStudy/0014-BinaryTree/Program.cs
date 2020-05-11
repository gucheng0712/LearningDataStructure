using System;

namespace BinaryTree
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // SequenceBinaryTreeTraversal();

            LinkedBinarySortTree linkedBinarySortTree = new LinkedBinarySortTree();
            int[] data = { 62, 58, 88, 47, 73, 99, 35, 51, 93, 37 };

            foreach (var t in data)
            {
                linkedBinarySortTree.Add(t);
            }
            linkedBinarySortTree.MiddleTraversal();
            Console.WriteLine();

            Console.WriteLine(linkedBinarySortTree.Contains(99));
            Console.WriteLine(linkedBinarySortTree.Contains(100));

            linkedBinarySortTree.Remove(35);
            linkedBinarySortTree.MiddleTraversal();
            Console.WriteLine();
            linkedBinarySortTree.Remove(62);
            linkedBinarySortTree.MiddleTraversal();
            Console.WriteLine();
        }



        static void SequenceBinaryTreeTraversal()
        {
            //这个是要存储到二叉树的数
            char[] data = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            SequenceBinaryTree<char> sequenceBinaryTree = new SequenceBinaryTree<char>(10);

            for (int i = 0; i < data.Length; i++)
            {
                sequenceBinaryTree.Add(data[i]);
            }

            sequenceBinaryTree.PreorderTraversal();
            Console.WriteLine();
            sequenceBinaryTree.InorderTraversal();
            Console.WriteLine();
            sequenceBinaryTree.PostorderTraversal();
            Console.WriteLine();
            sequenceBinaryTree.LevelOrderTraversal();
        }
    }
}
