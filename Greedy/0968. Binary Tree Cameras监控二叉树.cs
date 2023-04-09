using BinaryTree;

namespace Greedy
{
    /*https://leetcode.cn/problems/binary-tree-cameras/*/
    public class Binary_Tree_Cameras监控二叉树
    {
        int result = 0;

        public int MinCameraCover(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }


            if (IsCameraNode(root) == 0)
            {
                result++;
            }


            return result;
        }

        // 定义状态
        //0：无覆盖
        //1: 有摄像机
        //2. 有覆盖 
        int IsCameraNode(TreeNode root)
        {
            // end condition
            if (root == null)
            {
                // 子节点的下一个空结点设其为有覆盖，则可以使子节点的父节点有摄像机
                return 2;
            }

            var left = IsCameraNode(root.Left);
            var right = IsCameraNode(root.Right);


            // 单次遍历
            // 左右都有覆盖，返回无覆盖
            if (left == 2 && right == 2)
            {
                return 0;
            }

            // 左右至少有一个无覆盖
            if (left == 0 || right == 0)
            {
                result++;
                return 1;
            }

            // 左右至少有一个摄像机
            if (left == 1 || right == 1)
            {
                return 2;
            }

            return -1;

        }

    }
}