namespace SymmetricBinaryTree
{
    using ValidateBinaryTree;

    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            return root == null || IsSymmetric(root.left, root.right);
        }

        private bool IsSymmetric(TreeNode left, TreeNode right)
        {
            bool flag = left == null && right == null;

            if (left != null && right != null && left.val != right.val)
            {
                flag = false;
            }

            if (left != null && right != null)
            {
                return (left.val == right.val) && IsSymmetric(left.right, right.left)
                                               && IsSymmetric(left.left, right.right);
            }

            return flag;
        }
    }
}