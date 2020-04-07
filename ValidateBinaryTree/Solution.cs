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

            if (node.val >= maxVal || node.val <= minVal)
            {
                return false;
            }

            return IsValidBST(node.right, node.val, maxVal)
                   && IsValidBST(node.left, minVal, node.val);
        }
    }
}