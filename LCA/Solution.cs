using ValidateBinaryTree;

namespace LCA
{
    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return null;
            }

            if (root.val == p.val || root.val == q.val)
            {
                return root;
            }

            var left = LowestCommonAncestor(root.left, p, q);
            var right = LowestCommonAncestor(root.right, p, q);

            if (left == null && right == null)
            {
                return null;
            }

            if (left != null || right != null)
            {
                return root;
            }

            return left ?? right;
        }
    }
}