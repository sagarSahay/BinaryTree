namespace BinaryTreeMaximumSumPath
{
    using System;
    using ValidateBinaryTree;

    public class Solution
    {
        int maxSum = Int32.MinValue;
        public int MaxPathSum(TreeNode input)
        {
            max_gain(input);
            return maxSum;
        }

        private int max_gain(TreeNode input)
        {
            if (input == null)
            {
                return 0;
            }

            var leftGain = Math.Max(max_gain(input.Left), 0);
            var rightGain = Math.Max(max_gain(input.Right), 0);

            maxSum = Math.Max(input.Val + leftGain + rightGain, maxSum);

            return input.Val + Math.Max(leftGain, rightGain);
        }
    }
}