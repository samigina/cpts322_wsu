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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UniqueIntCounter counter = new UniqueIntCounter { };
            String case1 = "1.HashSet method: " + counter.Counter1().ToString() + " unique numbers" + Environment.NewLine
                + "2.O(1) storage method: " + counter.Counter2().ToString() + " unique numbers" + Environment.NewLine
                + "3.Sorted method: " + counter.Counter3().ToString() + " unique numbers";
            Console.WriteLine(case1);
            textBox1.Text = case1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
