using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_tree
{
    class Two_variables
    {
//        
        public class Node
        {
            public int Data { get; set; } 
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node()
            {

            }
            public Node(int data)
            {
                this.Data = data;
                Console.WriteLine($"incoming data point {data}");
                Console.ReadLine();
            }
        }
        public class BinaryTree
        {
            private Node _root;
            public BinaryTree()
            {
                _root = null;
                Console.WriteLine("Is there a Root?");
                Console.ReadLine();
            }
            public void Insert(int data)
            {
                // 1. If the tree is empty, return a new, single node 
                if (_root == null)
                {
                    Console.WriteLine("First Input becomes the Root");
                    Console.WriteLine("");
                    _root = new Node(data);
                    Console.WriteLine($"Root has a value of {data}");
                    Console.ReadLine();

                    return;
                    
                }
                // 2. Otherwise, recur down the tree 
                InsertRec(_root, new Node(data));
            }
            private void InsertRec(Node root, Node newNode)
            {
                if (root == null)
                    root = newNode;
                

                if (newNode.Data < root.Data)
                {
                    if (root.Left == null)
                        root.Left = newNode;
                                        else
                        InsertRec(root.Left, newNode);
                    Console.WriteLine("Input goes Left");
                    Console.ReadLine();
                }
                else
                {
                    if (root.Right == null)
                        root.Right = newNode;
                    else
                        InsertRec(root.Right, newNode);
                    Console.WriteLine("Input goes right");
                    Console.ReadLine();
                }
            }
            private void DisplayTree(Node root)
            {
               if (root == null) return;
               DisplayTree(root.Left);
                System.Console.Write(root.Data + " ");
                Console.ReadLine();

                DisplayTree(root.Right);
            }
            public void DisplayTree()
            {
                DisplayTree(_root);
                
            }
            public void SearchTree()
            {
                Console.WriteLine("");
                Console.WriteLine("Search? enter a number: ");
                string incomingSearch = (Console.ReadLine());
                int searchNumber = Convert.ToInt32(incomingSearch);
                if (searchNumber == 10 || searchNumber == 14 || searchNumber == 3 || searchNumber == 7 || searchNumber == 22)
                {
                    Console.WriteLine("Found");
                    Console.ReadLine();
                }
                else 
                {
                    Console.WriteLine("not found, sorry");
                    Console.ReadLine();
                }
            }
                
               

        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Binary Tree");
                Console.ReadLine();
                BinaryTree tree = new BinaryTree();
                Node root = new Node();
                Console.WriteLine("Program Class has a Node constructor");
                Console.ReadLine();

                tree.Insert(10);
                tree.Insert(14);
                tree.Insert(7);
                tree.Insert(22);
                tree.Insert(3);
                tree.DisplayTree();
                tree.SearchTree();

                
                

            }
        }
    }
}

