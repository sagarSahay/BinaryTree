using System;
using System.Collections.Generic;
using ValidateBinaryTree;

namespace ZigzagLevelOrder
{
    using System.Linq;

    public class Solution
    {
        private List<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> ZigzagOrder(TreeNode input)
        {
            if (input == null)
            {
                return result;
            }

            var queue = new Queue<(TreeNode, int)>();
            queue.Enqueue((input, 0));
            result.Add(new List<int>() {input.val});
            var flag = false;
            var dict = new Dictionary<int, List<int>>();
            dict.Add(0, new List<int>() {input.val});
            while (queue.Count > 0)
            {
                var ls = new List<int>();
                var (node, level) = queue.Dequeue();
                level += 1;
                if (node.right != null)
                {
                    ls.Add(node.right.val);
                    queue.Enqueue((node.right, level));
                }

                if (node.left != null)
                {
                    ls.Add(node.left.val);
                    queue.Enqueue((node.left, level));
                }

                if (dict.ContainsKey(level))
                {
                    dict[level].AddRange(ls);
                }
                else
                {
                    dict.Add(level, ls);
                }


                if (ls.Count > 0)
                {
                    // if (flag && result.Count > level)
                    // {
                    //     ls.Reverse();
                    // }
                    //
                    // result.Insert(level, ls);
                    flag = !flag;
                }
            }

            var f1 = false;
            foreach (var keyval in dict)
            {
                if (!f1)
                {
                    result.Add(keyval.Value);
                    f1 = true;
                }
                else
                {
                    f1 = false;
                    
                    result.Add(keyval.Value);
                }
            }

            return result;
        }
    }
}