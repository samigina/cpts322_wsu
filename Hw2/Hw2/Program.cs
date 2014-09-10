// Author:
//    Ruofei Xu 
/* ID:11237005
 * Created by SharpDevelop.
 * User: Evan
 * Date: 9/7/2014
 * 
 * Cpts hw2
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }

    class UniqueIntCounter
    {
        private List<int> num_list = new List<int> { };
        private Random int_generater = new Random { };
        private int size = 10000;
        private int max = 20000;
        private int min = 0;

        public UniqueIntCounter()
        {
             for(int index = 0; index < size; index++)
             {
                 int new_number = int_generater.Next(min, max);
                 num_list.Add(new_number);
             }
        }

        public int Counter1()
        {
            HashSet<int> num_set = new HashSet<int> { }; //O(1)

            foreach(int num in num_list) //O(1)
            {
                num_set.Add(num); //O(1)
            }
            return num_set.Count;
        }

        public int Counter2()
        {
            int counter = 0;

            for (int index = 0; index < size; index++ )
            {
                if(index < size - 1)
                {
                    if(num_list.IndexOf(num_list[index], index + 1) == -1)
                    {
                        counter++;
                    }
                }
                else
                {
                    counter++;
                }
            }
                return counter;
        }
        public int Counter3()
        {
            int counter = 1;
            num_list.Sort();

            for (int index = 0; index < size - 1; index++ )
            {
                if(num_list[index] != num_list[index + 1])
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
