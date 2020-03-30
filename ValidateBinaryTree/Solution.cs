namespace ValidateBinaryTree
{
    public class Solution
    {
        public bool IsValidBST(TreeNode node)
        {
            return IsValidBST(node, long.MinValue, long.MaxValue);
        }

        private bool IsValidBST(TreeNode node, long minVal, long maxVal)
        {
            if (node == null)
            {
                return true;
            }

            if (node.Val >= maxVal || node.Val <= minVal)
            {
                return false;
            }

            return IsValidBST(node.Right, node.Val, maxVal)
                   && IsValidBST(node.Left, minVal, node.Val);
        }
    }
}