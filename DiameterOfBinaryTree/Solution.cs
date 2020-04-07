using System;
using ValidateBinaryTree;

namespace DiameterOfBinaryTree
{
    public class Solution
    {
        public int DiameterOfBinaryTree(TreeNode root) 
        {
            if (root == null)
            {
                return 0;
            }

            var leftHeight = getHeight(root.left);
            var rightHeight = getHeight(root.right);

            var leftDiameter = DiameterOfBinaryTree(root.left);
            var rightDiameter = DiameterOfBinaryTree(root.right);

            return Math.Max(1 + leftHeight + rightHeight, Math.Max(leftDiameter, rightDiameter)) -1;
        }

        private int getHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var left = getHeight(root.left);
            var right = getHeight(root.right);

            if (left > right)
            {
                return 1 + left;
            }

            return 1 + right;
        }
    }
}