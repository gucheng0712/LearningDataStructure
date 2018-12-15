using System;
namespace RangeSumOfBST
{
    public class Tree
    {

        TreeNode root;

        // 添加数据
        public void Add(int item)
        {
            TreeNode newNode = new TreeNode(item); // 把添加的item,变成一个Node

            // 如果root是空的,那么这个节点就是root
            if (root == null)
            {
                root = newNode;
            }
            else // 如果root不是空的那么就要判断是把这个新的节点放在root的LeftChild 还是 RightChild
            {
                TreeNode temp = root; // 声明一个临时的节点

                while (true)
                {
                    if (item < temp.val) // 放在 LeftChild
                    {
                        if (temp.left == null)
                        {
                            temp.left = newNode;
                            break; //终止循环
                        }
                        else
                        {
                            temp = temp.left; // 如果左节点不是空的,那么把这个临时的节点换成这个节点的 LeftChild 继续死循环
                        }
                    }
                    else // 放在 RightChild
                    {
                        if (temp.right == null)
                        {
                            temp.right = newNode;
                            break; //终止循环
                        }
                        else
                        {
                            temp = temp.right; // 如果右节点不是空的,那么把这个临时的节点换成这个节点的 RightChild 继续死循环
                        }
                    }
                }
            }
        }

        public int RangeSumBST(int low, int high)
        {
            return RangeSumBST(root, low, high);
        }

        int RangeSumBST(TreeNode node, int L, int R)
        {
            if (node == null) return 0;

            if (node.val >= L && node.val <= R)
            {
                return node.val + RangeSumBST(node.left, L, R) + RangeSumBST(node.right, L, R);
            }
            else
            {
                return RangeSumBST(node.left, L, R) + RangeSumBST(node.right, L, R);
            }
        }
    }
}
