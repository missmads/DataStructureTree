using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        //The root
        private TreeNode root;

        public Tree(int value)
        {
            if (value != null)
                this.root = new TreeNode(value);
        }
    }

    public class TreeNode
    {
        // Contains the value of the node
        private int value;
        // Shows whether the current node has a parent or not
        private bool hasParent;
        // Contains the children of the node (zero or more)
        private List<TreeNode> children;
        // Constructs a tree node, "value" is the value of the node
        public TreeNode(int value)

        {
            if (value != null)
            {
                this.value = value;
                this.children = new List<TreeNode>();
            }
        }

        public void AddChild(TreeNode child)
        {
            child.hasParent = true;
            this.children.Add(child);
        }

        public TreeNode GetChild(int index)
        {
            return children[index];
        }
    }
}
