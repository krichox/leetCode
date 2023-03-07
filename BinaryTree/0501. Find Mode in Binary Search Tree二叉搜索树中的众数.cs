using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace BinaryTree
{
    
    public class Find_Mode_in_Binary_Search_Tree二叉搜索树中的众数
    {
        public int[] FindMode(TreeNode root)
        {
            var dic = new Dictionary<int, int>();
            inOrder(root, dic);

            var maxNum = dic.OrderByDescending(x => x.Value).First().Value;
            return dic.Where(x => x.Value == maxNum).Select(y => y.Key).ToArray();
        }

        public void inOrder(TreeNode root, Dictionary<int, int> dic)
        {
            if (root == null)
            {
                return;
            }

            inOrder(root.Left, dic);
            if (!dic.ContainsKey(root.Val))
            {
                dic.Add(root.Val, 1);
            }
            else
            {
                dic[root.Val]++;
            }

            inOrder(root.Right, dic);
        }
        
        
        
        
        
        
        
        List<int> result = new List<int>();
        TreeNode pre = null;
        int maxCount = 0;
        int count = 0;
    
        public int[] FindMode2(TreeNode root) {
            FindMaxNum(root);

            return result.ToArray();
        }

        public void FindMaxNum(TreeNode root)
        {
            if(root == null)
            {
                return;
            }

            FindMaxNum(root.Left);
            var curValue = root.Val;
            if(pre == null || curValue != pre.Val)
            {
                count = 1;
            }
            else
            {
                count++;
            }

            if(maxCount < count)
            {
                result.Clear();
                result.Add(curValue);
                maxCount = count;
            }else if(maxCount == count)
            {
                result.Add(curValue);
            }

            pre = root;

            FindMaxNum(root.Right);
        }
    }
}