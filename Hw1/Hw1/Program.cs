// Author:
//    Ruofei Xu
/*
 * Created by SharpDevelop.
 * User: Ruofei
 * Date: 8/29/2014
 * Time: 1:28 PM
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a tree and a string for input
            BST bst_tree = new BST { };
            string line = string.Empty;

            //get input number and split by space
            Console.Write("Enter a collection of numbers in the range [0,100], separated by spaces: ");
            line = Console.ReadLine();
            string[] num_arr = line.Split(' ');

            //add each int to the tree
            foreach(string num_str in num_arr)
            {
                int new_num = 0;
                new_num = Convert.ToInt32(num_str);
                bst_tree.Add(new_num);
            }

            //output the expected result
            bst_tree.PrintInAscending(bst_tree.root);
            Console.WriteLine("\nTree statistics:");
            Console.WriteLine("  Number of nodes: {0}", bst_tree.counter);
            Console.WriteLine("  Number of levers: {0}", bst_tree.GetHeight(bst_tree.root));
            Console.WriteLine("  Minimum number of levels that a tree with {0} nodes could have = {1}", bst_tree.counter, bst_tree.GetLowestHeight());
            Console.WriteLine("Done");
            Console.ReadKey();
            return;
        }
    }
}
