namespace BinaryTree
{
    /*
     https://leetcode.cn/problems/convert-sorted-array-to-binary-search-tree/description/
     Given an integer array nums where the elements are sorted in ascending order, convert it to a 
height-balanced
 binary search tree.

 

Example 1:


Input: nums = [-10,-3,0,5,9]
Output: [0,-3,9,-10,null,5]
Explanation: [0,-10,5,null,-3,null,9] is also accepted:

Example 2:


Input: nums = [1,3]
Output: [3,1]
Explanation: [1,null,3] and [3,1] are both height-balanced BSTs.*/
    public class Convert_Sorted_Array_to_Binary_Search_Tree将有序数组转换为二叉搜索树 {
        public TreeNode SortedArrayToBST(int[] nums) {
            return BuildTreeNodeFromBST(nums, 0, nums.Length -1);
        }

        TreeNode BuildTreeNodeFromBST(int[] nums, int left, int right)
        {
            if(left > right)
            {
                return null;
            }

            var mid = (left + right) / 2;
            var root = new TreeNode(nums[mid]);

            root.Left = BuildTreeNodeFromBST(nums, left, mid - 1);
            root.Right= BuildTreeNodeFromBST(nums, mid + 1, right);

            return root;
        }
    }
}