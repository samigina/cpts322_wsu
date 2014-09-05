// Author:
//    Ruofei Xu
// Class:
//    A BST tree class and BST node class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
    //create a BST node class for BST 
    public class BSTNode
    {
        public int Data;
        public BSTNode Left;
        public BSTNode Right;

        public BSTNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
        
    }

    //BST
    public class BST
    {
        //declare the root and a counter variable
        public BSTNode root;
        public int counter;

        public BST()
        {
            root = null;
            counter = 0;
        }

        //Add method
        public void Add(int value)
        {
            //add on the root if there is no node
            if(null == root)
            {
                root = new BSTNode(value);
                counter++;
            }
            else
            {
                BSTNode current_node = root;
                while(true)
                {
                    //if the value already existed, then skip this value
                    if(value == current_node.Data)
                    {
                        return;
                    }
                    //if the value smaller than current node and left node is null, then add this value to left
                    else if(value < current_node.Data && null == current_node.Left)
                    {
                        BSTNode new_node = new BSTNode(value);
                        current_node.Left = new_node;
                        counter++;
                        return;
                    }
                    //if the value larger then curren node and right node is null, then add this value to right
                    else if(value > current_node.Data && null == current_node.Right)
                    {
                        BSTNode new_node = new BSTNode(value);
                        current_node.Right = new_node;
                        counter++;
                        return;
                    }
                    //if the value smaller than curent node replace current node to left node
                    else if(value < current_node.Data)
                    {
                        current_node = current_node.Left;
                    }
                    //if the value larger than curent node replace current node to right node
                    else if(value > current_node.Data)
                    {
                        current_node = current_node.Right;
                    }
                    //just in case for debug
                    else
                    {
                        Console.WriteLine("Unexpected result.");
                        return;
                    }
                }
            }
        }

        //get tree's height method
        public int GetHeight(BSTNode current_node)
        {
            //if no node then height is 0
            if(null == root)
            {
                return 0;
            }
            //if leaf node then height is 1
            else if(null == current_node.Left && null == current_node.Right)
            {
                return 1;
            }
            //recursively find the height
            else if(null == current_node.Left)
            {
                return GetHeight(current_node.Right) + 1;
            }
            else if(null == current_node.Right)
            {
                return GetHeight(current_node.Left) + 1;
            }
            else
            {
                return Math.Max(GetHeight(current_node.Left) + 1, GetHeight(current_node.Right) + 1);
            }
        }

        //a method for printing value in ascending order
        public void PrintInAscending(BSTNode current_node)
        {
            //print this infromation if just start
            if(root.Data == current_node.Data)
            {
                Console.Write("Tree contents: ");
            }
            //print the value if it's a leaf node
            if(null == current_node.Left && null == current_node.Right)
            {
                Console.Write("{0} ", current_node.Data);
                return;
            }
            //recursively print all int in ascending
            else if(null == current_node.Left)
            {
                Console.Write("{0} ", current_node.Data);
                PrintInAscending(current_node.Right);
                return;
            }
            else if(null == current_node.Right)
            {
                PrintInAscending(current_node.Left);
                Console.Write("{0} ", current_node.Data);
                return;
            }
            else
            {
                PrintInAscending(current_node.Left);
                Console.Write("{0} ", current_node.Data);
                PrintInAscending(current_node.Right);
                return;
            }
        }

        // a method for getting the lowest height
        public int GetLowestHeight()
        {
            return (int)Math.Ceiling(Math.Log(counter + 1,2));
        }
    }

}
