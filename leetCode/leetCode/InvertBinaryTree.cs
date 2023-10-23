using Microsoft.Azure.Cosmos.Linq;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using System;


namespace leetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }


        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            TreeNode tmp = new TreeNode();

            tmp = root.left;

            root.left = root.right;
            
            root.right = tmp;

            this.InvertTree(root.left);
            this.InvertTree(root.right);

            return root;

        }

    }
}
