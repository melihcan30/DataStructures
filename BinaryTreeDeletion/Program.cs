using System;
using System.Collections.Generic;

namespace BinaryTreeDeletion
{
    class Binary
    {
        //Kodlar tam değildir!!
        public class Node
        {
            public int key;
            public Node left, right;

            // Constructor 
            public Node(int key)
            {
                this.key = key;
                left = null;
                right = null;
            }
        }

        Node root;
        
        

        // Inorder traversal of a binary tree 
        void inorder(Node temp)
        {
            temp = root;
            if (temp == null)
                return;

            inorder(temp.left);
            Console.WriteLine(temp.key + " ");
            inorder(temp.right);
        }

        // Function to delete deepest 
        // element in binary tree 
        public void DeleteDeepest(Node root,
                                Node delNode)
        {
            Queue<Node> q = new LinkedList<Node>();
            q.add(root);

            Node temp = null;

            // Do level order traversal until last node 
            while (!q.isEmpty())
            {
                temp = q.peek();
                q.remove();

                if (temp == delNode)
                {
                    temp = null;
                    return;

                }
                if (temp.right != null)
                {
                    if (temp.right == delNode)
                    {
                        temp.right = null;
                        return;
                    }
                    else
                        q.add(temp.right);
                }

                if (temp.left != null)
                {
                    if (temp.left == delNode)
                    {
                        temp.left = null;
                        return;
                    }
                    else
                        q.add(temp.left);
                }
            }
        }

        // Function to delete given element 
        // in binary tree 
        static void delete(Node root, int key)
        {
            if (root == null)
                return;

            if (root.left == null &&
            root.right == null)
            {
                if (root.key == key)
                    return;
                else
                    return;
            }

            Queue<Node> q = new LinkedList<Node>();
            q.add(root);
            Node temp = null, keyNode = null;

            // Do level order traversal until 
            // we find key and last node. 
            while (!q.isEmpty())
            {
                temp = q.peek();
                q.remove();

                if (temp.key == key)
                    keyNode = temp;

                if (temp.left != null)
                    q.add(temp.left);

                if (temp.right != null)
                    q.add(temp.right);
            }

            if (keyNode != null)
            {
                int x = temp.key;
                DeleteDeepest(root, temp);
                keyNode.key = x;
            }
        }

        // Driver code 
        public static void main(String args[])
        {
            root = new Node(10);
            root.left = new Node(11);
            root.left.left = new Node(7);
            root.left.right = new Node(12);
            root.right = new Node(9);
            root.right.left = new Node(15);
            root.right.right = new Node(8);

            Console.WriteLine("Inorder traversal " +
                            "before deletion:");
            inorder(root);

            int key = 11;
            delete(root, key);

            Console.WriteLine("\nInorder traversal " +
                            "after deletion:");
            inorder(root);
        }
    }
}
