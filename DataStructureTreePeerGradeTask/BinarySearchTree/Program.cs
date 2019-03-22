using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TreeNode> nodes;

            Treevalues treevalues = new Treevalues();

            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter Root Number:");

            nodes = new List<TreeNode>();

            int value = Convert.ToInt32(Console.ReadLine());
            Tree tree = new Tree(value);

            while (true)
            {
                
                Console.WriteLine("Enter Input, Remove or Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "Input":
                        Console.WriteLine("Enter New Node:");

                        int node = Convert.ToInt32(Console.ReadLine());
                        nodes.Add(new TreeNode(node));

                        break;
                    case "Remove":
                        int index = Convert.ToInt32(Console.ReadLine());
                        
                        break;
                    case "Exit":
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
