using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {


        static void Main(string[] args)
        {
            Tree.TreeNode<string> root = Tree.MakeTree();
            //PrintTree(root);

            Console.WriteLine(Tree.GetHeight(root));
        }
    }
}
