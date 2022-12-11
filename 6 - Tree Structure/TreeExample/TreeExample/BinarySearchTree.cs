using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TreeExample
{
    public class BinarySearchTree
    {
        //Using the sort that has the containment of the data to insert to the tree
        public QuickSort sort; 

        //Containing the value of the node and the branches on where to look at
        public Node root;

        public BinarySearchTree()
        {
            root = null;
            sort = new QuickSort();
        }

        //This is mainly here to compare how the binary search tree when it's sorted vs unsorted
        public void CanSort(bool option)
        {
            if(option)
            {
                sort.SortData();
            }
        }

        public Node ReturnNode()
        {
            return root;
        }

        //Inserting each value into the node and placing to either the left or right side of the parent
        public void Insert(int x)
        {
            Node newNode = new Node();
            newNode.value = int.Parse(sort.ScoreData[x]);
            if(root == null) 
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while(true)
                {
                    parent = current;
                    if (int.Parse(sort.ScoreData[x]) < current.value)
                    {
                        current = current.leftNode;
                        if(current == null)
                        {
                            parent.leftNode = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightNode;
                        if(current == null)
                        {
                            parent.rightNode = newNode;
                            return;
                        }
                    }
                }
            }
        
        }


        public void PreOrder(Node n)
        {
            if(n != null)
            {
                Console.Write(n.value + " ");
                PreOrder(n.leftNode);
                PreOrder(n.rightNode);
            }
        }

        public void InOrder(Node n)
        {
            if(n != null) 
            {
                InOrder(n.leftNode);
                Console.Write(n.value + " ");
                InOrder(n.rightNode);
            }
        }

        public void PostOrder(Node n)
        {
            if(n != null)
            {
                PostOrder(n.leftNode);
                PostOrder(n.rightNode);
                Console.Write(n.value + " ");
            }
        }
    }

    public class Node
    {
        public int value;
        public Node leftNode;
        public Node rightNode;
    }

}
