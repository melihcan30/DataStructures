using System;

namespace PostorderPreorderInorder
{
    // Postorder, Preorder, Inorder kodları 
    public class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        Node root;

        BinaryTree(int key)
        {
            root = new Node(key);
        }

        BinaryTree()
        {
            root = null;
        }

        void printPostorder(Node node)
        {
            if (node == null)
                return;

            printPostorder(node.left);
            printPostorder(node.right);

            Console.Write(node.key + " ");
        }

        void printInorder(Node node)
        {
            if (node == null)
                return;

            printInorder(node.left);

            Console.Write(node.key + " ");

            printInorder(node.right);
        }

        void printPreorder(Node node)
        {
            if (node == null)
                return;

            Console.Write(node.key + " ");

            printPreorder(node.left);
            printPreorder(node.right);
        }

        void printPostorder() { printPostorder(root); }
        void printInorder() { printInorder(root); }
        void printPreorder() { printPreorder(root); }

        public static void Main(String[] args)
        {
            BinaryTree tree = new BinaryTree();

            tree.root = new Node(3);
            tree.root.left = new Node(2);
            tree.root.right = new Node(4);
            tree.root.left.left = new Node(1);
            tree.root.right.right = new Node(5);

            Console.WriteLine("Preorder düzenlemesi " + "binary tree ");
            tree.printPreorder();
            Console.WriteLine("\nInorder düzenlemesi " + "binary tree ");
            tree.printInorder();
            Console.WriteLine("\nPostorder düzenlemesi " + "binary tree ");
            tree.printPostorder();
            Console.ReadLine();
        }
    }
}
