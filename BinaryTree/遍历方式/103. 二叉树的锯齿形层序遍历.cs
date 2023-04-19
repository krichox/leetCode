using System.Collections.Generic;

namespace BinaryTree
{
    public class 二叉树的锯齿形层序遍历 {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
            var result = new List<IList<int>>();
            if(root == null)
            {
                return result;
            }
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);
            var isOrder = true;

            while(queue.Count != 0)
            {
                var count = queue.Count;
                var path = new LinkedList<int>();
                for(var i = 0; i < count; i++)
                {
                    var cur = queue.Dequeue();
                    if(isOrder)
                    {
                        path.AddLast(cur.Val);
                    }else
                    {
                        path.AddFirst(cur.Val);
                    }


                    if(cur.Left != null)
                    {
                        queue.Enqueue(cur.Left);
                    }

                    if(cur.Right != null)
                    {
                        queue.Enqueue(cur.Right);
                    }
                

                }
                isOrder = !isOrder;
                result.Add(new List<int>(path));
            }
            return result;
        }
    }
}