namespace SymmetricBinaryTree
{
    using ValidateBinaryTree;

    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            return root == null || IsSymmetric(root.Left, root.Right);
        }

        private bool IsSymmetric(TreeNode left, TreeNode right)
        {
            bool flag = left == null && right == null;

            if (left != null && right != null && left.Val != right.Val)
            {
                flag = false;
            }

            if (left != null && right != null)
            {
                return (left.Val == right.Val) && IsSymmetric(left.Right, right.Left)
                                               && IsSymmetric(left.Left, right.Right);
            }

            return flag;
        }
    }
}