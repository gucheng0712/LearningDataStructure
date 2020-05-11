using System;
namespace BinaryTree
{
    public class LinkedBinarySortTree //  可以扩展成泛型
    {
        Node root;

        // 添加数据
        public void Add(int item)
        {
            Node newNode = new Node(item); // 把添加的item,变成一个Node

            // 如果root是空的,那么这个节点就是root
            if (root == null)
            {
                root = newNode;
            }
            else // 如果root不是空的那么就要判断是把这个新的节点放在root的LeftChild 还是 RightChild
            {
                Node temp = root; // 声明一个临时的节点

                while (true)
                {
                    if (item < temp.Data) // 放在 LeftChild
                    {
                        if (temp.LeftChild == null)
                        {
                            temp.LeftChild = newNode;
                            newNode.Parent = temp;
                            break; //终止循环
                        }
                        else
                        {
                            temp = temp.LeftChild; // 如果左节点不是空的,那么把这个临时的节点换成这个节点的 LeftChild 继续死循环
                        }
                    }
                    else // 放在 RightChild
                    {
                        if (temp.RightChild == null)
                        {
                            temp.RightChild = newNode;
                            newNode.Parent = temp;
                            break; //终止循环
                        }
                        else
                        {
                            temp = temp.RightChild; // 如果右节点不是空的,那么把这个临时的节点换成这个节点的 RightChild 继续死循环
                        }
                    }
                }
            }
        }

        // 中序遍历
        public void MiddleTraversal()
        {
            MiddleTraversal(root);
        }
        void MiddleTraversal(Node node)
        {
            if (node == null) return;
            MiddleTraversal(node.LeftChild);
            Console.Write(node.Data + " ");
            MiddleTraversal(node.RightChild);
        }

        // 查找是否树里面包含这个值
        public bool Contains(int item)
        {
            return Contains(item, root);
        }

        bool Contains(int item, Node node)
        {
            return FindMethod1(item, node);
            // return FindMethod2(item, node);
        }

        bool FindMethod1(int item, Node node)
        {
            if (node == null) return false;

            if (node.Data == item) return true;

            // 如果没有找到, 那么就递归查找这个节点的左子节点或者右子节点
            return (item > node.Data) ? Contains(item, node.RightChild) : Contains(item, node.LeftChild);
        }

        bool FindMethod2(int item, Node node)
        {
            Node temp = node;
            while (true)
            {
                if (temp == null) return false;
                if (temp.Data == item) return true;

                // 如果没有找到, 那么就让这个临时的节点等于这个节点的左子节点或者右子节点
                // 然后再循环直到找到这个节点的值等于要查找的值, 如果没找到那么返回false
                temp = (item <= temp.Data) ? temp.LeftChild : temp.RightChild;
            }
        }

        // 在树里删除指定的值
        public bool Remove(int item)
        {
            Node temp = root;
            while (true)
            {
                if (temp == null) return false;
                if (temp.Data == item) // 一直循环直到查找到这个item
                {
                    Remove(temp);
                    return true;
                }

                // 如果没有找到, 那么就让这个临时的节点等于这个节点的左子节点或者右子节点
                // 然后再循环直到找到这个节点的值等于要查找的值, 如果没找到那么返回false
                temp = (item <= temp.Data) ? temp.LeftChild : temp.RightChild;
            }
        }

        void Remove(Node node)
        {
            // 如果node的左右子节点都是 null (叶子节点), 那么 就只要直接删除 
            if (node.LeftChild == null && node.RightChild == null)
            {
                if (node.Parent == null) // 如果这个 Node 没有parent, 那么这个节点就是root, 清除对root的引用的值
                {
                    root = null;
                }

                // 判断Node是Parent的左节点还是右节点,清除Parent对它的引用的值
                if (node.Parent.LeftChild == node)
                {
                    node.Parent.LeftChild = null;
                }
                else if (node.Parent.RightChild == node)
                {
                    node.Parent.RightChild = null;
                }
                return;
            }

            // 如果只有左子节点或者右子节点是null, 
            // 那么就替换 当前node的值为它的存在的子节点的值,并且清除那个子节点的值
            if (node.LeftChild == null && node.RightChild != null)
            {
                node.Data = node.RightChild.Data;
                node.RightChild = null;
                return;
            }
            if (node.LeftChild != null && node.RightChild == null)
            {
                node.Data = node.LeftChild.Data;
                node.LeftChild = null;
                return;
            }

            // 如果左右子节点都不是null, 定义一个temp Node,
            // 并把这个要删除的节点的右子节点赋值给它
            Node temp = node.RightChild;

            // 循环查找到这个右子节点的最左子节点(最小值), 把它赋值给temp
            while (true)
            {
                if (temp.LeftChild != null)
                {
                    temp = temp.LeftChild;
                }
                else
                {
                    break;
                }
            }
            node.Data = temp.Data; // 把找到的值赋值给node的data
            Remove(temp); //在最后在赋值后把temp给删除掉
        }


    }
}
