using System;
using System.Collections.Generic;

namespace LevelOrderO_n_Time
{
    //Bu kodla level order çalışma zamanı O(n) zamana indirgenir. 
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int item)
        {
            data = item;
            left = null;
            right = null;
        }
    }

    public class BinaryTree
    {
        Node root;

        void printLevelOrder()
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {

                Node tempNode = queue.Dequeue();
                Console.Write(tempNode.data + " ");

                if (tempNode.left != null)
                {
                    queue.Enqueue(tempNode.left);
                }

                if (tempNode.right != null)
                {
                    queue.Enqueue(tempNode.right);
                }
            }
        }

        public static void Main()
        {
            BinaryTree tree_level = new BinaryTree();
            tree_level.root = new Node(1);
            tree_level.root.left = new Node(2);
            tree_level.root.right = new Node(3);
            tree_level.root.left.left = new Node(4);
            tree_level.root.left.right = new Node(5);

            Console.WriteLine("Level order traversal " +
                                "of binary tree is - ");
            tree_level.printLevelOrder();
            Console.ReadLine();
        }
    }
}
